using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardLib
{
    public sealed class _2 : Card
    {
        //public CardSuit Suit { get; private set; }
        //public const int Value = 2;
        //public const int Sequence = 2;
        //public const string Face = "2";

        public override CardSuit Suit => _suit;

        public override int Value => 2;

        public override int Sequence => 2;

        public override string Face => "2";

        readonly CardSuit _suit;

        public _2(CardSuit cardSuit)
        {
            this._suit = cardSuit;
        }
    }
}
