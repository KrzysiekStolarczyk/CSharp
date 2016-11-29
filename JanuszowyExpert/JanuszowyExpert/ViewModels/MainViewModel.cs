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

        public MainViewModel()
        {
            Questions = new Questions();
            Questions.QuestionContext = "cuka";

            Thread.Sleep(5000);
            Questions.QuestionContext = "cuka2das";
        }


    }
}
