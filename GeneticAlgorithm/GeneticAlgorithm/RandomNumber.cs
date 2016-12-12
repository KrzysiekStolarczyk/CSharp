using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticAlgorithm
{
    class RandomNumber
    {
        public Stack<int> NumberInStack = new Stack<int>();

        public void getNumbersFromFile()
        {
            int counter = 0;
            string line;

            System.IO.StreamReader file =new System.IO.StreamReader("RandomNumbers.txt");
            while ((line = file.ReadLine()) != null)
            {
                addNumberFromfileToStack(int.Parse(line));
                counter++;
            }

            file.Close();
        }

        public void addNumberFromfileToStack(int number)
        {
            NumberInStack.Push(number);
        }
    
       public int GetRandomNumber(int min, int max)
        {    
            return NumberInStack.Pop() % ((max - min) + 1);
        }

        public RandomNumber()
        {
            getNumbersFromFile();
        }
    }
}
