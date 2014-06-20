using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace uniTunes.UI.ViewModels.Classes
{
    public class MenuItem
    {
        public MenuItem()
        { }

        public MenuItem(string name, string color, string action, string controller, string image)
        {
            Name = name;
            Color = color;
            Action = action;
            Controller = controller;
            Image = image;
        }

        public string Name { get; set; }
        public string Color { get; set; }
        public string Action { get; set; }
        public string Controller { get; set; }
        public string Image { get; set; }
    }
}