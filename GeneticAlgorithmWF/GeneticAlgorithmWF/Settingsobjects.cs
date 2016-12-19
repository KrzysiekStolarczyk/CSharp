using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeneticAlgorithmWF
{
    
    public class Settings0bjects
    {
        public void UstawMainGrida(DataGridView grid)
        {
            grid.Columns[5].Visible = false;
            grid.Columns[6].Visible = false;
            grid.Columns[0].HeaderText = "Osobnik";
            grid.Columns[0].ToolTipText = "Nazwa Osobnika";
            grid.Columns[3].HeaderText = "Fenotyp";
            grid.Columns[3].ToolTipText = "Randomowa Liczba";
            grid.Columns[3].DisplayIndex = 1;
            grid.Columns[1].HeaderText = "Chromosom";
            grid.Columns[1].ToolTipText = "Wartość binarna losowej liczby";
            grid.Columns[2].HeaderText = "Przystosowanie";
            grid.Columns[2].ToolTipText = "Wynik funkcji";
            grid.Columns[4].HeaderText = "Selekcja";
            grid.Columns[4].ToolTipText = "Przystosowanie procentowe";
            grid.Columns[7].HeaderText = "Selekcja 2";
            grid.Columns[7].ToolTipText = "Selekcja rosnąca";
        }

        public void UstawGridPoMutacji(DataGridView grid)
        {
            grid.Columns[0].Visible = false;
            grid.Columns[1].HeaderText = "Osobnik";
            grid.Columns[1].ToolTipText = "Nazwa Osobnika";
            grid.Columns[1].Width = 70;
            grid.Columns[2].HeaderText = "Chromosom";
            grid.Columns[2].ToolTipText = "Wartość binarna losowej liczby";
            grid.Columns[2].Width = 70;
            grid.Columns[3].HeaderText = "Para";
            grid.Columns[3].ToolTipText = "Numer pary";
            grid.Columns[3].DisplayIndex = 0;
            grid.Columns[3].Width = 40;
            grid.Columns[4].HeaderText = "Cross";
            grid.Columns[4].ToolTipText = "Czy było krzyżowanie";
            grid.Columns[4].Width = 45;
            grid.Columns[5].HeaderText = "Locus";
            grid.Columns[5].ToolTipText = "Na którym miejscu krzyżowanie";
            grid.Columns[5].Width = 40;
            grid.Columns[6].HeaderText = "Mutacja";
            grid.Columns[6].ToolTipText = "Czy była mutacja";
            grid.Columns[6].Width = 50;
            grid.Columns[7].HeaderText = "Mut Gen";
            grid.Columns[7].ToolTipText = "Numer genu który podlegał mutacji";
            grid.Columns[7].Width = 40;
            grid.Columns[8].HeaderText = "Nowy Fenotyp";
            grid.Columns[8].ToolTipText = "Nowy fenotyp";
            grid.Columns[8].Width = 50;
        }


    }
}
