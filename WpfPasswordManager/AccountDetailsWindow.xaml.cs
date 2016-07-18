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

namespace WpfPasswordManager
{
    /// <summary>
    /// Interaction logic for AccountDetailsWindow.xaml
    /// </summary>
    public partial class AccountDetailsWindow : Window
    {
        State currentState;
        public enum State {Add, Edit};
        public AccountDetails accountDetails;

        public AccountDetailsWindow(State state)
        {
            InitializeComponent();
            this.currentState = state;
            
        }

        public AccountDetailsWindow(State state, long accountId)
        {
            InitializeComponent();
            this.currentState = state;
            if(this.currentState == State.Edit)
            {
                SQLiteDbHelper sqLiteDbHelper = SQLiteDbHelper.getInstance();
                this.accountDetails = sqLiteDbHelper.selectWithId(accountId);
                this.fillFields(accountDetails);
            }
        }

        public void onSaveBtnClicked(object sender, RoutedEventArgs e)
        {
            SQLiteDbHelper sqLiteDbHelper = SQLiteDbHelper.getInstance();
            if (this.currentState == State.Add)
            {
                sqLiteDbHelper.insert(titleField.Text, usernameField.Text, passwordField.Password);
            }
            else
            {
                AccountDetails updatedAccountDetails = new AccountDetails(this.accountDetails.Id, titleField.Text, usernameField.Text, passwordField.Password);
                sqLiteDbHelper.update(updatedAccountDetails);
            }
            
            this.Close();
        }

        public void fillFields(AccountDetails accountDetails)
        {
            titleField.Text = accountDetails.Title;
            usernameField.Text = accountDetails.Username;
            passwordField.Password = accountDetails.Password;
        }
    }
}
