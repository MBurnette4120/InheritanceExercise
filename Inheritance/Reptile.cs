using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Inheritance
{
    public class Reptile:Animal
    {
        public Reptile()
        {
            
        }

        public bool ColdBlooded { get; set; }
        public string HairorScales { get; set; }
        public bool Mouth { get; set; }
        public string Food { get; set; }

        public string Name { get; set; }

        public void PrintInfo()
        {
            Console.WriteLine(ColdBlooded);
            Console.WriteLine(HairorScales);
            Console.WriteLine(Mouth);
            Console.WriteLine(Food);

        }














    }
}
