using CardLib;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerEngine
{
    class CardValueComparer : IEqualityComparer<Card>
    {
        public bool Equals(Card x, Card y)
        {
            return x.Value == y.Value;
        }

        public int GetHashCode([DisallowNull] Card obj)
        {
            return obj.Value;
        }
    }
}
