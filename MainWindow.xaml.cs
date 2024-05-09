using System;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp12
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DateTime day = DateTime.Now;
        public MainWindow()
        {
            InitializeComponent();

            for (int i = 1; i <= DateTime.DaysInMonth(day.Year, day.Month); i++)
            {
                UserView c = new UserView
                {
                    Day = i.ToString()
                };
                Calendar.Children.Add(c);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            day = day.AddMonths(1);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            day = day.AddMonths(-1);
        }

        private void UserView_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}