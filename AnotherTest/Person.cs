using System.ComponentModel;

namespace AnotherTest
{
    class Person : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private string _firstName;
        private string _surname;
        private string _email;

        public Person(string firstName = "", string surname = "", string email = "")
        {
            _firstName = firstName;
            _surname = surname;
            _email = email;
        }

        public string FirstName
        {
            get { return _firstName; }
            set
            {
                if (!_firstName.Equals(value))
                {
                    _firstName = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(FirstName)));
                }
            }
        }

        public string Surname
        {
            get { return _surname; }
            set
            {
                if (!_surname.Equals(value))
                {
                    _surname = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Surname)));
                }
            }
        }

        public string Email
        {
            get { return _email; }
            set
            {
                if (!_email.Equals(value))
                {
                    _email = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Email)));
                }
            }
        }
    }
}
