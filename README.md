# 🎓 Console-Based Student Management System (C# OOP)

This project is a **console-based Student Management System** developed using **Object-Oriented Programming (OOP) principles** in **C#**.

🚫 No GUI  
🚫 No Database  
✅ Pure OOP design and class interaction

The system demonstrates how multiple classes interact together in a clean architecture.

---

## 🎯 Project Goal

Design a basic Student Management System using **OOP concepts only**:

- Encapsulation  
- Abstraction  
- Object interaction  
- Class relationships  

---

## ⚙️ Functional Requirements

The system allows the user to:

1. Add a new Student  
2. View all Students  
3. Search for a Student by ID  
4. Update Student Information  
5. Delete a Student  
6. Add a new Course  
7. Add a new Instructor  
8. Enroll a Student in a Course  
9. View all Courses  
10. View all Instructors  

### ⭐ Bonus Features

11. Check if a student is enrolled in a specific course  
12. Get the instructor name by course name  

---

## 🧱 System Classes

---

### 👨‍🎓 Class: `Student`

**Properties**
- `int StudentId`
- `string Name`
- `int Age`
- `List<Course> Courses`

**Methods**
- `bool Enroll(Course course)` → Adds course if not already enrolled  
- `string PrintDetails()` → Returns formatted student info  

---

### 👨‍🏫 Class: `Instructor`

**Properties**
- `int InstructorId`
- `string Name`
- `string Specialization`

**Methods**
- `string PrintDetails()` → Returns instructor information  

---

### 📘 Class: `Course`

**Properties**
- `int CourseId`
- `string Title`
- `Instructor Instructor`

**Methods**
- `string PrintDetails()` → Returns course information with instructor  

---

### 🏫 Class: `SchoolStudentManager`  
> ⚠️ IMPORTANT: This replaces `StudentManager`

This class acts as the **system controller** and manages all lists.

**Properties**
- `List<Student> Students`
- `List<Course> Courses`
- `List<Instructor> Instructors`

**Methods**
- `bool AddStudent(Student student)`
- `bool AddCourse(Course course)`
- `bool AddInstructor(Instructor instructor)`
- `Student FindStudent(int studentId)`
- `Course FindCourse(int courseId)`
- `Instructor FindInstructor(int instructorId)`
- `bool EnrollStudentInCourse(int studentId, int courseId)`

---

## 🖥️ Console Menu

The application runs with a menu like this:

  A. Add Student (starts with empty course list)
  B. Add Instructor
  C. Add Course (select instructor by ID)
  D. Enroll Student in Course
  E. Show All Students
  F. Show All Courses
  G. Show All Instructors
  H. Find Student by ID or Name
  I. Find Course by ID or Name
  J. Exit
  K. Check if the student enrolled in specific course 
  L. Enroll Instructor to course
