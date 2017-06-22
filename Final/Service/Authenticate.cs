using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Final.Models;

namespace Final.Service
{

    public class Authenticate
    {
        private static HashSet<string> tokens = new HashSet<string>();
        private Authenticate(){}

        public static bool isVaild(string code)
        {
            return tokens.Contains(code);
        }

        public static string getToken(string username,string password)
        {
            return null;
        }
    }
}