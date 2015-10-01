using System.ComponentModel;

namespace AnotherTest
{
    class Person : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private string _firstName;
        public string FirstName
        {
            get { return _firstName; }
            set
            {
                if (!_firstName.Equals(value))
                {
                    _firstName = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("FirstName"));
                    }
                }
            }
        }

        private string _surname;
        public string Surname
        {
            get { return _surname; }
            set
            {
                if (!_surname.Equals(value))
                {
                    _surname = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("Surname"));
                    }
                }
            }
        }

        private string _email;
        public string Email
        {
            get { return _email; }
            set
            {
                if (!_email.Equals(value))
                {
                    _email = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("Email"));
                    }
                }
            }
        }

        public Person(string firstName = "", string surname = "", string email = "")
        {
            _firstName = firstName;
            _surname = surname;
            _email = email;
        }
    }
}
