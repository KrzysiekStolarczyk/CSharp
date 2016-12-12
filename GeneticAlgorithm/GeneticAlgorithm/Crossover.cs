using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace GeneticAlgorithm
{
    class Crossover
    {
        public int IdSubject { get; set; }
        public string NameSubject { get; set; }
        public string RandomNumberAsBinary { get; set; }
        public int NumberOfPar { get; set; }
        public bool PropabilityCross { get; set; }
        public int Locus { get; set; }
        public bool PropabilityMutation{ get; set; }
        public int NumberOfMutationGen { get; set; }

        //public string[,] tab = new string[4, 5];


        public Crossover(int idSubject, string nameSubject, string randomNumberAsBinary,int numberOfPar)
        {
            IdSubject = idSubject;
            NameSubject = nameSubject;
            RandomNumberAsBinary = randomNumberAsBinary;
            NumberOfPar = numberOfPar;

            PropabilityCross = false;
            Locus = 0;
            PropabilityMutation = false;
            NumberOfMutationGen = 0;
        }


        public Crossover()
        {

        }

        //public void AddListToTable(List<Crossover> chromosomeCouple, RandomNumber numberList)
        //{
        //    int i = 0;
        //    int numberElementOfList = 1;
        //    foreach (var item in chromosomeCouple)
        //    {
        //        if (numberElementOfList % 2 == 1 )
        //        {
        //            tab[i, 0] = "Para" + (i + 1);
        //            tab[i, 1] = item.NameSubject;
        //            tab[i, 2] = item.RandomNumberAsBinary;
                   
        //        }
        //        else
        //        {
        //            tab[i, 3] = item.NameSubject;
        //            tab[i, 4] = item.RandomNumberAsBinary;
        //            i++;
        //        }
        //        numberElementOfList++;

        //    }

        //    CheckIfNeedCross(tab, numberList);

        //}

        //public void CheckIfNeedCross(string[,] tab, RandomNumber numberList)
        //{
        //    double randomNumber;
        //    string text;
        //    for (int i = 0; i < 4; i++)
        //    {
        //        randomNumber = numberList.GetRandomNumber(0, 100) / (double)100;
        //        if (randomNumber <= 0.75)
        //        {
        //            text = tab[i, 0] + " " + tab[i, 1] + " "+ tab[i, 2] + " " + tab[i, 3]+ " "+ tab[i, 4];
        //            MessageBox.Show(text);
        //        }
        //    }
        //}
            

        //public void RemovePairToCross(List<Crossover> chromosomeCouple, int from)
        //{

        //    chromosomeCouple.RemoveRange(from, 2);
        //}

     

    }
}
