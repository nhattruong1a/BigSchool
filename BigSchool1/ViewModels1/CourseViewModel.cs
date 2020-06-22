using System;
using BigSchool1.ViewModels1;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BigSchool1.Models;
using System.ComponentModel.DataAnnotations;

namespace BigSchool1.ViewModels1
{
    public class CourseViewModel
    {
        [Required]
        public string Place { get; set; }
        [Required]
        [FutureDate]
        public string Date { get; set; }
        [Required]
        public string Time { get; set; }
        [Required]
        public byte Category { get; set; }
        public IEnumerable<Category> Categories { get; set; }

        public DateTime GetDateTime()
        {
            return DateTime.Parse(string.Format("{0} {1}",Date,Time));
        }

        private class FutureDateAttribute : ValidationAttribute
        {

        }
    }
}