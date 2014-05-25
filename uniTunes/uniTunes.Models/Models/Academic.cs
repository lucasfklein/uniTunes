using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace uniTunes.Models
{
    public partial class Academic
    {
        [Key]
        public int AcademicId { get; set; }
        [Required]
        public string Login { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; }        
        public Account Balance { get; set; }
        public LinkType Link { get; set; }
    }

    public enum LinkType
    {
        Administrator = 1,
        Student = 2,
        Author = 3
    }
}
