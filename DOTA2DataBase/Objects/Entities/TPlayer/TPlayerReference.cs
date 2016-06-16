using System;
using System.Collections.Generic;
using VL.Common.ORM.Objects;

namespace DOTA2DataBase.Objects.Entities
{
    public partial class TPlayer : IPDMTBase
    {
        public List<TRound_Team_Player> Round_Team_Player { get; set; }
    }
}
