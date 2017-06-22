using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Final.Models;

namespace Final.Service
{
    public class PostService
    {
        public static string getAllPost(string username)
        {
            var ctx = Context.getInstance();
            var query = from p in ctx.post
                        join u in ctx.user
                        on p.userId equals u.userId
                        select new 
                        {
                            username = u.userName,
                            avatar = u.avatar,
                            time = p.time,
                            title = p.title,
                            content = p.content,
                            starNum = p.starNum,
                            star = (from s in ctx.star
                                    where s.postId == p.postId && s.userName == u.userName && s.userName == username
                                    select s).Count() != 0
                        };
            return query.ToArray().ToString();
        }

        public static string getPostById(string username,int postid)
        {
            var ctx = Context.getInstance();
            return null;
        }
    }
}