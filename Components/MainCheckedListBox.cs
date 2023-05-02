using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Large_File_Scanner.Components
{
    public class MainCheckedListBox
    {
        private MainCheckedListBox()
        {
        }
        private static MainCheckedListBox instance = new MainCheckedListBox();
        public static MainCheckedListBox Instance => instance ??= new MainCheckedListBox();

        private CheckedListBox checkedListBox;

        /// <summary>
        /// Definir qual é o componente que sera utilizado pelo projeto
        /// </summary>
        /// <param name="checkedListBox"></param>
        public void SetCheckedListBox(CheckedListBox checkedListBox)
        {
            if(this.checkedListBox == null)
            {
                this.checkedListBox = checkedListBox;
            }
                
        }

        /// <summary>
        /// Marcar ou desmarcar todos os items do checked list box
        /// </summary>
        /// <param name="value">verdadeiro marca, falso desmarca</param>
        public void CheckOrUncheck(bool value)
        {
            if (checkedListBox.Items.Count > 0)
            {
                for (int i = 0; i < checkedListBox.Items.Count; i++)
                {
                    checkedListBox.SetItemChecked(i, value);
                }

                return;
            }

            MessageBox.Show("Nenhum item listado!", "Falha!", MessageBoxButtons.OK);
        }
    }
}
