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
        [Required, StringLength(20)]
        public string Login { get; set; }
        [Required, StringLength(10)]
        public string Password { get; set; }
        [Required, StringLength(50)]
        public string FirstName { get; set; }
        [StringLength(50)]
        public string LastName { get; set; }
        [Required, StringLength(50)]
        public string Email { get; set; }
        public LinkType Link { get; set; }

        public virtual Account Account { get; set; }
    }

    public enum LinkType
    {
        Administrator = 1,
        Student = 2,
        Professor = 3,
        Employee = 4
    }
}
