namespace LoginServer
{
    using System;
    using System.Windows.Forms;

    public class ListViewHelper
    {
        static ListViewHelper()
        {
            ZYXDNGuarder.Startup();
        }

        public static void ListView_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            ListView view = sender as ListView;
            if (e.Column == (view.ListViewItemSorter as ListViewColumnSorter).SortColumn)
            {
                if ((view.ListViewItemSorter as ListViewColumnSorter).Order == SortOrder.Ascending)
                {
                    (view.ListViewItemSorter as ListViewColumnSorter).Order = SortOrder.Descending;
                }
                else
                {
                    (view.ListViewItemSorter as ListViewColumnSorter).Order = SortOrder.Ascending;
                }
            }
            else
            {
                (view.ListViewItemSorter as ListViewColumnSorter).SortColumn = e.Column;
                (view.ListViewItemSorter as ListViewColumnSorter).Order = SortOrder.Ascending;
            }
            ((ListView) sender).Sort();
        }
    }
}

