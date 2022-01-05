using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_14
{
    abstract class Animal
    {
        public abstract string Name { get; set; }
        public Animal(string name)
        {
            Name = name;
        }

        public abstract void Say(); 

        public abstract void Weight();

        public abstract void Headcount();

        public void ShowInfo()
        {
            Console.WriteLine(Name);
            Say();
            Weight();
            Headcount();
        }
    
    }
}
