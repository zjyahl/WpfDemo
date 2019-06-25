using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfDemo.viewmodel
{
    class Student:INotifyPropertyChanged
    {
        private string name;
        private int? age;
        private double height;
      

        public event PropertyChangedEventHandler PropertyChanged;

        public static readonly RoutedEvent NameChangedEvent = EventManager.RegisterRoutedEvent("NameChanged", RoutingStrategy.Bubble, typeof(EventHandler), typeof(Student));

        public static void AddNameChangedHandler(DependencyObject d, RoutedEventHandler h)
        {
            UIElement e = d as UIElement;
            e?.AddHandler(Student.NameChangedEvent, h);
        }
        public static void RemoveNameChangedHandler(DependencyObject d, RoutedEventHandler h)
        {
            UIElement e = d as UIElement;
            e?.RemoveHandler(Student.NameChangedEvent, h);
        }
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

        public int? Age
        {
            get
            {
                return age;
            }

            set
            {
                age = value;
                fieldChanage("Age");
            }
        }

        public double Height
        {
            get
            {
                return height;
            }

            set
            {
                height = value;
                fieldChanage("Height");
            }
        }

        private void fieldChanage(string fileName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(fileName));
        }
    }
}
