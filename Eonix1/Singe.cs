using System;
using System.Collections.Generic;
using System.Text;

namespace Eonix1
{
    
    public class Singe 
    {
        public string Nom { get; set; }
        public int Choix { get; set; }
        public Singe()
        {

        }
        public Singe(string nom)
        {
            Nom = nom;
        }
        public void Tours()
        {
            Random rand = new Random();
            Choix = rand.Next(1, 5);
            switch (this.Choix)
            {
                case 1:
                    Jongler();
                    break;
                case 2:
                    FaitLaRoue();
                    break;
                case 3:
                    Chanter();
                    break;
                case 4:
                    JoueDeLaTrompette();
                    break;
                default:
                    Console.WriteLine("pas de tours disponible");
                    break;
            }
           
        }
        private void Jongler()
        {
            Console.WriteLine($"{this.Nom} jongle avec des balles");
        }
        private void FaitLaRoue()
        {
            Console.WriteLine($"{this.Nom} fait la roue");
        }
        private void Chanter()
        {
            Console.WriteLine($"{this.Nom} se met a chanter bruyamment");
        }
        private void JoueDeLaTrompette()
        {
            Console.WriteLine($"{this.Nom} joue de la trompette");
        }
    }
}
