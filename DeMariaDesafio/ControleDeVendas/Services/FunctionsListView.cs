namespace ControleDeVendas.Services
{
    internal class FunctionsListView
    {
        #region Metodos Publicos
        //Método para aplicar efeito zebrado
        public void AplicarCorLista(ListViewItem pListaItem, int pCount)
        {
            if (pCount % Convert.ToInt16(2) == 0)
            {
                pListaItem.BackColor = Color.FromArgb(255, 255, 255);
            }
            else
            {
                pListaItem.BackColor = Color.FromArgb(255, 255, 217);
            }
        }

        public void ColorListView(ListView pLista, bool pTipoChecked)
        {
            int vil_Count = 0;

            pLista.Items.Clear();
            if (pTipoChecked == false)
            {
                pLista.CheckBoxes = false;
            }
            else
            {
                pLista.CheckBoxes = true;
            }
            ListViewItem vol_ListViewItem = new ListViewItem("");
            pLista.Items.Add(vol_ListViewItem);
            vil_Count++;
            AplicarCorLista(vol_ListViewItem, vil_Count);
            pLista.FullRowSelect = true;
            pLista.GridLines = true;
            pLista.Refresh();
            //
        }

        public void RedefineColorListView(ListView pLista)
        {
            int vil_Count = 0;
            foreach (ListViewItem vol_ListViewItem in pLista.Items)
            {
                vil_Count++;
                AplicarCorLista(vol_ListViewItem, vil_Count);
            }
        }
        #endregion
    }
}

