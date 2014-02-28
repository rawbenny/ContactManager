using System;

namespace ContactManager.Model
{
    [Serializable]
    public class Contact : Notifier
    {
        private string _name;
        private int _age;
        private string _address;
        private string _cellPhone;
        private string _homePhone;        
        private Guid _id = Guid.Empty;
        private string _imagePath;
        private string _studentId;        
        private string _grade;
        private string _email;

        public Guid Id
        {
            get { return _id; }
            set
            {
                _id = value;
                OnPropertyChanged("Id");
            }
        }

        public string ImagePath
        {
            get { return _imagePath; }
            set
            {
                _imagePath = value;
                OnPropertyChanged("ImagePath");
            }
        }

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged("Name");

            }
        }

        public int Age
        {

            get { return _age; }
            set
            {
                _age = value;
                OnPropertyChanged("Age");
            }
        }

        public string Grade
        {
            get { return _grade; }
            set
            {
                _grade = value;
                OnPropertyChanged("Grade");
            }
        }

        public string StudentId
        {
            get { return _studentId; }
            set
            {
                _studentId = value;
                OnPropertyChanged("StudentId");
            }
        }

        

        public string CellPhone
        {
            get { return _cellPhone; }
            set
            {
                _cellPhone = value;
                OnPropertyChanged("CellPhone");
            }
        }

        public string HomePhone
        {
            get { return _homePhone; }
            set
            {
                _homePhone = value;
                OnPropertyChanged("HomePhone");
            }
        }

        public string Email
        {
            get { return _email; }
            set
            {
                _email = value;
                OnPropertyChanged("Email");
            }
        }


        public string Address
        {
            get { return _address; }
            set
            {
                _address = value;
                OnPropertyChanged("Address");
            }
        }

        public override string ToString()
        {
            return Name;
        }

        public override bool Equals(object obj)
        {
            Contact other = obj as Contact;
            return other != null && other.Id == Id;
        }
        public override int GetHashCode()
        {
            int hash = 17;
            // hash += CellPhone.GetHashCode();
            //hash += HomePhone.GetHashCode();
            return hash;
        }
    }
}