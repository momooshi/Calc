using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using ClassLibrary2;
using System.IO;
using System.Linq;

namespace LABASVP2DZ
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void Button_Click_Calculate(object sender, RoutedEventArgs e)
        {
            try
            {
                Sum D = new Sum(tbA.Text, tbB.Text);

                lbl1.Content = "Result = " + D.dif();
            }
            catch(Exception)
            {
                MessageBox.Show("Недопустимый ввод", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Button_Click_Menu(object sender, RoutedEventArgs e)
        {
            Hide();
            MainWindow menu = new MainWindow();
            menu.ShowDialog();
            Close();
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            StreamWriter SaveRes = new StreamWriter(@"C:\СВП\LABASVP2DZ\Save_Result.txt", true);
            Sum D = new Sum(tbA.Text, tbB.Text);
            SaveRes.WriteLine(D.dif());
            Save_Check.Content= "🔥SAVE🔥";
            SaveRes.Close();
        }
    }
}
