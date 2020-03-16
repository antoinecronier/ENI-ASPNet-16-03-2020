using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module1Demo
{
    /// <summary>
    /// Main class with entry point.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Entry point of my application.
        /// </summary>
        /// <param name="args">Command line args.</param>
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello world");

            int a = 1;
            float b = 2.1F;
            double c = 2.2;

            bool d = true;

            string e = "zoejroizje";

            String f = e;
            Console.WriteLine("int.MaxValue " + int.MaxValue);
            Console.WriteLine("int.MinValue " + int.MinValue);

            if (false)
            {

            }
            else if (true)
            {

            }
            else
            {

            }

            int i = 0;
            while (i < 10)
            {
                i++;
            }

            for (int j = 0; j < 10; j++)
            {

            }

            Class1 class1 = new Class1();
            Class1 class11 = new Class1(1);

            Console.WriteLine(class1.MyProperty1);
            class1.MyProperty1 = 10;
            Console.WriteLine(class1.MyProperty1);

            // Read only prop
            //class1.MyProperty2 = 10;

            //C# règles:
            // Fonction commence par une majuscule => PascalCase
            // Il n'existe pas vraiment de primitive, tout est objet
            // Tout les objets possède une valeur par défaut, forcé par C#

            Console.ReadKey();
        }
    }
}
