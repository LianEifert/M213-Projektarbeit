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
        public int RandomZahl(List<int> list)
        {
            int rand = Rnd.Next(0, 100);
      for (int i = 0; i < list.Count; i++)
      {
            if(rand == list[i])
            {
            RandomZahl(list);
            break;
            }
      }
            return rand;
        }
    }
}
