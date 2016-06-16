using System;
using System.Collections.Generic;
using VL.Common.ORM.Objects;

namespace DOTA2DataBase.Objects.Entities
{
    public partial class TEventReward : IPDMTBase
    {
        public TEvent Event { get; set; }
    }
}
