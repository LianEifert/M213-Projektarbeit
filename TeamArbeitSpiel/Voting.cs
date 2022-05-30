using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamArbeitSpiel
{
    public class Voting
    {
        //public List<int> votes { get; set; }
        public int[] votes { get; set; }

        public int VoteSystem()
        {
            //return votes.IndexOf(votes.Max());


            int maxValue = votes.Max();
            int Index = votes.ToList().IndexOf(maxValue);
            return Index;
        }



        public bool votesure()
        {
            int voteWinner = 0;
            for (int i = 0; i < votes.Length; i++)
            {
                

                if (voteWinner <= votes[i])
                {

                    if ((voteWinner == votes[i])&&(voteWinner != 0)&&voteWinner==votes.Max())
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
