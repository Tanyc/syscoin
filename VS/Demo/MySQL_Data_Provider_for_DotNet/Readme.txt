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

==============================================

Project: MySQLClient
Version: 0.9
Release Date: 2003-01-29


Overview
--------
MySQLClient is a Custom .Net Data Provider for MySQL. It can be
used just the same way as the OLEDB or SQL Server provider.

It implements 100% of the functionality required for Custom
Data Providers.

These are the most important features:
-Automatic conversion of MySQL data types to .Net data types and
 vice versa, including DateTime types
-Parameterized SQL statements with help of parameters.
 Example: "SELECT * FROM user WHERE name=?"
-Unicode support by implicit conversion from and to UTF-8
 (can be optionally turned on).
-BLOB support in form of byte arrays.
-Transaction support (of course only for InnoDb tables).


Getting started
---------------
Open the VS solution and compile it. This creates the sample
project and the MySQLClient dll.

I have included the libmysql.dll, the library with the C-API
functions, that MySQLClient uses. Either copy it beside the 
sample executable (into Bin\Debug) or into the system directory.
This version is taken from 4.0.3 beta.

I have included a small code example. It shows the
use of the DataAdapter, Unicode, Blobs and Transactions.
Before you run the example, create a new database in MySQL
with help of the 'createdatabase.sql' script.

Every class and method in the code is documented.


Development State
-----------------
Actually, MySQLClient implements the following classes:
-MySQLCommand
-MySQLConnection
-MySQLDataAdapter
-MySQLDataReader
-MySQLException
-MySQLParameter
-MySQLParameterCollection
-MySQLRowUpdatedEventArgs
-MySQLRowUpdatingEventArgs
-MySQLTransaction
-MySQLTypes

In the meantime this software definitely has reached beta status. I have developed an
application myself, that makes heavy use of the data provider (blobs, DataAdapters and
Unicode) and it works (of course ;-) Additionally I know from several other people
that successfully use this Data Provider.


To do
-----
-MySQLCommand, MySQLConnection and MySQLDataAdapter are derived
 from Component, which means that they can be dragged onto forms
 just like the corresponding objects from OLEDB or SQL Server.
 No wizard functionality implemented until now.
-GetChars and GetBytes methods in MySQLDataReader.
-Possible optimizations when communicating with MySQL.
 I have seen a project that used a named pipe or a socket to 
 communicate with MySQL. If speed is the highest priority, 
 this might be an option.


Contact and Feedback
--------------------
Please report any bugs on this website:
http://sourceforge.net/projects/mysqldotnet/

Also please use that website to ask for support.

Christoph Wienands

