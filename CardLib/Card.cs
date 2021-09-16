using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardLib
{
    public abstract class Card
    {
        public abstract CardSuit Suit { get; }
        public abstract int Value { get; }
        public abstract int Sequence { get; }
        public abstract string Face { get; }
    }
}
