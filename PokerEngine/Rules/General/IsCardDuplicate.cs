using CardLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerEngine
{
    class IsCardDuplicate : IRules
    {
        public PokerResult Execute(List<Card> Cards)
        {
            var list = Cards.GroupBy(c => c, new CardComparer())
                .Where(g => g.Count() > 1).ToList();

            if (list.Count > 0)
                return PokerResult.CardDuplicated;


            return PokerResult.Undetermined;
        }
    }
}
