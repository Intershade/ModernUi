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

namespace ModernUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool _textBoxInit = true;
        private bool _passwordInit = true;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }
        private void TextBox_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (_textBoxInit)
            {
                TextBox.Text = "";
                _textBoxInit = false;
            }
        }
        private void PasswordBox_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (_passwordInit)
            {
                PasswordBox.Password = "";
                _passwordInit = false;
            }
        }
    }
}
