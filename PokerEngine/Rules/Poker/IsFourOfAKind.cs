using CardLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerEngine
{
    class IsFourOfAKind : IRules
    {
        public PokerResult Execute(List<Card> Cards)
        {
            var list = Cards.GroupBy(c => c, new CardValueComparer())
                .Where(g => g.Count() > 3).ToList();

            if (list.Count > 0)
                return PokerResult.FourOfAKind;


            return PokerResult.Undetermined;
        }
    }
}
