using LeAn_2011063130.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LeAn_2011063130.ViewModels
{
    public class CourseViewModel
    {
        public string Place { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public List<Category> Categories { get; internal set; }
    }
}