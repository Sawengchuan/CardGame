using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardLib
{
    public sealed class A : Card
    {
        //public CardSuit Suit { get; private set; }
        //public const int Value = 1;
        //public const int Sequence = 1;

        //public const string Face = "A";

        public override CardSuit Suit { get => _suit; }

        public override int Value => 1;

        public override int Sequence => 1;

        public override string Face => "A";

        readonly CardSuit _suit;

        public A(CardSuit cardSuit)
        {
            this._suit = cardSuit;
        }

    }
}
