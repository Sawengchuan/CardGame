using CardLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerEngine
{
    class IsEmpty : IRules
    {
        public PokerResult Execute(List<Card> Cards)
        {
            if (Cards == null)
                return PokerResult.InsufficientCard;

            return PokerResult.Undetermined;
        }
    }
}
