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

        public Cars car = new Cars();

        int a = 1;


        public MainViewModel()
        {
            car.AddCarsToList();
            //MessageBox.Show(car.ListOfCars.Count.ToString());

            //Questions.ActiveButton = (_bountNumber == true) ? false: true;

            AskQuestions();
        }


        private bool _bountNumber;
        public bool CheckBoxYes
        {
            get { return _bountNumber; }
            set
            {
                if (_bountNumber != value)
                {
                    _bountNumber = value;
                    OnPropertyChanged();
                }
            }
        }

        private string _question;
        public string QuestionContext
        {
            get { return _question; }
            set
            {
                if (_question != value)
                {
                    _question = value;
                    OnPropertyChanged();
                }
            }
        }



        public void AskQuestions()
        {
            if (a == 1)
            {

            }
            QuestionContext = $"{DateTime.Now.ToString()}Czy chcesz aby Janusz pomógł Ci wybrać samochód twoich marzeń?";

        }
        public void AskQuestions2()
        {

            QuestionContext = "Nie chuju?";
            //_question = "Nie chuju?";
        }


    }




}

