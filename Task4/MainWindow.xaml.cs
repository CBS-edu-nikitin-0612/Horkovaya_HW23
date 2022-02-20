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

namespace Task4
{
    class Model
    {
        public double Add(double x, double y)
        {
            return x + y;
        }
        public double Sub(double x, double y)
        {
            return x - y;
        }
        public double Mul(double x, double y)
        {
            return x * y;
        }
        public double Div(double x, double y)
        {
            if (y!=0)
            {
                return x / y;
            }
            return 0;
        }
    }
    public partial class MainWindow : Window
    {
        Model model;
        public MainWindow()
        {
            InitializeComponent();
            model = new Model();
        }

        private void Button_Click_Add(object sender, RoutedEventArgs e)
        {
            textBoxResult.Text = model.Add(Convert.ToDouble(textBoxOperand1.Text), Convert.ToDouble(textBoxOperand2.Text)).ToString();
        }

        private void Button_Click_Sub(object sender, RoutedEventArgs e)
        {
            textBoxResult.Text = model.Sub(Convert.ToDouble(textBoxOperand1.Text), Convert.ToDouble(textBoxOperand2.Text)).ToString();
        }

        private void Button_Click_Mul(object sender, RoutedEventArgs e)
        {
            textBoxResult.Text = model.Mul(Convert.ToDouble(textBoxOperand1.Text), Convert.ToDouble(textBoxOperand2.Text)).ToString();
        }

        private void Button_Click_Div(object sender, RoutedEventArgs e)
        {
            textBoxResult.Text = model.Div(Convert.ToDouble(textBoxOperand1.Text), Convert.ToDouble(textBoxOperand2.Text)).ToString();
        }
    }
}