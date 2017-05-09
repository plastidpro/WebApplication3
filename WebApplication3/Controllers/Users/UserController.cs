using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace WebApplication3.Controllers
{
    public class UserController : Controller
    {
        public ActionResult Index()
        {
            return View(InitilizeData());
        }

        [HttpPost]
        public ActionResult Index(UserViewModel model)
        {
            UserViewModel user = InitilizeData();
            user.SelectedGroups = model.SelectedGroups;
            //add code to manipulate user groups

            //foreach (var item in user.SelectedGroups)

            //{

            //    

            //}

            User userX = user.User;
            var json = new List<PeopleList>();
            List<Person> p1 = new List<Person> { new Person { name = "Name 1", age = 20 } };
            json.Add(new PeopleList { inputs = p1 });
            //List<Person> p2 = new List<Person> { new Person { name = "Name 2", age = 30 } };
            //json.Add(new PeopleList { inputs = p2 });

            string jsonString = JsonConvert.SerializeObject(json, Formatting.None, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore, Formatting = Formatting.Indented });
            string kek = JsonConvert.SerializeObject(userX);
            Debug.Write(JArray.Parse(jsonString));


            return View(user);
        }

        private UserViewModel InitilizeData()
        {
            UserViewModel userVM = new UserViewModel();
            userVM.User = new Models.User
            {
                ID = 1,
                Name = "Ahmed Omer",
                Password = "123123",
                Email = "a@b.c"

            };
            userVM.User.ID = 1;
            userVM.User.Name = "Ahmed Omer";
            userVM.User.Password = "123123";
            userVM.User.Email = "a@b.c";
            userVM.AllGroups = new List<Group>() {
                new Group {ID=1,Name="Group 1" },
                new Group {ID=2,Name="Group 2" },
                new Group {ID=3,Name="Group 3" },
                new Group {ID=4,Name="Group 4" },
                new Group {ID=5,Name="Group 5" }
            };

            userVM.UserGroups = new List<Group>()
            {
                userVM.AllGroups[4],
                userVM.AllGroups[1],
                userVM.AllGroups[2],
            };
            userVM.SelectedGroups = userVM.UserGroups.Select(x => x.ID).ToArray();
            return userVM;
        }
    }


    public class Container
    {
        public List<User> User { get; set; }
    }


    public class PeopleList
    {
        public List<Person> inputs { get; set; }
    }

    public class Person
    {
        public String name { get; set; }
        public int age { get; set; }
    }
}