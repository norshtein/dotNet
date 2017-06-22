using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Final.Models
{
    public class PostModel
    {
        public int PostId { get; set; }
        public Nullable<int> UserId { get; set; }
        public Nullable<int> GroupId { get; set; }
        public byte[] Content { get; set; }
        public Nullable<System.DateTime> Time { get; set; }
        public string Title { get; set; }
        public Nullable<int> StarNum { get; set; }
    }
}