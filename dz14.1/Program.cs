using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz14._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dogs dogs = new Dogs();
            dogs.Name = "собака";
            dogs.ShowInfo();
            
            Cats cats = new Cats();
            cats.Name = "кошка";
            cats.ShowInfo();
            
            Console.ReadKey();
        }
    }
    abstract class Animal
    {
        public abstract string Name { get; set; }
        public abstract void Say();
        public void ShowInfo()
        {
            Console.WriteLine("класс животного:{0} ",Name);
            Console.Write("говорит "); Say();
        }
    }
    class Dogs:Animal
    {
        string name;
        public override string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public override void Say()
        {
            Console.WriteLine("Гав");
        }
    }
    class Cats : Animal
    {
        string name;
        public override string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public override void Say()
        {
            Console.WriteLine("Мяу");
        }
    }
}
