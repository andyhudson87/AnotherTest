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
        }

        private void buttonSubmit_Click(object sender, RoutedEventArgs e)
        {
            _person.FirstName = "Big John";
        }
    }
}
