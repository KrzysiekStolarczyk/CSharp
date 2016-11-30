using JanuszowyExpert.Models;
using System;
using System.Windows;
using System.Threading;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace JanuszowyExpert.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {

        //public Questions Questions
        public Questions Questions { get; set; }
        //public Questions checkBoxYes { get; set; }
        public Questions checkBoxNo { get; set; }

        public Cars car = new Cars();

        public MainViewModel()
        {
            car.AddCarsToList();
            //MessageBox.Show(car.ListOfCars.Count.ToString());

            Questions = new Questions();
            //Questions.QuestionContext = "cuka";
            //Questions.AskQuestions();

            

        }


        private int _bountNumber;
        public int checkBoxYes
        {
            get { return _bountNumber; }
            set
            {
                if (_bountNumber != value)
                {
                    _bountNumber = value;
                    OnPropertyChanged();
                    MessageBox.Show(_bountNumber.ToString());
                }
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName]string propertyName = null)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }



    }




}

