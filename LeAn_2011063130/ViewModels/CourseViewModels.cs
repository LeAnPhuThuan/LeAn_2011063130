using LeAn_2011063130.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LeAn_2011063130.ViewModels
{
    public class CourseViewModel
    {
        [Required] 
        public string Place { get; set; }
        [Required]
        [FutureDate]
        public string Date { get; set; }
        [Required]
        [ValidTime]
        public string Time { get; set; }
        public List<Category> Categories { get; internal set; }
        [Required]
        public byte Category { get; internal set; }

        internal DateTime GetDateTime()
        {
            throw new NotImplementedException();
        }
    }
}