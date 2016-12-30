using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace GeneticAlgorithmWF
{
    public partial class MainView : Form
    {

        List<DataVariablesToList> ListaOsobnikow { get; set; }
        List<DataVariablesToList> ListaOsobnikowPoKrzyzowaniuIMutacji { get; set; }
        List<Crossover> ParyOsobnikow { get; set; }
        Crossover Krzyzowanie;
        Settings0bjects Settings;
        int iteracja = 0;
        public double SumFunctionFromList;
        RandomNumber RandomNumberMain;
        DataVariablesToList header;

        public double prawdoKrzyzowania;
        public double parametrMutacji;
        public MainView()
        {
            InitializeComponent();
            Settings = new Settings0bjects();
            RandomNumberMain = new RandomNumber();
            ListaOsobnikow = new List<DataVariablesToList>();
            ListaOsobnikowPoKrzyzowaniuIMutacji = new List<DataVariablesToList>();
            ParyOsobnikow = new List<Crossover>();
            Krzyzowanie = new Crossover();
            getParameters();
            header = new DataVariablesToList(prawdoKrzyzowania);
            
            //LoadList();
            button1.Enabled = false;
            buttonKrzyzowanie.Enabled = false;

        }

        // Krok 1: Losowanie 8 osobników
        public void LoadList()
        {
            if (iteracja == 0)
            {
                for (int i = 0; i < 8; i++)
                {
                    int randomNumber = RandomNumberMain.GetRandomNumber(0, 127);
                    ListaOsobnikow.Add(new DataVariablesToList(string.Concat("Osobnik", i), convertToBinary(randomNumber), ResultFromFunction(randomNumber), randomNumber));
                }
            }
            else
            {
                ListaOsobnikow.Clear();
                int i = 1;
                foreach (var list in ParyOsobnikow)
                {
                    ListaOsobnikow.Add(new DataVariablesToList(string.Concat("Osobnik", i), list.RandomNumberAsBinary, ResultFromFunction(list.NewFenotyp), list.NewFenotyp));
                    i++;
                }
            }

            AddColumnTolist();
            dataGridView2.DataSource = ListaOsobnikow;
            dataGridView2.Refresh();
            Settings.UstawMainGrida(dataGridView2);
            iteracja++;
        }
      

        private void button2_Click(object sender, EventArgs e)
        {
            bool petla= true;
            while (petla)
            {
                LoadList();
                Selection2();
                getParameters();
                //2
                PropabilityCrossover(prawdoKrzyzowania);
                WyznacznieLocus();
                PrzeksztalceniePoLocus();
                PrawdopodobienstwoMutacji();
                //3
                dataGridView1.DataSource = ParyOsobnikow;
                Settings.UstawGridPoMutacji(dataGridView1);
                dataGridView1.Refresh();
                ShowAxis();

                if (ParyOsobnikow.Sum(x => x.NewFenotyp)>=1014)
                {
                    petla=!petla;
                }
                //System.Threading.Thread.Sleep(2000);
            }
        }

        public String convertToBinary(int numberToConvert)
        {
            return Convert.ToString(numberToConvert, 2).PadLeft(7, '0');
        }

        public double ResultFromFunction(int x)
        {
            //f(x) = 2(x2+1), gdzie x  <0..127>
            return 2 * (Math.Pow(x, 2) + 1);
        }

        //Krok 2: Uzupełnienie kolumn
        public void AddColumnTolist()// uzupełnianie reszty kolumn
        {
            double suma = ListaOsobnikow.Sum(x => x.FunctionResult);
            Dictionary<string, double> MyValue = new Dictionary<string, double>();
            double percentAsDouble = 0;
            double SumPercent = 0;
            double asPercentOneRow = 0;

            foreach (var item in ListaOsobnikow)
            {
                asPercentOneRow = item.FunctionResult / suma;// dla danego wiersza procent z całości
                percentAsDouble = asPercentOneRow * 100;//  wyświetlanie procentu jako po przecinku czyki 54%->0.54

                item.Percentage = string.Format("{0:P2}.", asPercentOneRow, 4);
                item.PercentageAsDouble = percentAsDouble;

                SumPercent = SumPercent + asPercentOneRow;// suma częsciowa procentów
                item.PartSum = string.Format("{0:P2}.", SumPercent, 4); // aktualizacja Podsumy

                MyValue.Add(item.NameSubject, asPercentOneRow);
            }

            chart1.Series[0].Points.Clear();
            chart1.Series[0].ChartType = SeriesChartType.Pie;
            foreach (string tagname in MyValue.Keys)
            {
                chart1.Series[0].Points.AddXY(tagname, MyValue[tagname]);
            }
        }


        private void buttonSelekcja_Click(object sender, EventArgs e)
        {
            getParameters();
            LoadList();
            Selection2();
            buttonSelekcja.Enabled = false;
            buttonKrzyzowanie.Enabled = true;
            
        }


        // losowanie 2

        public void Selection2()// selekcja 8 osobników
        {
            richTextBox1.Text += "\n\n\n\nNumer iteracji " + iteracja+ "\n\n";

            ParyOsobnikow.Clear();//czyszczenie listy 
            int randomNumber;
            string info = "\nPo przeprowadzamy selekcję osobników za pomocą koła ruletki zostały wylosowane osobniki: \n";
            double SumPartFromList;
            int ListCount = 0;
            int numberOfPairr = 0;
            for (int i = 0; i < 8; i++)
            {
                randomNumber = RandomNumberMain.GetRandomNumber(0, 100);
                SumPartFromList = 0;
                int id = 0;
                foreach (var item in ListaOsobnikow)
                {
                    id += 1;
                    SumPartFromList = (SumPartFromList + item.PercentageAsDouble) > 99 ? 100: SumPartFromList + item.PercentageAsDouble;
                    if (SumPartFromList >= randomNumber)
                    {
                        richTextBox1.Text += richTextBox1.Text = "Dla liczby " + randomNumber + " wybrano " + item.NameSubject + " ,ponieważ " + String.Format("{0:N2}", SumPartFromList) + " >= " + randomNumber + "\n";
                        ListCount = ParyOsobnikow.Count;

                        numberOfPairr = ListCount <= 1 ? 1 : ListCount <= 3 ? 2 : ListCount <= 5 ? 3 : 4;

                        ParyOsobnikow.Add(new Crossover(ListCount + 1, item.NameSubject, item.RandomNumberAsBinary, numberOfPairr, item.RandomNumber));

                        if (ParyOsobnikow.Count % 2 == 1)
                        {
                            info = info + "Para nr " + numberOfPairr + " " + item.NameSubject + ", ";
                        }
                        else
                        {
                            info = info + item.NameSubject + "\n";
                        }
                        break;
                    }
                }
            }

            richTextBox1.Text += info + "\n";
            richTextBox1.SelectionStart = richTextBox1.Text.Length;
            richTextBox1.ScrollToCaret();
            //Krzyzowanie.AddListToTable(ParyOsobnikow, RandomNumberMain);
        }


        public void PropabilityCrossover(double propabilityParam)// prawdopodobieństwo krzyżowania, ustawia true lub folse dla danej pary
        {
            double randomNumber;
            richTextBox1.Text += "Sprawdzamy prawdobodobieństwo krzyżowania dla parametru krzyżowania (PK) o wartości " + propabilityParam + "\n";
            for (int i = 0; i < 4; i++)
            {
                randomNumber = (double)RandomNumberMain.GetRandomNumber(0, 100) / 100;
                if (randomNumber < propabilityParam)
                {
                    ParyOsobnikow.Where(p => p.NumberOfPar == i + 1).ToList().ForEach(p => p.PropabilityCross = true);
                    richTextBox1.Text += "Wylosowano liczbę " + randomNumber + " która jest mniejsza od PK, więc para numer " + (i + 1) + " podlega krzyżowaniu.\n";
                }
                else
                {
                    richTextBox1.Text += "Wylosowano liczbę " + randomNumber + " która nie jest mniejsza od PK, więc para " + (i + 1) + " nie podlega krzyżowaniu.\n";
                }
            }
            richTextBox1.SelectionStart = richTextBox1.Text.Length;
            richTextBox1.ScrollToCaret();
        }


        public void WyznacznieLocus()// miejsce krzyzowania
        {
            for (int i = 0; i < 4; i++)
            {
                int randomNumber = RandomNumberMain.GetRandomNumber(1, 7);
                ParyOsobnikow.Where(p => p.NumberOfPar == i + 1 && p.PropabilityCross).ToList().ForEach(p => p.Locus = randomNumber);
            }
        }

        public void PrzeksztalceniePoLocus()
        {
            int idSubject = 0;
            string chromosom1p = string.Empty;
            string chromosom2p = string.Empty;
            string chromosom1k = string.Empty;
            string chromosom2k = string.Empty;

            foreach (var item in ParyOsobnikow)
            {
                if (item.PropabilityCross)
                {
                    idSubject = item.IdSubject;
                    if (idSubject % 2 != 0)
                    {
                        chromosom1p = item.RandomNumberAsBinary.Substring(0, item.Locus);
                        chromosom1k = item.RandomNumberAsBinary.Substring(item.Locus);
                    }
                    else
                    {
                        chromosom2p = item.RandomNumberAsBinary.Substring(0, item.Locus);
                        chromosom2k = item.RandomNumberAsBinary.Substring(item.Locus);

                        ParyOsobnikow.Where(p => p.IdSubject == idSubject - 1).ToList().ForEach(p => { p.RandomNumberAsBinary = chromosom1p + chromosom2k; p.NewFenotyp = Convert.ToInt32(chromosom1p + chromosom2k, 2); });
                        ParyOsobnikow.Where(p => p.IdSubject == idSubject).ToList().ForEach(p => { p.RandomNumberAsBinary = chromosom2p + chromosom1k; p.NewFenotyp = Convert.ToInt32(chromosom2p + chromosom1k, 2); });
                    }
                }
            }
        }

        public void PrawdopodobienstwoMutacji()
        {
            string zmianaGenu;
            double randomNumber = (double)RandomNumberMain.GetRandomNumber(0, 100) / 1000000000;// czy ma zajść mutacja

            if (randomNumber < parametrMutacji)
            {
                int numberOfMut = RandomNumberMain.GetRandomNumber(1, 8);//który osobnik bedzie mutowany

                foreach (var item in ParyOsobnikow)
                {
                    if (item.IdSubject == numberOfMut)
                    {
                        item.PropabilityMutation = true;
                        int ktotyGenMaBycMutowany = RandomNumberMain.GetRandomNumber(1, 8);
                        ktotyGenMaBycMutowany = ktotyGenMaBycMutowany == 0 ? 1 : ktotyGenMaBycMutowany;
                        item.NumberOfMutationGen = ktotyGenMaBycMutowany;                     
                        zmianaGenu = item.RandomNumberAsBinary.Substring(item.NumberOfMutationGen - 1, 1) == "1" ? "0" : "1";

                        item.RandomNumberAsBinary = item.RandomNumberAsBinary.Remove(item.NumberOfMutationGen - 1, 1);
                        item.RandomNumberAsBinary = item.RandomNumberAsBinary.Insert(item.NumberOfMutationGen - 1, zmianaGenu);
                        item.NewFenotyp = Convert.ToInt32(item.RandomNumberAsBinary, 2);
                    }
                }
            }
        }


        private void buttonKrzyzowanie_Click(object sender, EventArgs e)
        {
            PropabilityCrossover(prawdoKrzyzowania);
            WyznacznieLocus();
            PrzeksztalceniePoLocus();
            PrawdopodobienstwoMutacji();

            buttonKrzyzowanie.Enabled = false;
            button1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            dataGridView1.DataSource = ParyOsobnikow;
            Settings.UstawGridPoMutacji(dataGridView1);
            button1.Enabled = false;
            buttonSelekcja.Enabled = true;
            dataGridView1.Refresh();
            ShowAxis();
        }

        public void ShowAxis()
        {
            chartAxis.Series[0].Points.Clear();
            foreach (var tagname in ParyOsobnikow)
            {
                chartAxis.Series[0].Points.AddXY(tagname.NameSubject, tagname.NewFenotyp);
            }
        }


        public void getParameters()
        {
            if (!checkBoxKrz.Checked && textBoxKrz.Text != "")
            {
                prawdoKrzyzowania = double.Parse(textBoxKrz.Text);
            }
            else
            {
                prawdoKrzyzowania = 0.75;

            }
            if (!checkBoxMut.Checked && textBoxMut.Text != "")
            {
                parametrMutacji = double.Parse(textBoxMut.Text);
            }
            else
            {
                parametrMutacji = 0.15;
            }

        }

        
    }
}
