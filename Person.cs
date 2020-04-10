using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance 
{
    public class Person 
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public void GetNameAndAge() 
        {
            Console.WriteLine("The person has name: {0} and age: {1}", Name, Age);
        }
        public Person(string name, int age) 
        {
            Name = name;
            Age = age;
        }
    }

}
