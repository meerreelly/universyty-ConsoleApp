using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace universytet
{
    public class Student :Person
    {
        
        string email;

        public Student(string name,string surname,string city,int age,string email) : base(name, surname,city,age)
        {
            this.email = email;
        }
        public override string GetInfo()
        {
            return $"Name: {this.name}|Surname: {this.surname}|City: {this.city}|Email: {this.email} ";
        }
        public override string ToString()
        {
            return $"Name: {this.name}|Surname: {this.surname}|City: {this.city}|Email: {this.email} ";
        }
    }
}
