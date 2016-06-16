using System.Runtime.Serialization;
using System;
using System.Collections.Generic;
using System.Data;
using VL.Common.ORM.Objects;
using DOTA2DataBase.Objects.Enums;

namespace DOTA2DataBase.Objects.Entities
{
    [DataContract]
    public partial class TRound_Team_Player : IPDMTBase
    {
        #region Properties
        [DataMember]
        public Guid RoundId { get; set; }
        [DataMember]
        public Guid TeamId { get; set; }
        [DataMember]
        public Guid PlayerId { get; set; }
        [DataMember]
        public Guid HeroId { get; set; }
        [DataMember]
        public Int64 KDA { get; set; }
        [DataMember]
        public String KDADetail { get; set; }
        [DataMember]
        public Int64 GPM { get; set; }
        [DataMember]
        public Int64 XPM { get; set; }
        [DataMember]
        public Boolean? IsGodLike { get; set; }
        #endregion

        #region Constructors
        public TRound_Team_Player()
        {
        }
        public TRound_Team_Player(IDataReader reader) : base(reader)
        {
        }
        #endregion

        #region Methods
        public override void Init(IDataReader reader)
        {
            this.RoundId = new Guid(reader[nameof(this.RoundId)].ToString());
            this.TeamId = new Guid(reader[nameof(this.TeamId)].ToString());
            this.PlayerId = new Guid(reader[nameof(this.PlayerId)].ToString());
            this.HeroId = new Guid(reader[nameof(this.HeroId)].ToString());
            this.KDA = Convert.ToInt64(reader[nameof(this.KDA)]);
            this.KDADetail = Convert.ToString(reader[nameof(this.KDADetail)]);
            this.GPM = Convert.ToInt64(reader[nameof(this.GPM)]);
            this.XPM = Convert.ToInt64(reader[nameof(this.XPM)]);
            if (reader[nameof(this.IsGodLike)] != DBNull.Value)
            {
                this.IsGodLike = Convert.ToBoolean(reader[nameof(this.IsGodLike)]);
            }
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
            if (fields.Contains(nameof(PlayerId)))
            {
                this.PlayerId = new Guid(reader[nameof(this.PlayerId)].ToString());
            }
            if (fields.Contains(nameof(HeroId)))
            {
                this.HeroId = new Guid(reader[nameof(this.HeroId)].ToString());
            }
            if (fields.Contains(nameof(KDA)))
            {
                this.KDA = Convert.ToInt64(reader[nameof(this.KDA)]);
            }
            if (fields.Contains(nameof(KDADetail)))
            {
                this.KDADetail = Convert.ToString(reader[nameof(this.KDADetail)]);
            }
            if (fields.Contains(nameof(GPM)))
            {
                this.GPM = Convert.ToInt64(reader[nameof(this.GPM)]);
            }
            if (fields.Contains(nameof(XPM)))
            {
                this.XPM = Convert.ToInt64(reader[nameof(this.XPM)]);
            }
            if (fields.Contains(nameof(IsGodLike)))
            {
                if (reader[nameof(this.IsGodLike)] != DBNull.Value)
                {
                    this.IsGodLike = Convert.ToBoolean(reader[nameof(this.IsGodLike)]);
                }
            }
        }
        public override string GetTableName()
        {
            return nameof(TRound_Team_Player);
        }
        #endregion
    }
}
