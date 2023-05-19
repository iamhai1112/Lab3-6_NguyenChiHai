using Lab3_6_NguyenChiHai.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab3_6_NguyenChiHai.ViewModels
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
            return DateTime.Parse(string.Format("{0} {1}", Date, Time));
        }
    }
}