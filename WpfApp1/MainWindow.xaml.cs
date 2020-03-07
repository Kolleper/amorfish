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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly PersonCollection persons;
        public MainWindow()
        {
            InitializeComponent();
            persons = new PersonCollection();
            DataContext = persons;
        }

        private void ButtonAddClick(object sender, RoutedEventArgs e)
        {
            persons.AddNewPerson();
        }
        private void ButtonRemoveClick(object sender, RoutedEventArgs e)
        {
            while (listView.SelectedItems.Count > 0)
            {
                persons.RemovePerson((PersonInformation)listView.SelectedItems[0]);
            }
        }
        //private void DatePicker_SelectedChanged(object sender, SelectionChangedEventArgs e)
        //{
        //    DateTime? selectedDate = calendar1.SelectedDate;

        //    MessageBox.Show(selectedDate.Value.Date.ToShortDateString());
        //}

    }
}
