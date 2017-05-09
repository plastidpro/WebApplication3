using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace WebApplication3.Models
{
    public class HomeModel
    {
        public IList<string> SelectedFruits { get; set; }
        public IList<SelectListItem> AvailableFruits { get; set; }
        public ICollection<CheckBox> RequeredScalesCollection { get; set; }

        public HomeModel()
        {
            SelectedFruits = new List<string>();
            AvailableFruits = new List<SelectListItem>();
            RequeredScalesCollection = new List<CheckBox>()
            {
                new CheckBox()
                {
                    Text = "100"
                },
                new CheckBox()
                {
                    Text = "200"
                },
                new CheckBox()
                {
                    Text = "300"
                }
            };
        }
    }
}