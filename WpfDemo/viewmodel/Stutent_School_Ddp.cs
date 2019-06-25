using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace WpfDemo.viewmodel
{
    class Stutent_School_Ddp : DependencyObject
    {

        public static readonly DependencyProperty SchoolProperty = DependencyProperty.Register("SchoolDdp", typeof(School), typeof(Stutent_School_Ddp));

        public School SchoolDdp
        {
            get
            {
                return GetValue(SchoolProperty) as School;
            }

            set
            {
                SetValue(SchoolProperty, value);
                reBindUi(value);

            }
        }

        public void SetBinding(DependencyProperty dp, BindingBase binding)
        {
             BindingOperations.SetBinding(this, dp, binding);
             reBindUi(SchoolDdp);
        }

        private void reBindUi(School school)
        {
            
        }
    }
}
