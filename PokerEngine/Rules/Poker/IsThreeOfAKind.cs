using CardLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerEngine
{
    class IsThreeOfAKind : IRules
    {
        public PokerResult Execute(List<Card> Cards)
        {
            var list1 = Cards.GroupBy(c => c, new CardValueComparer())
                .Where(g => g.Count() > 2).ToList();

            if (list1.Count > 0)
                return PokerResult.ThreeOfAKind;


            return PokerResult.Undetermined;
        }
    }
}
