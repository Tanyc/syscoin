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


namespace System.Data.MySQLClient
{
	/// <summary>
	/// Collects all parameters relevant to an System.Data.MySQLClLient.MySQLCommand as well as their respective mappings to System.Data.DataSet columns.
	/// </summary>
	public sealed class MySQLParameterCollection : MarshalByRefObject, IList, IEnumerable, IDataParameterCollection, ICollection
	{
		ArrayList m_objList = new ArrayList(5);


		/// <summary>
		/// Initializes a new instance of the MySQLParameterCollection class.
		/// </summary>
		internal MySQLParameterCollection() : base() {}


		/// <summary>
		/// Adds a System.Data.MySQLClient.MySQLParameter object to the System.Data.MySQLClient.MySQLCommand.
		/// </summary>
		/// <param name="objValue">The System.Data.MySQLClient.MySQLParameter object to add to the collection.</param>
		/// <returns>The index of the new System.Data.MySQLClient.MySQLParameter object in the collection.</returns>
		int IList.Add(object objValue) 
		{ 
			return m_objList.Add((MySQLParameter) objValue);
		}


		/// <summary>
		/// Adds a System.Data.MySQLClient.MySQLParameter object to the System.Data.MySQLClient.MySQLCommand.
		/// </summary>
		/// <param name="objValue">The System.Data.MySQLClient.MySQLParameter object to add to the collection.</param>
		/// <returns>The index of the new System.Data.MySQLClient.MySQLParameter object in the collection.</returns>
		public int Add(MySQLParameter objParam) 
		{ 
			return m_objList.Add(objParam);
		}


		/// <summary>
		/// Adds a newly created System.Data.MySQLClient.MySQLParameter object to the System.Data.MySQLClient.MySQLCommand given the parameter name.
		/// </summary>
		/// <param name="strName">The name of the parameter</param>
		/// <returns>The index of the new System.Data.MySQLClient.MySQLParameter object in the collection.</returns>
		public int Add(string strName) 
		{
			return Add(new MySQLParameter(strName)); 
		}


		/// <summary>
		/// Adds a newly created System.Data.MySQLClient.MySQLParameter object to the System.Data.MySQLClient.MySQLCommand given the parameter name and the parameter type and the parameter value.
		/// </summary>
		/// <param name="strName">The name of the parameter</param>
		/// <param name="enmType">The data type of the parameter</param>
		/// <returns>The index of the new System.Data.MySQLClient.MySQLParameter object in the collection.</returns>
		public int Add(string strName, DbType enmType) 
		{
			return Add(new MySQLParameter(strName, enmType)); 
		}

		
		/// <summary>
		/// Adds a newly created System.Data.MySQLClient.MySQLParameter object to the System.Data.MySQLClient.MySQLCommand given the parameter name, the parameter type and the parameter value.
		/// </summary>
		/// <param name="strName">The name of the parameter</param>
		/// <param name="enmType">The data type of the parameter</param>
		/// <param name="objParamValue">The value of the parameter</param>
		/// <returns>The index of the new System.Data.MySQLClient.MySQLParameter object in the collection.</returns>
		public int Add(string strName, DbType enmType, object objParamValue) 
		{
			return Add(new MySQLParameter(strName, enmType, objParamValue)); 
		}

		
		/// <summary>
		/// Removes all items from the collection.
		/// </summary>
		public void Clear()
		{
			m_objList.Clear();
		}


		/// <summary>
		/// Gets a value indicating whether an System.Data.MySQLClient.MySQLParameter object exists in the collection.
		/// </summary>
		/// <param name="objValue">The value of the System.Data.MySQLClient.MySQLParameter object to find</param>
		/// <returns>True if the collection contains the System.Data.MySQLClient.MySQLParameter; otherwise, false</returns>
		public bool Contains(object objValue) 
		{ 
			return m_objList.Contains(objValue);
		}


		/// <summary>
		/// Gets a value indicating whether an System.Data.MySQLClient.MySQLParameter object with the given name exists in the collection.
		/// </summary>
		/// <param name="objValue">The name of the System.Data.MySQLClient.MySQLParameter object to find</param>
		/// <returns>True if the collection contains the System.Data.MySQLClient.MySQLParameter; otherwise, false</returns>
		public bool Contains(string strName) 
		{ 
			return (-1 != IndexOf(strName));
		}


		/// <summary>
		/// Copies System.Data.MySQLClient.MySQLParameter objects from the System.Data.MySQLClient.MySQLParameterCollection to the specified array.  
		/// </summary>
		/// <param name="objArray">The System.Array into which to copy the System.Data.MySQLClient.MySQLParameter objects</param>
		/// <param name="intIndex">The starting index of the array</param>
		public void CopyTo(System.Array objArray, int intIndex) 
		{
			m_objList.CopyTo(objArray, intIndex);
		}


		/// <summary>
		/// Returns an enumerator that can iterate through this ParameterCollection.
		/// </summary>
		/// <returns>An System.Collections.IEnumerator that can be used to iterate through the collection</returns>
		public IEnumerator GetEnumerator() 
		{ 
			return m_objList.GetEnumerator();
		}


		/// <summary>
		/// Gets the location of the System.Data.MySQLClient.MySQLParameter object in the collection.
		/// </summary>
		/// <param name="objValue">The System.Data.MySQLClient.MySQLParameter object to locate</param>
		/// <returns>The zero-based location of the System.Data.MySQLClient.MySQLParameter in the collection.</returns>
		public int IndexOf(object objValue) 
		{
			return m_objList.IndexOf(objValue);
		}


		/// <summary>
		/// Gets the location of the System.Data.MySQLClient.MySQLParameter object in the collection given the name.
		/// </summary>
		/// <param name="strName">The System.Data.MySQLClient.MySQLParameter object to locate</param>
		/// <returns>The zero-based location of the System.Data.MySQLClient.MySQLParameter in the collection.</returns>
		public int IndexOf(string strName)
		{ 
			int intIndex = 0;
			foreach (MySQLParameter objParam in this)
			{
				if (objParam.ParameterName == strName) return intIndex; 
				intIndex++;
			}
			return -1;
		}


		/// <summary>
		/// Inserts an System.Data.MySQLClient.MySQLParameter in the collection at the specified index.
		/// </summary>
		/// <param name="intIndex">The zero-based index where the parameter is to be inserted within the collection.</param>
		/// <param name="objValue">The System.Data.MySQLClient.MySQLParameter to add to the collection.</param>
		public void Insert(int intIndex, object objValue) 
		{
			m_objList.Insert(intIndex, objValue);
		}


		/// <summary>
		/// Removes the specified System.Data.MySQLClient.MySQLParameter from the collection.
		/// </summary>
		/// <param name="objValue">The System.Data.MySQLClient.MySQLParameter object to remove from the collection.</param>
		public void Remove(object objValue) 
		{
			m_objList.Remove(objValue);
		}


		/// <summary>
		/// Removes the System.Data.MySQLClient.MySQLParameter with the specified name from the collection.
		/// </summary>
		/// <param name="strName">The name of the parameter to remove.</param>
		public void RemoveAt(string strName)
		{
			m_objList.RemoveAt(IndexOf(strName));
		}


		/// <summary>
		/// Removes the System.Data.MySQLClient.MySQLParameter at the specified index from the collection.
		/// </summary>
		/// <param name="intIndex">The zero-based index of the parameter to remove.</param>
		public void RemoveAt(int intIndex) 
		{
			m_objList.RemoveAt(intIndex);
		}


		/// <summary>
		/// Gets the number of System.Data.MySQLClient.MySQLParameter objects in the collection.
		/// </summary>
		public int Count 
		{
			get { return m_objList.Count; } 
		}


		public MySQLParameter this[string strName]
		{
			get { return (MySQLParameter) m_objList[IndexOf(strName)]; } 
			set { m_objList[IndexOf(strName)] = value; }
		}


		object IDataParameterCollection.this[string strName] 
		{ 
			get { return m_objList[IndexOf(strName)]; } 
			set { m_objList[IndexOf(strName)] = (MySQLParameter) value; }
		}

		
		public MySQLParameter this[int intIndex] 
		{
			get { return (MySQLParameter) m_objList[intIndex]; } 
			set { m_objList[intIndex] = value; }  
		}


		object IList.this[int intIndex] 
		{
			get { return m_objList[intIndex]; } 
			set { m_objList[intIndex] = (MySQLParameter) value; }  
		}


		/// <summary>
		/// Gets a value indicating whether access to the System.Collections.ICollection is synchronized (thread-safe).
		/// </summary>
		bool ICollection.IsSynchronized 
		{
			get { return m_objList.IsSynchronized; } 
		}


		/// <summary>
		/// Gets an object that can be used to synchronize access to the System.Collections.ICollection.
		/// </summary>
		object ICollection.SyncRoot 
		{
			get { return m_objList.SyncRoot; } 
		}


		/// <summary>
		/// Gets a value indicating whether the System.Collections.IList has a fixed size.
		/// </summary>
		bool IList.IsFixedSize 
		{
			get { return false; } 
		}


		/// <summary>
		/// Gets a value indicating whether the System.Collections.IList is read-only.
		/// </summary>
		bool IList.IsReadOnly 
		{
			get { return false; } 
		}


		/// <summary>
		/// Creates a new ParameterCollection object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new ParameterCollection object that is a copy of this instance</returns>
		internal object Clone()
		{
			MySQLParameterCollection objNew = new MySQLParameterCollection();
			foreach (object objParam in (IList) m_objList)
			{
				objNew.m_objList.Add(((MySQLParameter) objParam).Clone());
			}
			return objNew;
		}
	}
}
