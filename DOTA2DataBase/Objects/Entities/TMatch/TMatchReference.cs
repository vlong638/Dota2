using System;
using System.Collections.Generic;
using VL.Common.ORM.Objects;

namespace DOTA2DataBase.Objects.Entities
{
    public partial class TMatch : IPDMTBase
    {
        public TEvent Event { get; set; }
        public List<TMatch_Team> Match_Team { get; set; }
        public List<TRound> Rounds { get; set; }
    }
}
