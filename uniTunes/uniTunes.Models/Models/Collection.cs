using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uniTunes.Models
{
    public class Collection
    {
        public int Id { get; set; }
        public int AcademicId { get; set; }
        public List<Media> Favorites { get; set; }
        public List<Media> Purchased { get; set; }
    }
}
