using System;
using System.Net;
using System.IO;
using System.Threading;

namespace Spider
{	
	// ��ɱ����ɵ��������߳�ִ�еĲ���������
	// �ȴ����õ�URL�����غʹ���ҳ��
	public class DocumentWorker
	{
		// Ҫɨ��Ļ���URI
		private Uri m_uri;
		// The spider that this thread "works for"
		private Spider m_spider;
		// The thread that is being used.
		private Thread m_thread;
		// �̱߳�ţ�������ʶ��ǰ�Ĺ����߳�
		private int m_number;		
		// ȱʡ�ĵ�������
		public const string IndexFile = "index.html";

		// ���캯����������ʾӵ�е�ǰ�����̵߳�֩�����
		public DocumentWorker(Spider spider)
		{
			m_spider = spider;
		}

		// ���������һ��URI���ƣ�����/images/blank.gif.
		// ����ת���ɱ����ļ����ơ������δ������Ӧ��Ŀ¼
		// �ṹ���򴴽�֮
		private string convertFilename(Uri uri)
		{
			string result = m_spider.OutputPath;
			int index1;
			int index2;			

			// add ending slash if needed
			if( result[result.Length-1]!='\\' )
				result = result+"\\";

			// strip the query if needed
			String path = uri.PathAndQuery;
			int queryIndex = path.IndexOf("?");
			if( queryIndex!=-1 )
				path = path.Substring(0,queryIndex);

			// see if an ending / is missing from a directory only			
			int lastSlash = path.LastIndexOf('/');
			int lastDot = path.LastIndexOf('.');

			if( path[path.Length-1]!='/' )
			{
				if(lastSlash>lastDot)
					path+="/"+IndexFile;
			}

			// determine actual filename		
			lastSlash = path.LastIndexOf('/');

			string filename = "";
			if(lastSlash!=-1)
			{
				filename=path.Substring(1+lastSlash);
				path = path.Substring(0,1+lastSlash);
				if(filename.Equals("") )
					filename=IndexFile;
			}

			// ��Ҫʱ����Ŀ¼�ṹ			
			index1 = 1;
			do
			{
				index2 = path.IndexOf('/',index1);
				if(index2!=-1)
				{
					String dirpart = path.Substring(index1,index2-index1);
					result+=dirpart;
					result+="\\";
					Directory.CreateDirectory(result);
					index1 = index2+1;					
				}
			} while(index2!=-1);
			// attach name
			result+=filename;
			return result;
		}

		// ���������ļ����浽����
		private void SaveBinaryFile(WebResponse response)
		{
			byte []buffer = new byte[1024];

			if( m_spider.OutputPath==null )
				return;
			string filename = convertFilename( response.ResponseUri );
			Stream outStream = File.Create( filename );
			Stream inStream = response.GetResponseStream();	
			
			int l;
			do
			{
				l = inStream.Read(buffer,0,buffer.Length);
				if(l>0)
					outStream.Write(buffer,0,l);
			}
			while(l>0);
			
			outStream.Close();
			inStream.Close();
		}

		// �����ı��ļ�
		private void SaveTextFile(string buffer)
		{
			if( m_spider.OutputPath==null )
				return;
			string filename = convertFilename( m_uri );
			StreamWriter outStream = new StreamWriter( filename );
			outStream.Write(buffer);
			outStream.Close();
		}

		// ����һ��ҳ��
		private string GetPage()
		{
			WebResponse response = null;
			Stream stream = null;
			StreamReader reader = null;
			try
			{
				HttpWebRequest request = (HttpWebRequest)WebRequest.Create(m_uri);
							
				response = request.GetResponse();
				stream = response.GetResponseStream();
				if( !response.ContentType.ToLower().StartsWith("text/") )
				{
					SaveBinaryFile(response);
					return null;
				}
				string buffer = "",line;
				reader = new StreamReader(stream);			
				while( (line = reader.ReadLine())!=null )
				{
					buffer+=line+"\r\n";
				}			
				SaveTextFile(buffer);
				return buffer;
			}
			catch(WebException e)
			{
				System.Console.WriteLine("����ʧ�ܣ�����" + e);
				return null;
			}
			catch(IOException e)
			{
				System.Console.WriteLine("����ʧ�ܣ�����" + e);
				return null;
			}
			finally
			{
				if( reader!=null ) reader.Close();
				if( stream!=null ) stream.Close();
				if( response!=null ) response.Close();
			}
		}

		private void ProcessLink(string link)
		{
			Uri url;
			// fully expand this URL if it was a relative link
			try
			{
				url = new Uri(m_uri,link,false);
			}
			catch(UriFormatException e)
			{
				System.Console.WriteLine( "Invalid URI:" + link +" Error:" + e.Message);
				return;
			}
			if(!url.Scheme.ToLower().Equals("http") &&
				!url.Scheme.ToLower().Equals("https") )
				return;
			// comment out this line if you would like to spider
			// the whole Internet (yeah right, but it will try)
			if( !url.Host.ToLower().Equals( m_uri.Host.ToLower() ) )
				return;
			m_spider.addURI( url );
		}

		private void ProcessPage(string page)
		{
			ParseHTML parse = new ParseHTML();
			parse.Source = page;
			while(!parse.Eof())
			{
				char ch = parse.Parse();
				if(ch==0)
				{
					Attribute a = parse.GetTag()["HREF"];
					if( a!=null )
						ProcessLink(a.Value);					
					a = parse.GetTag()["SRC"];
					if( a!=null )
						ProcessLink(a.Value);
				}
			}
		}
		// This method is the main loop for the spider threads.
		// This method will wait for URL's to become available, 
		// and then process them. 
		public void Process()
		{
			while(!m_spider.Quit )
			{
				m_uri = m_spider.ObtainWork();
				
				m_spider.SpiderDone.WorkerBegin();
				System.Console.WriteLine("Download("+this.Number+"):"+m_uri);			
				string page = GetPage();
				if(page!=null)
					ProcessPage(page);
				m_spider.SpiderDone.WorkerEnd();
			}
		}
		// Start the thread.
		public void start()
		{
			ThreadStart ts = new ThreadStart( this.Process );
			m_thread = new Thread(ts);
			m_thread.Start();
		}
		// The thread number. Used only to identify this thread.
		public int Number 
		{
			get
			{
				return m_number;
			}

			set
			{
				m_number = value;
			}		
		}
	}
}

