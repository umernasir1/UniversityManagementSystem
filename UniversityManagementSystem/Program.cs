using System;
using System.Collections.Generic;

namespace UniversityManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            University uni = new University("Elite Tech University");

            while (true)
            {
                Console.Clear();
                Console.WriteLine($"--- {uni.Name} Management System ---");
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. Add Course");
                Console.WriteLine("3. Enroll Student in Course");
                Console.WriteLine("4. Show All Students");
                Console.WriteLine("5. Show All Courses");
                Console.WriteLine("6. Show Enrollments");
                Console.WriteLine("0. Exit");
                Console.Write("\nEnter your choice: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        uni.AddStudent();
                        break;
                    case "2":
                        uni.AddCourse();
                        break;
                    case "3":
                        uni.EnrollStudent();
                        break;
                    case "4":
                        uni.ListStudents();
                        break;
                    case "5":
                        uni.ListCourses();
                        break;
                    case "6":
                        uni.ListEnrollments();
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }

                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
            }
        }
    }

    class University
    {
        public string Name { get; }
        private List<Student> Students = new();
        private List<Course> Courses = new();
        private List<Enrollment> Enrollments = new();

        public University(string name) => Name = name;

        public void AddStudent()
        {
            Console.Write("Enter Student Name: ");
            string name = Console.ReadLine();
            Students.Add(new Student(name));
            Console.WriteLine("Student added successfully.");
        }

        public void AddCourse()
        {
            Console.Write("Enter Course Name: ");
            string name = Console.ReadLine();
            Courses.Add(new Course(name));
            Console.WriteLine("Course added successfully.");
        }

        public void EnrollStudent()
        {
            if (Students.Count == 0 || Courses.Count == 0)
            {
                Console.WriteLine("Students or Courses are not available.");
                return;
            }

            ListStudents();
            Console.Write("Enter Student ID: ");
            int sid = int.Parse(Console.ReadLine());

            ListCourses();
            Console.Write("Enter Course ID: ");
            int cid = int.Parse(Console.ReadLine());

            Student student = Students.Find(s => s.Id == sid);
            Course course = Courses.Find(c => c.Id == cid);

            if (student != null && course != null)
            {
                Enrollments.Add(new Enrollment(student, course));
                Console.WriteLine("Enrollment successful.");
            }
            else
            {
                Console.WriteLine("Invalid IDs provided.");
            }
        }

        public void ListStudents()
        {
            Console.WriteLine("\n--- Students ---");
            foreach (var student in Students)
            {
                Console.WriteLine($"ID: {student.Id} - Name: {student.Name}");
            }
        }

        public void ListCourses()
        {
            Console.WriteLine("\n--- Courses ---");
            foreach (var course in Courses)
            {
                Console.WriteLine($"ID: {course.Id} - Name: {course.Name}");
            }
        }

        public void ListEnrollments()
        {
            Console.WriteLine("\n--- Enrollments ---");
            foreach (var enroll in Enrollments)
            {
                Console.WriteLine($"{enroll.Student.Name} is enrolled in {enroll.Course.Name}");
            }
        }
    }

    class Student
    {
        private static int counter = 1;
        public int Id { get; }
        public string Name { get; }

        public Student(string name)
        {
            Id = counter++;
            Name = name;
        }
    }

    class Course
    {
        private static int counter = 1;
        public int Id { get; }
        public string Name { get; }

        public Course(string name)
        {
            Id = counter++;
            Name = name;
        }
    }

    class Enrollment
    {
        public Student Student { get; }
        public Course Course { get; }

        public Enrollment(Student student, Course course)
        {
            Student = student;
            Course = course;
        }
    }
}
