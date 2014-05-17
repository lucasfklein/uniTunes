using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uniTunes.Models.Models
{
    public class Academic
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }        

        public Balance Balance { get; set; }
        public LinkType Link { get; set; }
    }

    public enum LinkType
    {
        Administrator = 1,
        Student = 2,
        Author = 3
    }
}
