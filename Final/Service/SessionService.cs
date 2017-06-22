using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Final.Service
{
    public class SessionService
    {
        public static string getSession(string username,string password)
        {
            if (UserService.checkVaild(username, password))
                return Authenticate.getToken(username,password);
            return null;
        }

        public static bool deleteSession(string token)
        {
            if (Authenticate.isVaild(token))
            {
                Authenticate.deleteToken(token);
                return true;
            }
            return false;
        }
    }
}