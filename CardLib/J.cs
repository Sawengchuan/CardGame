using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardLib
{
    public sealed class J : Card
    {
        //public CardSuit Suit
        //{
        //    get; private set;
        //}
        //public const int Value = 11; 
        //public const int Sequence = 11;

        //public const string Face = "J";

        // public override CardSuit Suit { get => _suit; }
        public override CardSuit Suit => _suit;

        public override int Value => 11;

        public override int Sequence => 11;

        public override string Face => "J";

        readonly CardSuit _suit;

        public J(CardSuit cardSuit)
        {
            this._suit = cardSuit;
        }

    }
}
