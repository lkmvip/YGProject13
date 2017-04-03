using ns1;
using ns10;
using ns2;
using ns8;
using System;
using System.Runtime.CompilerServices;
using System.Threading;

namespace ns7
{
	internal class Class9<T> : Interface0<T>
	{
		[NonSerialized]
		private ReaderWriterLockSlim readerWriterLockSlim_0;

		private string string_0;

		public T Context
		{
			get;
			set;
		}

		public string Credentials
		{
			get
			{
				return this.string_0;
			}
		}

		public int Index
		{
			get;
			set;
		}

		public bool Invalid
		{
			get;
			set;
		}

		public IDisposable ReadLock
		{
			get
			{
				return new ReadOnlyLock(this.readerWriterLockSlim_0);
			}
		}

		public DateTime Timestamp
		{
			get;
			set;
		}

		public IDisposable UpdateLock
		{
			get
			{
				return new ns8.WriteLock(this.readerWriterLockSlim_0);
			}
		}

		public IDisposable WriteLock
		{
			get
			{
				return new ns10.ReadLock(this.readerWriterLockSlim_0);
			}
		}

		public Class9()
		{
			this.readerWriterLockSlim_0 = Locks.smethod_8(LockRecursionPolicy.NoRecursion);
			this.string_0 = string.Empty;
			this.Index = -1;
			this.Timestamp = DateTime.MinValue;
			this.Invalid = true;
		}

		public virtual void imethod_0()
		{
			this.string_0 = Guid.NewGuid().ToString();
			this.Context = default(T);
		}

		public bool imethod_1(string string_1)
		{
			if (string.IsNullOrEmpty(this.string_0))
			{
				return false;
			}
			if (string.IsNullOrEmpty(string_1))
			{
				return false;
			}
			if (this.string_0 != string_1)
			{
				return false;
			}
			return true;
		}

		public override string ToString()
		{
			return string.Format("{0}-{1}", this.Index, this.Timestamp);
		}
	}
}