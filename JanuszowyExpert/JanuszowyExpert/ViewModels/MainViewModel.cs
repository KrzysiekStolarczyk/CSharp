using JanuszowyExpert.Models;
using System;
using System.Windows;
using System.Threading;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using System.Windows.Controls;
using System.Xml.Linq;

namespace JanuszowyExpert.ViewModels
{
    public class MainViewModel : BaseClassViewmodel
    {

        public DelegateCommand Next { get; set; }
        public Cars car = new Cars();


        public MainViewModel()
        {
            car.AddCarsToList();
            AskQuestions();
            Next = new DelegateCommand(NextQuestion);
        }


        private void NextQuestion(object parameter)
        {

            QuestionContext = "Pytanie 2";
            ActiveButton = false;
        }
        private void CheckIsCheckedAnswer()
        {

            if (_currentSelectionY == false && _currentSelectionN == false)
            {
                ActiveButton = false;
            }
            else if (_currentSelectionY == true)
            {
                ActiveButton = true;
            }
            else
            {
                ActiveButton = true;
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


        private bool _currentSelectionY;
        public bool CurentSelectionY
        {
            get { return _currentSelectionY; }
            set
            {
                if (_currentSelectionY != value)
                {
                    _currentSelectionY = value;
                    OnPropertyChanged();
                    CheckIsCheckedAnswer();
                }
            }
        }


        private bool _activeButton;
        public bool ActiveButton
        {
            get { return _activeButton; }
            set
            {
                if (_activeButton != value)
                {
                    _activeButton = value;
                    OnPropertyChanged();
                }
            }
        }


        private bool _currentSelectionN;
        public bool CurentSelectionN
        {
            get { return _currentSelectionN; }
            set
            {
                if (_currentSelectionN != value)
                {
                    _currentSelectionN = value;
                    OnPropertyChanged();
                    CheckIsCheckedAnswer();
                }
            }
        }

        public void AskQuestions()
        {

            QuestionContext = "Czy chcesz aby Janusz pomógł Ci wybrać samochód twoich marzeń?";

        }

    }

}

