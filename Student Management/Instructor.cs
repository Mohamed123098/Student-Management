using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Management
{
    public class Instructor
    {
        public int InstructorId { get; set; }
        public string Name { get; set; }
        public string Specialization { get; set; }
        public List<Course>? Courses { get; set; } = new();
        public string PrintDetails()
        {
            return $"InstructorId : {InstructorId} | Name : {Name} | Specialization : {Specialization}";
        }
        public bool Enroll(Course course)
        {
            if (course != null || Courses.Find(c => c.CourseId == course.CourseId) == null)
            {
                Courses.Add(course);
                return true;
            }
            return false;
        }
    }
}
