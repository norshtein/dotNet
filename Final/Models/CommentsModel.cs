using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Final.Models
{
    public class CommentsModel
    {
        public int CommentId { get; set; }
        public Nullable<int> UserId { get; set; }
        public Nullable<int> PostId { get; set; }
        public string Content { get; set; }
        public Nullable<System.DateTime> Time { get; set; }
    }
}