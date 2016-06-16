using System.Runtime.Serialization;
using System;
using System.Collections.Generic;
using System.Data;
using VL.Common.ORM.Objects;
using DOTA2DataBase.Objects.Enums;

namespace DOTA2DataBase.Objects.Entities
{
    [DataContract]
    public partial class TTeam : IPDMTBase
    {
        #region Properties
        [DataMember]
        public Guid TeamId { get; set; }
        [DataMember]
        public String Name { get; set; }
        [DataMember]
        public String NameAbbr { get; set; }
        [DataMember]
        public Int64 MMR { get; set; }
        #endregion

        #region Constructors
        public TTeam()
        {
        }
        public TTeam(IDataReader reader) : base(reader)
        {
        }
        #endregion

        #region Methods
        public override void Init(IDataReader reader)
        {
            this.TeamId = new Guid(reader[nameof(this.TeamId)].ToString());
            this.Name = Convert.ToString(reader[nameof(this.Name)]);
            this.NameAbbr = Convert.ToString(reader[nameof(this.NameAbbr)]);
            this.MMR = Convert.ToInt64(reader[nameof(this.MMR)]);
        }
        public override void Init(IDataReader reader, List<string> fields)
        {
            if (fields.Contains(nameof(TeamId)))
            {
                this.TeamId = new Guid(reader[nameof(this.TeamId)].ToString());
            }
            if (fields.Contains(nameof(Name)))
            {
                this.Name = Convert.ToString(reader[nameof(this.Name)]);
            }
            if (fields.Contains(nameof(NameAbbr)))
            {
                this.NameAbbr = Convert.ToString(reader[nameof(this.NameAbbr)]);
            }
            if (fields.Contains(nameof(MMR)))
            {
                this.MMR = Convert.ToInt64(reader[nameof(this.MMR)]);
            }
        }
        public override string GetTableName()
        {
            return nameof(TTeam);
        }
        #endregion
    }
}
