using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using uniTunes.Models;

namespace uniTunes.UI.ViewModels
{
    public class BuyCreditViewModel
    {
        [Required]
        public CreditType CreditType { get; set; }
        
        [Required, Range(1.00, 100.00, ErrorMessage = "O valor deve estar entre 1 e 100.0")]
        public double Price {get; set;}
    }
}