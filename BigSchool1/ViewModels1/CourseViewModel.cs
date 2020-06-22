using System;
using BigSchool1.ViewModels1;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BigSchool1.Models;

namespace BigSchool1.ViewModels1
{
    public class CourseViewModel
    {
        public string Place { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public byte Category { get; set; }
        public IEnumerable<Category> Categories { get; set; }

        public DateTime GetDateTime()
        {
            return DateTime.Parse(string.Format("{0} {1}"));
        }
    }
}