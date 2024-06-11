using System.Windows;
using System.Windows.Input;
using testapp.Model;
using TESTAPP.Model;
using TESTAPP.Database;

namespace TESTAPP.ViewModel
{
    public class RegistryViewModel : Notify
    {
        private string _email;
        private string _password;
        private string _confirmPassword;
        public string Email
        {
            get => _email;
            set
            {
                _email = value;
                OnPropertyChanged();
                
            }
        }
        public string Password
        {
            get => _password;
            set
            {
                _password = value;
                OnPropertyChanged();
            }
        }

        public string ConfirmPassword
        {
            get => _confirmPassword;
            set
            {
                _confirmPassword = value;
                OnPropertyChanged();
            }
        }

        private readonly DatabaseContext _dbContext;

        public ICommand RegButton {  get; set; }
        public RegistryViewModel()
        {
            RegButton = new CommandAction(Register);
        }

        private void Register()
        {

            if (string.IsNullOrEmpty(Email))
            {
                MessageBox.Show("Please enter your email.");
                return;
            }
            if (string.IsNullOrEmpty(Password))
            {
                MessageBox.Show("Please enter your password.");
                return;
            }
            if (string.IsNullOrEmpty(ConfirmPassword))
            {
                MessageBox.Show("Please confirm your password.");
                return;
            }
            if (Password != ConfirmPassword)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }
            if (Password.Length < 6)
            {
                MessageBox.Show("Password should be at least 6 characters long.");
                return;
            }

            User newUser = new User()
            {
                Email = Email,
                Password = Password
            };

            _dbContext.Users.Add(newUser);
            _dbContext.SaveChanges();
            MessageBox.Show($"Registration successful! Email: {Email}, Password: {Password}");
        }

    }
}
