namespace GeneticAlgorithmWF
{
    class DataVariablesToList
    {
        public string NameSubject { get; set; }
        public string RandomNumberAsBinary { get; set; }
        public double FunctionResult { get; set; }
        public int RandomNumber { get; set; }
        public string Percentage { get; set; }
        public double PercentageAsDouble { get; set; }
        public double CrossoverProbability { get; set; }
        public string PartSum { get; set; }

        public DataVariablesToList(double CrossoverProbability)
        {
            this.CrossoverProbability = CrossoverProbability;
        }

        public DataVariablesToList()
        {
            Percentage = "";
            PercentageAsDouble = 0;
            PartSum = "";        
        }

        public DataVariablesToList(string nameSubject, string randomNumberAsBinary, double functionResult, int randomNumber) : this()
        {
            NameSubject = nameSubject;
            RandomNumberAsBinary = randomNumberAsBinary;
            FunctionResult = functionResult;
            RandomNumber = randomNumber;
        }
    }
}
