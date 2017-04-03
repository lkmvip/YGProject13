using System;
using System.Collections;
using System.Windows.Forms;

namespace ns11
{
	internal class ListViewColumnSorter : IComparer
	{
		private CaseInsensitiveComparer caseInsensitiveComparer_0 = new CaseInsensitiveComparer();

		private int int_0;

		private SortOrder sortOrder_0;

		public SortOrder Order
		{
			get
			{
				return this.sortOrder_0;
			}
			set
			{
				this.sortOrder_0 = value;
			}
		}

		public int SortColumn
		{
			get
			{
				return this.int_0;
			}
			set
			{
				this.int_0 = value;
			}
		}

		public ListViewColumnSorter()
		{
		}

		int System.Collections.IComparer.Compare(object x, object y)
		{
			ListViewItem listViewItem = (ListViewItem)x;
			ListViewItem listViewItem1 = (ListViewItem)y;
			int num = this.caseInsensitiveComparer_0.Compare(listViewItem.SubItems[this.int_0].Text, listViewItem1.SubItems[this.int_0].Text);
			if (this.sortOrder_0 == SortOrder.Ascending)
			{
				return num;
			}
			if (this.sortOrder_0 != SortOrder.Descending)
			{
				return 0;
			}
			return -num;
		}
	}
}