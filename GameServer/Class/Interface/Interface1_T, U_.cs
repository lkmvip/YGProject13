using System;
using System.Collections;
using System.Collections.Generic;

namespace ns2
{
	internal interface Interface1<T, U> : IDictionary<T, U>, ICollection<KeyValuePair<T, U>>, IEnumerable<KeyValuePair<T, U>>, IEnumerable, IDisposable
	{
		void imethod_0(T gparam_0, U gparam_1);

		void imethod_1(T gparam_0);
	}
}