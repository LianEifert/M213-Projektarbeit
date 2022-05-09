using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamArbeitSpiel
{
    public class Voting
    {
        public List<int> votes { get; set; }

        public int VoteSystem()
        {
            return votes.IndexOf(votes.Max());
        }





    }
}
