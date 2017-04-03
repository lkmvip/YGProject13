using ns2;
using ns4;
using System;
using System.Threading;

namespace ns10
{
	public class ReadLock : BaseLock
	{
		public ReadLock(ReaderWriterLockSlim locks) : base(locks)
		{
			Locks.smethod_2(this.readerWriterLockSlim_0);
		}

		public override void Dispose()
		{
			Locks.smethod_5(this.readerWriterLockSlim_0);
		}
	}
}