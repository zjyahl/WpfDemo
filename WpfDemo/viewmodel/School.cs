using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfDemo.viewmodel
{
    class School : INotifyPropertyChanged
    {
        private string name;

        public event PropertyChangedEventHandler PropertyChanged;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
                fieldChanage("Name");
            }
        }

       

        private void fieldChanage(string fileName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(fileName));
        }
    }
}
