using JanuszowyExpert.Models;
using System.Windows;
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
        public int ile;

        public MainViewModel()
        {

            Cars.AddCarsToList(ListCars);
            AskQuestions();
            Next = new DelegateCommand(ButtonQlik);
            AllQuestions.AddtoListQuestions(ListQuest);
            ask = NextQuest(NrQues);
            QuestionContext = ask.ContextQuestion;
            ButtonContent = "Następne pytanie";

        }


        private void ButtonQlik(object parameter)
        {
            if (ButtonContent == "Reset")
            {
                System.Diagnostics.Process.Start(Application.ResourceAssembly.Location);
                Application.Current.Shutdown();

            }


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

                if (ListCars.Where(x => x.Status == true).ToList().Count > 0)
                {
                    ButtonContent = "Reset";
                    QuestionContext = ListCars.Where(x => x.Status == true).Select(x => "Twoje wymarzone auto to: " + x.Mark + " " + x.Model + " " + x.Series).FirstOrDefault();
                    ImageLocation = ListCars.Where(x => x.Status == true).Select(x => "G:/Git/C# Projekty/JanuszowyExpert/JanuszowyExpert/Zdjecia/" + x.LocationPhotos).FirstOrDefault();

                }
                else
                {
                    ButtonContent = "Reset";
                    QuestionContext = " Niestety Janusz nie ogarnął tematu...";
                    ImageLocation = "G:/Git/C# Projekty/JanuszowyExpert/JanuszowyExpert/Zdjecia/brak.jpg";
                }

            }
            else
            {
                ask = NextQuest(NrQues);


                QuestionContext = ask.ContextQuestion;
            }


            CurentSelectionY = false;
            CurentSelectionN = false;

            if (ButtonContent == "Reset")
            {
                ActiveButton = true;
            }
            else
            {
                ActiveButton = false;
            }
        }


        public void RemoveFromListCars(int id, bool choice)
        {
            if (id == 1 && choice)
            {
                var ids = new[] { "Coupe", "Hatchback", "Sedan" };
                ListCars.Where(x => (ids.Contains(x.Body)) && x.Status).ToList().ForEach(s => s.Status = false);
                ile = ListCars.Where(x => x.Status == true).ToList().Count;
            }
            else if (id == 1 && choice == false)
            {
                var ids = new[] { "Kombi", "Minivan", "SUV" };
                ListCars.Where(x => ids.Contains(x.Body) && x.Status).ToList().ForEach(s => s.Status = false);
                ile = ListCars.Where(x => x.Status == true).ToList().Count;
            }
            else if (id == 3 && choice)
            {
                ListCars.Where(x => (x.EngineCapacity > 2500 && x.Status)).ToList().ForEach(s => s.Status = false);
                ile = ListCars.Where(x => x.Status == true).ToList().Count;
                //ListCars.OrderBy(p => p.EngineCapacity);
            }
            else if (id == 3 && choice == false)
            {
                ListCars.Where(x => (x.EngineCapacity <= 2500 && x.Status)).ToList().ForEach(s => s.Status = false);
                ile = ListCars.Where(x => x.Status == true).ToList().Count;
                //ListCars.OrderByDescending(p => p.EngineCapacity);

            }
            else if (id == 4 && choice)
            {
                ListCars.Where(x => (x.FuelType == "Diesel" && x.Status)).ToList().ForEach(s => s.Status = false);
                ile = ListCars.Where(x => x.Status == true).ToList().Count;
            }
            else if (id == 4 && choice == false)
            {
                ListCars.Where(x => (x.FuelType == "Benzyna" && x.Status)).ToList().ForEach(s => s.Status = false);
                ile = ListCars.Where(x => x.Status == true).ToList().Count;
            }
            else if (id == 5 && choice)
            {
                ListCars.Where(x => (x.YearOfproduction >= 2003 && x.Status)).ToList().ForEach(s => s.Status = false);
                ile = ListCars.Where(x => x.Status == true).ToList().Count;
            }
            else if (id == 6 && choice)
            {
                ListCars.Where(x => ((x.YearOfproduction < 2003 || x.YearOfproduction > 2011) && x.Status)).ToList().ForEach(s => s.Status = false);
                ile = ListCars.Where(x => x.Status == true).ToList().Count;
            }
            else if (id == 6 && choice == false)
            {
                ListCars.Where(x => (x.YearOfproduction < 2011 && x.Status)).ToList().ForEach(s => s.Status = false);
                ile = ListCars.Where(x => x.Status == true).ToList().Count;
            }
            else if (id == 7 && choice)
            {
                ListCars.Where(x => (x.Miliage > 150000 && x.Status)).ToList().ForEach(s => s.Status = false);
                ile = ListCars.Where(x => x.Status == true).ToList().Count;
            }
            else if (id == 7 && choice == false)
            {
                ListCars.Where(x => (x.Miliage <= 150000 && x.Status)).ToList().ForEach(s => s.Status = false);
                ile = ListCars.Where(x => x.Status == true).ToList().Count;
            }
            else if (id == 8 && choice)
            {
                ListCars.Where(x => (x.Country != "Niemcy" && x.Status)).ToList().ForEach(s => s.Status = false);
                ile = ListCars.Where(x => x.Status == true).ToList().Count;
            }
            else if (id == 9 && choice)
            {
                ListCars.Where(x => (x.Country != "Włochy" && x.Status)).ToList().ForEach(s => s.Status = false);
                ile = ListCars.Where(x => x.Status == true).ToList().Count;
            }
            else if (id == 9 && choice == false)
            {
                ListCars.Where(x => ((x.Country == "Włochy" || x.Country == "Niemcy") && x.Status)).ToList().ForEach(s => s.Status = false);
                ile = ListCars.Where(x => x.Status == true).ToList().Count;
            }


        }


        public AllQuestions NextQuest(int idQ)
        {
            return ListQuest.Find(x => x.IdQuestion == idQ);

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



        private string _image;
        public string ImageLocation
        {
            get { return _image; }
            set
            {
                if (_image != value)
                {
                    _image = value;
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


        private string _visible;
        public string VisibleElements
        {
            get { return _visible; }
            set
            {
                if (_visible != value)
                {
                    _visible = value;
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

            QuestionContext = "Czy chcesz aby Janusz pomógł Ci wybrać samochód twoich marzeń    ?";

        }

    }

}

