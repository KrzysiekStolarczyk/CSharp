using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace JanuszowyExpert.ViewModels
{
    public class BaseClassViewmodel : INotifyPropertyChanged
    {
        //private int _bountNumber;
        //public int BoundNumber
        //{
        //    get { return _bountNumber; }
        //    set
        //    {
        //        if (_bountNumber != value)
        //        {
        //            _bountNumber = value;
        //            OnPropertyChanged();
        //        }
        //    }
        //}
        //public BaseClassViewmodel()
        //{
        //}

        


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
