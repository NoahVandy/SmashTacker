using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmashTacker
{
    public class ChallengerList
    {
        private List<Challenger> theList { get; set; }


        public ChallengerList()
        {
            theList = new List<Challenger>();
        }


        public bool Add(Challenger challenger)
        {

            if (theList.Contains(challenger))
            {
                return false;
            }
            else
            {
                this.theList.Add(challenger);
                return true;
            }

        }

        public List<Challenger> getItemList()
        {
            List<Challenger> mirror = new List<Challenger>(theList.Count);

            foreach (Challenger i in theList)
            {
                Challenger item = i;
                mirror.Add(item);
            }
            return mirror;


        }
    }
}
