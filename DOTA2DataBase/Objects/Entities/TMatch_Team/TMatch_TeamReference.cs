using System;
using System.Collections.Generic;
using VL.Common.ORM.Objects;

namespace DOTA2DataBase.Objects.Entities
{
    public partial class TMatch_Team : IPDMTBase
    {
        public TMatch Match { get; set; }
        public TTeam Team { get; set; }
    }
}
