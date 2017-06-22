using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Final.Models;

namespace Final.Service
{
    public class Context
    {
        private static NETEntities1 ctx = new NETEntities1();
        public static NETEntities1 getInstance()
        {
            return ctx;
        }
    }
}