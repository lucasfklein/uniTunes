using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uniTunes.Models
{
    public partial class Music
    {
        [Key]
        public int MusicId { get; set; }
        public Media Media { get; set; }
        public int Length { get; set; }
    }
}
