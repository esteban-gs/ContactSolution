using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Controls;
using System.Windows.Data;

namespace ContactApp.ViewHelpers
{
    /// <summary>
    /// Static class: Implements View actions shared accross multiple views in the application.
    /// </summary>
    public static class IndexViewBase
    {
        public static bool SortAscending { get; private set; } = true;

        public static ListSortDirection ToggleSortDirection
        {
            get
            {
                SortAscending = !SortAscending;
                ListSortDirection sortDirection;

                if (SortAscending)
                {
                    sortDirection = ListSortDirection.Ascending;
                }
                else
                {
                    sortDirection = ListSortDirection.Descending;
                }
                return sortDirection;
            }
        }


        public static void ToggleSortListView(ListView listView, object sender)
        {
            CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(listView.ItemsSource);
            listView.Items.SortDescriptions.Clear();

            GridViewColumnHeader column = (sender as GridViewColumnHeader);
            string sortBy = column.Tag.ToString();

            view.SortDescriptions.Add(new SortDescription(sortBy, ToggleSortDirection));
        }
    }
}
