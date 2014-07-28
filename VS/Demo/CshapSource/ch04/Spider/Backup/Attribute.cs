using System;

namespace Spider
{
	public class Attribute: ICloneable
	{
        private string m_name;//属性名

		private string m_value;//属性值		

		private char m_delim;
	
		public Attribute(string name,string value,char delim)
		{
			m_name = name;
			m_value = value;
			m_delim = delim;
		}

		public Attribute():this("","",(char)0)
		{
		}

		public Attribute(String name,String value):this(name,value,(char)0)
		{
		}

		public char Delim
		{
			get 
			{
				return m_delim;
			}

			set 
			{
				m_delim = value;
			}
		}

		public string Name
		{
			get 
			{
				return m_name;
			}

			set 
			{
				m_name = value;
			}
		}

		public string Value
		{
			get 
			{
				return m_value;
			}

			set 
			{
				m_value = value;
			}
		}

		#region ICloneable Members
		public virtual object Clone()
		{
			return new Attribute(m_name,m_value,m_delim);		
		}
		#endregion
	}

}
