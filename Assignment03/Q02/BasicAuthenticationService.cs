using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

enum ServiceRoles
{
    general_user1, general_user2, general_user3
}


namespace Assignment03.Q02
{
    internal class BasicAuthenticationService :IAuthenticationService
    {
        private string _username, _password;
        private ServiceRoles _serviceRoles;

        public BasicAuthenticationService(string username, string password, ServiceRoles serviceRoles)
        {
            _username = username;
            _password = password;
            _serviceRoles = serviceRoles;
        }



        public bool AuthenticateUser(string username, string password)
        {
            if ((String.Compare(username, _username) == 0) && (String.Compare(password, _password) == 0))
            {
                return true;
            }

            else
            {
                return false;
            }

        }


        public bool AuthorizeUser(ServiceRoles userAuthorityRole)
        {
            if (userAuthorityRole == _serviceRoles)
            {
                return true;
            }

            else
            {
                return false;
            }
        }

    }
}
