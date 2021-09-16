using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CardLib;

namespace PokerEngine
{
    public class RankingEvaluator
    {
        public string Evaluate(List<Card> Cards)
        {
            PokerResult result = PokerResult.Undetermined;


            List<IRules> rules = new List<IRules>();
            rules.Add(new IsEmpty());
            rules.Add(new IsInsufficientCards());
            rules.Add(new IsFiveCards());
            rules.Add(new IsCardDuplicate());

            rules.Add(new IsRoyalFlush());
            rules.Add(new IsStraightFlush());
            rules.Add(new IsFourOfAKind());
            rules.Add(new IsFullHouse());
            rules.Add(new IsFlush());
            rules.Add(new IsStraight());
            rules.Add(new IsThreeOfAKind());
            rules.Add(new IsTwoPair());
            rules.Add(new IsPair());
            rules.Add(new IsHighCard());


            foreach (var rule in rules)
            {
                result = rule.Execute(Cards);

                if (result != PokerResult.Undetermined)
                    break;

            }

            return ConvertResultToString(result);
        }

        string ConvertResultToString(PokerResult pokerResult)
        {
            string result = "";

            switch(pokerResult)
            {
                case PokerResult.RoyalFlush:
                    result = "Royal Flush";
                    break;
                case PokerResult.StraightFlush:
                    result = "Straight Flush";
                    break;
                case PokerResult.FourOfAKind:
                    result = "Four of a Kind";
                    break;
                case PokerResult.FullHouse:
                    result = "Full House";
                    break;
                case PokerResult.Flush:
                    result = "Flush";
                    break;
                case PokerResult.Straight:
                    result = "Straight";
                    break;
                case PokerResult.ThreeOfAKind:
                    result = "Three of a Kind";
                    break;
                case PokerResult.TwoPair:
                    result = "Two Pair";
                    break;
                case PokerResult.Pair:
                    result = "Pair";
                    break;
                case PokerResult.HighCard:
                    result = "High Card";
                    break;
                case PokerResult.InsufficientCard:
                    result = "<5"; // string.Empty;
                    break;
                case PokerResult.Not5Card:
                    result = "!= 5"; // string.Empty;
                    break;
                case PokerResult.CardDuplicated:
                    result = "duplicate card"; // string.Empty;
                    break;
                case PokerResult.Undetermined:
                    result = "undertermined"; // string.Empty;
                    break;
            }

            return result;
        }
    }
}
