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

namespace practice_6
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private Pair pair1;
        private Pair pair2;

        private void calculate(object sender, RoutedEventArgs e)
        {
            pair1 = new Pair(int.Parse(firstP1.Text), int.Parse(secondP1.Text));
            pair2 = new Pair(int.Parse(firstP2.Text), int.Parse(secondP2.Text));
            Pair result = pair1 + pair2;
            rez.Text = result.First + ", " + result.Second;
        }

        private void exit(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void info(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("ИСП-34, Горшков Илья, Вариант 2. Использовать класс Pair (пара чисел). Разработать операцию сложения пар (a, b) + (c, d) = (a + c, b + d). Разработать операцию уменьшения полей на 1.");
        }

        private void reset(object sender, RoutedEventArgs e)
        {
            rez.Clear();
            firstP1.Clear();
            secondP1.Clear();
            secondP2.Clear();
            firstP2.Clear();
            secondP2.Clear();
            firstP3.Clear();
            secondP3.Clear();
        }

        private void decrease(object sender, RoutedEventArgs e)
        {
            pair1 = new Pair(int.Parse(firstP1.Text), int.Parse(secondP1.Text));
            Pair result = --pair1;
            rez.Text = result.First + ", " + result.Second; ;
        }    
    }
}
