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
using System.Linq;

namespace JanuszowyExpert.ViewModels
{
    public class MainViewModel : BaseClassViewmodel
    {

        public DelegateCommand Next { get; set; }
        public Cars car = new Cars();
        public List<AllQuestions> ListQuest = new List<AllQuestions>();
        public List<Cars> ListCars = new List<Cars>();
        public int NrQues = 0;
        public bool YourChoice;
        public int BeforeNrQue;
        public AllQuestions ask;

        public MainViewModel()
        {

            Cars.AddCarsToList(ListCars);
            AskQuestions();
            Next = new DelegateCommand(ButtonQlik);
            AllQuestions.AddtoListQuestions(ListQuest);
            ask = NextQuest(NrQues);
            QuestionContext = ask.ContextQuestion;


        }


        private void ButtonQlik(object parameter)
        {




            BeforeNrQue = NrQues;

            if (_currentSelectionY)
            {
                NrQues = ask.AnswerTrue;
                YourChoice = true;

            }
            else if (_currentSelectionN)
            {
                NrQues = ask.AnswerFalse;
                YourChoice = false;

            }

            RemoveFromListCars(BeforeNrQue, YourChoice);

            if (NrQues == 10)
            {
                QuestionContext = ListCars.Where(x => x.Status == true).ToList().Count.ToString();
            }
            else
            {
                ask = NextQuest(NrQues);


                QuestionContext = ask.ContextQuestion;
            }

            ActiveButton = false;


        }




        public void RemoveFromListCars(int id, bool choice)
        {
            if (id == 1 && choice)
            {
                var ids = new[] { "Coupe", "Hatchback", "Sedan" };
                ListCars.Where(x => ids.Contains(x.Body) || x.Power >= 200).ToList().ForEach(s => s.Status = false);
            }
            else if (id == 1 && choice==false)
            {
                var ids = new[] { "Kombi", "Minivan", "SUV" };
                ListCars.Where(x => ids.Contains(x.Body) ).ToList().ForEach(s => s.Status = false);
            }

        }


        public AllQuestions NextQuest(int idQ)
        {
            return ListQuest.Find(x => x.IdQuestion == idQ);

            //foreach (AllQuestions value in ListQuest)
            //{
            //    if (value.IdQuestion == idQ)
            //        return value;
            //}
            //return null;


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

        private string _ButtonContent;
        public string ButtonContent
        {
            get { return _ButtonContent; }
            set
            {
                if (_ButtonContent != value)
                    _ButtonContent = value;
                OnPropertyChanged();
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

            QuestionContext = "Czy chcesz aby Janusz pomógł Ci wybrać samochód twoich marzeń    ?";

        }

    }

}

