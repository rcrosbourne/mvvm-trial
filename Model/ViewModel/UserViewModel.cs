using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using Model;

namespace ViewModel
{
    public class UserViewModel : INotifyPropertyChanged
    {
        private IEnumerable<User> users;
        public IEnumerable<User> Users {
            get
            {
                return users;
            }
            set
            {
                this.users = value;
                this.OnPropertyChanged("Users");
            }
        }
        public UserViewModel()
        {
            User us = new User(); //Get the data loaded
            this.users = us.FindAll();
        }
        private void OnPropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
