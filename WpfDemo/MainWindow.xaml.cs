using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfDemo.viewmodel;

namespace WpfDemo
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            /*
            Student stu = new Student { Name = "andy", Age = 16, Height = 160.8 };
            Binding binding = new Binding();
            binding.Source = stu;
            binding.Path = new PropertyPath("Name");
            BindingOperations.SetBinding(this.textBox1, TextBox.TextProperty, binding);
            */
        }
    }

}
