using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace WpfPasswordManager
{
    class SQLiteDbHelper
    {
        private static SQLiteDbHelper instance = null;
        SQLiteConnection dbConnection;
        String create_table = "CREATE TABLE accounts (id INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL, title VARCHAR(20), username VARCHAR(20), password VARCHAR(20))";
        String insert_into_table = "INSERT INTO accounts (title, username, password) VALUES";
        String select_titles = "SELECT id, title FROM accounts";
        String select_with_id = "SELECT * FROM accounts WHERE id=";
        String update_account = "UPDATE accounts SET ";
        String delete_sql = "DELETE FROM accounts WHERE id=";

        public static SQLiteDbHelper getInstance()
        {
            if (SQLiteDbHelper.instance == null)
            {
                SQLiteDbHelper.instance = new SQLiteDbHelper();
            }
            return SQLiteDbHelper.instance;
        }

        private SQLiteDbHelper()
        {
            //if file doesn't exist
            SQLiteConnection.CreateFile("MyDatabase.sqlite");

            // connect to database
            this.dbConnection = new SQLiteConnection("Data Source=MyDatabase.sqlite;Version=3;");
            this.dbConnection.Open();

            // create a table
            SQLiteCommand command = new SQLiteCommand(create_table, dbConnection);
            command.ExecuteNonQuery();

            this.dbConnection.Close();
        }

        public void insert(String title, String username, String password)
        {
            this.dbConnection.Open();

            String insertSql = this.insert_into_table + "('" + title + "','" + username + "','" + password + "')"; 
            SQLiteCommand command = new SQLiteCommand(insertSql, dbConnection);
            command.ExecuteNonQuery();

           this.dbConnection.Close();
        }

        public List<AccountTitle> selectTitles()
        {
            this.dbConnection.Open();

            SQLiteCommand command = new SQLiteCommand(this.select_titles, dbConnection);
            SQLiteDataReader reader = command.ExecuteReader();
            List<AccountTitle> accountTitles = new List<AccountTitle>();
            while (reader.Read())
            {
                AccountTitle accountTitle = new AccountTitle((long)reader["id"], (String)reader["title"]);
                accountTitles.Add(accountTitle);
            }
            this.dbConnection.Close();
            return accountTitles;
        }

        public AccountDetails selectWithId(long id)
        {
            this.dbConnection.Open();

            String sql = this.select_with_id + id;
            SQLiteCommand command = new SQLiteCommand(sql, dbConnection);
            SQLiteDataReader reader = command.ExecuteReader();
            AccountDetails accountDetails = new AccountDetails();
            while (reader.Read())
            {
                accountDetails.Id = (long)reader["id"];
                accountDetails.Title = (String)reader["title"];
                accountDetails.Username = (String)reader["username"];
                accountDetails.Password = (String)reader["password"];
            }
            this.dbConnection.Close();
            return accountDetails;
        }

        public void update(AccountDetails accountDetails)
        {
            this.dbConnection.Open();

            String updateSql = this.update_account + "title='" + accountDetails.Title + "',username='" + accountDetails.Username + "',password='" + accountDetails.Password + "' WHERE id=" + accountDetails.Id;
            SQLiteCommand command = new SQLiteCommand(updateSql, dbConnection);
            command.ExecuteNonQuery();
            this.dbConnection.Close();
        }

        public void delete(long id)
        {
            this.dbConnection.Open();

            String deleteSql = this.delete_sql + id;
            SQLiteCommand command = new SQLiteCommand(deleteSql, dbConnection);
            command.ExecuteNonQuery();
            this.dbConnection.Close();
        }
    }
}
