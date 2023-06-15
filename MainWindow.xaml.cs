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

namespace Calculadora_23CV2._0
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void ButtonClick(object sender, RoutedEventArgs e)
        {
            {
                try
                {
                    Button button = (Button)sender;
                    string value = (string)button.Content;

                    if (IsNumber(value))
                    {
                        HandleNumber(value);
                    }


                }
                catch (Exception)
                {

                    throw new Exception("");
                }
            }
        }

        private bool IsNumber(string num) 
        {
            return double.TryParse(num, out _);
        }
        private void HandleNumber(string value)
        {
            if (String.IsNullOrEmpty(Screen.Text))
            {
                Screen.Text = value;

            }
            Screen.Text += value;
        }
        
    }   
}
