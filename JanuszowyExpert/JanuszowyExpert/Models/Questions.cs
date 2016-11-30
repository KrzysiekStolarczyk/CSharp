using JanuszowyExpert.ViewModels;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace JanuszowyExpert.Models
{
    public class Questions
    {
        public string QuestionContext { get; set; }
        //public bool checkBoxYes { get; set; }
        //public bool checkBoxNo { get; set; }
        public bool ActiveButton { get; set; }
        public bool CurentSelectionY { get; set; }
        public bool CurentSelectionN { get; set; }
        //public DelegateCommand NextQuestion { get; set; }
        //BaseClassViewmodel test = new BaseClassViewmodel();


        public Questions()
        {

        }



        //public Questions(string QuestionContext1)
        //{
        //    QuestionContext = QuestionContext1;
        //}

        //public Questions()
        //{
        //    NextQuestion = new DelegateCommand(AskQuestions2, Czy);

        //}


        private bool Czy(object obj)
        {
            return true;
        }

    }
}
