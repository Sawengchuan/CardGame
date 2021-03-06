using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardLib
{
    public sealed class _5 : Card
    {
        //public CardSuit Suit { get; private set; }
        //public const int Value = 5;
        //public const int Sequence = 5;
        //public const string Face = "5";

        public override CardSuit Suit { get => _suit; }

        public override int Value => 5;

        public override int Sequence => 5;

        public override string Face => "5";

        readonly CardSuit _suit;

        public _5(CardSuit cardSuit)
        {
            this._suit = cardSuit;
        }


    }
}
