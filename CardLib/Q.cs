using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardLib
{
    public sealed class Q : Card
    {
        //public CardSuit Suit
        //{
        //    get; private set;
        //}
        //public const int Value = 12; 
        //public const int Sequence = 12;

        //public const string Face = "Q";

        public override CardSuit Suit { get => _suit; }

        public override int Value => 12;

        public override int Sequence => 12;

        public override string Face => "Q";

        readonly CardSuit _suit;

        public Q(CardSuit cardSuit)
        {
            this._suit = cardSuit;
        }

    }
}
