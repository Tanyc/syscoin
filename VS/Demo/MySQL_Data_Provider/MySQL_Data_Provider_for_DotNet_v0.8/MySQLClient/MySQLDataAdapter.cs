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
using System.Data.Common;


namespace System.Data.MySQLClient
{
	/// <summary>
	/// Occurs during System.Data.Common.DbDataAdapter.Update(System.Data.DataSet) before a command is executed against the data source. The attempt to update is made, so the event fires.
	/// </summary>
	public delegate void MySQLRowUpdatingEventHandler(object sender, MySQLRowUpdatingEventArgs e);
	/// <summary>
	/// Occurs during System.Data.Common.DbDataAdapter.Update(System.Data.DataSet) after a command is executed against the data source.  The attempt to update is made, so the event fires.
	/// </summary>
	public delegate void MySQLRowUpdatedEventHandler(object sender, MySQLRowUpdatedEventArgs e);


	/// <summary>
	/// Represents a set of data commands and a database connection that are used to fill the System.Data.DataSet and update the data source.
	/// </summary>
	public sealed class MySQLDataAdapter : DbDataAdapter, IDbDataAdapter
	{
		MySQLCommand m_objDeleteCommand = null;
		MySQLCommand m_objInsertCommand = null;
		MySQLCommand m_objSelectCommand = null;
		MySQLCommand m_objUpdateCommand = null;

		static private readonly object EventRowUpdated = new object(); 
		static private readonly object EventRowUpdating = new object(); 


		/// <summary>
		/// Initializes a new instance of the System.Data.MySQLCLient.MySQLDataAdapter class.
		/// </summary>
		public MySQLDataAdapter() : base() {} 


		/// <summary>
		/// Initializes a new instance of the System.Data.MySQLCLient.MySQLDataAdapter classs with the specified System.Data.MySQL.MySQLCommand as the System.Data.MySQLClient.MySQLDataAdapter.SelectCommand property.
		/// </summary>
		/// <param name="objSelectCommand">An System.Data.MySQLClient.MySQLCommand that is a SELECT statement. This System.Data.MySQLClient.MySQLCommand is set as the System.Data.MySQLClient.MySQLDataAdapter.SelectCommand property of the System.Data.MySQLClient.MySQLDataAdapter.</param>
		public MySQLDataAdapter(MySQLCommand objSelectCommand) : base()
		{
			SelectCommand = objSelectCommand;
		}


		/// <summary>
		/// Initializes a new instance of the System.Data.MySQLCLient.MySQLDataAdapter class with a System.Data.MySQLClient.MySQLDataAdapter.SelectCommand.
		/// </summary>
		/// <param name="strSelectCommand">The System.Data.MySQLClient.MySQLDataAdapter.SelectCommand.</param>
		/// <param name="strConnectionString">The connection string.</param>
		public MySQLDataAdapter(string strSelectCommand, string strConnectionString) : base()
		{
			SelectCommand = new MySQLCommand(strSelectCommand, new MySQLConnection(strConnectionString));
		}


		/// <summary>
		/// Initializes a new instance of the System.Data.MySQLCLient.MySQLDataAdapter class with a System.Data.MySQLClient.MySQLDataAdapter.SelectCommand.
		/// </summary>
		/// <param name="strSelectCommand">The System.Data.MySQLClient.MySQLDataAdapter.SelectCommand.</param>
		/// <param name="objConnection">A System.Data.MySQLClient.MySQLConnection that represents the connection.</param>
		public MySQLDataAdapter(string strSelectCommand, MySQLConnection objConnection) : base()
		{
			SelectCommand = new MySQLCommand(strSelectCommand, objConnection);
		}

		
		/// <summary>
		/// Gets or sets an SQL statement or stored procedure for deleting records from the data set.
		/// </summary>
		IDbCommand IDbDataAdapter.DeleteCommand
		{ 
			get { return m_objDeleteCommand; }
			set { m_objDeleteCommand = (MySQLCommand) value; }
		}


		/// <summary>
		/// Gets or sets a SQL statement or stored procedure for deleting records from the data set.
		/// </summary>
		public MySQLCommand DeleteCommand
		{ 
			get { return m_objDeleteCommand; }
			set { m_objDeleteCommand = value; }
		}


		/// <summary>
		/// Gets or sets an SQL statement or stored procedure for inserting records from the data set.
		/// </summary>
		IDbCommand IDbDataAdapter.InsertCommand
		{ 
			get { return m_objInsertCommand; }
			set { m_objInsertCommand = (MySQLCommand) value; } 
		}


		/// <summary>
		/// Gets or sets an SQL statement or stored procedure for inserting records from the data set.
		/// </summary>
		public MySQLCommand InsertCommand
		{ 
			get { return m_objInsertCommand; }
			set { m_objInsertCommand = value; } 
		}


		/// <summary>
		/// Gets or sets an SQL statement or stored procedure for selecting records from the data set.
		/// </summary>
		IDbCommand IDbDataAdapter.SelectCommand
		{
			get { return m_objSelectCommand; }
			set { m_objSelectCommand = (MySQLCommand) value; }
		}


		/// <summary>
		/// Gets or sets an SQL statement or stored procedure for selecting records from the data set.
		/// </summary>
		public MySQLCommand SelectCommand
		{ 
			get { return m_objSelectCommand; }
			set { m_objSelectCommand = value; }
		}


		/// <summary>
		/// Gets or sets an SQL statement or stored procedure for updating records from the data set.
		/// </summary>
		IDbCommand IDbDataAdapter.UpdateCommand 
		{
			get { return m_objUpdateCommand; }
			set { m_objUpdateCommand = (MySQLCommand) value; } 
		}


		/// <summary>
		/// Gets or sets an SQL statement or stored procedure for updating records from the data set.
		/// </summary>
		public MySQLCommand UpdateCommand
		{ 
			get { return m_objUpdateCommand; }
			set { m_objUpdateCommand = value; } 
		}

		
		/// <summary>
		/// Creates an object that is used as a parameter for the RowUpdated event
		/// </summary>
		protected override RowUpdatedEventArgs CreateRowUpdatedEvent(
			DataRow objRow, IDbCommand objCommand, StatementType enmStatementType, DataTableMapping objTableMapping)
		{ 
			return new MySQLRowUpdatedEventArgs(objRow, objCommand, enmStatementType, objTableMapping);
		}


		/// <summary>
		/// Creates an object that is used as a parameter for the RowUpdating event
		/// </summary>
		protected override RowUpdatingEventArgs CreateRowUpdatingEvent(
			DataRow objRow, IDbCommand objCommand, StatementType enmStatementType, DataTableMapping objTableMapping)
		{ 
			return new MySQLRowUpdatingEventArgs(objRow, objCommand, enmStatementType, objTableMapping);
		}


		/// <summary>
		/// Fires the RowUpdated event
		/// </summary>
		protected override void OnRowUpdated(RowUpdatedEventArgs objValue)
		{
			MySQLRowUpdatedEventHandler objHandler = (MySQLRowUpdatedEventHandler) Events[EventRowUpdated];
			if ((null != objHandler) && (objValue is MySQLRowUpdatedEventArgs)) 
			{
				objHandler(this, (MySQLRowUpdatedEventArgs) objValue);
			}
		}

		
		/// <summary>
		/// Fires the RowUpdating event
		/// </summary>
		protected override void OnRowUpdating(RowUpdatingEventArgs objValue)
		{
			MySQLRowUpdatingEventHandler objHandler = (MySQLRowUpdatingEventHandler) Events[EventRowUpdating];
			if ((null != objHandler) && (objValue is MySQLRowUpdatingEventArgs)) 
			{
				objHandler(this, (MySQLRowUpdatingEventArgs) objValue);
			}
		}


		/// <summary>
		/// Fires the RowUpdating event
		/// </summary>
		public event MySQLRowUpdatingEventHandler RowUpdating
		{
			add { Events.AddHandler(EventRowUpdating, value); }
			remove { Events.RemoveHandler(EventRowUpdating, value); }
		}


		/// <summary>
		/// Fires the RowUpdated event
		/// </summary>
		public event MySQLRowUpdatedEventHandler RowUpdated
		{
			add { Events.AddHandler(EventRowUpdated, value); }
			remove { Events.RemoveHandler(EventRowUpdated, value); }
		}
	}
}
