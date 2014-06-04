using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace uniTunes.UI.ViewModels
{
    public class HomeViewModel
    {
        public List<MenuItem> Menus { get; set; }
    }

    public class MenuItem
    {
        public MenuItem()
        { }

        public MenuItem(string k, string n, string c, string u)
        {
            Key = k;
            Name = n;
            Color = c;
            Url = u;
        }

        public string Key { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public string Url { get; set; }
    }
}