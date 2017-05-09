using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication3.Code
{
    public class Utils
    {
        public static IList<SelectListItem> GetFruits()
        {
            return new List<SelectListItem>
            {
                new SelectListItem {Text = "Apple", Value = "Apple"},
                new SelectListItem {Text = "Pear", Value = "Pear"},
                new SelectListItem {Text = "Banana", Value = "Banana"},
                new SelectListItem {Text = "Orange", Value = "Orange"},
            };
        }
    }
}