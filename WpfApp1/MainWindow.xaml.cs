using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

/*namespace WpfApp1
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

        private void InkCanvas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.T)
                ToggleEditingMode();
        }
        private void ToggleEditingMode()
        {
            if (inkCanvas.EditingMode == InkCanvasEditingMode.Ink)
                inkCanvas.EditingMode = InkCanvasEditingMode.EraseByPoint;
            else
                inkCanvas.EditingMode = InkCanvasEditingMode.Ink;
        }

        private void ButtonRemoveClick(object sender, RoutedEventArgs e)
        {
            while (listView.SelectedItems.Count > 0)
            {
                persons.RemovePerson((PersonInformation)listView.SelectedItems[0]);
            }
        }


    }
}*/
