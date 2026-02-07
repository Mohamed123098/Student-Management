using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Management
{
    public class Course
    {
        public int CourseId { get; set; }
        public string Title { get; set; }
        public List<Instructor> Instructors { get; set; } = new();
        public List<Student>? Students { get; set; } = new();

        

        public string PrintDetails()
        {
            return $"CourseId {CourseId}| Title : {Title} | Instructor Name :{GetInstructors()}";
        }
        public string GetInstructors()
        {
            String coursesNames = "";
            foreach (var item in Instructors)
            {
                coursesNames += (item.Name.ToString()) + "|";
            }
            return coursesNames;
        }
        public  bool Enroll<T>(T t)
        {
            if (t is Student student)
            {
                if (student != null || Students.Find(s => s.StudentId == student.StudentId) == null)
                {
                    Students.Add(student);
                    return true;
                }
                
            }
            else if(t is Instructor instructor)
            {
                if (instructor != null || Instructors.Find(i => i.InstructorId == instructor?.InstructorId) == null)
                {
                    Instructors.Add(instructor);
                    return true;
                }
                
            }
            return false;
        }
        
    }
}
