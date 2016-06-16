using System.Runtime.Serialization;
using System;
using System.Collections.Generic;
using System.Data;
using VL.Common.ORM.Objects;
using DOTA2DataBase.Objects.Enums;

namespace DOTA2DataBase.Objects.Entities
{
    [DataContract]
    public partial class TMatch_Team : IPDMTBase
    {
        #region Properties
        [DataMember]
        public Guid MatchId { get; set; }
        [DataMember]
        public Guid TeamId { get; set; }
        #endregion

        #region Constructors
        public TMatch_Team()
        {
        }
        public TMatch_Team(IDataReader reader) : base(reader)
        {
        }
        #endregion

        #region Methods
        public override void Init(IDataReader reader)
        {
            this.MatchId = new Guid(reader[nameof(this.MatchId)].ToString());
            this.TeamId = new Guid(reader[nameof(this.TeamId)].ToString());
        }
        public override void Init(IDataReader reader, List<string> fields)
        {
            if (fields.Contains(nameof(MatchId)))
            {
                this.MatchId = new Guid(reader[nameof(this.MatchId)].ToString());
            }
            if (fields.Contains(nameof(TeamId)))
            {
                this.TeamId = new Guid(reader[nameof(this.TeamId)].ToString());
            }
        }
        public override string GetTableName()
        {
            return nameof(TMatch_Team);
        }
        #endregion
    }
}
