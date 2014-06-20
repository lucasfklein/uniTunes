using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uniTunes.Models
{
    public partial class Media
    {
        [Key, ScaffoldColumn(false)]
        public int MediaId { get; set; }

        [DisplayName("Academic")]
        public int AcademicId { get; set; }
        
        [StringLength(100)]
        public string Name { get; set; }
        [StringLength(250)]
        public string Description { get; set; }

        [Range(0.00, 100.0)]
        public double Price { get; set; }
        
        public DateTime CreatedOn { get; set; }
        public byte[] File { get; set; }
        public int Length { get; set; }
        public MediaType MediaType {get; set;}

        public bool IsFree
        {
            get
            {
                return (Price <= 0);
            }
        }

        public virtual Academic Author { get; set; }
    }

    public enum MediaType
    {
        Music = 0,
        Podcast = 1,
        Book = 2,
        Video = 3
    }
}
