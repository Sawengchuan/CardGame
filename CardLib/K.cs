using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardLib
{
    public sealed class K : Card
    {
        //public CardSuit Suit
        //{
        //    get; private set;
        //}
        //public const int Value = 13; 
        //public const int Sequence = 13;

        //public const string Face = "K";

        public override CardSuit Suit { get => _suit; }

        public override int Value => 13;

        public override int Sequence => 13;

        public override string Face => "K";

        readonly CardSuit _suit;

        public K(CardSuit cardSuit)
        {
            this._suit = cardSuit;
        }

    }
}
