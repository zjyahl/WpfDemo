using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WpfDemo.viewmodel;

namespace WpfDemo
{
    /// <summary>
    /// BindWindow.xaml 的交互逻辑
    /// </summary>
    public partial class BindWindow : Window
    {
        ObservableCollection<Student> students = new ObservableCollection<Student>();
        private Student stu = new Student();
        private HashSet<DependencyObject> errCbjects = new HashSet<DependencyObject>();
        public BindWindow()
        {
            InitializeComponent();
            this.DataContext = stu;

        }


        private void TextBox_Error(object sender, ValidationErrorEventArgs e)
        {
            DependencyObject  el = e.OriginalSource as DependencyObject;
           
                var errs = Validation.GetErrors(el);
                if (errs.Count > 0)
                {
                    var err = errs[0].ErrorContent.ToString();
                    errCbjects.Add(el);
                }
                else { errCbjects.Remove(el); }

            
            e.Handled = true;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
  
            foreach (var errObject in errCbjects)
            {
                var errs = Validation.GetErrors(errObject);
                if (errs.Count > 0)
                {
                    var err = errs[0].ErrorContent.ToString();
                }
            }
            Student t = stu;
            int a = 12;
        }
    }
}
