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
using System.Runtime.InteropServices;


namespace System.Data.MySQLClient
{
	/// <summary>
	/// The exception that is thrown to return an error from a MySQL data source.
	/// </summary>
	public sealed class MySQLException : ExternalException
	{
		public MySQLException() : base() {}

		public MySQLException(string strMessage) : base(strMessage) {}

		public MySQLException(string strMessage, int intErrorCode) : base(strMessage, intErrorCode) {}

		public MySQLException(string strMessage, Exception objInnerException) : base(strMessage, objInnerException) {}

		public MySQLException(System.Runtime.Serialization.SerializationInfo objInfo,
							  System.Runtime.Serialization.StreamingContext objContext)
							  : base(objInfo, objContext) {}
	}
}
