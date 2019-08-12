using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace XamarinActivities.ViewModel
{
    public class ContactViewModel : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;
        private void onPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        private string _firstName;
        [NotNull]
        public string FirstName
        {
            get { return _firstName; }
            set
            {
                if (_firstName == value)
                {
                    return;
                }

                _firstName = value;
                onPropertyChanged();
                onPropertyChanged(FullName);
            }
        }


        private string _lastName;
        [NotNull]
        public string LastName
        {
            get { return _lastName; }
            set
            {
                if (_lastName == value)
                {
                    return;
                }

                _lastName = value;
                onPropertyChanged();
                onPropertyChanged(FullName);
            }
        }

        public string FullName
        {
            get
            {
                return String.Format("{0} {1}", FirstName, LastName);
            }
        }

        public string Initials
        {
            get
            {
                return String.Format("{0}{1}", FirstName[0], LastName[0]);
            }
        }

        private string _mobileNumber;
        [NotNull]
        public string MobileNumber
        {
            get { return _mobileNumber; }
            set
            {
                if(_mobileNumber == value)
                {
                    return;
                }
                _mobileNumber = value;
                onPropertyChanged();
            }
        }

        private string _emailAddress;
        public string EmailAddress
        {
            get { return _emailAddress; }
            set
            {
                if(_emailAddress == value)
                {
                    return;
                }
                _emailAddress = value;
                onPropertyChanged();
            }
        }

        private string _facebookLink;
        public string FacebookLink
        {
            get { return _facebookLink; }
            set
            {
                if(_facebookLink == value)
                {
                    return;
                }
                _facebookLink = value;
                onPropertyChanged();
            }
        }

        private string _instagramLink;
        public string InstagramLink
        {
            get { return _instagramLink; }
            set
            {
                if(_instagramLink == value)
                {
                    return;
                }
                _instagramLink = value;
                onPropertyChanged();
            }
        }

    }
}
