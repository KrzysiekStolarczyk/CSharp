using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektNaZaliczenie
{
    class Settings
    {

        public void SettingsDataGridWarehouseStock(DataGridView grid )
        {
            grid.RowHeadersVisible = false;
            grid.ClearSelection();
        }
    }
}
