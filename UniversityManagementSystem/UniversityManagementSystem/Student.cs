using System.IO;

namespace UniversityManagementSystem
{
    class Student : Person
    {
        private string course;
        private string email;
        private string address;
        private int phone;

        public string Course
        {
            get { return course; }
            set { course = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public int Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        public Student(int ID, string Name, int Age, string Gender, string Course, string Email, string Address, int Phone) : base(ID, Name, Age, Gender)
        {
            this.Course = Course;
            this.Email = Email;
            this.Address = Address;
            this.Phone = Phone;
        }

        public Student(string Name, int ID, int Age, string Gender, string Course, string Email, string Address, int Phone) : base(ID, Name, Age, Gender)
        {
            this.Course = Course;
            this.Email = Email;
            this.Address = Address;
            this.Phone = Phone;
        }

        public override void GetFile()
        {
            FileStream fs = new FileStream("E:\\studentfile.txt", FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);

            sw.WriteLine("\t DETAILS OF STUDENT");
            sw.WriteLine($"SID: {ID}");
            sw.WriteLine($"Name: {Name}");
            sw.WriteLine($"Age: {Age}");
            sw.WriteLine($"Gender: {Gender}");
            sw.WriteLine($"Course: {Course}");
            sw.WriteLine($"Email: {Email}");
            sw.WriteLine($"Address: {Address}");
            sw.WriteLine($"Phone: {Phone}");
            sw.WriteLine();

            sw.Flush();
            sw.Close();
            fs.Close();
        }
    }
}