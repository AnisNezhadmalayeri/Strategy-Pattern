using Exercise;
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

namespace Strategy
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
        int[] arr = new int[10000];
        Sorter sorter = new Sorter();
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int Min = 0;
            Random randNum = new Random();
            for (int i = 0; i < Convert.ToInt32(CountNumber.Text); i++)
            {
                arr[i] = randNum.Next(Min, Convert.ToInt32(CountNumber.Text));
            }
            Logger.Text += "Array={";
            for (int i = 0; i <= Convert.ToInt32(CountNumber.Text); i++)
            {
                if (i != Convert.ToInt32(CountNumber.Text))
                    Logger.Text += arr[i] + ",";
                else
                    Logger.Text += arr[i] + "}";
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            sorter.sortAlgorithm = (ISortAlgorithm)Way.SelectedItem;
            long Duration = sorter.Sort(arr);
            Logger.Text += "\n Time for sort array is'" + Duration + "'.";
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            Way.Items.Add(new QuickSort());
            Way.Items.Add(new BubbleSort());
        }

    }
}
