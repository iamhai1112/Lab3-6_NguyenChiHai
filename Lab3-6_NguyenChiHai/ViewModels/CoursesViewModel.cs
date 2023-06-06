using Lab3_6_NguyenChiHai.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab3_6_NguyenChiHai.ViewModels
{
    public class CoursesViewModel
    {
        public IEnumerable<Course> UpcommingCourses { get; set; }
        public bool ShowAction { get; set; }
    }
}