using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Final.Models
{
    public class UserModel
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Avatar { get; set; }
        public string Signature { get; set; }
        public string Password { get; set; }
    }
}