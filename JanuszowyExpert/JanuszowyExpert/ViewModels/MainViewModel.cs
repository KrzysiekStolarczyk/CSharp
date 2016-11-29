using JanuszowyExpert.Models;
using System;
using System.Windows;
using System.Threading;
namespace JanuszowyExpert.ViewModels
{
    public class MainViewModel
    {

        //public Questions Questions
        public Questions Questions { get; set; }
        public Questions checkBoxYes { get; set; }
        public Questions checkBoxNo { get; set; }

        public Cars car= new Cars();

        public MainViewModel()
        {
            car.AddCarsToList();
            //MessageBox.Show(car.ListOfCars.Count.ToString());

            Questions = new Questions();
            //Questions.QuestionContext = "cuka";
            Questions.AskQuestions();

        }



    }
}
