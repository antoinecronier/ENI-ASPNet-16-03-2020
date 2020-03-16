using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2Demo.Entities
{
    public class Bataille : Jeu<CardGame>
    {

        //base = super en Java
        public Bataille() : base("Bataille")
        {
            this.GameInterface = new CardGameImpl();
        }

        public override void play()
        {
            for (int i = 0; i < 5; i++)
            {
                turn();
            }
        }
    }
}
