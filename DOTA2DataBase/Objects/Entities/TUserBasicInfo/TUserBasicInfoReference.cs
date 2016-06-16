using System;
using System.Collections.Generic;
using VL.Common.ORM.Objects;

namespace DOTA2DataBase.Objects.Entities
{
    public partial class TUserBasicInfo : IPDMTBase
    {
        public TUser User { get; set; }
    }
}
