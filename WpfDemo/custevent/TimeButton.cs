using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace WpfDemo.custevent
{
    class TimeButton:Button
    {
        public static readonly RoutedEvent TimeOutEvent = EventManager.RegisterRoutedEvent("TimeOut", RoutingStrategy.Bubble, typeof(EventHandler<TimeOutEventArgs>), typeof(TimeButton));

        public event RoutedEventHandler TimeOut
        {
            add { this.AddHandler(TimeOutEvent, value); }
            remove { this.RemoveHandler(TimeOutEvent, value); }
        }
        protected override void OnClick()
        {
            base.OnClick();
            TimeOutEventArgs args = new TimeOutEventArgs(TimeOutEvent, this);
            this.RaiseEvent(args);
        }

    }
}
