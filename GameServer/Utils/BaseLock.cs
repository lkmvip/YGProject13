using System;
using System.Threading;

namespace ns4
{
	public abstract class BaseLock : IDisposable
	{
		protected ReaderWriterLockSlim readerWriterLockSlim_0;

		public BaseLock(ReaderWriterLockSlim locks)
		{
			this.readerWriterLockSlim_0 = locks;
		}

		public abstract void Dispose();
	}
}