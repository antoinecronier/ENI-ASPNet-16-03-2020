using Module2Demo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2Demo
{
   public class Program
    {
        public static void Main(string[] args)
        {
            Personne p1 = new Personne();
            Personne p2 = new Personne("Jean", "Louis");
            Personne p3 = new Personne() { Nom = "El", Prenom = "Jean" };
            Personne p4 = p2.Clone() as Personne;
            //Personne p4 = (Personne) p2.Clone();

            //Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine(p4);

            p2.Nom = "Cronier";
            p4.Prenom = "Antoine";

            Console.WriteLine(p2);
            Console.WriteLine(p4);

            //Console.WriteLine(p3);

            Jeu<CardGame> jeu = new Bataille();
            // A proscrire je ne connais pas le type réel => Jeu<CardGame>
            //var jeu = new Bataille();
            jeu.play();
            // new sur abstract impossible.
            //Jeu jeu1 = new Jeu();

            // var ici est possible car membre de droite connu
            var jeux = new List<Jeu<CardGame>>();
            jeux.Add(jeu);
            jeux.Add(new Bataille());

            foreach (var item in jeux)
            {
                item.play();
                // Attention ne pas modifier les valeurs d'item dans le foreach
            }

            for (int i = 0; i < jeux.Count; i++)
            {
                jeux.ElementAt(i).play();
            }

            Console.ReadKey();
        }
    }
}
