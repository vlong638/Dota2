using System.Runtime.Serialization;
using System;
using System.Collections.Generic;
using System.Data;
using VL.Common.ORM.Objects;
using DOTA2DataBase.Objects.Enums;

namespace DOTA2DataBase.Objects.Entities
{
    [DataContract]
    public partial class TPlayer : IPDMTBase
    {
        #region Properties
        [DataMember]
        public Guid PlayerId { get; set; }
        [DataMember]
        public String Name { get; set; }
        [DataMember]
        public String NameAbbr { get; set; }
        #endregion

        #region Constructors
        public TPlayer()
        {
        }
        public TPlayer(IDataReader reader) : base(reader)
        {
        }
        #endregion

        #region Methods
        public override void Init(IDataReader reader)
        {
            this.PlayerId = new Guid(reader[nameof(this.PlayerId)].ToString());
            this.Name = Convert.ToString(reader[nameof(this.Name)]);
            this.NameAbbr = Convert.ToString(reader[nameof(this.NameAbbr)]);
        }
        public override void Init(IDataReader reader, List<string> fields)
        {
            if (fields.Contains(nameof(PlayerId)))
            {
                this.PlayerId = new Guid(reader[nameof(this.PlayerId)].ToString());
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
            return nameof(TPlayer);
        }
        #endregion
    }
}
