using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace universytet
{
    public class Person
    {
        protected string name;
        protected string surname;
        protected string city;
        protected int age;

        public Person()
        {
            this.name = null;
            this.surname = null;
            this.city = null;
            this.age = 0;
        }

        public  Person(string name, string surname, string city, int age)
        {
            this.name = name;
            this.surname = surname;
            this.city = city;
            this.age = age;
        }   

        public virtual string GetInfo()
        {
            return $"Name: {this.name} Surname:{this.surname} City: {this.city}";
        }

        public override string ToString()
        {
            return $"Name: {this.name} Surname:{this.surname} City: {this.city}";
        }
    }
}
