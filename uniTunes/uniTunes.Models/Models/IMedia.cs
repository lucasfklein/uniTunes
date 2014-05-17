using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uniTunes.Models.Models;

namespace uniTunes.Models
{
    public abstract class IMedia
    {
        public string Name;
        public string Description;
        public double Price;
        public Academic Author;
        public DateTime CreatedOn;

        public bool IsFree
        { 
            get 
            { 
                return (Price <= 0); 
            } 
        }
    }

    public class Music : IMedia
    {
        public int Length { get; set; }
    }

    public class Podcast : IMedia
    {
        public int Length { get; set; }
    }

    public class Book : IMedia
    {
        public int Pages { get; set; }
    }
}
