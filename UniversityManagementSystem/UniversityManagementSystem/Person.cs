namespace UniversityManagementSystem
{
    abstract class Person
    {
        private int id;
        private string name;
        private int age;
        private string gender;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public Person(int ID, string Name, int Age, string Gender)
        {
            this.ID = ID;
            this.Name = Name;
            this.Age = Age;
            this.Gender = Gender;
        }

        public abstract void GetFile();
    }
}