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
using System.Windows.Shapes;

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для TaskWindow.xaml
    /// </summary>
    public partial class TaskWindow : Window
    {
        public TaskWindow()
        {
            InitializeComponent();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ListBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ListBoxItem_Selected(object sender, RoutedEventArgs e)
        {

        }

       
            private void grid_Loaded(object sender, RoutedEventArgs e)
        {
            List<MyTable> result = new List<MyTable>(3);
            result.Add(new MyTable(1, "PROVERKA", "Zody Aeller", "NOK", "C", "104.00", "2.13", "3", "United States"));
            result.Add(new MyTable(2, "PROVERKA", "Zody Aeller", "NOK", "C", "104.00", "2.13", "3", "United States"));
            result.Add(new MyTable(3, "PROVERKA", "Zody Aeller", "NOK", "C", "104.00", "2.13", "3", "United States"));
            result.Add(new MyTable(4, "PROVERKA", "Zody Aeller", "NOK", "C", "104.00", "2.13", "3", "United States"));
            result.Add(new MyTable(5, "PROVERKA", "Zody Aeller", "NOK", "C", "104.00", "2.13", "3", "United States"));
            result.Add(new MyTable(6, "PROVERKA", "Zody Aeller", "NOK", "C", "104.00", "2.13", "3", "United States"));
            grid.ItemsSource = result;
        }

            private void grid_MouseUp(object sender, MouseButtonEventArgs e)
            {
                MyTable path = grid.SelectedItem as MyTable;
                MessageBox.Show(" ID: " + path.Id + "\n Исполнитель: " + path.No + "\n Альбом: " + path.Name
                    + "\n Год: " + path.Team);
            }

            private void grid_SelectionChanged(object sender, SelectionChangedEventArgs e)
            {

            }

    }

    class MyTable
    {
        public MyTable(int Id, string No, string Name, string Team, string Position, string Height, string Weight, string Experience, string Country)
        {
            this.Id = Id;
            this.No = No;
            this.Name = Name;
            this.Team = Team;
            this.Position = Position;
            this.Weight = Weight;
            this.Height = Height;
            this.Experience = Experience;
            this.Country = Country;
        }
        public int Id { get; set; }
        public string No { get; set; }
        public string Name { get; set; }
        public string Team { get; set; }
        public string Position { get; set; }
        public string Weight { get; set; }
        public string Height { get; set; }
        public string Experience { get; set; }
        public string Country { get; set; }
    }
}
