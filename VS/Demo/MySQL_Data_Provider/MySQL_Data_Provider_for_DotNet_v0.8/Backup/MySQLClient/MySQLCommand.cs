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
using System.Data;
using System.ComponentModel;
using System.Globalization;
using System.Text;


namespace System.Data.MySQLClient
{
	/// <summary>
	/// Represents a SQL statement that is executed against a database.
	/// </summary>
	public sealed class MySQLCommand : Component, ICloneable, IDbCommand
	{
		MySQLConnection m_objConnection = null;
		MySQLParameterCollection m_objParameters = new MySQLParameterCollection();
		string m_strCommandText = "";
		CultureInfo m_objCultureInfo = CultureInfo.InvariantCulture;
		bool m_blnUseUnicodeEncoding = false;
		MySQLTransaction m_objTransaction = null;
		int m_intLastInsertID = -1;

		/// <summary>
		/// Initializes a new instance of the System.Data.MySQLClient.MySQLCommand class.
		/// </summary>
		public MySQLCommand() : base() {}

		
		/// <summary>
		/// Initializes a new instance of the System.Data.MySQLClient.MySQLCommand class the SQL statement.
		/// </summary>
		/// <param name="strCommandText">SQL statement</param>
		public MySQLCommand(string strCommandText) : base()
		{
			m_strCommandText = strCommandText;
		}
		
		
		/// <summary>
		/// Initializes a new instance of the System.Data.MySQLClient.MySQLCommand class the SQL statement and the connection.
		/// </summary>
		/// <param name="strCommandText">SQL statement</param>
		/// <param name="objConnection">Connection that is used to execute the query</param>
		public MySQLCommand(string strCommandText, MySQLConnection objConnection) : base()
		{
			m_strCommandText = strCommandText;
			m_objConnection = objConnection;
		}


		/// <summary>
		/// Initializes a new instance of the System.Data.MySQLClient.MySQLCommand class the SQL statement, the connection and a transaction context.
		/// </summary>
		/// <param name="strCommandText">SQL statement</param>
		/// <param name="objConnection">Connection that is used to execute the query</param>
		/// <param name="objTransaction">Transaction context of connection</param>
		public MySQLCommand(string strCommandText, MySQLConnection objConnection, MySQLTransaction objTransaction) : base()
		{
			VerifyTransaction(objTransaction, objConnection);
			m_strCommandText = strCommandText;
			m_objConnection = objConnection;
			m_objTransaction = objTransaction;
		}


		/// <summary>
		/// Executes the query, and returns the first column of the first row in the resultset returned by the query. Extra columns or rows are ignored.
		/// </summary>
		/// <returns>The first column of the first row in the resultset.</returns>
		public object ExecuteScalar()
		{
			VerifyDatabaseConnection();
			MySQLDataReader objDR = ExecuteReader();
			if (!objDR.Read()) return null;

			object objValue = objDR[0];
			objDR.Close();
			return objValue;
		}


		/// <summary>
		/// Executes a SQL statement against the System.Data.MySQLClient.MySQLCommand.Connection and returns the number of rows affected.
		/// </summary>
		/// <returns>The number of rows affected.</returns>
		unsafe public int ExecuteNonQuery()
		{
			VerifyDatabaseConnection();
			void* ptrDBHandle = m_objConnection.DBHandle;

			// insert parameters into string, at the same time convert string to ASCII to pass to MySQL
			byte[] bteTempCommand = PrepareParameterCommand(m_strCommandText, m_objParameters, m_objCultureInfo);

			// run query
			ptrDBHandle = m_objConnection.DBHandle;
			if (0 != CPrototypes.mysql_real_query_b(ptrDBHandle, bteTempCommand, (ulong) bteTempCommand.Length))
				throw new MySQLException(CPrototypes.mysql_error(ptrDBHandle), (int) CPrototypes.mysql_errno(ptrDBHandle));
			
			return (int) CPrototypes.mysql_affected_rows(ptrDBHandle);
		}


		/// <summary>
		/// Sends the System.Data.MySQLClient.MySQLCommand.CommandText to the System.Data.MySQLClient.MySQLCommand.Connection and builds an System.Data.MySQLClient.MySQLDataReader.
		/// </summary>
		/// <returns>A System.Data.MySQLClient.MySQLDataReader object.</returns>
		IDataReader IDbCommand.ExecuteReader()
		{
			return ExecuteReader(CommandBehavior.Default);
		}


		/// <summary>
		/// Sends the System.Data.MySQLClient.MySQLCommand.CommandText to the System.Data.MySQLClient.MySQLCommand.Connection and builds an System.Data.MySQLClient.MySQLDataReader.
		/// </summary>
		/// <returns>A System.Data.MySQLClient.MySQLDataReader object.</returns>
		public MySQLDataReader ExecuteReader()
		{
			return ExecuteReader(CommandBehavior.Default);
		}


		/// <summary>
		/// Sends the System.Data.MySQLClient.MySQLCommand.CommandText to the System.Data.MySQLClient.MySQLCommand.Connection and builds an System.Data.MySQLClient.MySQLDataReader using one of the System.Data.CommandBehavior values.
		/// </summary>
		/// <param name="enmBehavior">One of the System.Data.CommandBehavior values.</param>
		/// <returns>A System.Data.MySQLClient.MySQLDataReader object.</returns>
		IDataReader IDbCommand.ExecuteReader(CommandBehavior enmBehavior)
		{
			return ExecuteReader(enmBehavior);
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="enmBehavior">One of the System.Data.CommandBehavior values.</param>
		/// <returns>A System.Data.MySQLClient.MySQLDataReader object.</returns>
		unsafe public MySQLDataReader ExecuteReader(CommandBehavior enmBehavior)
		{
			VerifyDatabaseConnection();

			void* ptrDBHandle = m_objConnection.DBHandle;
			string strTempCommand = m_strCommandText;
			void* ptrResultHandle;

			// special command behaviours
			//if (enmBehavior == CommandBehavior.SequentialAccess) throw new NotSupportedException("Sequential Access not supported");
			if (0 != (enmBehavior & CommandBehavior.SingleRow)) strTempCommand = strTempCommand + "\nLIMIT 1";

			// insert parameters into string, at the same time convert string to ASCII to pass to MySQL
			byte[] bteTempCommand = PrepareParameterCommand(strTempCommand, m_objParameters, m_objCultureInfo);

			// debug
			//System.Console.WriteLine(System.Text.Encoding.ASCII.GetString(bteTempCommand));

			// run query
			if (0 != CPrototypes.mysql_real_query_b(ptrDBHandle, bteTempCommand, (ulong) bteTempCommand.Length))
				throw new MySQLException(CPrototypes.mysql_error(ptrDBHandle), (int) CPrototypes.mysql_errno(ptrDBHandle));

			// store auto column id of last created row
			m_intLastInsertID = (int) CPrototypes.mysql_insert_id(ptrDBHandle);

			ptrResultHandle = CPrototypes.mysql_use_result(ptrDBHandle);
			// check result...
			if (null != ptrResultHandle)
				return new MySQLDataReader(ptrResultHandle, m_objConnection, m_objCultureInfo, enmBehavior, m_blnUseUnicodeEncoding);
			else if (CPrototypes.mysql_errno(ptrDBHandle) == 0)
			{
				// ...if no error occured, this means, that no data was retrieved
				return new MySQLDataReader(m_objConnection);
			}
			else
				throw new MySQLException(CPrototypes.mysql_error(ptrDBHandle), (int) CPrototypes.mysql_errno(ptrDBHandle));
		}


		/// <summary>
		/// Gets or sets the SQL statement or stored procedure to execute at the data source.
		/// </summary>
		public string CommandText
		{
			get{ return m_strCommandText; }
			set{ m_strCommandText = value; }
		}


		/// <summary>
		/// Gets or sets the System.Data.MySQLClient.MySQLConnection used by this instance of the System.Data.MySQLClient.MySQLCommand.
		/// </summary>
		IDbConnection IDbCommand.Connection
		{
			get{ return m_objConnection; }
			set{ m_objConnection = (MySQLConnection) value; } 
		}


		/// <summary>
		/// Gets or sets the System.Data.MySQLClient.MySQLConnection used by this instance of the System.Data.MySQLClient.MySQLCommand.
		/// </summary>
		public MySQLConnection Connection
		{
			get{ return m_objConnection; }
			set{ m_objConnection = value; }
		}


		/// <summary>
		/// Gets the System.Data.MySQLClient.MySQLParameterCollection.
		/// </summary>
		IDataParameterCollection IDbCommand.Parameters 
		{
			get{ return m_objParameters; } 
		}


		/// <summary>
		/// Gets the System.Data.MySQLClient.MySQLParameterCollection.
		/// </summary>
		public MySQLParameterCollection Parameters 
		{
			get{ return m_objParameters; } 
		}


		/// <summary>
		/// Creates a new instance of an System.Data.MySQLClient.MySQLParameter object. 
		/// </summary>
		/// <returns>A System.Data.MySQLCLient.MySQLParameter object.</returns>
		IDbDataParameter IDbCommand.CreateParameter()
		{
			return new MySQLParameter();
		}


		/// <summary>
		/// Creates a new instance of an System.Data.MySQLClient.MySQLParameter object. 
		/// </summary>
		/// <returns>A System.Data.MySQLCLient.MySQLParameter object.</returns>
		public MySQLParameter CreateParameter()
		{
			return new MySQLParameter();
		}


		/// <summary>
		/// Not supported
		/// </summary>
		public void Cancel()
		{
			throw new NotSupportedException("Cancel command not supported"); 
		}
		

		/// <summary>
		/// Not supported
		/// </summary>
		public void Prepare()
		{
			throw new NotSupportedException("Prepare command not supported"); 
		}

		
		/// <summary>
		/// Not supported
		/// </summary>
		public int CommandTimeout 
		{
			get{ return 0; }
			set{ if (0 != value) throw new NotSupportedException("Not supported"); }
		}


		/// <summary>
		/// Indicates how the CommandText is interpreted, only CommandType.Text supported
		/// </summary>
		public CommandType CommandType 
		{
			get { return CommandType.Text; } 
			set { if (value != CommandType.Text) throw new NotSupportedException("Only text commands allowed"); }
		}

		
		/// <summary>
		/// Gets or sets how command results are applied to the System.Data.DataRow when used by the System.Data.Common.DbDataAdapter.Update(System.Data.DataSet) method of the System.Data.Common.DbDataAdapter. Only UpdateRowSource.None supported.
		/// </summary>
		public UpdateRowSource UpdatedRowSource  
		{ 
			get { return UpdateRowSource.None; } 
			set { if (value != UpdateRowSource.None) throw new NotSupportedException("Only UpdateRowSource.None is allowed"); } 
		}


		/// <summary>
		/// Creates a new System.Data.MySQLCLient.MySQLCommand object that is a copy of the current instance.
		/// </summary>
		/// <returns>New System.Data.MySQLCLient.MySQLCommand object that is a copy of this instance</returns>
		public object Clone()
		{ 
			MySQLCommand objNew = new MySQLCommand();
			objNew.m_objConnection = m_objConnection;
			objNew.m_objParameters = (MySQLParameterCollection) m_objParameters.Clone();
			objNew.m_strCommandText = m_strCommandText;
			return objNew;
		}

		
		/// <summary>
		/// Gets or sets the transaction in which the System.Data.MySQLClient.MySQLCommand executes.
		/// </summary>
		IDbTransaction IDbCommand.Transaction
		{ 
			get { return m_objTransaction; }
			set { 
				VerifyTransaction((MySQLTransaction) value, m_objConnection);
				m_objTransaction = (MySQLTransaction) value;
			}
		}

		
		/// <summary>
		/// Gets or sets the transaction in which the System.Data.MySQLClient.MySQLCommand executes.
		/// </summary>
		public MySQLTransaction Transaction
		{ 
			get { return m_objTransaction; }
			set 
			{ 
				VerifyTransaction(value, m_objConnection);
				m_objTransaction = value;
			}
		}


		/// <summary>
		/// Gets or sets the System.Globalization.CultureInfo object, which is used to parse results returned from MySQL.
		/// </summary>
		public CultureInfo CultureForMySQL
		{
			get { return m_objCultureInfo; }
			set { m_objCultureInfo = value; }
		}


		/// <summary>
		/// Gets or sets the value indicating whether the Command object should parse strings returned from MySQL as ASCII or Unicode.
		/// </summary>
		public bool UseUnicode
		{
			get { return m_blnUseUnicodeEncoding; }
			set { m_blnUseUnicodeEncoding = value; } 
		}


		/// <summary>
		/// Returns the Auto Column ID of the last inserted row. Use the RowUpdatedEvent of the DataAdapter to update (or better: synchronize) ID columns of DataTables on the fly.
		/// </summary>
		/// <returns>The value of the last inserted Auto Column ID</returns>
		public int GetLastInsertID()
		{
			return m_intLastInsertID;
		}

		//*******************************************************

		/// <summary>
		/// Checks that a MySQL connection is available, that it is open and that no other query is currently running.
		/// </summary>
		private void VerifyDatabaseConnection()
		{
			// check if connection is available
			if (null == m_objConnection)
				throw new MySQLException("Connection not set");

			// check that connection is open
			if (m_objConnection.State != ConnectionState.Open)
				throw new MySQLException("Connection not open");

			// check that connection is not currently in a query
			if (null != m_objConnection.CurrentQuery)
				throw new MySQLException("Connection currently used by a query. Close this query first.");
		}


		/// <summary>
		/// Checks that the transaction object belongs to the current connection
		/// </summary>
		/// <param name="objTransaction">Transaction to check</param>
		/// <param name="objConnection">Connection to check</param>
		private void VerifyTransaction(MySQLTransaction objTransaction, MySQLConnection objConnection)
		{
			if (!objConnection.Equals(objTransaction.Connection))
				throw new MySQLException("Connection and Transaction.Connection don't match. Must be the same connection.");
		}


		/// <summary>
		/// Builds a byte array from the command text and the parameter collection. Parameters are transformed depending on their types. Parameters are inserted into the command text instead of '?'.
		/// </summary>
		/// <param name="strCommandText">Command text with '?'s</param>
		/// <param name="objParameters">Parameter collection to insert into command text</param>
		/// <param name="objCulture">CultureInfo object used for converting numbers and dates to MySQL format</param>
		/// <returns></returns>
		private byte[] PrepareParameterCommand(string strCommandText, MySQLParameterCollection objParameters, CultureInfo objCulture)
		{
			if (objParameters.Count == 0) return Encoding.ASCII.GetBytes(strCommandText);

			// prepare parameters as array of byte arrays
			object[] arrParameters = new object[objParameters.Count];
			int intTotalParamLength = 0;
			MySQLParameter objParam;

			for (int a = 0; a < objParameters.Count; a++)
			{
				objParam = objParameters[a];

				// first check if parameter contains a null value
				if (null == objParam.Value)
					arrParameters[a] = MySQLTypeConverter.ConvertDotNetNull();
				else if (DBNull.Value == objParam.Value)
					arrParameters[a] = MySQLTypeConverter.ConvertDotNetNull();
				else if (objParam.DbType != DbType.Object)
					// then check if parameter type was set explicitly
					arrParameters[a] = MySQLTypeConverter.ConvertDotNetValue(objParam.Value, objParam.DbType, objCulture, m_blnUseUnicodeEncoding);
				else
					// if there is no parameter type, use the original type of the value
					arrParameters[a] = MySQLTypeConverter.ConvertDotNetValue(objParam.Value, objCulture, m_blnUseUnicodeEncoding);

				// keep track of the total byte size of the parameters
				intTotalParamLength += ((ConversionResult) arrParameters[a]).Length;
			}

			// allocate the result array
			byte[] bteResult = new byte[strCommandText.Length + intTotalParamLength];
			byte[] bteTemp;
			int intPos1 = 0;
			int intPos2;
			int intResultPos = 0;
			char chrQM = '?';

			// cut the '?' and insert the prepared byte arrays of the parameters
			for (int a = 0; a < arrParameters.Length; a++)
			{
				intPos2 = strCommandText.IndexOf(chrQM, intPos1);
				if (-1 == intPos2) break;

				bteTemp = Encoding.ASCII.GetBytes(strCommandText.Substring(intPos1, intPos2 - intPos1));
				bteTemp.CopyTo(bteResult, intResultPos);
				intResultPos += bteTemp.Length;
				Buffer.BlockCopy(((ConversionResult) arrParameters[a]).Value, 0, bteResult, intResultPos, ((ConversionResult) arrParameters[a]).Length);
				intResultPos += ((ConversionResult) arrParameters[a]).Length;

				intPos1 = intPos2 + 1;
			}

			// copy rest of command string after last '?'
			bteTemp = Encoding.ASCII.GetBytes(strCommandText.Substring(intPos1));
			bteTemp.CopyTo(bteResult, intResultPos);
			intResultPos += bteTemp.Length;

			// set remaining bytes to 32, the ASCII code for space
			for (int a = intResultPos; a < bteResult.Length; a++)
				bteResult[a] = 32;

			return bteResult;
		}
	}
}
