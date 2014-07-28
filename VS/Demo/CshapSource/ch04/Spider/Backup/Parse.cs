using System;

namespace Spider
{
	public class Parse:AttributeList 
	{		
		private string m_source;//���������ַ���
		private int m_idx;//���������ַ�����HTMLҳ���е�����λ��
		private char m_parseDelim;//�ʼ�ı�����������delimiter
		private string m_parseName;//�ʼ�ı�������������
		private string m_parseValue;//�ʼ�ı�����������ֵ
		public string m_tag;//�ʼ�ı�������tag

		public static bool IsWhiteSpace(char ch)//ȷ���Ƿ�Ϊ�ո�
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
		public bool Eof()//ȷ���Ƿ��˱��������ַ���β
		{
			return(m_idx>=m_source.Length );
		}
		public void ParseAttributeName()//����������
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
		public void ParseAttributeValue()//��������ֵ
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