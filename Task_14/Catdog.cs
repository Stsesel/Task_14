using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_14
{
    class Catdog : Cat
    {

 
        int headcount;

        public override string Name
        {
            get => name;
            set => name = value;
        }



        public Catdog(string name, string say, double weight, int headcount)
            : base(name, say, weight, headcount)
        {
            this.headcount = headcount;
            
        }


        public override void Headcount()
        {
            Console.WriteLine(headcount);
        }

    }
}
