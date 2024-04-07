using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTask.Models
{
    internal class Group
    {
        private static int groupCount = 0;
        private Student[] students;

        public static Group[] Groups { get; private set; } = new Group[0];

        public static int GroupCount => groupCount;

        public int GroupId { get; }
        public string GroupName { get; set; }

        public Student[] Students
        {
            get { return students; }
            set { students = value; }
        }
        public Group(Student[] students, int groupId, string groupName)
        {
            GroupId = groupId;
            GroupName = groupName;
            Students = students;
        }

        public Group(string groupName)
        {
            this.GroupId = ++groupCount;
            this.GroupName = groupName;


            Array.Resize(ref GroupCount);
            Groups[GroupCount - 1] = this;
        }

        public void GetGroupInfo()
        {
            Console.WriteLine($"Group ID: {GroupId}");
            Console.WriteLine($"Group Name: {GroupName}");
            Console.WriteLine("Students:");
            foreach (Student student in Students)
            {
                Console.WriteLine($"- ID: {student.Id}, Name: {student.Name}, Surname: {student.Surname}");
            }
        }
        public Student GetStudent(int id)
        {
            foreach (Student student in Students)
            {
                if (student.Id == id)
                {
                    return student;
                }
                return null;
                Console.WriteLine("Bele telebe yoxdur");
            }
        }
        public void AddStudent(Student student)
        {
            Array.Resize(ref students, students.Length + 1);
            students[students.Length - 1] = student;
        }
        public void ShowStudents()
        {
            foreach (Student student in Students)
            {
                Console.WriteLine($"- ID: {student.Id}, Name: {student.Name}, Surname: {student.Surname}");
            }
        }
        public override string ToString()
        {
            return $"Group ID: {GroupId}, Group Name: {GroupName}, Number of Students: {Students.Length}";
        }
        static void AddGroup(Group group)
        {
            Array.Resize(ref Group.Groups, Group.Groups.Length + 1);
            Group.Groups[Group.Groups.Length - 1] = group;
        }
        static Group GetGroup(int id)
        {
            foreach (Group group in Group.Groups)
            {
                if (group.GroupId == id)
                {
                    return group;
                }
            }
            return null;
        }
}

