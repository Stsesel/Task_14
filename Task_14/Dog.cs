using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_14
{
    class Dog : Animal
    {
        string name;
        string say;
        double weight;
        int headcount;

        public override string Name
        {
            get => name;
            set => name = value;
        }

        public Dog (string name, string say, double weight, int headcount)
            : base(name)
        {
            this.say = say;
            this.weight = weight;
            this.headcount = headcount;
        }
        public override void Say()
        {
            Console.WriteLine(say);
        }

        public override void Weight()
        {
            Console.WriteLine("весит " + weight + " кг");
        }

        public override void Headcount()
        {
            Console.WriteLine("у зверя голов " + headcount + " шт.");
        }
    }
}
