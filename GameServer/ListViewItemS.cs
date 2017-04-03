using System;
using System.Windows.Forms;

namespace ns11
{
	internal class ListViewItemS
	{
		public ListViewItemS()
		{
		}

		public static void smethod_0(object sender, ColumnClickEventArgs e)
		{
			ListView column = sender as ListView;
			if (e.Column != (column.ListViewItemSorter as ListViewColumnSorter).SortColumn)
			{
				(column.ListViewItemSorter as ListViewColumnSorter).SortColumn = e.Column;
				(column.ListViewItemSorter as ListViewColumnSorter).Order = SortOrder.Ascending;
			}
			else if ((column.ListViewItemSorter as ListViewColumnSorter).Order != SortOrder.Ascending)
			{
				(column.ListViewItemSorter as ListViewColumnSorter).Order = SortOrder.Ascending;
			}
			else
			{
				(column.ListViewItemSorter as ListViewColumnSorter).Order = SortOrder.Descending;
			}
			((ListView)sender).Sort();
		}
	}
}