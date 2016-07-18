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
using System.Windows.Shapes;
using System.Configuration;

namespace WpfPasswordManager
{
    /// <summary>
    /// Interaction logic for RegisterWindow.xaml
    /// </summary>
    public partial class RegisterWindow : Window
    {
        public RegisterWindow()
        {
            InitializeComponent();
        }

        private void onRegisterBtnClicked(object sender, RoutedEventArgs e)
        {
            Boolean inputCorrect = this.isInputCorrect(usernameField.Text, passwordField.Password, confirmPasswordField.Password);
            if (inputCorrect)
            {
                //save this information in configuration manager and close the window
                this.saveData(usernameField.Text, passwordField.Password);
                this.Close();
            }
            else
            {
                //show message box and clear the fields
                MessageBoxResult msgBoxResult = MessageBox.Show("Incorrect information. Please try again.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                this.clearFields(usernameField, passwordField, confirmPasswordField);
            }
        }

        private Boolean isInputCorrect(String username, String password, String confirmPassword)
        {
            if(String.IsNullOrEmpty(username) || String.IsNullOrEmpty(password) || String.IsNullOrEmpty(confirmPassword))
            {
                return false;
            }
            else if(password != confirmPassword)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void saveData(String username, String password)
        {
            ConfigurationManager.AppSettings.Set(username, password);
        }

        private void clearFields(TextBox usernameTextBox, PasswordBox passwordBox, PasswordBox confirmPasswordBox)
        {
            usernameTextBox.Text = "";
            passwordBox.Password = "";
            confirmPasswordBox.Password = "";
        }
    }
}
