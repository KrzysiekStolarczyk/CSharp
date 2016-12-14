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
    public partial class Form1 : Form
    {

        List<DataVariablesToList> ListaOsobnikow { get; set; }
        List<DataVariablesToList> ListaOsobnikowPoKrzyzowaniuIMutacji { get; set; }
        List<Crossover> ParyOsobnikow { get; set; }
        Crossover Krzyzowanie;
        Settings0bjects Settings;

        public double SumFunctionFromList;
        RandomNumber RandomNumberMain;
        DataVariablesToList header;

        public double prawdoKrzyzowania = 0.75;
        public double parametrMutacji = 0.02;
        public Form1()
        {
            InitializeComponent();
            Settings = new Settings0bjects();
            RandomNumberMain = new RandomNumber();
            ListaOsobnikow = new List<DataVariablesToList>();
            ListaOsobnikowPoKrzyzowaniuIMutacji = new List<DataVariablesToList>();
            ParyOsobnikow = new List<Crossover>();
            Krzyzowanie = new Crossover();
            header = new DataVariablesToList(0.75);
            LoadList();
        }


        public void LoadList()// Losowanie 8 osobników
        {
            int randomNumber;

            for (int i = 0; i < 8; i++)
            {
                randomNumber = RandomNumberMain.GetRandomNumber(0, 127);
                ListaOsobnikow.Add(new DataVariablesToList(string.Concat("Osobnik", i), convertToBinary(randomNumber), ResultFromFunction(randomNumber), randomNumber));
            }
            AddColumnTolist();
            dataGridView2.DataSource = ListaOsobnikow;

            Settings.UstawMainGrida(dataGridView2);

        }

        public String convertToBinary(int numberToConvert)
        {
            return Convert.ToString(numberToConvert, 2).PadLeft(8, '0');
        }

        public double ResultFromFunction(int x)
        {
            //f(x) = 2(x2+1), gdzie x  <0..127>
            return 2 * (Math.Pow(x, 2) + 1);
        }

        public void AddColumnTolist()// uzupełnianie reszty kolumn
        {
            double suma = SumFunctionResultFromColumnList();
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


        public double SumFunctionResultFromColumnList()
        {

            foreach (var item in ListaOsobnikow)
            {
                SumFunctionFromList = SumFunctionFromList + item.FunctionResult;
            }
            return SumFunctionFromList;
        }


        private void buttonSelekcja_Click(object sender, EventArgs e)
        {
            Selection2();
        }


        // losowanie 2

        public void Selection2()// selekcja 8 osobników
        {
            int randomNumber;
            string info = "\nPo przeprowadzamy selekcję osobników za pomocą koła ruletki zostały wylosowane osobniki: ";
            double SumPartFromList;
            int ListCount;
            int numberOfPairr;
            for (int i = 0; i < 8; i++)
            {
                randomNumber = RandomNumberMain.GetRandomNumber(0, 100);
                SumPartFromList = 0;
                int id = 0;
                foreach (var item in ListaOsobnikow)
                {
                    id += 1;
                    SumPartFromList = SumPartFromList + item.PercentageAsDouble;
                    if (SumPartFromList >= randomNumber)
                    {                      
                        richTextBox1.Text+=richTextBox1.Text= "Dla liczby " + randomNumber + " wybrano " + item.NameSubject + " ,ponieważ " + String.Format("{0:N2}", SumPartFromList) + " >= " + randomNumber+"\n";

                        info = info + ", " + item.NameSubject;
                        ListCount = ParyOsobnikow.Count;
                        numberOfPairr = ListCount <= 1 ? 1 : ListCount <= 3 ? 2 : ListCount <= 5 ? 3 : 4;

                        ParyOsobnikow.Add(new Crossover(ListCount + 1, item.NameSubject, item.RandomNumberAsBinary, numberOfPairr,item.RandomNumber));
                        break;
                    }
                }
            }

            richTextBox1.Text += info;

            //Krzyzowanie.AddListToTable(ParyOsobnikow, RandomNumberMain);
        }


        public void PropabilityCrossover(double propabilityParam)// prawdopodobieństwo krzyżowania, ustawia true lub folse dla danej pary
        {
            double randomNumber;

            for (int i = 0; i < 4; i++)
            {
                randomNumber = (double)RandomNumberMain.GetRandomNumber(0, 100) / 100;
                if (randomNumber < propabilityParam)
                {
                    ParyOsobnikow.Where(p => p.NumberOfPar == i + 1).ToList().ForEach(p => p.PropabilityCross = true);
                }
            }
            
        }


        public void WyznacznieLocus()// miejsce krzyzowania
        {
            int randomNumber;


            for (int i = 0; i < 4; i++)
            {
                randomNumber = RandomNumberMain.GetRandomNumber(1, 7);
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

                        ParyOsobnikow.Where(p => p.IdSubject == idSubject - 1).ToList().ForEach(p => { p.RandomNumberAsBinary = chromosom1p + chromosom2k; p.NewFenotyp = Convert.ToInt32(chromosom1p + chromosom2k, 2) ; });
                        ParyOsobnikow.Where(p => p.IdSubject == idSubject).ToList().ForEach(p => { p.RandomNumberAsBinary = chromosom2p + chromosom1k; p.NewFenotyp = Convert.ToInt32(chromosom2p + chromosom1k, 2); });

                    }
                }

            }

            
        }

        public void PrawdopodobienstwoMutacji()
        {
            double randomNumber;
            string zmianaGenu;
            string test;

            foreach (var item in ParyOsobnikow)
            {
                if (item.PropabilityCross)
                {
                    randomNumber = (double)RandomNumberMain.GetRandomNumber(0, 100) / 1000000000;

                    if (randomNumber < parametrMutacji)
                    {
                        item.PropabilityMutation = true;
                        item.NumberOfMutationGen = RandomNumberMain.GetRandomNumber(1, 8);
                        test = item.RandomNumberAsBinary.Substring(item.NumberOfMutationGen - 1, 1);
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource= ParyOsobnikow;
            Settings.UstawGridPoMutacji(dataGridView1);
        }

        //private void button2_Click(object sender, RoutedEventArgs e)
        //{
        //    string test = "0001101";
        //    MessageBox.Show(test.Substring(3, 1));
        //    string test2;
        //    int locus = 2;
        //    test2 = test.Substring(0, locus) + test.Substring(locus).Replace("0", "2").Replace("1", "0").Replace("2", "1");


        //}


    }
}
