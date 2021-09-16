using CardLib;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerEngine
{
    class CardSuitComparer : IEqualityComparer<Card>
    {
        public bool Equals(Card x, Card y)
        {
            return x.Suit == y.Suit;
        }

        public int GetHashCode([DisallowNull] Card obj)
        {
            int hashCode = 0;

            if (obj.Suit == CardSuit.Club)
                hashCode = 10000;

            if (obj.Suit == CardSuit.Diamond)
                hashCode = 20000;

            if (obj.Suit == CardSuit.Heart)
                hashCode = 30000;

            if (obj.Suit == CardSuit.Spade)
                hashCode = 40000;

            return hashCode;

        }
    }
}
