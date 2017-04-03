using ns2;
using ns4;
using System;
using System.Threading;

namespace ns8
{
	public class WriteLock : BaseLock
	{
		public WriteLock(ReaderWriterLockSlim locks) : base(locks)
		{
			Locks.smethod_0(this.readerWriterLockSlim_0);
		}

		public override void Dispose()
		{
			Locks.smethod_4(this.readerWriterLockSlim_0);
		}
	}
}