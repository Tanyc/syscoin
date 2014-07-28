using System;
using System.Collections;

namespace Spider
{	
	public class AttributeList:Attribute
	{
		protected ArrayList m_list;

		public override Object Clone()
		{
			AttributeList rtn = new AttributeList();			

			for ( int i=0;i<m_list.Count;i++ )
				rtn.Add( (Attribute)this[i].Clone() );

			return rtn;
		}

		public AttributeList():base("","")
		{
			m_list = new ArrayList();
		}

		public void Add(Attribute a)
		{
			m_list.Add(a);
		}

		public void Clear()
		{
			m_list.Clear();
		}

		public bool IsEmpty()
		{
			return( m_list.Count<=0);
		}

		public void Set(string name,string value)
		{
			if ( name==null )
				return;
			if ( value==null )
				value="";

			Attribute a = this[name];

			if ( a==null ) 
			{
				a = new Attribute(name,value);
				Add(a);
			} 
			else
				a.Value = value;
		}

		public int Count
		{
			get 
			{
				return m_list.Count;
			}
		}

		public ArrayList List
		{
			get 
			{
				return m_list;
			}
		}

		public Attribute this[int index]
		{
			get 
			{
				if ( index<m_list.Count )
					return(Attribute)m_list[index];
				else
					return null;
			}
		}

		public Attribute this[string index]
		{
			get 
			{
				int i=0;

				while ( this[i]!=null ) 
				{
					if ( this[i].Name.ToLower().Equals( (index.ToLower()) ))
						return this[i];
					i++;
				}
				return null;
			}
		}
	}
}
