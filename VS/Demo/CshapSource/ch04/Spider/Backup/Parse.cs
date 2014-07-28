using System;

namespace Spider
{
	public class Parse:AttributeList 
	{		
		private string m_source;//被解析的字符串
		private int m_idx;//被解析的字符串在HTML页面中的索引位置
		private char m_parseDelim;//最开始的被分析的属性delimiter
		private string m_parseName;//最开始的被分析的属性名
		private string m_parseValue;//最开始的被分析的属性值
		public string m_tag;//最开始的被分析的tag

		public static bool IsWhiteSpace(char ch)//确定是否为空格
		{
			return( "\t\n\r ".IndexOf(ch) != -1 );
		}
		public void EatWhiteSpace()
		{
			while ( !Eof() ) 
			{
				if ( !IsWhiteSpace(GetCurrentChar()) )
					return;
				m_idx++;
			}
		}
		public bool Eof()//确定是否到了被分析的字符串尾
		{
			return(m_idx>=m_source.Length );
		}
		public void ParseAttributeName()//分析属性名
		{
			EatWhiteSpace();
			// get attribute name
			while ( !Eof() ) 
			{
				if ( IsWhiteSpace(GetCurrentChar()) ||
					(GetCurrentChar()=='=') ||
					(GetCurrentChar()=='>') )
					break;
				m_parseName+=GetCurrentChar();
				m_idx++;
			}

			EatWhiteSpace();
		}
		public void ParseAttributeValue()//分析属性值
		{
			if ( m_parseDelim!=0 )
				return;

			if ( GetCurrentChar()=='=' ) 
			{
				m_idx++;
				EatWhiteSpace();
				if ( (GetCurrentChar()=='\'') ||
					(GetCurrentChar()=='\"') ) 
				{
					m_parseDelim = GetCurrentChar();
					m_idx++;
					while ( GetCurrentChar()!=m_parseDelim ) 
					{
						m_parseValue+=GetCurrentChar();
						m_idx++;
					}
					m_idx++;
				} 
				else 
				{
					while ( !Eof() &&
						!IsWhiteSpace(GetCurrentChar()) &&
						(GetCurrentChar()!='>') ) 
					{
						m_parseValue+=GetCurrentChar();
						m_idx++;
					}
				}
				EatWhiteSpace();
			}
		}

		public void AddAttribute()
		{
			Attribute a = new Attribute(m_parseName,
				m_parseValue,m_parseDelim);
			Add(a);
		}
		public char GetCurrentChar()
		{
			return GetCurrentChar(0);
		}
		public char GetCurrentChar(int peek)
		{
			if( (m_idx+peek)<m_source.Length )
				return m_source[m_idx+peek];
			else
				return (char)0;
		}
		public char AdvanceCurrentChar()
		{
			return m_source[m_idx++];
		}
		public void Advance()
		{
			m_idx++;
		}
		public string ParseName
		{
			get 
			{
				return m_parseName;
			}
			set 
			{
				m_parseName = value;
			}
		}
		public string ParseValue
		{
			get 
			{
				return m_parseValue;
			}

			set 
			{
				m_parseValue = value;
			}
		}
		public char ParseDelim
		{
			get 
			{
				return m_parseDelim;
			}
			set 
			{
				m_parseDelim = value;
			}
		}
		public string Source
		{
			get 
			{
				return m_source;
			}
			set 
			{
				m_source = value;
			}
		}
	}
}