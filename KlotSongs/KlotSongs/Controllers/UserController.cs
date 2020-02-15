using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace KlotSongs.Controllers
{
    public class UserController
    {
        public Exception Error { get; private set; }

        //public User LoggedInUser {get; private set}

        public bool TryLogin(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username))
                return false;

            if (string.IsNullOrWhiteSpace(password))
                return false;

            SHA1 sha1 = SHA1.Create();
            string hashedPassword = Encoding.UTF8.GetString(sha1.ComputeHash(Encoding.UTF8.GetBytes(password)));

            try
            {
                //call db service
            }
            catch (Exception e)
            {
                Error = e;
                return false;
            }

            Error = null;
            return true;
        }

        public bool TryRegister(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username))
                return false;

            if (string.IsNullOrWhiteSpace(password))
                return false;

            SHA1 sha1 = SHA1.Create();
            string hashedPassword = Encoding.UTF8.GetString(sha1.ComputeHash(Encoding.UTF8.GetBytes(password)));

            try
            {
                //call db service
            }
            catch (Exception e)
            {
                Error = e;
                return false;
            }

            Error = null;
            return true;
        }
    }
}
