using ns10;
using ns2;
using ns8;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Threading;

namespace RxjhServer
{
	[Serializable]
	public class ThreadSafeDictionary<TKey, TValue> : IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, Interface1<TKey, TValue>, IDisposable
	{
		private IDictionary<TKey, TValue> dict;

		[NonSerialized]
		private ReaderWriterLockSlim readerWriterLockSlim_0;

		public int Count
		{
			get
			{
				int count;
				using (ReadOnlyLock readOnlyLock = new ReadOnlyLock(this.readerWriterLockSlim_0))
				{
					count = this.dict.Count;
				}
				return count;
			}
		}

		public bool IsReadOnly
		{
			get
			{
				bool isReadOnly;
				using (ReadOnlyLock readOnlyLock = new ReadOnlyLock(this.readerWriterLockSlim_0))
				{
					isReadOnly = this.dict.IsReadOnly;
				}
				return isReadOnly;
			}
		}

		public virtual TValue this[TKey key]
		{
			get
			{
				TValue item;
				using (ReadOnlyLock readOnlyLock = new ReadOnlyLock(this.readerWriterLockSlim_0))
				{
					item = this.dict[key];
				}
				return item;
			}
			set
			{
				using (ReadLock readLock = new ReadLock(this.readerWriterLockSlim_0))
				{
					this.dict[key] = value;
				}
			}
		}

		public ICollection<TKey> Keys
		{
			get
			{
				ICollection<TKey> tKeys;
				using (ReadOnlyLock readOnlyLock = new ReadOnlyLock(this.readerWriterLockSlim_0))
				{
					tKeys = new List<TKey>(this.dict.Keys);
				}
				return tKeys;
			}
		}

		public ICollection<TValue> Values
		{
			get
			{
				ICollection<TValue> tValues;
				using (ReadOnlyLock readOnlyLock = new ReadOnlyLock(this.readerWriterLockSlim_0))
				{
					tValues = new List<TValue>(this.dict.Values);
				}
				return tValues;
			}
		}

		public ThreadSafeDictionary()
		{
			this.dict = new Dictionary<TKey, TValue>();
			this.readerWriterLockSlim_0 = Locks.smethod_8(LockRecursionPolicy.NoRecursion);
		}

		public virtual void Add(KeyValuePair<TKey, TValue> item)
		{
			using (ReadLock readLock = new ReadLock(this.readerWriterLockSlim_0))
			{
				this.dict.Add(item);
			}
		}

		public void Add(TKey key, TValue value)
		{
			using (ReadLock readLock = new ReadLock(this.readerWriterLockSlim_0))
			{
				this.dict.Add(key, value);
			}
		}

		public void Clear()
		{
			using (ReadLock readLock = new ReadLock(this.readerWriterLockSlim_0))
			{
				this.dict.Clear();
			}
		}

		public bool Contains(KeyValuePair<TKey, TValue> item)
		{
			bool flag;
			using (ReadOnlyLock readOnlyLock = new ReadOnlyLock(this.readerWriterLockSlim_0))
			{
				flag = this.dict.Contains(item);
			}
			return flag;
		}

		public bool ContainsKey(TKey key)
		{
			bool flag;
			using (ReadOnlyLock readOnlyLock = new ReadOnlyLock(this.readerWriterLockSlim_0))
			{
				flag = this.dict.ContainsKey(key);
			}
			return flag;
		}

		public void CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex)
		{
			using (ReadOnlyLock readOnlyLock = new ReadOnlyLock(this.readerWriterLockSlim_0))
			{
				this.dict.CopyTo(array, arrayIndex);
			}
		}

		public void Dispose()
		{
			if (this.readerWriterLockSlim_0 != null)
			{
				this.readerWriterLockSlim_0.Dispose();
				this.readerWriterLockSlim_0 = null;
			}
			if (this.dict != null)
			{
				this.dict.Clear();
				this.dict = null;
			}
		}

		public void imethod_0(TKey gparam_0, TValue gparam_1)
		{
			using (ReadLock readLock = new ReadLock(this.readerWriterLockSlim_0))
			{
				if (this.dict.ContainsKey(gparam_0))
				{
					this.dict.Remove(gparam_0);
				}
				this.dict.Add(gparam_0, gparam_1);
			}
		}

		public void imethod_1(TKey gparam_0)
		{
			using (WriteLock writeLock = new WriteLock(this.readerWriterLockSlim_0))
			{
				if (this.dict.ContainsKey(gparam_0))
				{
					using (ReadLock readLock = new ReadLock(this.readerWriterLockSlim_0))
					{
						this.dict.Remove(gparam_0);
					}
				}
			}
		}

		public bool Remove(KeyValuePair<TKey, TValue> item)
		{
			bool flag;
			using (ReadLock readLock = new ReadLock(this.readerWriterLockSlim_0))
			{
				flag = this.dict.Remove(item);
			}
			return flag;
		}

		public bool Remove(TKey key)
		{
			bool flag;
			using (ReadLock readLock = new ReadLock(this.readerWriterLockSlim_0))
			{
				flag = this.dict.Remove(key);
			}
			return flag;
		}

		IEnumerator<KeyValuePair<TKey, TValue>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator()
		{
			throw new NotSupportedException("Cannot enumerate a threadsafe dictionary.  Instead, enumerate the keys or values collection");
		}

		IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			throw new NotSupportedException("Cannot enumerate a threadsafe dictionary.  Instead, enumerate the keys or values collection");
		}

		public bool TryGetValue(TKey key, out TValue value)
		{
			bool flag;
			using (ReadOnlyLock readOnlyLock = new ReadOnlyLock(this.readerWriterLockSlim_0))
			{
				flag = this.dict.TryGetValue(key, out value);
			}
			return flag;
		}
	}
}