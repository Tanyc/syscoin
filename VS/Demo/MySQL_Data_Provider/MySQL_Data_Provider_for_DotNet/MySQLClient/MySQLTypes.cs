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
using System.Globalization;
using System.Runtime.InteropServices;
using System.Text;


namespace System.Data.MySQLClient
{
	/// <summary>
	/// This struct stores the result of a .Net to MySQL conversion
	/// </summary>
	internal struct ConversionResult
	{
		/// <summary>
		/// Contains the MySQL string in form of an array of ASCII characters
		/// </summary>
		public byte[] Value;
		/// <summary>
		/// Number of the USED bytes in the Value byte array (array might be longer!)
		/// </summary>
		public int Length;
	}

	
	/// <summary>
	/// MySQL Column Flags.
	/// </summary>
	[Flags]
	internal enum EColumnFlags : uint
	{
		NOT_NULL_FLAG = 1,			/* Field can't be NULL */
		PRI_KEY_FLAG = 2,			/* Field is part of a primary key */
		UNIQUE_KEY_FLAG = 4,		/* Field is part of a unique key */
		MULTIPLE_KEY_FLAG = 8,		/* Field is part of a key */
		BLOB_FLAG = 16,				/* Field is a blob */
		UNSIGNED_FLAG = 32,			/* Field is unsigned */
		ZEROFILL_FLAG = 64,			/* Field is zerofill */
		BINARY_FLAG = 128,			/* Indicates binary compare? */
		ENUM_FLAG = 256,			/* field is an enum */
		AUTO_INCREMENT_FLAG = 512,	/* field is a autoincrement field */
		TIMESTAMP_FLAG = 1024,		/* Field is a timestamp */
		SET_FLAG = 2048,			/* field is a set */
		NUM_FLAG = 32768,			/* Field is num (for clients) */
		PART_KEY_FLAG = 16384,		/* Intern; Part of some key */
		GROUP_FLAG = 32768,			/* Intern: Group field */
		UNIQUE_FLAG = 65536,		/* Intern: Used by sql_yacc */
	}


	/// <summary>
	/// MySQL Data Types.
	/// </summary>
	public enum MySQLDataTypes : int
	{
		DATA_TYPE_DECIMAL = 0,
		DATA_TYPE_TINY_INT = 1,
		DATA_TYPE_SMALL_INT = 2,
		DATA_TYPE_INTEGER = 3,
		DATA_TYPE_FLOAT = 4,
		DATA_TYPE_DOUBLE = 5,
		DATA_TYPE_NULL = 6,
		DATA_TYPE_TIMESTAMP = 7,
		DATA_TYPE_BIGINT = 8,
		DATA_TYPE_MEDIUM_INT = 9,
		DATA_TYPE_DATE = 10,
		DATA_TYPE_TIME = 11,
		DATA_TYPE_DATETIME = 12,
		DATA_TYPE_YEAR = 13,
		DATA_TYPE_NEWDATE = 14,		/* ??? */
		DATA_TYPE_ENUM = 247,			/* not used, see STRING */
		DATA_TYPE_SET = 248,			/* not used, see STRING */
		DATA_TYPE_TINY_BLOB = 249,		/* not used, see BLOB */
		DATA_TYPE_MEDIUM_BLOB = 250,	/* not used, see BLOB */
		DATA_TYPE_LONG_BLOB = 251,		/* not used, see BLOB */
		DATA_TYPE_BLOB = 252,			/* also text, longblob, longtext, mediumblob, mediumtext, tinytext, tinyblob */
		DATA_TYPE_VAR_CHAR = 253,
		DATA_TYPE_STRING = 254,		/* also char, enum, set */
	}


	/// <summary>
	/// Field descriptor for MySQL 4 and up (tested with 4.0.3 beta)
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	internal struct MySQLField
	{
		public string ColName;	 // Name of column 
		public string TableName;  // Table of column if column was a field
		public string OriginalTableName;  // Original table name, if name is an alias

		// the following two lines are supposed to return strings
		// however, the library crashed while marshaling null pointers to strings (the default value is usually a null pointer
		// because those values are usually not needed, I simply changed them to uint instead of char*
		public uint temp1; //public string Database;  // Database
		public uint temp2; //public string Default;  // Default value (also used for set- and enum values) 

		// Note for older versions:
		// Somewhen before v4.0.3 beta, the definition of the mysql_field struct did not contain the database member.
		// In case you are working with an older version and the application crashes in MySQLDataReader in the line
		//		objField = (MySQLField) Marshal.PtrToStructure(ptrTemp, typeof(MySQLField));
		// then you probably need to remove the line with temp1 from above.

		public uint Length;  // Width of column
		public uint MaxLength;	// Max width of selected set
		public uint Flags;  // Diverse flags, see EColumnFlags
		public uint Decimals;  // Number of decimals in field
		public MySQLDataTypes Type;	 // Type of field, see EDataTypes


		public bool IsPrimaryKey { get { return (Flags & (uint) EColumnFlags.PRI_KEY_FLAG) != 0; } }
		public bool IsUniqueKey	{ get { return (Flags & (uint) EColumnFlags.UNIQUE_KEY_FLAG) != 0; } }
		public bool IsAutoIncrement { get { return (Flags & (uint) EColumnFlags.AUTO_INCREMENT_FLAG) != 0; } }
		public bool AllowNull { get { return (Flags & (uint) EColumnFlags.NOT_NULL_FLAG) == 0; } }

		public bool IsUnsigned { get { return (Flags & (uint) EColumnFlags.UNSIGNED_FLAG) != 0; } }
		public bool IsBinary { get { return (Flags & (uint) EColumnFlags.BINARY_FLAG) != 0; } }
		public bool IsEnum { get { return (Flags & (uint) EColumnFlags.ENUM_FLAG) != 0; } }
		public bool IsBlob { get { return (Flags & (uint) EColumnFlags.BLOB_FLAG) != 0; } }
		public bool IsSet { get { return (Flags & (uint) EColumnFlags.SET_FLAG) != 0; } }
	}  


	/// <summary>
	/// Field descriptor for older MySQL clients
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	internal struct MySQLField_Old
	{
		public string ColName;	 // Name of column 
		public string TableName;  // Table of column if column was a field
		public string OriginalTableName;  // Original table name, if name is an alias

		// the following two lines are supposed to return strings
		// however, the library crashed while marshaling null pointers to strings (the default value is usually a null pointer
		// because those values are usually not needed, I simply changed them to uint instead of char*
		// public uint temp1; //public string Database;  // Database
		public uint temp2; //public string Default;  // Default value (also used for set- and enum values) 

		// Somewhen before v4.0.3 beta, the definition of the mysql_field struct did not contain the database member.
		// The member temp1 did not yet exist before MySQL 4

		public uint Length;  // Width of column
		public uint MaxLength;	// Max width of selected set
		public uint Flags;  // Diverse flags, see EColumnFlags
		public uint Decimals;  // Number of decimals in field
		public MySQLDataTypes Type;	 // Type of field, see EDataTypes
	}  


	/// <summary>
	/// C prototypes wrapper for mysqllib.dll.
	/// </summary>
	internal class CPrototypes
	{
		private static int m_intClientVersion = Int32.Parse(mysql_get_client_info().Substring(0, 1));

		[ DllImport( "libmySQL.dll", EntryPoint="mysql_init", CharSet=System.Runtime.InteropServices.CharSet.Ansi, ExactSpelling = true)]
		unsafe public static extern void* mysql_init(void* must_be_null);
		[ DllImport( "libmySQL.dll", EntryPoint="mysql_close" , CharSet=System.Runtime.InteropServices.CharSet.Ansi, ExactSpelling = true)]
		unsafe public static extern void mysql_close(void* handle);
		[ DllImport( "libmySQL.dll", EntryPoint="mysql_real_connect", CharSet=System.Runtime.InteropServices.CharSet.Ansi, ExactSpelling = true )]
		unsafe public static extern void* mysql_real_connect(void* mysql, string host, string user, string passwd, string db, uint port, string unix_socket, int client_flag);
		[ DllImport( "libmySQL.dll", EntryPoint="mysql_select_db" , CharSet=System.Runtime.InteropServices.CharSet.Ansi, ExactSpelling = true)]
		unsafe public static extern int mysql_select_db(void* handle, string new_db);
		[ DllImport( "libmySQL.dll", EntryPoint="mysql_query" , CharSet=System.Runtime.InteropServices.CharSet.Ansi, ExactSpelling = true)]
		unsafe public static extern int mysql_query(void*mysql, string query);
		[ DllImport( "libmySQL.dll", EntryPoint="mysql_real_query", CharSet=System.Runtime.InteropServices.CharSet.Ansi, ExactSpelling = true )]
		unsafe public static extern int mysql_real_query(void*mysql, string query, ulong length);
		[ DllImport( "libmySQL.dll", EntryPoint="mysql_store_result", CharSet=System.Runtime.InteropServices.CharSet.Ansi, ExactSpelling = true )]
		unsafe public static extern void *mysql_store_result(void *mysql);
		[ DllImport( "libmySQL.dll", EntryPoint="mysql_use_result" , CharSet=System.Runtime.InteropServices.CharSet.Ansi, ExactSpelling = true)]
		unsafe public static extern void *mysql_use_result(void *mysql);
		[ DllImport( "libmySQL.dll", EntryPoint="mysql_free_result", CharSet=System.Runtime.InteropServices.CharSet.Ansi, ExactSpelling = true )]
		unsafe public static extern void mysql_free_result(void*result);
		[ DllImport( "libmySQL.dll", EntryPoint="mysql_errno", CharSet=System.Runtime.InteropServices.CharSet.Ansi, ExactSpelling = true )]
		unsafe public static extern uint mysql_errno(void*mysql);
		[ DllImport( "libmySQL.dll", EntryPoint="mysql_error", CharSet=System.Runtime.InteropServices.CharSet.Ansi, ExactSpelling = true )]
		unsafe public static extern string mysql_error(void*mysql);
		[ DllImport( "libmySQL.dll", EntryPoint="mysql_field_count", CharSet=System.Runtime.InteropServices.CharSet.Ansi, ExactSpelling = true )]
		unsafe public static extern uint mysql_field_count(void*mysql);
		[ DllImport( "libmySQL.dll", EntryPoint="mysql_affected_rows", CharSet=System.Runtime.InteropServices.CharSet.Ansi, ExactSpelling = true )]
		unsafe public static extern ulong mysql_affected_rows(void*mysql);
		[ DllImport( "libmySQL.dll", EntryPoint="mysql_num_fields", CharSet=System.Runtime.InteropServices.CharSet.Ansi, ExactSpelling = true )]
		unsafe public static extern uint mysql_num_fields(void*result);
		[ DllImport( "libmySQL.dll", EntryPoint="mysql_num_rows" , CharSet=System.Runtime.InteropServices.CharSet.Ansi, ExactSpelling = true)]
		unsafe public static extern ulong mysql_num_rows(void *result);
		[ DllImport( "libmySQL.dll", EntryPoint="mysql_fetch_field_direct" , CharSet=System.Runtime.InteropServices.CharSet.Ansi, ExactSpelling = true)]
		unsafe public static extern IntPtr mysql_fetch_field_direct(void*result, uint fieldnr);
		[ DllImport( "libmySQL.dll", EntryPoint="mysql_fetch_row" , CharSet=System.Runtime.InteropServices.CharSet.Ansi, ExactSpelling = true)]
		unsafe public static extern IntPtr mysql_fetch_row(void*result);
		[ DllImport( "libmySQL.dll", EntryPoint="mysql_fetch_lengths", CharSet=System.Runtime.InteropServices.CharSet.Ansi, ExactSpelling = true )]
		unsafe public static extern IntPtr mysql_fetch_lengths(void*result);
		[ DllImport( "libmySQL.dll", EntryPoint="mysql_insert_id" , CharSet=System.Runtime.InteropServices.CharSet.Ansi, ExactSpelling = true)]
		unsafe public static extern ulong mysql_insert_id(void*mysql);
		[ DllImport( "libmySQL.dll", EntryPoint="mysql_options", CharSet=System.Runtime.InteropServices.CharSet.Ansi, ExactSpelling = true )]
		unsafe public static extern int mysql_options(void*mysql, int option, string arg);
		[ DllImport( "libmySQL.dll", EntryPoint="mysql_get_client_info", CharSet=System.Runtime.InteropServices.CharSet.Ansi, ExactSpelling = true )]
		unsafe public static extern string mysql_get_client_info();

		//this duplicate of mysql_query takes a byte array as parameter
		//this is needed to pass blobs and unicode properly to mysql
		[ DllImport( "libmySQL.dll", EntryPoint="mysql_real_query" )]
		unsafe public static extern int mysql_real_query_b(void*mysql, byte[] query, ulong length);

		/// <summary>
		/// Executes a SQL statement against a MySQL database.
		/// </summary>
		/// <param name="strCommand">Command text to be executed</param>
		/// <param name="ptrDBHandle">Handle for the database</param>
		/// <returns>Number of affected (changed) records</returns>
		unsafe public static int RunSQLStatement(string strCommand, void * ptrDBHandle)
		{
			void* ptrResult = null;
			void* ptrTemp = null;

			// run query
			if (0 != CPrototypes.mysql_real_query(ptrDBHandle, strCommand, (ulong) strCommand.Length))
				throw new MySQLException(CPrototypes.mysql_error(ptrDBHandle) + "\n" + strCommand, (int) CPrototypes.mysql_errno(ptrDBHandle));

			ptrResult = CPrototypes.mysql_use_result(ptrDBHandle);
			if (null != ptrResult)
			{
				do 
				{
					ptrTemp = CPrototypes.mysql_fetch_row(ptrResult).ToPointer();
				} while (null != ptrTemp);
				CPrototypes.mysql_free_result(ptrResult);
			}

			return (int) CPrototypes.mysql_affected_rows(ptrDBHandle);
		}


		/// <summary>
		/// Returns field definition information during database queries.
		/// Checks the version of the MySQL client and uses the appropriate field structure.
		/// </summary>
		/// <param name="ptrField">Pointer to field</param>
		/// <returns>MySQLField structure with field definition</returns>
		unsafe public static MySQLField ReadField(IntPtr ptrField)
		{	
			MySQLField objField;

			// check if client is prior to v4.x. In that case use MySQLField_Old for marshaling.
			if (m_intClientVersion <=3)
			{
				MySQLField_Old objFieldOld = (MySQLField_Old) Marshal.PtrToStructure(ptrField, typeof(MySQLField_Old));

				objField = new MySQLField();
				objField.ColName = objFieldOld.ColName;
				objField.Decimals = objFieldOld.Decimals;
				objField.Flags = objFieldOld.Flags;
				objField.Length = objFieldOld.Length;
				objField.MaxLength = objFieldOld.MaxLength;
				objField.OriginalTableName = objFieldOld.OriginalTableName;
				objField.TableName = objFieldOld.TableName;
				objField.Type = objFieldOld.Type;
			}
			else
				objField = (MySQLField) Marshal.PtrToStructure(ptrField, typeof(MySQLField));

			return objField;
		}
	}


	/// <summary>
	/// This class provides methods for converting MySQL data types to .Net data types and vice versa.
	/// </summary>
	internal class MySQLTypeConverter
	{
		/// <summary>
		/// Looks up the matching .Net data type for a given MySQL data type.
		/// </summary>
		/// <param name="enmMySQLType">MySQL data type</param>
		/// <param name="blnUnsigned">Indicates if the data type is unsigned</param>
		/// <returns>The matching .Net datatype</returns>
		public static System.Type MapMySQLType(MySQLDataTypes enmMySQLType, bool blnUnsigned, bool blnBinary)
		{
			switch(enmMySQLType)
			{
				case MySQLDataTypes.DATA_TYPE_STRING:
				case MySQLDataTypes.DATA_TYPE_ENUM:
				case MySQLDataTypes.DATA_TYPE_SET:
				case MySQLDataTypes.DATA_TYPE_VAR_CHAR:
				case MySQLDataTypes.DATA_TYPE_TIMESTAMP:
					return typeof(System.String);

				case MySQLDataTypes.DATA_TYPE_BLOB:
				case MySQLDataTypes.DATA_TYPE_LONG_BLOB:
				case MySQLDataTypes.DATA_TYPE_MEDIUM_BLOB:
				case MySQLDataTypes.DATA_TYPE_TINY_BLOB:
					if (blnBinary) return typeof(System.Byte[]);
					else return typeof(System.String);

				case MySQLDataTypes.DATA_TYPE_DATE:
				case MySQLDataTypes.DATA_TYPE_DATETIME:
					return typeof(System.DateTime);

				case MySQLDataTypes.DATA_TYPE_TIME:
					return typeof(System.TimeSpan);

				case MySQLDataTypes.DATA_TYPE_DECIMAL:
					return typeof(System.Decimal);

				case MySQLDataTypes.DATA_TYPE_DOUBLE:
					return typeof(System.Double);

				case MySQLDataTypes.DATA_TYPE_FLOAT:
					return typeof(System.Single);

				case MySQLDataTypes.DATA_TYPE_BIGINT:
					if (blnUnsigned)
						return typeof(System.UInt64);
					else
						return typeof(System.Int64);

				case MySQLDataTypes.DATA_TYPE_INTEGER:
				case MySQLDataTypes.DATA_TYPE_MEDIUM_INT:
					if (blnUnsigned)
						return typeof(System.UInt32);
					else
						return typeof(System.Int32);

				case MySQLDataTypes.DATA_TYPE_SMALL_INT:
					if (blnUnsigned)
						return typeof(System.UInt16);
					else
						return typeof(System.Int16);

				case MySQLDataTypes.DATA_TYPE_TINY_INT:
					if (blnUnsigned)
						return typeof(System.Byte);
					else
						return typeof(System.SByte);

				case MySQLDataTypes.DATA_TYPE_YEAR:
					return typeof(System.Int16);

				default:
					return typeof(System.String);
			}
		}


		/// <summary>
		/// Converts a MySQL value to a .Net value.
		/// </summary>
		/// <param name="strValue">MySQL string to convert</param>
		/// <param name="enmMySQLType">MySQL data type</param>
		/// <param name="blnUnsigned">Indicates if the MySQL value is unsigned</param>
		/// <param name="objMySQLCulture">CultureInfo object to convert number values correctly</param>
		/// <returns>The converted .Net value</returns>
		public static object ConvertMySQLValue(string strValue, MySQLDataTypes enmMySQLType, bool blnUnsigned, CultureInfo objMySQLCulture)
		{
			try
			{
				switch(enmMySQLType)
				{
					case MySQLDataTypes.DATA_TYPE_BLOB:
					case MySQLDataTypes.DATA_TYPE_ENUM:
					case MySQLDataTypes.DATA_TYPE_LONG_BLOB:
					case MySQLDataTypes.DATA_TYPE_MEDIUM_BLOB:
					case MySQLDataTypes.DATA_TYPE_SET:
					case MySQLDataTypes.DATA_TYPE_STRING:
					case MySQLDataTypes.DATA_TYPE_TINY_BLOB:
					case MySQLDataTypes.DATA_TYPE_VAR_CHAR:
					case MySQLDataTypes.DATA_TYPE_TIMESTAMP:
						return strValue;

					case MySQLDataTypes.DATA_TYPE_DATE:
						return new DateTime(Convert.ToInt32(strValue.Substring(0, 4)), Convert.ToInt32(strValue.Substring(5, 2)), Convert.ToInt32(strValue.Substring(8, 2)));

					case MySQLDataTypes.DATA_TYPE_DATETIME:
						return new DateTime(Convert.ToInt32(strValue.Substring(0, 4)), Convert.ToInt32(strValue.Substring(5, 2)), Convert.ToInt32(strValue.Substring(8, 2)), 
							Convert.ToInt32(strValue.Substring(11, 2)), Convert.ToInt32(strValue.Substring(14, 2)), Convert.ToInt32(strValue.Substring(17, 2)));

					case MySQLDataTypes.DATA_TYPE_TIME:
						return new TimeSpan(Convert.ToInt32(strValue.Substring(0, 2)), Convert.ToInt32(strValue.Substring(3, 2)), Convert.ToInt32(strValue.Substring(6, 2)));

					case MySQLDataTypes.DATA_TYPE_DECIMAL:
						return Convert.ToDecimal(strValue, objMySQLCulture);

					case MySQLDataTypes.DATA_TYPE_DOUBLE:
						return Convert.ToDouble(strValue, objMySQLCulture);

					case MySQLDataTypes.DATA_TYPE_FLOAT:
						return Convert.ToSingle(strValue, objMySQLCulture);

					case MySQLDataTypes.DATA_TYPE_BIGINT:
						if (blnUnsigned)
							return Convert.ToUInt64(strValue, objMySQLCulture);
						else
							return Convert.ToInt64(strValue, objMySQLCulture);

					case MySQLDataTypes.DATA_TYPE_INTEGER:
					case MySQLDataTypes.DATA_TYPE_MEDIUM_INT:
						if (blnUnsigned)
							return Convert.ToUInt32(strValue, objMySQLCulture);
						else
							return Convert.ToInt32(strValue, objMySQLCulture);

					case MySQLDataTypes.DATA_TYPE_SMALL_INT:
						if (blnUnsigned)
							return Convert.ToUInt16(strValue, objMySQLCulture);
						else
							return Convert.ToInt16(strValue);

					case MySQLDataTypes.DATA_TYPE_TINY_INT:
						if (blnUnsigned)
							return Convert.ToByte(strValue, objMySQLCulture);
						else
							return Convert.ToSByte(strValue, objMySQLCulture);

					case MySQLDataTypes.DATA_TYPE_YEAR:
						return Convert.ToInt16(strValue, objMySQLCulture);

					default:
						return strValue;
				}
			}
			catch (InvalidCastException)
			{
				return strValue;
			}
		}


		/// <summary>
		/// Converts .Net value to a MySQL string (wrapped in a ConversionResult type).
		/// </summary>
		/// <param name="objValue">.Net value to convert</param>
		/// <param name="objMySQLCulture">CultureInfo object to convert numbers correctly</param>
		/// <param name="blnUnicode">Specify if strings should be UFT8 encoded during conversion</param>
		/// <returns>A ConversionResult type containing the converted value</returns>
		public static ConversionResult ConvertDotNetValue(object objValue, CultureInfo objMySQLCulture, bool blnUnicode)
		{	
			Type objType = objValue.GetType();
			if (objType.Equals(typeof(System.Boolean))) return ConvertDotNetValue(objValue, DbType.Boolean, objMySQLCulture, blnUnicode);
			if (objType.Equals(typeof(System.Byte))) return ConvertDotNetValue(objValue, DbType.Byte, objMySQLCulture, blnUnicode);
			if (objType.Equals(typeof(System.Int16))) return ConvertDotNetValue(objValue, DbType.Int16, objMySQLCulture, blnUnicode);
			if (objType.Equals(typeof(System.Int32))) return ConvertDotNetValue(objValue, DbType.Int32, objMySQLCulture, blnUnicode);
			if (objType.Equals(typeof(System.Int64))) return ConvertDotNetValue(objValue, DbType.Int64, objMySQLCulture, blnUnicode);
			if (objType.Equals(typeof(System.UInt16))) return ConvertDotNetValue(objValue, DbType.UInt16, objMySQLCulture, blnUnicode);
			if (objType.Equals(typeof(System.UInt32))) return ConvertDotNetValue(objValue, DbType.UInt32, objMySQLCulture, blnUnicode);
			if (objType.Equals(typeof(System.UInt64))) return ConvertDotNetValue(objValue, DbType.UInt64, objMySQLCulture, blnUnicode);
			if (objType.Equals(typeof(System.Double))) return ConvertDotNetValue(objValue, DbType.Double, objMySQLCulture, blnUnicode);
			if (objType.Equals(typeof(System.Single))) return ConvertDotNetValue(objValue, DbType.Single, objMySQLCulture, blnUnicode);
			if (objType.Equals(typeof(System.Decimal))) return ConvertDotNetValue(objValue, DbType.Decimal, objMySQLCulture, blnUnicode);
			if (objType.Equals(typeof(System.String))) return ConvertDotNetValue(objValue, DbType.String, objMySQLCulture, blnUnicode);
			if (objType.Equals(typeof(System.DateTime))) return ConvertDotNetValue(objValue, DbType.DateTime, objMySQLCulture, blnUnicode);
			if (objType.Equals(typeof(System.TimeSpan))) return ConvertDotNetValue(objValue, DbType.Time, objMySQLCulture, blnUnicode);
			if (objType.Equals(typeof(System.Byte[]))) return ConvertDotNetValue(objValue, DbType.Binary, objMySQLCulture, blnUnicode);

			// type not defined, default
			ConversionResult objResult;
			objResult.Value = Encoding.ASCII.GetBytes(objValue.ToString());
			objResult.Length = objResult.Value.Length;
			return objResult;
		}


		/// <summary>
		/// Converts .Net value to a MySQL string (wrapped in a ConversionResult type).
		/// </summary>
		/// <param name="objValue">.Net value to convert</param>
		/// <param name="enmType">Type of the value</param>
		/// <param name="objMySQLCulture">CultureInfo object to convert numbers correctly</param>
		/// <param name="blnUnicode">Specify if strings should be UFT8 encoded during conversion</param>
		/// <returns>A ConversionResult type containing the converted value</returns>
		public static ConversionResult ConvertDotNetValue(object objValue, DbType enmType, CultureInfo objMySQLCulture, bool blnUnicode)
		{
			ConversionResult objResult;

			try
			{
				switch(enmType)
				{
					case DbType.AnsiString:
					case DbType.AnsiStringFixedLength:
					case DbType.String:
					case DbType.StringFixedLength:
					case DbType.VarNumeric:
					case DbType.Object:
						if (blnUnicode)
						{
							// !!! Don't append " because this is already done by EncodeUnicodeString
							objResult.Value = EncodeUnicodeString(EscapeMySQLString(objValue.ToString()));
							objResult.Length = objResult.Value.Length;
							return objResult;
						}
						else
						{
							objResult.Value = Encoding.ASCII.GetBytes("\"" + EscapeMySQLString(objValue.ToString()) + "\"");
							objResult.Length = objResult.Value.Length;
							return objResult;
						}

					case DbType.Binary:
						// EscapeMyBlob already returns ConversionResult struct
						return EscapeMySQLBlob((byte[]) objValue);

					case DbType.Decimal:
						objResult.Value = Encoding.ASCII.GetBytes("\"" + Convert.ToDecimal(objValue).ToString(objMySQLCulture) + "\"");
						objResult.Length = objResult.Value.Length;
						return objResult;

					case DbType.Double:
					case DbType.Single:
					case DbType.Currency:
						objResult.Value = Encoding.ASCII.GetBytes("\"" + Convert.ToDouble(objValue).ToString(objMySQLCulture) + "\"");
						objResult.Length = objResult.Value.Length;
						return objResult;

					case DbType.Byte:
					case DbType.Int16:
					case DbType.Int32:
					case DbType.Int64:
						objResult.Value = Encoding.ASCII.GetBytes("\"" + Convert.ToInt64(objValue).ToString(objMySQLCulture) + "\"");
						objResult.Length = objResult.Value.Length;
						return objResult;

					case DbType.SByte:
					case DbType.UInt16:
					case DbType.UInt32:
					case DbType.UInt64:
						objResult.Value = Encoding.ASCII.GetBytes("\"" + Convert.ToUInt64(objValue).ToString(objMySQLCulture) + "\"");
						objResult.Length = objResult.Value.Length;
						return objResult;

					case DbType.Date:
					case DbType.DateTime:
						DateTime dteTemp = Convert.ToDateTime(objValue);
						objResult.Value = Encoding.ASCII.GetBytes("\"" + dteTemp.Year + "-" + dteTemp.Month + "-" + dteTemp.Day + " " + dteTemp.Hour + ":" + dteTemp.Minute + ":" + dteTemp.Second + "\"");
						objResult.Length = objResult.Value.Length;
						return objResult;

					case DbType.Time:
						dteTemp = Convert.ToDateTime(objValue.ToString(), objMySQLCulture);
						objResult.Value = Encoding.ASCII.GetBytes("\"" + dteTemp.Hour + ":" + dteTemp.Minute + ":" + dteTemp.Second + "\"");
						objResult.Length = objResult.Value.Length;
						return objResult;

					case DbType.Boolean:
						objResult.Value = Encoding.ASCII.GetBytes("\"" + Convert.ToBoolean(objValue).ToString(objMySQLCulture) + "\"");
						objResult.Length = objResult.Value.Length;
						return objResult;

					case DbType.Guid:
						objResult.Value = Encoding.ASCII.GetBytes("\"" + ((Guid) objValue).ToString() + "\"");
						objResult.Length = objResult.Value.Length;
						return objResult;

					default:
						objResult.Value = Encoding.ASCII.GetBytes("\"" + EscapeMySQLString(objValue.ToString()) + "\"");
						objResult.Length = objResult.Value.Length;
						return objResult;
				}
			} 
			catch (Exception ex) { throw new MySQLException("Error in conversion from .Net to MySQL data type.\nData Type: " + enmType.ToString() + "\n" + "Value as String: \"" + objValue.ToString() + "\"", ex); }
		}


		public static ConversionResult ConvertDotNetNull()
		{
			ConversionResult objResult;
			objResult.Value = Encoding.ASCII.GetBytes("NULL");
			objResult.Length = objResult.Value.Length;
			return objResult;
		}

			
		/// <summary>
		/// Converts two-byte unicode string to UTF8 byte array. Appends " at the beginning and at the end automatically.
		/// </summary>
		/// <param name="strUnicode">String to encode</param>
		/// <returns>Byte array that contains the corresponding UTF8 characters (ASCII)</returns>
		public static byte[] EncodeUnicodeString(string strUnicode)
		{
			int intLenght = Encoding.UTF8.GetByteCount(strUnicode);
			byte[] bteTemp = new byte[intLenght + 2];
			bteTemp[0] = 34; // 34 is ASCII for "
			bteTemp[bteTemp.Length - 1] = 34;
			Encoding.UTF8.GetBytes(strUnicode, 0, strUnicode.Length, bteTemp, 1);
			return bteTemp;
		}


		/// <summary>
		/// Converts a byte array containing a UTF8 encoded characters (ASCII) to a Unicode string.
		/// </summary>
		/// <param name="bteUnicode">Array with UTF8 encoded characters</param>
		/// <returns>Converted Unicode string</returns>
		public static string DecodeUnicodeString(byte[] bteUTF8)
		{
			int intLength = Encoding.UTF8.GetDecoder().GetCharCount(bteUTF8, 0, bteUTF8.Length);
			char[] chrTemp = new char[intLength];
			Encoding.UTF8.GetDecoder().GetChars(bteUTF8, 0, bteUTF8.Length, chrTemp, 0);
			return new string(chrTemp);
		}


		/// <summary>
		/// Escapes a string. Replaces " and \ with \" and \\.
		/// </summary>
		/// <param name="strToEscape">String to excape</param>
		/// <returns>The escaped string</returns>
		public static string EscapeMySQLString(string strToEscape)
		{
			//todo: Optimze, convert to byte array and do all searching in one pass
			return strToEscape.Replace("\\", "\\\\").Replace("\"", "\\\"");
		}


		/// <summary>
		/// Espaces a BLOB byte array. Replaces " and \ with \" and \\.
		/// </summary>
		/// <param name="bteToEscape">Array of bytes to escape</param>
		/// <returns>A ConversionResult type that contains the escaped BLOB</returns>
		public static ConversionResult EscapeMySQLBlob(byte[] bteToEscape)
		{
			byte[] bteTemp = new byte[bteToEscape.Length * 2 + 2];
			int intPos2 = 1;

			// 34 is ASCII for ", 92 is ASCII for \
			bteTemp[0] = 34;
			for (int intPos1 = 0; intPos1 < bteToEscape.Length; intPos1++)
			{
				if (34 == bteToEscape[intPos1])
				{
					// replace " with \"
					bteTemp[intPos2++] = 92;
					bteTemp[intPos2++] = 34;
				}
				else if (92 == bteToEscape[intPos1])
				{
					// replace \ with \\
					bteTemp[intPos2++] = 92;
					bteTemp[intPos2++] = 92;
				}
				else
					bteTemp[intPos2++] = bteToEscape[intPos1];
			}
			bteTemp[intPos2++] = 34;
			
			ConversionResult objResult;
			objResult.Value = bteTemp;
			objResult.Length = intPos2;
			return objResult;
		}
	}
}