using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uniTunes.Models
{
    public abstract class IMedia
    {
        [Key]
        public int MediaId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public Academic Author { get; set; }
        public DateTime CreatedOn { get; set; }

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
