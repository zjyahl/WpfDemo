using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfDemo.custevent
{
    class TimeOutEventArgs:RoutedEventArgs
    {
        public TimeOutEventArgs(RoutedEvent routedEvent, object source):base(routedEvent, source)
        { }
    }
}
