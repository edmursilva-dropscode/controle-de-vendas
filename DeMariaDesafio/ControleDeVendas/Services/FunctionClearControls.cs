using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeVendas.Services
{
    internal class FunctionClearControls
    {
        public void LimparControles(Control.ControlCollection controles, Single pTipo)
        {
            foreach (Control ctrl in controles)
            {
                if (pTipo == 0)
                {
                    if (ctrl is RadioButton button)
                    {
                        button.Checked = false;
                    }
                    if (ctrl is CheckBox box)
                    {
                        box.Checked = false;
                    }
                    if (ctrl is TextBox box1)
                    {
                        box1.Clear();
                    }
                    if (ctrl is ListView view)
                    {
                        view.Items.Clear();
                    }
                    if (ctrl is ComboBox box2)
                    {
                        box2.Items.Clear();
                    }
                }
                else if (pTipo == 1)
                {
                    if (ctrl is TextBox box)
                    {
                        box.Clear();
                    }
                }
                LimparControles(ctrl.Controls, pTipo);
            }
        }


    }
}
