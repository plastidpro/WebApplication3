using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace WebApplication3.Models
{

    public class User
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public ICollection<Group> Groups { get; set; }
    }

    public class Group
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public ICollection<User> Users { get; set; }
    }
}