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
	/// Represents a SQL transaction to be made at a data source.
	/// </summary>
	public class MySQLTransaction : System.MarshalByRefObject, IDbTransaction, IDisposable
	{
		MySQLConnection m_objConnection;
		IsolationLevel m_enmIsolationLevel;


		/// <summary>
		/// Initializes a new instance of the MySQLTransaction class based on the specified connection.
		/// </summary>
		/// <param name="objConnection">Connection used by the transaction</param>
		internal MySQLTransaction(MySQLConnection objConnection) : base()
		{
			m_objConnection = objConnection;
			m_enmIsolationLevel = IsolationLevel.Unspecified;
		}


		/// <summary>
		/// Initializes a new instance of the MySQLTransaction class based on the specified connection with the given isolation level.
		/// </summary>
		/// <param name="objConnection">Connection used by the transaction</param>
		/// <param name="enmIsolationLevel">Specifies the System.Data.IsolationLevel for this transaction</param>
		internal MySQLTransaction(MySQLConnection objConnection, IsolationLevel enmIsolationLevel) : base()
		{
			m_objConnection = objConnection;
			m_enmIsolationLevel = enmIsolationLevel;
		}

		
		/// <summary>
		/// Commits the database transaction.
		/// </summary>
		unsafe public void Commit()
		{
			if (m_objConnection.State == ConnectionState.Closed)
				throw new MySQLException("Database closed");

			CPrototypes.RunSQLStatement("COMMIT", m_objConnection.DBHandle);
			m_objConnection = null;
		}


		/// <summary>
		/// Rolls back a transaction from a pending state.
		/// </summary>
		unsafe public void Rollback()
		{
			if (m_objConnection.State == ConnectionState.Closed)
				throw new MySQLException("Database closed");

			CPrototypes.RunSQLStatement("ROLLBACK", m_objConnection.DBHandle);
			m_objConnection = null;
		}


		/// <summary>
		/// Gets the System.Data.MySQLClient.MySQLConnection object associated with the transaction, or null if the transaction is no longer valid.
		/// </summary>
		IDbConnection IDbTransaction.Connection
		{
			get { return m_objConnection; } 
		}


		/// <summary>
		/// Gets the System.Data.MySQLClient.MySQLConnection object associated with the transaction, or null if the transaction is no longer valid.
		/// </summary>
		public MySQLConnection Connection 
		{
			get { return m_objConnection; } 
		}


		/// <summary>
		/// Specifies the System.Data.IsolationLevel for this transaction.
		/// </summary>
		public System.Data.IsolationLevel IsolationLevel 
		{
			get { return m_enmIsolationLevel; } 
		}


		/// <summary>
		/// 
		/// </summary>
		public void Dispose()
		{
		}
	}
}
