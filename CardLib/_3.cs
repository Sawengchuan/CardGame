using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardLib
{
    public sealed class _3 : Card
    {
        //public CardSuit Suit { get; private set; }
        //public const int Value = 3;
        //public const int Sequence = 3;
        //public const string Face = "3";

        public override CardSuit Suit { get => _suit; }

        public override int Value => 3;

        public override int Sequence => 3;

        public override string Face => "3";

        readonly CardSuit _suit;

        public _3(CardSuit cardSuit)
        {
            this._suit = cardSuit;
        }


    }
}
