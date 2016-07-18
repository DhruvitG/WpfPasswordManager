using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfPasswordManager
{
    public class AccountDetails
    {
        long id;
        String title;
        String username;
        String password;

        public long Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Title
        {
            get
            {
                return title;
            }

            set
            {
                title = value;
            }
        }

        public string Username
        {
            get
            {
                return username;
            }

            set
            {
                username = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }

        public AccountDetails() {}

        public AccountDetails(long id, String title, String username, String password)
        {
            this.id = id;
            this.title = title;
            this.username = username;
            this.password = password;
        }
    }
}
