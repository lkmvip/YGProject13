using ns4;
using System;
using System.Threading;

namespace ns2
{
	internal class ReadOnlyLock : BaseLock
	{
		public ReadOnlyLock(ReaderWriterLockSlim locks) : base(locks)
		{
			Locks.smethod_1(this.readerWriterLockSlim_0);
		}

		public override void Dispose()
		{
			Locks.smethod_3(this.readerWriterLockSlim_0);
		}
	}
}