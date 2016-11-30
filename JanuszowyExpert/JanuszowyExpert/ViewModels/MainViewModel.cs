using JanuszowyExpert.Models;
using System;
using System.Windows;
using System.Threading;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace JanuszowyExpert.ViewModels
{
    public class MainViewModel : BaseClassViewmodel//: INotifyPropertyChanged
    {

        //public Questions Questions
        public Questions Questions { get; set; }
        //public Questions checkBoxYes { get; set; }
        public Questions checkBoxNo { get; set; }
        public Questions ActiveButton { get; set; }



        public Cars car = new Cars();

        public MainViewModel()
        {
            car.AddCarsToList();
            //MessageBox.Show(car.ListOfCars.Count.ToString());

            Questions = new Questions();
            //Questions.QuestionContext = "cuka";
            //Questions.AskQuestions();
            //MessageBox.Show(_bountNumber.ToString());

            Questions.ActiveButton = (_bountNumber == true) ? false: true;

            AskQuestions();
        }


        private bool _bountNumber;
        public bool checkBoxYes
        {
            get { return _bountNumber; }
            set
            {
                if (_bountNumber != value)
                {
                    _bountNumber = value;
                    OnPropertyChanged();
                    //MessageBox.Show(_bountNumber.ToString());
                    AskQuestions2();
                }
            }
        }


 

        public void AskQuestions()
        {

            Questions.QuestionContext = "Czy chcesz aby Janusz pomógł Ci wybrać samochód twoich marzeń?";

        }
        public void AskQuestions2()
        {

            Questions.QuestionContext = "Nie chuju?";

        }


    }




}

