using JanuszowyExpert.ViewModels;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace JanuszowyExpert.Models
{
    public class Questions
    {
        public string QuestionContext { get; set; }
        public bool checkBoxYes { get; set; }
        public bool checkBoxNo { get; set; }

        //public DelegateCommand NextQuestion { get; set; }
        //BaseClassViewmodel test = new BaseClassViewmodel();


        public Questions()
        {

        }
       


        public Questions(string QuestionContext1)
        {
            QuestionContext = QuestionContext1;
        }

        //public Questions()
        //{
        //    NextQuestion = new DelegateCommand(AskQuestions2, Czy);
            
        //}


        private bool Czy(object obj)
        {
            return true;
        }
        private void AskQuestions2(object obj)
        {

            QuestionContext = "Czy samochód twoich marzeń?";

        }
        public object test1()
        {

            return true;

        }

        public void AskQuestions()
        {

            QuestionContext = "Czy chcesz aby Janusz pomógł Ci wybrać samochód twoich marzeń?";

        }
    }
}
