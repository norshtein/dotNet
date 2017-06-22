using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Final.Models;

namespace Final.Service
{

    public class Authenticate
    {
        private static Dictionary<string, string> tokens = new Dictionary<string, string>();
        private Authenticate(){}

        public static bool isVaild(string code)
        {
            return tokens.ContainsKey(code);
        }

        public static string getToken(string username,string password)
        {
            tokens[username] = username;
            return username;
        }

        public static string getUsername(string token)
        {
            if(isVaild(token))
                return tokens[token];
            return null;
        }

        public static bool deleteToken(string token)
        {
            if(isVaild(token))
            {
                tokens.Remove(token);
                return true;
            }
            return false;
        }
    }
}