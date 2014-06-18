using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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

        [Required, StringLength(200)]
        public string Question { get; set; }

        [Required, StringLength(200)]
        public string Answer { get; set; }

        public double Balance { get; set; }

        public LinkType Link { get; set; }

        public virtual List<Credit> Historic { get; set; }
    }

    public enum LinkType
    {
        Administrator = 1,
        Student = 2,
        Professor = 3,
        Employee = 4
    }
}
