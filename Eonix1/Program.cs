using System;

namespace Eonix1
{
    delegate void delegateSinge();
    class Program
    {
        static void Main(string[] args)
        {

            Spectateur spectateur = new Spectateur();
            spectateur.Nom = "Vous";

            Singe singe1 = new Singe("singe 1 ");
            Singe singe2 = new Singe("singe 2");
            Singe singe = new Singe();
            
            Dresseur dresseur1 = new Dresseur();
            Dresseur dresseur2 = new Dresseur();
            
            Console.WriteLine("Vous êtes en train de vous promenez dans la rue lorsque vous observez 2 singes\n" +
                "Le premier se trouve sur votre droite et le second sur votre gauche, lequel voulez-vous oberver?\n");
            
            string input;
            string saisie;
            do
            {
                do
                {
                    Console.WriteLine("Appuyer sur la touche 'D' pour regarder le singe de droite, 'G' pour regarder le singe de gauche\n");
                    input = Console.ReadLine().ToUpper();
                    Console.WriteLine();
                    switch (input)
                    {
                        case "D":
                            Console.WriteLine("Une autre personne se trouve à coté du singe de droite et lui demande de vous faire un tour\n");
                            dresseur1.Ordonne(singe1);
                            ChoixRandom(singe1);
                            break;

                        case "G":
                            Console.WriteLine("Une autre personne se trouve à coté du singe de gauche et lui demande de vous faire un tour\n");
                            dresseur2.Ordonne(singe2);
                            ChoixRandom(singe2);
                            break;

                        default:
                            Console.WriteLine("Entrez une touche valide");
                            break;
                    }
                } while (input != "D" && input != "G");

                Console.WriteLine("souhaitez-vous continuer a regarder le spectacle?\n'N' pour continuer votre chemin, autres touches pour voir un autre tour\n");
                saisie = Console.ReadLine().ToUpper();

            } while (saisie != "N");

            void ChoixRandom(Singe singe)
            {
                if (singe.Choix == 1 || singe.Choix == 2)
                {
                    spectateur.Applaudir();
                }
                else
                {
                    spectateur.Siffler();
                }
            }
        }       
    }
}
