using System.Windows;
using System.Reflection;

namespace AnotherTest
{ // http://www.codeproject.com/Articles/873592/Tutorial-for-a-Basic-WPF-MVVM-Project-Using-Entity
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Person _person;
        DatabaseContext _context;
        public MainWindow()
        {
            InitializeComponent();
            _person = new Person();
            _context = new DatabaseContext();
        }

        private void buttonPopulate_Click(object sender, RoutedEventArgs e)
        {
            _context.Persons.Add(new Person("John", "Big", "big.john@john.com"));
        }
    }
}
