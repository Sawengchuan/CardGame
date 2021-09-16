using CardLib;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerEngine
{
    class CardComparer : IEqualityComparer<Card>
    {
        public bool Equals(Card x, Card y)
        {
            return x.Face == y.Face && x.Suit == y.Suit && x.Value == y.Value;
        }

        public int GetHashCode([DisallowNull] Card obj)
        {
            int hashCode = 0;

            if (obj.Suit == CardSuit.Club)
                hashCode += 1000;

            if (obj.Suit == CardSuit.Diamond)
                hashCode += 2000;

            if (obj.Suit == CardSuit.Heart)
                hashCode += 3000;

            if (obj.Suit == CardSuit.Spade)
                hashCode += 4000;

            return hashCode + obj.Value; //.GetHashCode();
        }
    }
}
