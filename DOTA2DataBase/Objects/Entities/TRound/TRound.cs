using System.Runtime.Serialization;
using System;
using System.Collections.Generic;
using System.Data;
using VL.Common.ORM.Objects;
using DOTA2DataBase.Objects.Enums;

namespace DOTA2DataBase.Objects.Entities
{
    [DataContract]
    public partial class TRound : IPDMTBase
    {
        #region Properties
        [DataMember]
        public Guid MatchId { get; set; }
        [DataMember]
        public Guid RoundId { get; set; }
        [DataMember]
        public String RoundNumber { get; set; }
        [DataMember]
        public Int64 RoundStatus { get; set; }
        [DataMember]
        public Guid TeamIdOfWinner { get; set; }
        #endregion

        #region Constructors
        public TRound()
        {
        }
        public TRound(IDataReader reader) : base(reader)
        {
        }
        #endregion

        #region Methods
        public override void Init(IDataReader reader)
        {
            this.MatchId = new Guid(reader[nameof(this.MatchId)].ToString());
            this.RoundId = new Guid(reader[nameof(this.RoundId)].ToString());
            this.RoundNumber = Convert.ToString(reader[nameof(this.RoundNumber)]);
            this.RoundStatus = Convert.ToInt64(reader[nameof(this.RoundStatus)]);
            this.TeamIdOfWinner = new Guid(reader[nameof(this.TeamIdOfWinner)].ToString());
        }
        public override void Init(IDataReader reader, List<string> fields)
        {
            if (fields.Contains(nameof(MatchId)))
            {
                this.MatchId = new Guid(reader[nameof(this.MatchId)].ToString());
            }
            if (fields.Contains(nameof(RoundId)))
            {
                this.RoundId = new Guid(reader[nameof(this.RoundId)].ToString());
            }
            if (fields.Contains(nameof(RoundNumber)))
            {
                this.RoundNumber = Convert.ToString(reader[nameof(this.RoundNumber)]);
            }
            if (fields.Contains(nameof(RoundStatus)))
            {
                this.RoundStatus = Convert.ToInt64(reader[nameof(this.RoundStatus)]);
            }
            if (fields.Contains(nameof(TeamIdOfWinner)))
            {
                this.TeamIdOfWinner = new Guid(reader[nameof(this.TeamIdOfWinner)].ToString());
            }
        }
        public override string GetTableName()
        {
            return nameof(TRound);
        }
        #endregion
    }
}
