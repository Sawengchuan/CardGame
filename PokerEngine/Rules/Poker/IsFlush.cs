using CardLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerEngine
{
    class IsFlush : IRules
    {
        public PokerResult Execute(List<Card> Cards)
        {
            var list = Cards.GroupBy(c => c, new CardSuitComparer())
                .Where(g => g.Count() > 4).ToList();

            if (list.Count > 0)
                return PokerResult.Flush;


            return PokerResult.Undetermined;
        }
    }
}
