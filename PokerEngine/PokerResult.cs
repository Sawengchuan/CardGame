using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerEngine
{
    enum PokerResult
    {
        RoyalFlush,
        StraightFlush,
        FourOfAKind,
        FullHouse,
        Flush,
        Straight,
        ThreeOfAKind,
        TwoPair,Pair,
        HighCard,
        InsufficientCard,
        Not5Card,
        CardDuplicated,
        Undetermined
    }
}
