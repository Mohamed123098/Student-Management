using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Management
{
    public class Student
    {
        public int StudentId { get; set; } 
        public string Name { get; set; }
        public int Age { get; set; }
        public List<Course>? Courses { get; set; } = new();

        public  bool Enroll(Course course)
        {
            if (course != null||Courses.Find(c=>c.CourseId==course.CourseId)==null)
            {
                Courses.Add(course);
                return true;
            }
            return false;
        }
        public string PrintDetails()
        {
            return $"StudentId : {StudentId} | Name : {Name} | Age : {Age}| Courses [ {GetCourses()}]";
             

        }
        public string GetCourses()
        {
            String coursesNames = "";
            foreach (var item in Courses)
            {
                coursesNames+=(item.Title.ToString())+"|";
            }
            return coursesNames;
        }
    }
}
