using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2Demo.Entities
{
    public abstract class Jeu<T> where T : IJeu
    {
        private String name;

        private T gameInterface;

        protected T GameInterface
        {
            get { return gameInterface; }
            set { gameInterface = value; }
        }


        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        public Jeu()
        {

        }

        public Jeu(String Name)
        {
            this.Name = Name;
        }

        public abstract void play();
        public void turn()
        {
            Console.WriteLine("turn : " + this.ToString() + " draw : " + gameInterface.draw() + " | " + gameInterface.draw());
        }

        public override string ToString()
        {
            return base.ToString() + " Name: " + this.Name;
        }
    }
}
