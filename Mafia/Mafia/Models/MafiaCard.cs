using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mafia.Models
{
    public class MafiaCard
    {
        List<Card> mafiaDeck;

        public List<Card> MafiaDeck
        {
            get
            {
                return mafiaDeck;
            }

            set
            {
                mafiaDeck = value;
            }
        }

        public MafiaCard(List<Card> mafiaDeck)
        {
            MafiaDeck = mafiaDeck;
        }
    }
}