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


namespace System.Data.MySQLClient
{
	/// <summary>
	/// Represents an open connection to a MySQL database.
	/// </summary>
	public sealed class MySQLConnection : Component, ICloneable, IDbConnection, IDisposable
	{
		/// <summary>
		/// Occurs when the state of the connection changes.
		/// </summary>
		public event StateChangeEventHandler StateChanged;
		const int MYSQL_OPT_CONNECT_TIMEOUT = 0; // enum const for mysql_options()

		string m_strConnectionString = "";
		string m_strHost = "localhost";
		string m_strUser = "root";
		string m_strPassword = "";
		string m_strDatabase = "";
		int m_intConnectionTimeOut = 15;
		ConnectionState m_enmState = ConnectionState.Closed;
		unsafe void* m_ptrDBHandle = null;
		MySQLDataReader m_objCurrentQuery = null;


		/// <summary>
		/// Initializes a new instance of the System.Data.MySQLClient.MySQLConnection class.
		/// </summary>
		public MySQLConnection() : base() {}


		/// <summary>
		/// Initializes a new instance of the System.Data.MySQLClient.MySQLConnection class.
		/// </summary>
		/// <param name="strConnection">Example for connection string "Location=...;User ID=...;Password=...;Data Source =...; Connection timeout=...", use any combination of the property names.</param>
		public MySQLConnection(string strConnection) : base()
		{
			m_strConnectionString = strConnection;
			ParseConnectionString();
		}


		/// <summary>
		///	Gets or sets the string used to open a database.
		///	Example for connection string "Location=...;User ID=...;Password=...;Data Source =...; Connection timeout=...", use any combination of the property names.
		/// </summary>
		public string ConnectionString
		{
			get{ return m_strConnectionString; }

			set{ m_strConnectionString = value; ParseConnectionString(); }
		}


		/// <summary>
		/// Opens a database connection with the property settings specified by the System.Data.MySQLClient.MySQLConnectionString.
		/// </summary>
		unsafe public void Open()
		{
			if (m_ptrDBHandle != null) Close();

			// initialize mysql client dll
			m_ptrDBHandle = CPrototypes.mysql_init(null);
			if (null == m_ptrDBHandle)
				throw new MySQLException("Cannot initialize MySQL client library");

			CPrototypes.mysql_options(m_ptrDBHandle, MYSQL_OPT_CONNECT_TIMEOUT, m_intConnectionTimeOut.ToString());

			// now try to connect to server
			void* ptrRet = CPrototypes.mysql_real_connect(m_ptrDBHandle, m_strHost, m_strUser, m_strPassword, m_strDatabase, 0, null, 0);
			if (null == ptrRet)
				throw new MySQLException(CPrototypes.mysql_error(m_ptrDBHandle), (int) CPrototypes.mysql_errno(m_ptrDBHandle));

			if (null != StateChanged) StateChanged(this, new StateChangeEventArgs(m_enmState, ConnectionState.Open));
			m_enmState = ConnectionState.Open;
		}

		
		/// <summary>
		/// Closes the connection to the data source. This is the preferred method of closing any open connection.
		/// </summary>
		unsafe public void Close()
		{
			if (null != m_objCurrentQuery) m_objCurrentQuery.Close(true);
			if (null != StateChanged) StateChanged(this, new StateChangeEventArgs(m_enmState, ConnectionState.Closed));
			if (m_enmState != ConnectionState.Closed && null != m_ptrDBHandle) CPrototypes.mysql_close(m_ptrDBHandle);
			m_enmState = ConnectionState.Closed;
		}


		/// <summary>
		/// Changes the current database for an open System.Data.MySQLClient.MySQLConnection.
		/// </summary>
		/// <param name="strNewDatabase">The database name</param>
		unsafe public void ChangeDatabase(string strNewDatabase)
		{
			if (m_enmState == ConnectionState.Closed)
				throw new MySQLException("Connection not open");

			m_strDatabase = strNewDatabase;
			if (0 != CPrototypes.mysql_select_db(m_ptrDBHandle, strNewDatabase))
				throw new MySQLException(CPrototypes.mysql_error(m_ptrDBHandle), (int) CPrototypes.mysql_errno(m_ptrDBHandle));
		}


		/// <summary>
		/// Gets the current state of the connection.
		/// </summary>
		public ConnectionState State
		{
			get { return m_enmState; }
		}


		/// <summary>
		/// Gets the connection handle of the C-API.
		/// </summary>
		unsafe internal void* DBHandle
		{
			get { return m_ptrDBHandle; }
		}


		/// <summary>
		/// Disposes the object and frees up resources.
		/// </summary>
		public new void Dispose()
		{
			base.Dispose();
			Close();
		}


		/// <summary>
		/// Begins a database transaction.
		/// </summary>
		/// <returns>An object representing the new transaction. </returns>
		IDbTransaction IDbConnection.BeginTransaction()
		{
			return BeginTransaction();
		}


		/// <summary>
		/// Begins a database transaction.
		/// </summary>
		/// <returns>An object representing the new transaction.</returns>
		unsafe public MySQLTransaction BeginTransaction() 
		{
			if (m_enmState == ConnectionState.Closed)
				throw new MySQLException("Connection not open");

			CPrototypes.RunSQLStatement("BEGIN", m_ptrDBHandle);
			return new MySQLTransaction(this);
		}


		/// <summary>
		/// Begins a database transaction with the current System.Data.IsolationLevel value.
		/// </summary>
		/// <param name="enmIsolationLevel">The transaction isolation level for this connection.</param>
		/// <returns>An object representing the new transaction.</returns>
		IDbTransaction IDbConnection.BeginTransaction(IsolationLevel enmIsolationLevel) 
		{
			return BeginTransaction(enmIsolationLevel);
		}


		/// <summary>
		/// Begins a database transaction with the current System.Data.IsolationLevel value.
		/// </summary>
		/// <param name="enmIsolationLevel">The transaction isolation level for this connection.</param>
		/// <returns>An object representing the new transaction.</returns>
		unsafe public MySQLTransaction BeginTransaction(IsolationLevel enmIsolationLevel)
		{
			string strIsolation = "";
			switch (enmIsolationLevel)
			{
				case IsolationLevel.Chaos:
					throw new NotSupportedException("Isolation level Chaos not supported");
				case IsolationLevel.ReadCommitted:
					strIsolation = "READ COMMITTED"; break;
				case IsolationLevel.ReadUncommitted:
					strIsolation = "READ UNCOMMITTED"; break;
				case IsolationLevel.RepeatableRead:
					strIsolation = "REPEATABLE READ"; break;
				case IsolationLevel.Serializable:
					strIsolation = "SERIALIZABLE"; break;
			}
			if (0 != strIsolation.Length)
				CPrototypes.RunSQLStatement("SET TRANSACTION ISOLATION LEVEL " + strIsolation, m_ptrDBHandle);
			CPrototypes.RunSQLStatement("BEGIN", m_ptrDBHandle);
			return new MySQLTransaction(this, enmIsolationLevel);
		}


		/// <summary>
		/// Gets or sets a datareader that is currently using the connection. Indicates if a command object can start a new query with this connection.
		/// </summary>
		internal MySQLDataReader CurrentQuery
		{
			get { return m_objCurrentQuery; }
			set { m_objCurrentQuery = value; }
		}


		/// <summary>
		/// Creates and returns an System.Data.MySQLClient.MySQLCommand object associated with the System.Data.MySQLClient.MySQLConnection.
		/// </summary>
		/// <returns>An System.Data.MySQLClient.MySQLCommand object.</returns>
		IDbCommand IDbConnection.CreateCommand()
		{
			return CreateCommand(); 
		}
		

		/// <summary>
		/// Creates and returns an System.Data.MySQLClient.MySQLCommand object associated with the System.Data.MySQLClient.MySQLConnection.
		/// </summary>
		/// <returns>An System.Data.MySQLClient.MySQLCommand object.</returns>
		public MySQLCommand CreateCommand() 
		{
			MySQLCommand objCommand = new MySQLCommand();
			objCommand.Connection = this;
			return objCommand; 
		}


		/// <summary>
		/// Creates a new instance of this connection with the same value as an existing connection. Connection is always closed when created.
		/// </summary>
		/// <returns>A new connection that is a copy of this instance.</returns>
		public Object Clone() 
		{ 
			MySQLConnection objNew = new MySQLConnection();
			objNew.m_strConnectionString = m_strConnectionString;
			objNew.m_strDatabase = m_strDatabase;
			objNew.m_strHost = m_strHost;
			objNew.m_strPassword = m_strPassword;
			objNew.m_strUser = m_strUser;
			return objNew; 
		}


		/// <summary>
		/// Not supported
		/// </summary>
		public int ConnectionTimeout
		{ 
			get { return m_intConnectionTimeOut; } 
			set { m_intConnectionTimeOut = value; } 
		}


		/// <summary>
		/// Gets the name of the current database or the database to be used once a connection is open.
		/// </summary>
		unsafe public string Database
		{ 
			get{ return m_strDatabase; }
			set
			{
				if (m_enmState == ConnectionState.Open) CPrototypes.mysql_select_db(m_ptrDBHandle, value);
				m_strDatabase = value;
			}
		}


		/// <summary>
		/// Gets the location (server name or address) of the data source.
		/// </summary>
		public string DataSource
		{
			get { return m_strHost; }
		}

		//*******************************************************

		/// <summary>
		/// Retrieves the connection parameters from the connection string
		/// </summary>
		private void ParseConnectionString()
		{
			// this parsing algorithm was taken from MySQLSharp, www.sourceforge.net/projects/mysqlsharp
			string strPropName, strPropValue;
			int i = 0, j;

			while(i < m_strConnectionString.Length)
			{
				j = m_strConnectionString.IndexOf('=', i);
				if (j != -1)
					strPropName = m_strConnectionString.Substring(i, j - i);
				else
					strPropName = m_strConnectionString.Substring(i);
				i += strPropName.Length + 1;
				strPropName = strPropName.Trim();

				if (i == m_strConnectionString.Length) break;

				if (m_strConnectionString[i] == '\"' || m_strConnectionString[i] == '\'')
				{
					j = m_strConnectionString.IndexOf(m_strConnectionString[i], i + 1);
					if (j == -1)
						throw new MySQLException("Invalid property in connection string: " + strPropName);
					i++;
					strPropValue = m_strConnectionString.Substring(i, j - i);
					i += strPropValue.Length + 2;
				}
				else
				{
					j = m_strConnectionString.IndexOf(';', i);
					if (j != -1)
						strPropValue = m_strConnectionString.Substring(i, j - i);
					else
						strPropValue = m_strConnectionString.Substring(i);
					i += strPropValue.Length + 1;
				}

				switch (strPropName.ToLower())
				{
					case "server":
					case "address":
					case "location":
						m_strHost = strPropValue.Trim();
						break;
					case "data source":
					case "database":
					case "initial catalog":
					case "catalog":
						m_strDatabase = strPropValue.Trim();
						break;
					case "user":
					case "user id":
						m_strUser = strPropValue.Trim();
						break;
					case "password":
					case "pwd":
						m_strPassword = strPropValue.Trim();
						break;
					case "connection timeout":
					case "timeout":
						try 
						{
							m_intConnectionTimeOut = Int32.Parse(strPropValue);
						} 
						catch (Exception e) 
						{
							throw new MySQLException("Invalid Connection Timeout value in connection string", e);
						}
						if (m_intConnectionTimeOut < 0)
							throw new ArgumentException("Invalid negative value for Connection Timeout");
						break;
					default:
						throw new ArgumentException("Invalid property in connection string: " + strPropName);
				}
			}
		}
	}
}
