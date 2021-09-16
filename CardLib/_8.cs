using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardLib
{
    public sealed class _8 : Card
    {
        //public CardSuit Suit { get; private set; }
        //public const int Value = 8;
        //public const int Sequence = 8;

        //public const string Face = "8";

        public override CardSuit Suit { get => _suit; }

        public override int Value => 8;

        public override int Sequence => 8;

        public override string Face => "8";

        readonly CardSuit _suit;

        public _8(CardSuit cardSuit)
        {
            this._suit = cardSuit;
        }


    }
}
