using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardLib
{
    public sealed class _4 : Card
    {
        //public CardSuit Suit { get; private set; }
        //public const int Value = 4;
        //public const int Sequence = 4;

        //public const string Face = "4";

        public override CardSuit Suit { get => _suit; }

        public override int Value => 4;

        public override int Sequence => 4;

        public override string Face => "4";

        readonly CardSuit _suit;

        public _4(CardSuit cardSuit)
        {
            this._suit = cardSuit;
        }


    }
}


