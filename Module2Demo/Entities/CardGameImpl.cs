using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2Demo.Entities
{
    public class CardGameImpl : CardGame
    {
        private Random random;

        public CardGameImpl()
        {
            this.random = new Random();
        }

        public int draw()
        {
            return random.Next(7, 13);
        }
    }
}
