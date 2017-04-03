using System;

namespace ns5
{
	internal sealed class Exception1 : Exception
	{
		public Exception1() : base("Too much data pending.")
		{
		}
	}
}