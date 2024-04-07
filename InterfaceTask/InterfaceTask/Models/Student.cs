namespace InterfaceTask.Models
{
    internal class Student
    {
        private static int count = 0;
        public static int Count => count;

        public int Id { get; }
        private string name;
        private string surname;

        public string Name
        {
            get { return name; }
            set { name = value.Capitalize(); }
        }

        public string Surname
        {
            get { return surname; }
            set { surname = value.Capitalize(); }
        }
        public Student(int ıd, string name, string surname)
        {
            Id = ıd;
            Name = name;
            Surname = surname;
        }

        public static void GetInfo()
        {
            Console.WriteLine();
        }
    }
}
