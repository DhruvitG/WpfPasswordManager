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
    /// Interaction logic for AccountListWindow.xaml
    /// </summary>
    public partial class AccountListWindow : Window
    {
        SQLiteDbHelper sqLiteDbHelper;

        public AccountListWindow()
        {
            InitializeComponent();
            this.sqLiteDbHelper = SQLiteDbHelper.getInstance();
            this.showAllAccounts();
        }

        private void onAddAccountBtnClicked(object sender, RoutedEventArgs e)
        {
            AccountDetailsWindow accountDetailsWindow = new AccountDetailsWindow(AccountDetailsWindow.State.Add);
            accountDetailsWindow.Closed += this.onAccountDetailsWindowClosed;
            accountDetailsWindow.Show();
            
        }

        private void onAccountDetailsWindowClosed(object sender, EventArgs e)
        {
            this.showAllAccounts();
        }

        public void showAllAccounts()
        {
            List<AccountTitle> accountTitles = this.sqLiteDbHelper.selectTitles();
            lvDataBinding.ItemsSource = accountTitles;
        }

        public void onEditBtnClicked(object sender, RoutedEventArgs e)
        {
            Button editBtn = (Button)sender;
            AccountTitle accountTitle = (AccountTitle)editBtn.DataContext;
            AccountDetailsWindow accountDetailsWindow = new AccountDetailsWindow(AccountDetailsWindow.State.Edit, accountTitle.id);
            accountDetailsWindow.Closed += this.onAccountDetailsWindowClosed;
            accountDetailsWindow.Show();
        }

        public void onDeleteBtnClicked(object sender, RoutedEventArgs e)
        {
            Button deleteBtn = (Button)sender;
            AccountTitle accountTitle = (AccountTitle)deleteBtn.DataContext;
            this.sqLiteDbHelper.delete(accountTitle.id);
            this.showAllAccounts();
        }
    }
}
