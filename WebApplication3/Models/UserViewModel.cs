using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class UserViewModel
    {
        public User User { get; set; }
        public List<Group> AllGroups { get; set; }
        public List<Group> UserGroups { get; set; }
        public int[] SelectedGroups { get; set; }
    }
}