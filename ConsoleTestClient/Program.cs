using System;
using System.Collections.Generic;
using CardLib;
using PokerEngine;


namespace ConsoleTestClient
{
    class Program
    {
        static void Main(string[] args)
        {
            RankingEvaluator eval = new RankingEvaluator();

            List<Card> cards = new List<Card>();

            /*
            cards.Add(new _2(CardSuit.Club));
            cards.Add(new _5(CardSuit.Club));
            cards.Add(new _4(CardSuit.Diamond));
            cards.Add(new _3(CardSuit.Club));
            cards.Add(new _8(CardSuit.Spade));
            */


            cards.Add(new K(CardSuit.Heart));
            //cards.Add(new J(CardSuit.Spade));
            cards.Add(new _2(CardSuit.Club));
            cards.Add(new _3(CardSuit.Heart));
            cards.Add(new Q(CardSuit.Spade));
            cards.Add(new J(CardSuit.Diamond));
//            cards.Add(new K(CardSuit.Club));



            /*
             * 
            // royal flush
            cards.Add(new _10(CardSuit.Club));
            cards.Add(new J(CardSuit.Club));
            cards.Add(new Q(CardSuit.Club));
            cards.Add(new A(CardSuit.Club));
            cards.Add(new K(CardSuit.Club));
            // end royal flush
            */

            var result = eval.Evaluate(cards);

            Console.WriteLine(result);
            Console.Read();

        }
    }
}
