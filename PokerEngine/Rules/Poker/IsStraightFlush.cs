using CardLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerEngine
{
    class IsStraightFlush : IRules
    {
        readonly string[] ValidSequence = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "1" };
        readonly string validSequenceString;

        public IsStraightFlush()
        {
            validSequenceString = string.Join(",", ValidSequence);

            validSequenceString = "," + validSequenceString + ",";

        }

        public PokerResult Execute(List<Card> Cards)
        {
            var ClubCount = Cards.Count(card => card.Suit == CardSuit.Club);
            var DiamondCount = Cards.Count(card => card.Suit == CardSuit.Diamond);
            var HeartCount = Cards.Count(card => card.Suit == CardSuit.Heart);
            var SpadeCount = Cards.Count(card => card.Suit == CardSuit.Spade);

            if (ClubCount == 5 || DiamondCount == 5 || HeartCount == 5 || SpadeCount == 5)
            {
                var orderedCards = Cards.OrderBy(c => c.Value).ToList();

                var AExist = orderedCards.Exists(c => c.Face == "A");


                if(AExist)
                {
                    var orderedCardValue = "," + string.Join(",", orderedCards.Select(c => c.Value.ToString()).ToArray()) + ",";
                    if (validSequenceString.IndexOf(orderedCardValue) != -1)
                        return PokerResult.StraightFlush;


                    orderedCards.RemoveAt(0);
                    orderedCards.Insert(orderedCards.Count, new A(CardSuit.Club));

                    orderedCardValue = "," + string.Join(",", orderedCards.Select(c => c.Value.ToString()).ToArray()) + ",";
                    if (validSequenceString.IndexOf(orderedCardValue) != -1)
                        return PokerResult.StraightFlush;
                }
                else
                {
                    var orderedCardValue = "," + string.Join(",", orderedCards.Select(c => c.Value.ToString()).ToArray()) + ",";


                    if (validSequenceString.IndexOf(orderedCardValue) != -1)
                        return PokerResult.StraightFlush;
                }


            }

            return PokerResult.Undetermined;
        }
    }
}
