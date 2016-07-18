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
using System.Configuration;

namespace WpfPasswordManager
{
    public partial class LoginWindow : Window
    {
        
        public LoginWindow()
        {
            InitializeComponent();
            //Debug code
            ConfigurationManager.AppSettings.Set("test", "test");
        }

        private void onLoginClicked(object sender, RoutedEventArgs e)
        {
            String username = usernameTextBox.Text;
            String password = passwordBox.Password;
            String value = ConfigurationManager.AppSettings.Get(username);
            if(password == value)
            {
                //Close this window and open new window
                AccountListWindow accountListWindow = new AccountListWindow();
                accountListWindow.Show();
                this.Close();
                
            }
            else
            {
                // Show error message and clear fields
                MessageBoxResult msgBoxResult = MessageBox.Show("Incorrect information. Please try again.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                this.clearFields(usernameTextBox, passwordBox);
            }
        }

        private void onRegisterClicked(object sender, RoutedEventArgs e)
        {
            RegisterWindow registerWindow = new RegisterWindow();
            registerWindow.Show();
        }

        private void clearFields(TextBox usernameTextBox, PasswordBox passwordBox)
        {
            usernameTextBox.Text = "";
            passwordBox.Password = "";
        }
    }
}
