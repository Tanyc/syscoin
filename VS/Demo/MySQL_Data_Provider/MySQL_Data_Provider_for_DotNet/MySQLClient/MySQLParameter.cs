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


namespace System.Data.MySQLClient
{
	/// <summary>
	/// Represents a parameter to a System.Data.MySQLClient.MySQLCommand and optionally, its mapping to a System.Data.DataSet column.
	/// </summary>
	public sealed class MySQLParameter : MarshalByRefObject, IDbDataParameter, IDataParameter, ICloneable
	{
		object m_objValue = "";
		string m_strName = "";
		DbType m_enmDBType = DbType.Object;
		ParameterDirection m_enmDirection = ParameterDirection.Input;
		bool m_blnIsNullable = false;
		string m_strSourceColumn = "";
		DataRowVersion m_enmSourceVersion = DataRowVersion.Current;
		byte m_btPrecision = 0;
		byte m_btScale = 0;
		int m_intSize = 0;


		/// <summary>
		/// Initializes a new instance of the System.Data.MySQLCLient.MySQLParameter class.
		/// </summary>
		public MySQLParameter() : base() {}


		/// <summary>
		/// Initializes a new instance of the System.Data.MySQLCLient.MySQLParameter class with the parameter name.
		/// </summary>
		/// <param name="strName">The name of the parameter to map to a DataSet column</param>
		public MySQLParameter(string strName) : base()
		{
			m_strName = strName;
			if (0 == m_strSourceColumn.Length) m_strSourceColumn = strName;
		}


		/// <summary>
		/// Initializes a new instance of the System.Data.MySQLCLient.MySQLParameter class with the parameter name and the parameter type.
		/// </summary>
		/// <param name="strName">The name of the parameter to map to a DataSet column</param>
		/// <param name="objValue">The type of the new System.Data.MySQLClient.MySQLParameter object</param>
		public MySQLParameter(string strName, DbType enmType) : base()
		{
			m_strName = strName;
			m_enmDBType = enmType;
			if (0 == m_strSourceColumn.Length) m_strSourceColumn = strName;
		}


		/// <summary>
		/// Initializes a new instance of the System.Data.MySQLCLient.MySQLParameter class with the parameter name, the parameter value and the parameter type.
		/// </summary>
		/// <param name="strName">The name of the parameter to map to a DataSet column</param>
		/// <param name="objValue">The value of the new System.Data.MySQLClient.MySQLParameter object</param>
		/// <param name="enmType">The data type of the parameter</param>
		public MySQLParameter(string strName, DbType enmType, object objValue) : base()
		{
			m_strName = strName;
			m_enmDBType = enmType;
			m_objValue = objValue;
			if (0 == m_strSourceColumn.Length) m_strSourceColumn = strName;
		}

		
		/// <summary>
		/// Gets or sets the System.Data.DbType of the parameter.
		/// </summary>
		public DbType DbType
		{
			get { return m_enmDBType; } 
			set { m_enmDBType = value; } 
		}


		/// <summary>
		/// Gets or sets a value indicating whether the parameter is input-only, output-only, bidirectional, or a stored procedure return value parameter. Default is Input.
		/// </summary>
		public ParameterDirection Direction 
		{ 
			get { return m_enmDirection; }
			set { m_enmDirection = value; }
		}


		/// <summary>
		/// Gets or sets a value indicating whether the parameter accepts null values.
		/// </summary>
		public bool IsNullable
		{
			get { return m_blnIsNullable; } 
			set { m_blnIsNullable = value; }
		}


		/// <summary>
		/// Gets or sets the name of the System.Data.MySQLClient.MySQLParameter.
		/// </summary>
		public string ParameterName 
		{
			get { return m_strName; } 
			set { 
				m_strName = value;
				if (0 == m_strSourceColumn.Length) m_strSourceColumn = m_strName;
			} 
		}


		/// <summary>
		/// Gets or sets the name of the source column mapped to the System.Data.DataSet and used for loading or returning the System.Data.MySQLClient.MySQLParameter.Value.
		/// </summary>
		public string SourceColumn 
		{
			get { return m_strSourceColumn; } 
			set { m_strSourceColumn = value; } 
		}


		/// <summary>
		/// Gets or sets the System.Data.DataRowVersion to use when loading System.Data.MySQLClient.MySQLParameter.Value.
		/// </summary>
		public DataRowVersion SourceVersion 
		{
			get { return m_enmSourceVersion; } 
			set { m_enmSourceVersion = value; }
		}


		/// <summary>
		/// Gets or sets the value of the parameter.
		/// </summary>
		public object Value 
		{ 
			get { return m_objValue; } 
			set { m_objValue = value; } 
		} 


		/// <summary>
		/// Gets or sets the maximum number of digits used to represent the System.Data.MySQLClient.MySQLParameter.Value property.
		/// </summary>
		public byte Precision 
		{ 
			get { return m_btPrecision; } 
			set { m_btPrecision = value; } 
		} 


		/// <summary>
		/// Gets or sets the number of decimal places to which System.Data.MySQLClient.MySQLParameter.Value is resolved.
		/// </summary>
		public byte Scale 
		{ 
			get { return m_btScale; } 
			set { m_btScale = value; } 
		} 


		/// <summary>
		/// Gets or sets the maximum size, in bytes, of the data within the column.
		/// </summary>
		public int Size
		{ 
			get { return m_intSize; } 
			set { m_intSize = value; } 
		} 


		/// <summary>
		/// Creates a new Parameter object that is a copy of the current instance.  
		/// </summary>
		/// <returns>A new Parameter object that is a copy of this instance</returns>
		public object Clone()
		{
			MySQLParameter objNew = new MySQLParameter();
			objNew.m_blnIsNullable = m_blnIsNullable;
			objNew.m_btPrecision = m_btPrecision;
			objNew.m_btScale = m_btScale;
			objNew.m_enmDBType = m_enmDBType;
			objNew.m_enmDirection = m_enmDirection;
			objNew.m_enmSourceVersion = m_enmSourceVersion;
			objNew.m_intSize = m_intSize;
			objNew.m_objValue = m_objValue;
			objNew.m_strName = m_strName;
			objNew.m_strSourceColumn = m_strSourceColumn;
			return objNew; 
		}
	}
}
