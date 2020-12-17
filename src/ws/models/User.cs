using System;
using System.Collections.Generic;
using Newtonsoft;
using Newtonsoft.Json.Linq;

namespace demo.wsclient 
{
    public class User 
    {
        public string email { get; set; }
        public string password { get; set; }
        public List<string> roles { get; set; }
    }
}