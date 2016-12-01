using JanuszowyExpert.Models;
using System;
using System.Windows;
using System.Threading;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using System.Windows.Controls;
using System.Xml.Linq;
using System.Collections.Generic;

namespace JanuszowyExpert.ViewModels
{
    public class MainViewModel : BaseClassViewmodel
    {

        public DelegateCommand Next { get; set; }
        public Cars car = new Cars();
        public List<AllQuestions> ListQuest = new List<AllQuestions>();
        public List<Cars> ListCars= new List<Cars>();
        public int NrQues = 1;
        public bool YourChoice;

        public MainViewModel()
        {

            Cars.AddCarsToList(ListCars);
            AskQuestions();
            Next = new DelegateCommand(ButtonQlik);
            AllQuestions.AddtoListQuestions(ListQuest);
        }


        private void ButtonQlik(object parameter)
        {
            AllQuestions qqqqq = NextQuest(NrQues);


            QuestionContext = qqqqq.ContextQuestion;
            if(_currentSelectionY )
            {
                NrQues= qqqqq.AnswerTrue;
                YourChoice = true;
            }
            else if(_currentSelectionN)
            {
                NrQues = qqqqq.AnswerFalse;
                YourChoice = false;
            }
            RemoveFromListCars(NrQues, YourChoice);
            
                ActiveButton = false;
        }

        public void RemoveFromListCars(int id, bool choice)
        {
            if(id==1 && choice)
            {
                foreach (Cars value in ListCars)
                {
                    if ("Coupe".Equals(value.Body) || "Hatchback".Equals(value.Body) || "Sedan".Equals(value.Body))
                    {
                        value.Status = false;
                    }
                        
                }
               
            }
        }

        public AllQuestions NextQuest(int idQ)
        {
            foreach (AllQuestions value in ListQuest)
            {
                if (value.IdQuestion == idQ)
                    return value;
            }
            return null;
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

