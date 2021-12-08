using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using frameAction;
using Xamarin.Forms;


namespace frameAction
{
    class modelo: ContentPage
    {
        private string _name = "Jhonny Cast";
        public string Name
        {
            get => _name;
            set { 
                if (value == _name) 
                {
                    return; 
                } 
                _name = value;
                OnPropertyChanged();
            }
        }
    }
}
