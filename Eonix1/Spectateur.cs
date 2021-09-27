using System;
using System.Collections.Generic;
using System.Text;

namespace Eonix1
{
    public class Spectateur
    {
        public string Nom { get; set; }
        public Spectateur()
        {

        }
        public void Applaudir()
        {
            Console.WriteLine($"{this.Nom} Applaudissez devant ce spectacle\n");
        }
        public void Siffler()
        {
            Console.WriteLine($"{this.Nom} sifflez sur ce magnifique tour\n");
        }
    }
}
