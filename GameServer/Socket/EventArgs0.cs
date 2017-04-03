using System;
using System.Net.Sockets;

namespace ns0
{
	internal class EventArgs0 : EventArgs
	{
		private bool bool_0;

		private System.Net.Sockets.Socket socket_0;

		public bool AllowConnection
		{
			get
			{
				return this.bool_0;
			}
			set
			{
				this.bool_0 = value;
			}
		}

		public System.Net.Sockets.Socket Socket
		{
			get
			{
				return this.socket_0;
			}
		}

		public EventArgs0(System.Net.Sockets.Socket s)
		{
			this.socket_0 = s;
			this.bool_0 = true;
		}
	}
}