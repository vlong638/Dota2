using System.Runtime.Serialization;
using System;
using System.Collections.Generic;
using System.Data;
using VL.Common.ORM.Objects;
using DOTA2DataBase.Objects.Enums;

namespace DOTA2DataBase.Objects.Entities
{
    [DataContract]
    public partial class TTeam_Player : IPDMTBase
    {
        #region Properties
        [DataMember]
        public Guid TeamId { get; set; }
        [DataMember]
        public Guid PlayerId { get; set; }
        [DataMember]
        public DateTime? StartTime { get; set; }
        [DataMember]
        public DateTime? EndTime { get; set; }
        [DataMember]
        public String Remark { get; set; }
        #endregion

        #region Constructors
        public TTeam_Player()
        {
        }
        public TTeam_Player(IDataReader reader) : base(reader)
        {
        }
        #endregion

        #region Methods
        public override void Init(IDataReader reader)
        {
            this.TeamId = new Guid(reader[nameof(this.TeamId)].ToString());
            this.PlayerId = new Guid(reader[nameof(this.PlayerId)].ToString());
            if (reader[nameof(this.StartTime)] != DBNull.Value)
            {
                this.StartTime = Convert.ToDateTime(reader[nameof(this.StartTime)]);
            }
            if (reader[nameof(this.EndTime)] != DBNull.Value)
            {
                this.EndTime = Convert.ToDateTime(reader[nameof(this.EndTime)]);
            }
            if (reader[nameof(this.Remark)] != DBNull.Value)
            {
                this.Remark = Convert.ToString(reader[nameof(this.Remark)]);
            }
        }
        public override void Init(IDataReader reader, List<string> fields)
        {
            if (fields.Contains(nameof(TeamId)))
            {
                this.TeamId = new Guid(reader[nameof(this.TeamId)].ToString());
            }
            if (fields.Contains(nameof(PlayerId)))
            {
                this.PlayerId = new Guid(reader[nameof(this.PlayerId)].ToString());
            }
            if (fields.Contains(nameof(StartTime)))
            {
                if (reader[nameof(this.StartTime)] != DBNull.Value)
                {
                    this.StartTime = Convert.ToDateTime(reader[nameof(this.StartTime)]);
                }
            }
            if (fields.Contains(nameof(EndTime)))
            {
                if (reader[nameof(this.EndTime)] != DBNull.Value)
                {
                    this.EndTime = Convert.ToDateTime(reader[nameof(this.EndTime)]);
                }
            }
            if (fields.Contains(nameof(Remark)))
            {
                if (reader[nameof(this.Remark)] != DBNull.Value)
                {
                    this.Remark = Convert.ToString(reader[nameof(this.Remark)]);
                }
            }
        }
        public override string GetTableName()
        {
            return nameof(TTeam_Player);
        }
        #endregion
    }
}
