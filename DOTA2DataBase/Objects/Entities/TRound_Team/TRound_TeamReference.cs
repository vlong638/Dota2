using System;
using System.Collections.Generic;
using VL.Common.ORM.Objects;

namespace DOTA2DataBase.Objects.Entities
{
    public partial class TRound_Team : IPDMTBase
    {
        public TRound Round { get; set; }
        public TTeam Team { get; set; }
    }
}
