using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog("Собак", "говорит Гав-гав", 20, 1);
            dog.ShowInfo();
            Console.WriteLine();

            Cat cat = new Cat("Кошак", "говорит Мур-мяу", 5, 1);
            cat.ShowInfo();
            Console.WriteLine();

            Catdog catdog = new Catdog("КотоПёс", "говорит Мур-мяу-Гав-гав", 25, 2);
            catdog.ShowInfo();
            Console.ReadKey();
        }

    }
}
