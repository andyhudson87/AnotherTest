using System.Windows;
using System.Reflection;

namespace AnotherTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Person _person;
        public MainWindow()
        {
            InitializeComponent();
            _person = new Person();
            textBoxFirstName.DataContext = _person;
            textBoxSurname.DataContext = _person;
            textBoxEmail.DataContext = _person;
        }

        private void buttonPopulate_Click(object sender, RoutedEventArgs e)
        {
            _person.FirstName = "Big John";
            _person.Surname = "Hudson";
            _person.Email = "big.john.hudson@tvsscs.com";
        }
    }
}
