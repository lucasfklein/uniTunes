﻿using System;
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

        public MenuItem(string name, string color, string url, string image)
        {
            Name = name;
            Color = color;
            Url = url;
            Image = image;
        }

        public string Name { get; set; }
        public string Color { get; set; }
        public string Url { get; set; }
        public string Image { get; set; }
    }
}