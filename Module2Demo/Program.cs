using Module2Demo.Entities;
using Module2Demo.Utils;
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

            Console.WriteLine(Extension.Add(10, 12));
            int a = 10;
            Console.WriteLine(a.Add(12));

            String b = "aizpepoazipe";
            Console.WriteLine(b.Add("11111"));

            Func<String> func1 = new Func<string>(() =>
            {
                return "func1";
            });

            Console.WriteLine(func1.Invoke());

            Func<int,int,String> func2 = new Func<int, int, String>((i,j) =>
            {
                return "produit i et j => " + (i*j);
            });

            Console.WriteLine(func2.Invoke(10,12));

            func2 = func2Test;

            Console.WriteLine(func2.Invoke(10, 12));

            Action a1 = new Action(() =>
            {
                Console.WriteLine("in a1");
                Console.WriteLine(func2.Invoke(10, 12));
            });

            a1.Invoke();

            Task.Factory.StartNew(() =>
            {
                for (int i = 0; i < 10000; i++)
                {
                    Console.WriteLine(i);
                }
            });

            jeux.Where(x => x.Name.Equals("bataille"));

            Console.ReadKey();
        }

        private static String func2Test(int toto, int tata)
        {
            return "produit toto et tata => " + (toto * tata);
        }
    }
}
