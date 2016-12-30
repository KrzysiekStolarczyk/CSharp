namespace GeneticAlgorithmWF
{
    class Crossover
    {
        public int IdSubject { get; set; }
        public string NameSubject { get; set; }       
        public string RandomNumberAsBinary { get; set; }
        public int NumberOfPar { get; set; }
        public bool PropabilityCross { get; set; }
        public int Locus { get; set; }
        public bool PropabilityMutation { get; set; }
        public int NumberOfMutationGen { get; set; }
        public int NewFenotyp { get; set; }

        public Crossover(int idSubject, string nameSubject, string randomNumberAsBinary, int numberOfPar,int fenotyp)
        {
            IdSubject = idSubject;
            NameSubject = nameSubject;
            RandomNumberAsBinary = randomNumberAsBinary;
            NumberOfPar = numberOfPar;

            PropabilityCross = false;
            Locus = 0;
            PropabilityMutation = false;
            NumberOfMutationGen = 0;
            NewFenotyp = fenotyp;
        }

        public Crossover()
        {
        }
    }
}
