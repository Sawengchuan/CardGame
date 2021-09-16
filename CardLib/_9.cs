using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardLib
{
    public sealed class _9 : Card
    {
        //public CardSuit Suit { get; private set; }
        //public const int Value = 9;
        //public const int Sequence = 9;

        //public const string Face = "9";

        public override CardSuit Suit { get => _suit; }

        public override int Value => 9;

        public override int Sequence => 9;

        public override string Face => "9";

        readonly CardSuit _suit;

        public _9(CardSuit cardSuit)
        {
            this._suit = cardSuit;
        }


    }
}
