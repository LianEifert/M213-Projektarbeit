using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamArbeitSpiel
{
    public class RandomNumber
    {
        //Properties
        public static readonly Random Rnd = new Random();

        /// <summary>
        /// Erstellt eine Liste mit Random zahlen und gibt eine davon zurück
        /// </summary>
        /// <param name="list">Liste wird generiert mit den Randomzahlen</param>
        /// <returns>Gibt die Random Zahl zurück</returns>
        public int RandomZahl(List<int> list)
        {
            int rand = Rnd.Next(0, 100);
            for (int i = 0; i < list.Count; i++)
            {
                if (rand == list[i])
                {
                    RandomZahl(list);
                    break;
                }
            }
            return rand;
        }
    }
}
