using CardLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerEngine
{
    class IsFiveCards : IRules
    {
        public PokerResult Execute(List<Card> Cards)
        {
            if (Cards?.Count != 5)
                return PokerResult.Not5Card;

            return PokerResult.Undetermined;
        }
    }
}
