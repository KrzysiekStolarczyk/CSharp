using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DotNetZaliczenie
{
    class SharedMethods
    {       
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

        public void SettingsDataGrid(DataGridView grid)
        {
            grid.RowHeadersVisible = false;
            grid.ClearSelection();
            grid.ReadOnly = true;
        }
       
        public void MaskedTextBoxSetCursor(object sender, EventArgs e)
        {
            MaskedTextBox masked = (MaskedTextBox)sender;
            masked.Select(0, 0);
        }
    }
}
