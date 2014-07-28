using System;
using System.Threading;

namespace Spider
{
	public class Done 
	{
		//The number of SpiderWorker object
		//threads that are currently working on something.
		private int m_activeThreads = 0;

		//This boolean keeps track of if the very first thread has started
		//or not. This prevents this object from falsely reporting that the spider
		//is done, just because the first thread has not yet started.
		private bool m_started = false;

		//This method can be called to block the current thread until the spider is done.
		public void WaitDone()
		{
			Monitor.Enter(this);
			while ( m_activeThreads>0 ) 
			{
				Monitor.Wait(this);
			}
			Monitor.Exit(this);
		}

		//Called to wait for the first thread to
		//start. Once this method returns the spidering process has begun.
		public void WaitBegin()
		{
			Monitor.Enter(this);
			while ( !m_started ) 
			{
				Monitor.Wait(this);
			}
			Monitor.Exit(this);
		}

		// Called by a SpiderWorker object
		// to indicate that it has begun
		// working on a workload.
		public void WorkerBegin()
		{
			Monitor.Enter(this);
			m_activeThreads++;
			m_started = true;
			Monitor.Pulse(this);
			Monitor.Exit(this);
		}

		// Called by a SpiderWorker object to
		/// indicate that it has completed a
		/// workload.
		public void WorkerEnd()
		{
			Monitor.Enter(this);
			m_activeThreads--;
			Monitor.Pulse(this);
			Monitor.Exit(this);
		}

		// Called to reset this object to
		// its initial state.
		public void Reset()
		{
			Monitor.Enter(this);
			m_activeThreads = 0;
			Monitor.Exit(this);
		}
	}
}
