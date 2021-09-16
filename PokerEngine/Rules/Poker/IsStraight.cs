using CardLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerEngine
{
    class IsStraight : IRules
    {
        readonly string[] ValidSequence = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "1" };
        readonly string validSequenceString;

        public IsStraight()
        {
            validSequenceString = string.Join(",", ValidSequence);

            validSequenceString = "," + validSequenceString + ",";

        }

        public PokerResult Execute(List<Card> Cards)
        {
            var orderedCards = Cards.OrderBy(c => c.Value).ToList();

            var AExist = orderedCards.Exists(c => c.Face == "A");


            if (AExist)
            {
                var orderedCardValue = "," + string.Join(",", orderedCards.Select(c => c.Value.ToString()).ToArray()) + ",";
                if (validSequenceString.IndexOf(orderedCardValue) != -1)
                    return PokerResult.Straight;


                orderedCards.RemoveAt(0);
                orderedCards.Insert(orderedCards.Count, new A(CardSuit.Club));

                orderedCardValue = "," + string.Join(",", orderedCards.Select(c => c.Value.ToString()).ToArray()) + ",";
                if (validSequenceString.IndexOf(orderedCardValue) != -1)
                    return PokerResult.Straight;
            }
            else
            {
                var orderedCardValue = "," + string.Join(",", orderedCards.Select(c => c.Value.ToString()).ToArray()) + ",";


                if (validSequenceString.IndexOf(orderedCardValue) != -1)
                    return PokerResult.Straight;
            }

            return PokerResult.Undetermined;

        }
    }
}
