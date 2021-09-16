using CardLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerEngine
{
    class IsHighCard : IRules
    {
        public PokerResult Execute(List<Card> Cards)
        {
            return PokerResult.HighCard;
        }
    }
}
