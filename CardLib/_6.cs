using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardLib
{
    public sealed class _6 : Card
    {
        //public CardSuit Suit { get; private set; }
        //public const int Value = 6;
        //public const int Sequence = 6;
        //public const string Face = "6";

        public override CardSuit Suit { get => _suit; }

        public override int Value => 6;

        public override int Sequence => 6;

        public override string Face => "6";

        readonly CardSuit _suit;

        public _6(CardSuit cardSuit)
        {
            this._suit = cardSuit;
        }


    }
}
