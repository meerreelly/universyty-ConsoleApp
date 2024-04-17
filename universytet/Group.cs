using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace universytet
{
    public class Group
    {
        int groupnum;
        int AmountOfStudent;
        string majority;
        List<Student> Students;

        public Group()
        {
            this.groupnum = 0;
            this.AmountOfStudent = 0;
            this.majority = null;
            this.Students = new List<Student>();
        }

        public Group(int groupnum, List<Student> students, string majority)
        {
            this.majority = majority;
            this.groupnum = groupnum;
            Students = students;
            this.AmountOfStudent = Students.Count;
        }

        public  void AddStudent(Student newstudent)
        {
            Students.Add(newstudent);
        }

        public void ShowAllStudent()
        {
            Console.WriteLine("List of student:");
            foreach(Student student in Students)
            {
                Console.WriteLine(student.GetInfo());
            }
        }

    }
}
