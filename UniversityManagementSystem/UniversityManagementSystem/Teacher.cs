using System.IO;

namespace UniversityManagementSystem
{
    class Teacher : Person
    {
        private string courseTeacher;
        private int salary;

        public string CourseTeacher
        {
            get { return courseTeacher; }
            set { courseTeacher = value; }
        }
        public int Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public Teacher(int ID, string Name, int Age, string Gender, string CourseTeacher, int Salary) : base(ID, Name, Age, Gender)
        {
            this.CourseTeacher = CourseTeacher;
            this.Salary = Salary;
        }

        public Teacher(string Name, int ID, int Age, string Gender, string CourseTeacher, int Salary) : base(ID, Name, Age, Gender)
        {
            this.CourseTeacher = CourseTeacher;
            this.Salary = Salary;
        }

        public override void GetFile()
        {
            FileStream fs = new FileStream("E:\\teacherfile.txt", FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);

            sw.WriteLine("\t DETAILS OF TEACHERS");
            sw.WriteLine($"SID: {ID}");
            sw.WriteLine($"Name: {Name}");
            sw.WriteLine($"Age: {Age}");
            sw.WriteLine($"Gender: {Gender}");
            sw.WriteLine($"Course Teacher: {CourseTeacher}");
            sw.WriteLine($"Salary: {Salary}");
            sw.WriteLine();

            sw.Flush();
            sw.Close();
            fs.Close();
        }
    }
}