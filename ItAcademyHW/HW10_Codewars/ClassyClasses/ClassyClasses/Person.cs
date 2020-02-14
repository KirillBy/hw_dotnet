using System;
using System.Collections.Generic;
using System.Text;

namespace ClassyClasses
{
    public class Person
    {
        private string name;
        private int age;
        public string Info {  get { return name + "s age is " + age; } set { } }
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
    }
}
