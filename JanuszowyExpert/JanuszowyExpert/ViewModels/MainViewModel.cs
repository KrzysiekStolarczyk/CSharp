using JanuszowyExpert.Models;
using System;
using System.Windows;
using System.Threading;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace JanuszowyExpert.ViewModels
{
    public class MainViewModel : BaseClassViewmodel
    {

        public ICommand MyComand { get; set; }

        public Cars car = new Cars();
        //public Questions ques= new  Questions();

        public MainViewModel()
        {
            car.AddCarsToList();
            //ques.ActiveButton = false;
            AskQuestions();
            MyComand = new Command(ExecuteMethod, canExecuteMethod);
        }

        private bool canExecuteMethod(object parameter)
        {
            return true;
        }

        private void ExecuteMethod(object parameter)
        {
           //MessageBox.Show("No code behind");

            if (_currentSelectionY == false & _currentSelectionN == false)
            {
                QuestionContext = "Zaznacz odpowiedz ...";
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
                }
            }
        }

        public void AskQuestions()
        {

            //QuestionContext = $"{DateTime.Now.ToString()}Czy chcesz aby Janusz pomógł Ci wybrać samochód twoich marzeń?";
            QuestionContext = "Czy chcesz aby Janusz pomógł Ci wybrać samochód twoich marzeń?";

        }
        public void Test()
        {

            //QuestionContext = "Nie chuju?";
            //_question = "Nie chuju?";

            MessageBox.Show("Test");
        }


    }




}

