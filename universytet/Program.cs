
using universytet;

var student1 = new Student("name1","surname1","city", 21, "email@gmail.com");
var student2 = new Student("name2","surname2","city", 20, "email@gmail.com");
var student3 = new Student("name3","surname3","city", 18, "email@gmail.com");
var student4 = new Student("name4","surname4","city", 19, "email@gmail.com");
var student5 = new Student("name5","surname5","city", 22, "email@gmail.com");
var student6 = new Student("name6","surname6","city", 24, "email@gmail.com");
var student7 = new Student("name7","surname7","city", 17, "email@gmail.com");
List<Student> students = new List<Student>();
List<Student> students2 = new List<Student>();
students = [
    new Student("name1","surname1","city", 21, "email@gmail.com"),
    new Student("name2","surname2","city", 20, "email@gmail.com"),
    new Student("name3","surname3","city", 18, "email@gmail.com"),
    new Student("name4","surname4","city", 19, "email@gmail.com"),
    new Student("name5","surname5","city", 22, "email@gmail.com"),
    new Student("name6","surname6","city", 24, "email@gmail.com"),
    new Student("name7","surname7","city", 17, "email@gmail.com")];

var group = new Group(1,students, "majority1");   
var group2 = new Group(1,students2, "majority2");   
List<Group> groups = new List<Group>();
groups.Add(group);
groups.Add(group2);
var univers = new University("OA",groups);

while (true)
{
    Console.WriteLine("[1]-Show university info\n" +
        "[2]-Show group info\n" +
        "[3]-Add Student to Group\n" +
        "[4]-Exit");
    int temp = int.Parse(Console.ReadLine());
    switch (temp)
    {
        case 1: Console.WriteLine(univers);
            break;
        case 2: 
            int i =1;
            foreach(Group tempgr in univers.GetGroupList())
            {
                Console.WriteLine($"Info about group {i}");
                tempgr.ShowAllStudent();
                i++;
            }
        break;
        case 3: Console.WriteLine("Enter name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter surname");
            string surname = Console.ReadLine();
             Console.WriteLine("Enter city");
            string city = Console.ReadLine();
             Console.WriteLine("Enter age");
            int age =int.Parse(Console.ReadLine());
            Console.WriteLine("Enter email");
            string email = Console.ReadLine();
            var tempstudent = new Student(name,surname,city, age, email);
            i =1;
            foreach(Group tempgroups in univers.GetGroupList())
            {
                Console.WriteLine($"Info about group {i}");
                tempgroups.ShowAllStudent();
                i++;
            }
            Console.WriteLine("Select Group to add student");
            int tempgroup  =int.Parse(Console.ReadLine());
            List<Group> groups1 = univers.GetGroupList();
            groups[tempgroup-1].AddStudent(tempstudent);
            break;
    }
}