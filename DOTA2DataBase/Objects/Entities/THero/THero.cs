using System.Runtime.Serialization;
using System;
using System.Collections.Generic;
using System.Data;
using VL.Common.ORM.Objects;
using DOTA2DataBase.Objects.Enums;

namespace DOTA2DataBase.Objects.Entities
{
    [DataContract]
    public partial class THero : IPDMTBase
    {
        #region Properties
        [DataMember]
        public Guid HeroId { get; set; }
        [DataMember]
        public String Name { get; set; }
        [DataMember]
        public String NameAbbr { get; set; }
        #endregion

        #region Constructors
        public THero()
        {
        }
        public THero(IDataReader reader) : base(reader)
        {
        }
        #endregion

        #region Methods
        public override void Init(IDataReader reader)
        {
            this.HeroId = new Guid(reader[nameof(this.HeroId)].ToString());
            this.Name = Convert.ToString(reader[nameof(this.Name)]);
            this.NameAbbr = Convert.ToString(reader[nameof(this.NameAbbr)]);
        }
        public override void Init(IDataReader reader, List<string> fields)
        {
            if (fields.Contains(nameof(HeroId)))
            {
                this.HeroId = new Guid(reader[nameof(this.HeroId)].ToString());
            }
            if (fields.Contains(nameof(Name)))
            {
                this.Name = Convert.ToString(reader[nameof(this.Name)]);
            }
            if (fields.Contains(nameof(NameAbbr)))
            {
                this.NameAbbr = Convert.ToString(reader[nameof(this.NameAbbr)]);
            }
        }
        public override string GetTableName()
        {
            return nameof(THero);
        }
        #endregion
    }
}
