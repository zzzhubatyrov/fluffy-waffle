using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using testapp.Model;

namespace TESTAPP.Model
{
    public class User : Notify
    {
        private int _id;
        private string _name;
        private string _email;
        private string _password;
        private string _role;
        private string[] _shoppingCart;

        public int Id
        {
            get => _id;
            set
            {
                Id = value;
                OnPropertyChanged();
            }
        }
        public string Name
        {
            get => _name;
            set
            {
                Name = value;
                OnPropertyChanged();
            }
        }
        public string Email
        {
            get => _email;
            set
            {
                Email = value;
                OnPropertyChanged();
            }
        }
        public string Password
        {
            get => _password;
            set
            {
                Password = value;
                OnPropertyChanged();
            }
        }
        public string Role
        {
            get => _role;
            set
            {
                Role = value;
                OnPropertyChanged();
            }
        }
        public string[] ShoppintCart
        {
            get => _shoppingCart;
            set
            {
                ShoppintCart = value;
                OnPropertyChanged();
            }
        }
    }
}
