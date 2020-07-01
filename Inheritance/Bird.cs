using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Bird : Animal
    {
        public Bird()
        {

        }

        public bool Feathers { get; set; }
        public string BeakSize { get; set; }
        public bool Wings { get; set; }
        public bool Fly { get; set; }
        public string Name { get; set; }

        public void PrintInfo()
        {
            Console.WriteLine(Feathers);
            Console.WriteLine(BeakSize);
            Console.WriteLine(Wings);
            Console.WriteLine(Fly);

        }













    }
    
}
