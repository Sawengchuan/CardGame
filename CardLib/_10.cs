using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardLib
{
    public sealed class _10 : Card
    {
        //public CardSuit Suit
        //{
        //    get; private set;
        //}
        //public const int Value = 10; 
        //public const int Sequence = 10;

        //public const string Face = "10";

        public override CardSuit Suit { get => _suit; }

        public override int Value => 10;

        public override int Sequence => 10;

        public override string Face => "10";

        readonly CardSuit _suit;

        public _10(CardSuit cardSuit)
        {
            this._suit = cardSuit;
        }
    }
}
