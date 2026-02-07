using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Management
{
    public class School
    {
        public List<Student> Students { get; set; } = new();
        public List<Instructor> Instructors { get; set; } = new();
        public List<Course> Courses { get; set; } = new();


        /*
            • bool AddStudent(Student student)
            • bool AddCourse(Course course)
            • bool AddInstructor(Instructor instructor)
            • Student FindStudent(int studentId)
            • Course FindCourse(int courseId)
            • Instructor FindInstructor(int instructorId)
            • bool EnrollStudentInCourse(int studentId, int courseId)
         */
        public bool AddStudent(Student student)
        {
            if(student!=null ||Students.Find(s=>s.StudentId==student.StudentId)==null)
            {
                Students.Add(student);
                return true;
            }
            return false;
        }

        public bool AddCourse(Course course)
        {
            if (course != null || Courses.Find(c => c.CourseId == course.CourseId) == null)
            {
                Courses.Add(course);
                return true;
            }
            return false;
        }
        public bool AddInstructor(Instructor instructor)
        {
            if (instructor != null || Instructors.Find(i => i.InstructorId == instructor.InstructorId) == null)
            {
                Instructors.Add(instructor);
                return true;
            }
            return false;
        }

        public Student FindStudent(int StudentId)
        {
            
            
               return Students.Find(s => s.StudentId==StudentId)!;
            
            
        }
        public Course FindCourse(int CourseId)
        {
            if (CourseId > 0)
            {
                return Courses.Find(c => c.CourseId == CourseId)!;
            }
            return null!;
        }
        public Instructor FindInstructor(int InstructorId)
        {
            if (InstructorId > 0)
            {
                return Instructors.Find(i => i.InstructorId == InstructorId)!;
            }
            return null!;
        }
        public bool EnrollStudentInCourse(int studentId, int courseId)
        {
            if(studentId>0&&courseId>0)
            {
                Student student = Students.Find(s => s.StudentId == studentId)!;
                Course course = Courses.Find(c => c.CourseId == courseId)!;
                student.Enroll(course);
                course.Enroll(student);
                return true;
            }
            return false;
        }
        public bool EnrollInstructorInCourse(int courseId, int instructortId)
        {
            if (courseId > 0 && instructortId > 0)
            {
                Instructor instructor = Instructors.Find(i => i.InstructorId == instructortId)!;
                Course course = Courses.Find(c => c.CourseId == courseId)!;
                instructor.Enroll(course);
                course.Enroll(instructor);
                return true;
            }
            return false;
        }

        public string CheckEnrollingOfStudent(int studentId,int courseId)
        {
            if(studentId>0&&courseId>0)
            {
                if(Students.Find(s=>s.StudentId==studentId).Courses.Find(c=>c.CourseId==courseId)!=null)
                {
                    return $"Enrolled";
                }
            }
            return $"Not Enrolled";
        }
    }
}
