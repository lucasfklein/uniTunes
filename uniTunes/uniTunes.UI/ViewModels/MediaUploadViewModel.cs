using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using uniTunes.Models;

namespace uniTunes.UI.ViewModels
{
    public class MediaUploadViewModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public double Price { get; set; }   
        [Required]
        public HttpPostedFileBase File { get; set; }
        [Required]
        public int Length { get; set; }
        [Required]
        public MediaType MediaType { get; set; }
    }
}