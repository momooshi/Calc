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
using ClassLibrary2;
using Microsoft.Win32;
using System.IO;
using System.Diagnostics;


namespace LABASVP2DZ
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
        private void Button_Click_Calculate(object sender, RoutedEventArgs e)
        {
            Hide();
            Window1 calculate = new Window1();
            calculate.ShowDialog();
            Close();
        }

        private void Button_Click_Exit(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_History(object sender, RoutedEventArgs e)
        {
            Process.Start("notepad.exe", "C:\\СВП\\LABASVP2DZ\\Save_Result.txt");
        }
    }
    
}
