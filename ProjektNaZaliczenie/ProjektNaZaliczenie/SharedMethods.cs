using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektNaZaliczenie
{
    class SharedMethods
    {

        public void ValidInputChar(object sender, KeyPressEventArgs e)
        {
            int number;
            //var button = (TextBox)sender;
            //string tekst = button.Name;

            if (!Int32.TryParse(e.KeyChar.ToString(), out number) && e.KeyChar!=8)
            {
                e.Handled = true;
                MessageBox.Show("W tym polu można wprowadzać tylko wartości liczbowe.");
            }
        }

        public int CheckBeAbleUpdate(TextBox textBoxInput,DataGridView grid)
        {
            if (textBoxInput.TextLength == 0)
            {
                MessageBox.Show("Wprowadz wartość liczbową w pole tekstowe.");
                return -1;
            }
            else if (grid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Zaznacz wiersz, który chcesz zaktualizować");
                return -1;
            }
            else
            {
                return 1;
            }

        }




    }
}
