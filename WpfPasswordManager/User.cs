using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfPasswordManager
{
    class User
    {
        long id;
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

        public User()
        {

        }

        public User(long id, String username, String password)
        {
            Id = id;
            Username = username;
            Password = password;
        }
    }
}
