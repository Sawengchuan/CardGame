using CardLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerEngine
{
    class IsRoyalFlush : IRules
    {
        public PokerResult Execute(List<Card> Cards)
        {
            var ClubCount = Cards.Count(card => card.Suit == CardSuit.Club);
            var DiamondCount = Cards.Count(card => card.Suit == CardSuit.Diamond);
            var HeartCount = Cards.Count(card => card.Suit == CardSuit.Heart);
            var SpadeCount = Cards.Count(card => card.Suit == CardSuit.Spade);

            if (ClubCount == 5 || DiamondCount == 5 || HeartCount == 5 || SpadeCount == 5)
            {
                var AExist = Cards.Exists(c => c.Face == "A");
                var _10Exist = Cards.Exists(c => c.Face == "10");
                var JExist = Cards.Exists(c => c.Face == "J");
                var QExist = Cards.Exists(c => c.Face == "Q");
                var KExist = Cards.Exists(c => c.Face == "K");

                if (AExist && JExist && _10Exist && QExist && KExist)
                    return PokerResult.RoyalFlush;
            }

            return PokerResult.Undetermined;
        }
    }
}
