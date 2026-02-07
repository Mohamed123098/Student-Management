namespace Student_Management
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

           School school = new();
            char selectedOption = ' ';
            do
            {
                Console.WriteLine("=============================================");
                Console.WriteLine("A) Add Student");
                Console.WriteLine("B) Add Instructor");
                Console.WriteLine("C) Add Course ");
                Console.WriteLine("D) Enroll Student in Course");
                Console.WriteLine("E) Show All Students");
                Console.WriteLine("F) Show All Courses");
                Console.WriteLine("G) Show All Instructors");
                Console.WriteLine("H) Find the student by id or name");
                Console.WriteLine("I) Find the course by id or name");
                Console.WriteLine("J) Exit");
                Console.WriteLine("K) Check if the student enrolled in specific course");
                Console.WriteLine("L) Enroll Instructor to course");
                Console.Write("Enter your Selection : ");
                selectedOption = Convert.ToChar(Console.ReadLine());

                switch(selectedOption)
                {
                    case 'A':
                    case 'a':
                        Student student = new();
                        Console.WriteLine("Enter student id");
                        student.StudentId = Convert.ToInt16(Console.ReadLine());
                        Console.WriteLine("Enter ur name");
                        student.Name = Console.ReadLine();
                        Console.WriteLine("Enter ur Age");
                        student.Age = Convert.ToInt16(Console.ReadLine());
                        school.AddStudent(student);
                        break;
                    case 'B':
                    case 'b':
                        Instructor instructor = new();
                        Console.WriteLine("Enter instructor id");
                        instructor.InstructorId = Convert.ToInt16(Console.ReadLine());
                        Console.WriteLine("Enter ur name");
                        instructor.Name = Console.ReadLine();
                        Console.WriteLine("Enter ur Specialization");
                        instructor.Specialization = Console.ReadLine();
                        school.AddInstructor(instructor);
                        break;
                    case 'C':
                    case 'c':
                        Course course = new();
                        Console.WriteLine("Enter Course id");
                        course.CourseId = Convert.ToInt16(Console.ReadLine());
                        Console.WriteLine("Enter title of course");
                        course.Title = Console.ReadLine();
                        school.AddCourse(course);
                        break;
                    case 'D':
                    case 'd':
                        Console.WriteLine("Enter student id");
                        int sId = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter course id");
                        int cId = Convert.ToInt32(Console.ReadLine());
                        school.EnrollStudentInCourse(studentId: sId,courseId: cId);
                        break;
                    case 'E':
                    case 'e':
                        foreach (var item in school.Students)
                        {
                            Console.WriteLine(item.PrintDetails());
                        }

                        break;
                    case 'F':
                    case 'f':
                        foreach (var item in school.Courses)
                        {
                            Console.WriteLine(item.PrintDetails());
                        }
                        break;
                    case 'G':
                    case 'g':
                        foreach (var item in school.Instructors)
                        {
                            Console.WriteLine(item.PrintDetails());
                        }
                        break;
                    case 'H':
                    case 'h':
                        Console.WriteLine("1) search by id");
                        Console.WriteLine("2) search by name");
                        int option = Convert.ToInt32(Console.ReadLine());
                        switch(option)
                        {
                            case 1:
                                Console.WriteLine("Enter  Id of student");
                                int input = Convert.ToInt32( Console.ReadLine());
                                Console.WriteLine(school.FindStudent(Convert.ToInt32(input)).PrintDetails());
                                break;
                            case 2:
                                Console.WriteLine("Enter  name of student");
                                string Sinput = Console.ReadLine();
                                Console.WriteLine(school.Students.Find(s => s.Name == Sinput).PrintDetails());
                                break;
                        }
                        
                        break;
                    case 'I':
                    case 'i':
                        Console.WriteLine("1) search by id");
                        Console.WriteLine("2) search by name");
                        int optionI = Convert.ToInt32(Console.ReadLine());
                        switch (optionI)
                        {
                            case 1:
                                Console.WriteLine("Enter  Id of Course");
                                int input = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine(school.FindCourse(Convert.ToInt32(input)).PrintDetails());
                                break;
                            case 2:
                                Console.WriteLine("Enter  name of Course");
                                string Sinput = Console.ReadLine();
                                Console.WriteLine(school.Courses.Find(s => s.Title == Sinput).PrintDetails());
                                break;
                        }

                        break;
                    case 'J':
                    case 'j':
                        Console.WriteLine("See u Soon GOOD BYE");
                        break;
                        
                    case 'K':
                    case 'k':
                        Console.WriteLine("Enter student id");
                        int studentId = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter course id");
                        int courseId = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(school.CheckEnrollingOfStudent(studentId, courseId));
                        break;
                    case 'L':
                    case 'l':
                        Console.WriteLine("Enter instructor id");
                        int instructorId = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter course id");
                        int crsId = Convert.ToInt32(Console.ReadLine());
                        school.EnrollInstructorInCourse(instructortId: instructorId, courseId: crsId);
                        break;
                    default:
                        break;
                }
            } while (!(selectedOption=='J'||selectedOption=='j'));
           
        }
    }
}
