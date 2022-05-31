using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamArbeitSpiel
{
    public class Voting
    {
        //Properties
        public int[] votes { get; set; }

        /// <summary>
        /// Legt fest, welcher am meisten Votes hat
        /// </summary>
        /// <returns>Gibt den Index zurück des MaxValues</returns>
        public int VoteSystem()
        {
            int maxValue = votes.Max();
            int Index = votes.ToList().IndexOf(maxValue);
            return Index;
        }

        /// <summary>
        /// Schaut ob es der richtige Gewinner ist
        /// </summary>
        /// <returns>gibt true oder false zurück</returns>
        public bool votesure()
        {
            int voteWinner = 0;
            for (int i = 0; i < votes.Length; i++)
            {
                if (voteWinner <= votes[i])
                {
                    if ((voteWinner == votes[i]) && (voteWinner != 0) && voteWinner == votes.Max())
                    {
                        return false;
                    }
                    voteWinner = votes[i];
                }
            }
            return true;
        }

    }
}
