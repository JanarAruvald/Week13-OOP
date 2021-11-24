using System;

namespace OOPCAT
{
    class Program
    {
        class cat
        {
            //class fields
            string name;
            string color;
            double hungriness;

            public cat(string _name, string _color) //constructor
            {
                name = _name;
                color = _color;
                hungriness = 0;
                

            }
            public string Name
            {
                get { return name; }
            }
            public string Color
            {
                get { return color; }
            }
            public double Hungriness
            {
                get { return hungriness; }
            }
            public void Meow()
            {
                Console.WriteLine($"{Name} says \"Meow!\"");
                
            }
            public void Sleep()
            {
                Console.WriteLine("Zzzz...");
                hungriness += 0.2;
            }

            public void Rename(string NewName)
            {
                name = NewName;
            }
            

        }
        static void Main(string[] args)
        {
            cat MyCat = new cat("Blackie", "Black");
            MyCat.Meow();
            Console.WriteLine($"{MyCat.Name}'s level of hungriness: {MyCat.Hungriness}");

            while (MyCat.Hungriness != 1)
            {
                MyCat.Sleep();
            }
            MyCat.Meow();

            

        }
    }
}
