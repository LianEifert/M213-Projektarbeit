using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamArbeitSpiel
{
    public class RandomNumber
    {
       public static readonly Random Rnd = new Random();
        public int RandomZahl()
        {
            int rand = Rnd.Next(0, 100);
            return rand;
        }
    }
}
