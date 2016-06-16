using System.Runtime.Serialization;
using System;
using System.Collections.Generic;
using System.Data;
using VL.Common.ORM.Objects;
using DOTA2DataBase.Objects.Enums;

namespace DOTA2DataBase.Objects.Entities
{
    [DataContract]
    public partial class TRound_Team : IPDMTBase
    {
        #region Properties
        [DataMember]
        public Guid RoundId { get; set; }
        [DataMember]
        public Guid TeamId { get; set; }
        [DataMember]
        public Int64 Side { get; set; }
        [DataMember]
        public String BP { get; set; }
        #endregion

        #region Constructors
        public TRound_Team()
        {
        }
        public TRound_Team(IDataReader reader) : base(reader)
        {
        }
        #endregion

        #region Methods
        public override void Init(IDataReader reader)
        {
            this.RoundId = new Guid(reader[nameof(this.RoundId)].ToString());
            this.TeamId = new Guid(reader[nameof(this.TeamId)].ToString());
            this.Side = Convert.ToInt64(reader[nameof(this.Side)]);
            this.BP = Convert.ToString(reader[nameof(this.BP)]);
        }
        public override void Init(IDataReader reader, List<string> fields)
        {
            if (fields.Contains(nameof(RoundId)))
            {
                this.RoundId = new Guid(reader[nameof(this.RoundId)].ToString());
            }
            if (fields.Contains(nameof(TeamId)))
            {
                this.TeamId = new Guid(reader[nameof(this.TeamId)].ToString());
            }
            if (fields.Contains(nameof(Side)))
            {
                this.Side = Convert.ToInt64(reader[nameof(this.Side)]);
            }
            if (fields.Contains(nameof(BP)))
            {
                this.BP = Convert.ToString(reader[nameof(this.BP)]);
            }
        }
        public override string GetTableName()
        {
            return nameof(TRound_Team);
        }
        #endregion
    }
}
