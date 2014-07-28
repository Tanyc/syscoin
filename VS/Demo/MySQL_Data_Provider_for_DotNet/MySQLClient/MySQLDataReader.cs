#region LICENSE
/*
	MySQLClient: A Custom Data Provider for MySQL.
	Copyright (c) 2002 Christoph Wienands.

    This program is free software; you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation; either version 2 of the License, or
    (at your option) any later version.

    MySQLClient is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with MySQLClient; if not, write to the Free Software
    Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA  02111-1307  USA
*/
#endregion

using System;
using System.Collections;
using System.Data;
using System.Data.Common;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Text;


namespace System.Data.MySQLClient
{
	/// <summary>
	/// Provides a way of reading a forward-only stream of data rows from a data source.
	/// </summary>
	public sealed class MySQLDataReader : MarshalByRefObject, IDataReader, IDataRecord, IDisposable, IEnumerable
	{
		MySQLConnection m_objConnection = null;
		CommandBehavior m_enmCommandBehaviour = CommandBehavior.Default;
		DataTable m_objTableSchema = new DataTable();
		bool m_blnOpen = true;  // Indicates whether the DataReader is open
		bool m_blnCurrentRecord = false;  // Indicates whether the DataReader is positioned on a record and can return values.
		unsafe void* m_ptrDBHandle;  // Handle to the database
		unsafe void* m_ptrResult;  // Pointer to the result set
		unsafe IntPtr m_ptrRow;  // Pointer to the current result row
		uint m_intFieldCount = 0;  // Number of fields (coloumns) in the result set
		int m_lngRecordsAffected = -1;  // Affected records
		MySQLField[] m_objFields;  // Array of field definitions
		Hashtable m_objFieldNames = new Hashtable();
		object[] m_objValues;  // Array of field values in a row
		CultureInfo m_objCulture;  // Culture info to parse the date and number values returned from MySQL
		bool m_blnUseUnicode = false;  // Indicates whether strings from MySQL are UTF8 encoded and have to be decoded


		/// <summary>
		/// This "fake" constructor is used to be able to return an empty result and affected records after dataset updates.
		/// </summary>
		/// <param name="objConnection">Open connection to the database</param>
		unsafe internal MySQLDataReader(MySQLConnection objConnection) : base()
		{
			m_lngRecordsAffected = (int) CPrototypes.mysql_affected_rows(objConnection.DBHandle);
			Close();
		}


		/// <summary>
		/// Initializes a new DataReader object. Retrieves the field (column) definition.
		/// </summary>
		/// <param name="ptrResult">Pointer to the query result</param>
		/// <param name="objConnection">Open connection to the database</param>
		/// <param name="objCulture">Culture info to parse the date and number values returned from MySQL</param>
		/// <param name="enmBehavior">Special behaviour for the DataReader</param>
		/// <param name="blnUseUnicode">Indicates whether strings from MySQL are UTF8 encoded and have to be decoded</param>
		unsafe internal MySQLDataReader(void* ptrResult, MySQLConnection objConnection, CultureInfo objCulture, CommandBehavior enmBehavior, bool blnUseUnicode) : base()
		{
			objConnection.CurrentQuery = this;

			m_objConnection = objConnection;
			m_ptrDBHandle = m_objConnection.DBHandle;
			m_ptrResult = ptrResult;
			m_objCulture = objCulture;
			m_enmCommandBehaviour = enmBehavior;
			m_blnUseUnicode = blnUseUnicode;

			// retrieve column definition
			m_intFieldCount = CPrototypes.mysql_field_count(m_ptrDBHandle);
			m_objValues = new object[FieldCount];
			m_objFields = new MySQLField[FieldCount];
			ReadColumnDef(m_ptrResult, m_ptrDBHandle, m_objTableSchema);

			// special command behaviour: close right after retrieveing schema information
			if (0 != (m_enmCommandBehaviour & CommandBehavior.KeyInfo) || 0 != (m_enmCommandBehaviour & CommandBehavior.SchemaOnly))
				Close();
			else
				m_blnOpen = true;
		}


		/// <summary>
		/// Advances the System.Data.MySQLClient.MySQLDataReader to the next record.
		/// </summary>
		/// <returns>Returns true if there are more rows; otherwise, false.</returns>
		unsafe public bool Read()
		{
			if (!m_blnOpen) return false;
			//if (m_lngCurrentRow >= m_lngRowCount) return false;
			
			if (ReadNextMySQLRow())
			{
				m_blnCurrentRecord = true;
				return true;
			}
			else
			{
				// if end of resultset is reached, perform clean-up
				Close();
				return false;
			}
		}

		
		/// <summary>
		/// Closes the DataReader object and frees any used resources.
		/// </summary>
		public void Close()
		{
			Close(false);
		}


		/// <summary>
		/// This internal method is needed because a connection object might call DataReader.Close but DataReader.Close() might call Connection.Close() in turn because of CommandBehavior.CloseConnection.
		/// </summary>
		/// <param name="blnIgnoreBehaviour">If true, CommandBehavior.CloseConnection will be ignored and no call to Connection.Close is made</param>
		unsafe internal void Close(bool blnIgnoreBehaviour)
		{
			// if result is available...
			void* ptrTemp;
			if (null != m_ptrResult)
			{
				//...complete fetch process...
				do
				{
					ptrTemp = CPrototypes.mysql_fetch_row(m_ptrResult).ToPointer();
				} while (null != ptrTemp);

				//...and free the result
				CPrototypes.mysql_free_result(m_ptrResult);
				m_ptrResult = null;
				m_objConnection.CurrentQuery = null;
			}

			m_blnOpen = false;
			m_blnCurrentRecord = false;

			// special command behaviour: close connection at the end of reading
			if (!blnIgnoreBehaviour && (0 != (m_enmCommandBehaviour & CommandBehavior.CloseConnection))) m_objConnection.Close();
		}


		/// <summary>
		/// Advances the data reader to the next result, when reading the results of batch SQL statements.
		/// </summary>
		/// <returns>Nested queries not supported, always returns false.</returns>
		public bool NextResult()
		{
			return false;
		}


		/// <summary>
		/// Indicates whether the data reader is closed. 
		/// </summary>
		public bool IsClosed { get { return !m_blnOpen; } }

		
		/// <summary>
		/// Closes the DataReader and frees up any used resources.
		/// </summary>
		public void Dispose() { Close(); }


		/// <summary>
		/// Gets the name of the specified column.
		/// </summary>
		/// <param name="intIndex">The zero-based column ordinal</param>
		/// <returns>The name of the specified column</returns>
		public string GetName(int intIndex) { return m_objFields[intIndex].ColName; }

		
		/// <summary>
		/// Gets the name of the source data type.
		/// </summary>
		/// <param name="intIndex">The zero-based column ordinal</param>
		/// <returns>The name of the back-end data type</returns>
		public string GetDataTypeName(int intIndex) { return GetFieldType(intIndex).ToString(); }


		/// <summary>
		/// Gets the System.Type that is the data type of the object.
		/// </summary>
		/// <param name="intIndex">The zero-based column ordinal</param>
		/// <returns>The System.Type that is the data type of the object</returns>
		public Type GetFieldType(int intIndex) { return MySQLTypeConverter.MapMySQLType(m_objFields[intIndex].Type, m_objFields[intIndex].IsUnsigned, m_objFields[intIndex].IsBinary); }


		/// <summary>
		/// Gets the number of columns in the current row.
		/// </summary>
		public int FieldCount { get { return (int) m_intFieldCount; } }


		/// <summary>
		/// Gets a value indicating the depth of nesting for the current row. Only used with hierarchical data. Always 0.
		/// </summary>
		public int Depth { get { return 0; } }


		/// <summary>
		/// Returns a System.Data.DataTable that describes the column metadata of the System.Data.MySQLClient.MySQLDataReader.
		/// </summary>
		/// <returns>A System.Data.DataTable that describes the column metadata.</returns>
		public DataTable GetSchemaTable() { return m_objTableSchema; }

		
		/// <summary>
		/// Gets the number of rows changed, inserted, or deleted by execution of the SQL statement.
		/// </summary>
		public int RecordsAffected { get { return m_lngRecordsAffected; } }

		
		/// <summary>
		/// Returns an enumerator that can iterate through a collection.
		/// </summary>
		/// <returns>A System.Collections.IEnumerator that can be used to iterate through the collection</returns>
		IEnumerator IEnumerable.GetEnumerator() { return (IEnumerator) new DbEnumerator(this); }

		//*********************************************

		public object this[int intIndex]
		{
			get	{ CheckForCurrentRecord(); return m_objValues[intIndex]; }
		}

		public object this[string strColName]
		{
			get	{ CheckForCurrentRecord(); return m_objValues[GetOrdinal(strColName)]; }
		}

		public string GetString(int intIndex)
		{ 
			CheckForCurrentRecord();
			object objTemp = this[intIndex]; if (objTemp == DBNull.Value) return ""; else return objTemp.ToString();
		}

		public int GetValues(object[] objValues) 
		{
			CheckForCurrentRecord();
			int intMax = objValues.Length;
			if (intMax > m_objValues.Length) intMax = m_objValues.Length;
			for (int a = 0; a < intMax; a++) objValues[a] = m_objValues[a];
			return intMax;
		}

		public bool GetBoolean(int intIndex) { return Convert.ToBoolean(this[intIndex]); }
		public Byte GetByte(int intIndex) { return Convert.ToByte(this[intIndex]); }
		public Char GetChar(int intIndex) { return Convert.ToChar(this[intIndex]); }
		public DateTime GetDateTime(int intIndex) { return Convert.ToDateTime(this[intIndex]); }
		public Decimal GetDecimal(int intIndex) { return Convert.ToDecimal(this[intIndex]); }
		public Double GetDouble(int intIndex) { return  Convert.ToDouble(this[intIndex]); }
		public Single GetFloat(int intIndex) { return Convert.ToSingle(this[intIndex]); }
		public Guid GetGuid(int intIndex) { return new Guid(GetString(intIndex)); }
		public short GetInt16(int intIndex) { return Convert.ToInt16(this[intIndex]); }
		public int GetInt32(int intIndex) { return Convert.ToInt32(this[intIndex]); }
		public long GetInt64(int intIndex) { return Convert.ToInt64(this[intIndex]); }
		public int GetOrdinal(string strColName) { return Convert.ToInt32(m_objFieldNames[strColName]); }
		public Object GetValue(int intIndex) { return this[intIndex]; }
		public bool IsDBNull(int intIndex) { return this[intIndex].Equals(DBNull.Value); }
		public IDataReader GetData(int intIndex) { throw new NotSupportedException("GetData not supported."); }

		public long GetBytes(int intIndex, long intFieldOffset, byte[] bteBuffer, int intBufferOffset, int intLength)
		{ throw new NotSupportedException("GetBytes not supported"); }
		public long GetChars(int intIndex, long intFieldOffset, char[] bteBuffer, int intBufferOffset, int intLength)
		{ throw new NotSupportedException("GetChars not supported"); }

		//*********************************************

		/// <summary>
		/// Checks if DataReader is currently positioned on a valid row (important at the beginning and at the end).
		/// </summary>
		private void CheckForCurrentRecord()
		{
			if (!m_blnCurrentRecord)
				throw new MySQLException("No current record");
		}


		/// <summary>
		/// Reads the column definition for the result set.
		/// </summary>
		/// <param name="ptrResult">Pointer to the result set of the query</param>
		/// <param name="ptrDBHandle">Handle to the database</param>
		/// <param name="objTable">Field definition is stored in this table (meta data table)</param>
		unsafe private void ReadColumnDef(void* ptrResult, void* ptrDBHandle, DataTable objTable)
		{
			MySQLField objField;
			IntPtr ptrTemp;
			ArrayList objPrimaryKeys = new ArrayList(3);
			DataRow objRow;

			m_objTableSchema.Columns.Add("ColumnName", typeof(string));
			m_objTableSchema.Columns.Add("ColumnOrdinal", typeof(int));
			m_objTableSchema.Columns.Add("ColumnSize", typeof(int));
			m_objTableSchema.Columns.Add("NumericPrecision", typeof(int));
			m_objTableSchema.Columns.Add("NumericScale", typeof(int));
			m_objTableSchema.Columns.Add("DataType", typeof(object));
			m_objTableSchema.Columns.Add("ProviderType", typeof(int));
			m_objTableSchema.Columns.Add("IsLong", typeof(bool));
			m_objTableSchema.Columns.Add("AllowDBNull", typeof(bool));
			m_objTableSchema.Columns.Add("IsReadOnly", typeof(bool));
			m_objTableSchema.Columns.Add("IsRowVersion", typeof(bool));
			m_objTableSchema.Columns.Add("IsUnique", typeof(bool));
			m_objTableSchema.Columns.Add("IsKeyColumn", typeof(bool));
			m_objTableSchema.Columns.Add("IsAutoIncrement", typeof(bool));
			m_objTableSchema.Columns.Add("BaseSchemaName", typeof(string));
			m_objTableSchema.Columns.Add("BaseCatalogName", typeof(string));
			m_objTableSchema.Columns.Add("BaseTableName", typeof(string));
			m_objTableSchema.Columns.Add("BaseColumnName", typeof(string));

			for(uint a = 0; a < m_intFieldCount; a++)
			{
				ptrTemp = CPrototypes.mysql_fetch_field_direct(ptrResult, a);

				if (null == ptrTemp.ToPointer())
					throw new MySQLException(CPrototypes.mysql_error(ptrDBHandle), (int) CPrototypes.mysql_errno(ptrDBHandle));

				// if the component crashes here, the MySQLField struct of your libMySQL.dll has a different definition.
				// I ran into this problem when I switched between the dll for 4.0.3 beta and some older library (unknown version).
				objField = CPrototypes.ReadField(ptrTemp); 

				// store field definition in internal object objTable (meta data table)
				objRow = m_objTableSchema.NewRow();
				objRow["ColumnName"] = objField.ColName;
				objRow["ColumnOrdinal"] = a + 1;
				objRow["DataType"] = MySQLTypeConverter.MapMySQLType(objField.Type, objField.IsUnsigned, objField.IsBinary);

				objRow["IsAutoIncrement"] = objField.IsAutoIncrement;
				objRow["IsUnique"] = objField.IsUniqueKey;
				objRow["AllowDBNull"] = objField.AllowNull;
				objRow["IsKeyColumn"] = objField.IsPrimaryKey;
				objRow["ProviderType"] = objField.Type;
				objRow["IsReadOnly"] = false;  // true means "can be written" !
				if (objRow["DataType"].ToString().Equals("System.String"))
					objRow["ColumnSize"] = (int) objField.Length;
				if (objRow["DataType"].ToString().Equals("System.Decimal"))
					objRow["NumericScale"] = objField.Decimals;

				m_objTableSchema.Rows.Add(objRow);
				m_objFields[a] = objField;
				m_objFieldNames.Add(objField.ColName, a);
			}
		}


		/// <summary>
		/// Retrieves the next result row, converts the values to .Net data types and stores them in an internal array.
		/// </summary>
		/// <returns>True if there are more rows, otherwise false</returns>
		unsafe private bool ReadNextMySQLRow()
		{
			// get handle to row data
			m_ptrRow = CPrototypes.mysql_fetch_row(m_ptrResult);
			if(null == m_ptrRow.ToPointer())
				return false; // no more results

			int intOffset = 0;
			IntPtr ptrTemp;

			uint[] intLengths = ReadFieldLengths();
			byte[] bteTemp;

			for (int a = 0; a < m_intFieldCount; a++)
			{
				ptrTemp = Marshal.ReadIntPtr(m_ptrRow, intOffset);

				if (0 == intLengths[a] && m_objFields[a].AllowNull)
				{
					m_objValues[a] = DBNull.Value;
				}
				else 
				{
					// if binary type, just read byte array
					if (m_objFields[a].IsBinary && m_objFields[a].IsBlob)
					{
						bteTemp = new byte[intLengths[a]];
						Marshal.Copy(ptrTemp, bteTemp, 0, (int) intLengths[a]);
						m_objValues[a] = bteTemp;
					}
					// check if Unicode decoding is set, if yes, check if return value is of type string
					// Unicode decoding not necessary for other types
					else if (m_blnUseUnicode && (m_objFields[a].Type == MySQLDataTypes.DATA_TYPE_SET || m_objFields[a].Type == MySQLDataTypes.DATA_TYPE_STRING || m_objFields[a].Type == MySQLDataTypes.DATA_TYPE_ENUM || m_objFields[a].Type == MySQLDataTypes.DATA_TYPE_VAR_CHAR || (m_objFields[a].IsBlob && !m_objFields[a].IsBinary)))
					{
						bteTemp = new byte[intLengths[a]];
						Marshal.Copy(ptrTemp, bteTemp, 0, (int) intLengths[a]);
						m_objValues[a] = MySQLTypeConverter.DecodeUnicodeString(bteTemp);
					}
					else
					{
						// else use default convertion
						m_objValues[a] = MySQLTypeConverter.ConvertMySQLValue((string) Marshal.PtrToStringAnsi(ptrTemp), m_objFields[a].Type, m_objFields[a].IsUnsigned, m_objCulture);
					}
				}

				intOffset += sizeof(IntPtr);
			}

			return true;
		}


		/// <summary>
		/// Retrieves the byte lengths of the column values of a result row. Important for binary and UTF8 data.
		/// </summary>
		/// <returns></returns>
		unsafe private uint[] ReadFieldLengths()
		{
			IntPtr ptrTemp = CPrototypes.mysql_fetch_lengths(m_ptrResult);

			uint[] intResult = new uint[m_intFieldCount];
			int intOffset = 0;
			for (int a = 0; a < m_intFieldCount; a++)
			{
				intResult[a] = (uint) Marshal.ReadInt32(ptrTemp, intOffset);
				intOffset += sizeof(uint);
			}

			return intResult;
		}
	}
}