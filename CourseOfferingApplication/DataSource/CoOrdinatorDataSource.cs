using CourseOfferingApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseOfferingApplication.DataSource
{
    public class CoordinatorDataSource
    {
        public List<Course> GetCourses()
        {
            List<Course> courses = new List<Course>();
            courses.Add(new Course
            {
                Id = 1,
                Name = "Physics",
                Description="Physics"
            });
            courses.Add(new Course
            {
                Id = 2,
                Name = "Chemistry",
                Description = "Chemistry"
            });
            courses.Add(new Course
            {
                Id = 3,
                Name = "Maths",
                Description = "Maths"
            });
            courses.Add(new Course
            {
                Id = 4,
                Name = "Biology",
                Description = "Biology"
            });
            return courses;
        }
    }
}
