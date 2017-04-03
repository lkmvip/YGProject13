using System;
using System.Threading;

namespace ns2
{
	internal static class Locks
	{
		public static void smethod_0(ReaderWriterLockSlim readerWriterLockSlim_0)
		{
			bool flag = false;
			while (!flag)
			{
				flag = readerWriterLockSlim_0.TryEnterUpgradeableReadLock(1);
			}
		}

		public static void smethod_1(ReaderWriterLockSlim readerWriterLockSlim_0)
		{
			bool flag = false;
			while (!flag)
			{
				flag = readerWriterLockSlim_0.TryEnterReadLock(1);
			}
		}

		public static void smethod_2(ReaderWriterLockSlim readerWriterLockSlim_0)
		{
			bool flag = false;
			while (!flag)
			{
				flag = readerWriterLockSlim_0.TryEnterWriteLock(1);
			}
		}

		public static void smethod_3(ReaderWriterLockSlim readerWriterLockSlim_0)
		{
			if (readerWriterLockSlim_0.IsReadLockHeld)
			{
				readerWriterLockSlim_0.ExitReadLock();
			}
		}

		public static void smethod_4(ReaderWriterLockSlim readerWriterLockSlim_0)
		{
			if (readerWriterLockSlim_0.IsUpgradeableReadLockHeld)
			{
				readerWriterLockSlim_0.ExitUpgradeableReadLock();
			}
		}

		public static void smethod_5(ReaderWriterLockSlim readerWriterLockSlim_0)
		{
			if (readerWriterLockSlim_0.IsWriteLockHeld)
			{
				readerWriterLockSlim_0.ExitWriteLock();
			}
		}

		public static void smethod_6(ReaderWriterLockSlim readerWriterLockSlim_0)
		{
			Locks.smethod_5(readerWriterLockSlim_0);
			Locks.smethod_4(readerWriterLockSlim_0);
			Locks.smethod_3(readerWriterLockSlim_0);
		}

		public static ReaderWriterLockSlim smethod_7()
		{
			return Locks.smethod_8(LockRecursionPolicy.SupportsRecursion);
		}

		public static ReaderWriterLockSlim smethod_8(LockRecursionPolicy lockRecursionPolicy_0)
		{
			return new ReaderWriterLockSlim(lockRecursionPolicy_0);
		}
	}
}