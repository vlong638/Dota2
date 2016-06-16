using System;
using System.Collections.Generic;
using VL.Common.ORM.Objects;

namespace DOTA2DataBase.Objects.Entities
{
    public partial class TUser : IPDMTBase
    {
        public TUserBasicInfo UserBasicInfo { get; set; }
    }
}
