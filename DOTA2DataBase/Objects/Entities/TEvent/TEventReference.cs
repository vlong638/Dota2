using System;
using System.Collections.Generic;
using VL.Common.ORM.Objects;

namespace DOTA2DataBase.Objects.Entities
{
    public partial class TEvent : IPDMTBase
    {
        public List<TEventReward> EventRewards { get; set; }
        public List<TMatch> Matches { get; set; }
    }
}
