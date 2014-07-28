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
using System.Data.Common;


namespace System.Data.MySQLClient
{
	/// <summary>
	/// Provides data for the System.Data.MySQLClient.MySQLDataAdapter.RowUpdated event.
	/// </summary>
	public sealed class MySQLRowUpdatedEventArgs : RowUpdatedEventArgs
	{
		public MySQLRowUpdatedEventArgs(DataRow objDataRow, IDbCommand objCommand, StatementType enmStatementType, DataTableMapping objTableMapping)
			: base(objDataRow, objCommand, enmStatementType, objTableMapping)
		{}


		new public MySQLCommand Command
		{
			get { return (MySQLCommand) base.Command; }
		}
	}
}
