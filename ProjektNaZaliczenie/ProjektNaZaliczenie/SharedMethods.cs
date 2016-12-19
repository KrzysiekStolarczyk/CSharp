using System;
using System.Collections.Generic;
using System.Drawing;
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

        public void ValidInputCharWithComma(object sender, KeyPressEventArgs e)
        {
            int number;
            //var button = (TextBox)sender;
            //string tekst = button.Name;

            if (!Int32.TryParse(e.KeyChar.ToString(), out number) && e.KeyChar != 8 && e.KeyChar != 44)
            {
                e.Handled = true;
                MessageBox.Show("W tym polu można wprowadzać tylko wartości liczbowe.");
            }
        }

        public int CheckSelectedRowOnGrid(DataGridView grid)
        {
            if (grid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Zaznacz wiersz, który chcesz zaktualizować");
                return -1;
            }
            else
            {
                return 1;
            }
        }

        public int CheckEnteredTextBox(TextBox textBoxInput)
        {
            if (textBoxInput.TextLength == 0  || textBoxInput.Text.Substring(0, 1).Equals("!"))
            {
                MessageBox.Show("Uzupełnij pola.");
                return -1;
            }         
            else
            {
                return 1;
            }
        }

        public void SettingsDataGrid(DataGridView grid)
        {
            grid.RowHeadersVisible = false;
            grid.ClearSelection();
            grid.ReadOnly = true;
        }

        public void SetDefaultValueToTextBox(TextBox textbox,string info)
        {
            if (textbox.Text.Length == 0)
            {
                textbox.Text = info;
                textbox.ForeColor = SystemColors.GrayText;
            }
        }
    }
}
