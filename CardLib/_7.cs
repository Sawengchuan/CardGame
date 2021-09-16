using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardLib
{
    public sealed class _7 : Card
    {
        //public CardSuit Suit { get; private set; }
        //public const int Value = 7;
        //public const int Sequence = 7;

        //public const string Face = "7";

        public override CardSuit Suit { get => _suit; }

        public override int Value => 7;

        public override int Sequence => 7;

        public override string Face => "7";

        readonly CardSuit _suit;

        public _7(CardSuit cardSuit)
        {
            this._suit = cardSuit;
        }



    }
}
