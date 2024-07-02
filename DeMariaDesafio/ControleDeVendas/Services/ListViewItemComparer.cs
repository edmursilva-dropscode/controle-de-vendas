using System.Collections;

namespace ControleDeVendas.Services
{
    internal class ListViewItemComparer : IComparer
    {
        private readonly int col;
        private readonly SortOrder order;

        public ListViewItemComparer()
        {
            col = 0;
            order = SortOrder.Ascending;
        }

        public ListViewItemComparer(int column, SortOrder order)
        {
            col = column;
            this.order = order;
        }

        public int Compare(object? x, object? y) // Permitir parâmetros nulos
        {
            if (x == null && y == null)
            {
                return 0;
            }
            if (x == null)
            {
                return order == SortOrder.Ascending ? -1 : 1;
            }
            if (y == null)
            {
                return order == SortOrder.Ascending ? 1 : -1;
            }

            // Casting usando as e verificação de nulo
            ListViewItem? itemX = x as ListViewItem;
            ListViewItem? itemY = y as ListViewItem;

            if (itemX == null || itemY == null)
            {
                throw new ArgumentException("Both parameters should be of type ListViewItem.");
            }

            int returnVal = string.Compare(itemX.SubItems[col].Text, itemY.SubItems[col].Text);

            if (order == SortOrder.Descending)
            {
                returnVal *= -1;
            }

            return returnVal;
        }
    }
}

