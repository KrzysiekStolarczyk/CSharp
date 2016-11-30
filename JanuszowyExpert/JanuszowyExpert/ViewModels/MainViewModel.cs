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

        public MainViewModel()
        {
            car.AddCarsToList();

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
                    AskQuestions2();
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

        private bool _currentSelection;
        public bool CurrentSelection
        {
            get { return _currentSelection; }
            set
            {
                if (_currentSelection != value)
                {
                    _currentSelection = value;
                    OnPropertyChanged();
                }
            }
        }
        


        public void AskQuestions()
        {

            //QuestionContext = $"{DateTime.Now.ToString()}Czy chcesz aby Janusz pomógł Ci wybrać samochód twoich marzeń?";
            QuestionContext = "Czy chcesz aby Janusz pomógł Ci wybrać samochód twoich marzeń?";

        }
        public void AskQuestions2()
        {

            QuestionContext = "Nie chuju?";
            //_question = "Nie chuju?";
        }


    }




}

