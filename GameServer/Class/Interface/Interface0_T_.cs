using System;

namespace ns1
{
	internal interface Interface0<T>
	{
		T Context
		{
			get;
			set;
		}

		string Credentials
		{
			get;
		}

		int Index
		{
			get;
			set;
		}

		bool Invalid
		{
			get;
			set;
		}

		IDisposable ReadLock
		{
			get;
		}

		DateTime Timestamp
		{
			get;
			set;
		}

		IDisposable UpdateLock
		{
			get;
		}

		IDisposable WriteLock
		{
			get;
		}

		void imethod_0();

		bool imethod_1(string string_0);
	}
}