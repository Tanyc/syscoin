using System;
using System.Collections;
using System.Net;
using System.IO;
using System.Threading;

namespace Spider
{	
	public class Spider
	{
		//The URL's that have already been processed.
		private Hashtable m_already;

		//URL's that are waiting to be processed.
		private Queue m_workload;

		//The first URL to spider. All other URL's must have the
		//same hostname as this URL. 
		private Uri m_base;

		// The directory to save the spider output to.
		private string m_outputPath;

		// The form that the spider will report its progress to.
		private SpiderForm m_spiderForm;

		// How many URL's has the spider processed.
		private int m_urlCount = 0;

		// When did the spider start working
		private long m_startTime = 0;

		// Used to keep track of when the spider might be done.
		private Done m_done = new Done();		

		// Used to tell the spider to quit.
		private bool m_quit;

		// The status for each URL that was processed.
		enum Status { STATUS_FAILED, STATUS_SUCCESS, STATUS_QUEUED };
        
		// The constructor
		public Spider()
		{
			reset();
		}

		// Call to reset from a previous run of the spider
		public void reset()
		{
			m_already = new Hashtable();
			m_workload = new Queue();
			m_quit = false;
		}

		// Add the specified URL to the list of URI's to spider.
		// This is usually only used by the spider, itself, as new URL's are found.
		public void addURI(Uri uri)
		{
			Monitor.Enter(this);
			if( !m_already.Contains(uri) )
			{
				m_already.Add(uri,Status.STATUS_QUEUED);
				m_workload.Enqueue(uri);
			}
			Monitor.Pulse(this);
			Monitor.Exit(this);
		}

		// The URI that is to be spidered
		public Uri BaseURI 
		{
			get
			{
				return m_base;
			}
			set
			{
				m_base = value;
			}
		}

		// The local directory to save the spidered files to
		public string OutputPath
		{
			get
			{
				return m_outputPath;
			}
			set
			{
				m_outputPath = value;
			}
		}

		// The object that the spider reports its results to.
		public SpiderForm ReportTo
		{
			get
			{
				return m_spiderForm;
			}
			set
			{
				m_spiderForm = value;
			}
		}

		// Set to true to request the spider to quit.
		public bool Quit
		{
			get
			{
				return m_quit;
			}
			set
			{
				m_quit = value;
			}
		}

		// Used to determine if the spider is done, 
		// this object is usually only used internally by the spider.
		public Done SpiderDone
		{
			get
			{
				return m_done;
			}
		}

		//Called by the worker threads to obtain a URL to process.
		public Uri ObtainWork()
		{
			Monitor.Enter(this);
			while(m_workload.Count<1)
			{
				Monitor.Wait(this);
			}
			Uri next = (Uri)m_workload.Dequeue();
			if(m_spiderForm!=null)
			{
				m_spiderForm.SetLastURL(next.ToString());
				m_spiderForm.SetProcessedCount(""+(m_urlCount++));
				long etime = (System.DateTime.Now.Ticks-m_startTime)/10000000L;
				long urls = (etime==0)?0:m_urlCount/etime;
				m_spiderForm.SetElapsedTime( etime/60 + " minutes (" + urls +" urls/sec)" );
			}
			Monitor.Exit(this);
			return next;
		}

		// Start the spider.		
		public void Start(Uri baseURI,int threads)
		{
			// init the spider
			m_quit = false;
			m_base = baseURI;
			addURI(m_base);
			m_startTime = System.DateTime.Now.Ticks;;
			m_done.Reset();		
			// startup the threads
			for(int i=1;i<threads;i++)
			{				
				DocumentWorker worker = new DocumentWorker(this);
				worker.Number = i;
				worker.start();
			}
			// now wait to be done
			m_done.WaitBegin();
			m_done.WaitDone();			
		}
	}
}
