using System.Runtime.Serialization;
using System;
using System.Collections.Generic;
using System.Data;
using VL.Common.ORM.Objects;
using DOTA2DataBase.Objects.Enums;

namespace DOTA2DataBase.Objects.Entities
{
    [DataContract]
    public partial class TMatch : IPDMTBase
    {
        #region Properties
        [DataMember]
        public Guid EventId { get; set; }
        [DataMember]
        public Guid MatchId { get; set; }
        [DataMember]
        public String Name { get; set; }
        [DataMember]
        public Guid TeamIdOfWinner { get; set; }
        #endregion

        #region Constructors
        public TMatch()
        {
        }
        public TMatch(IDataReader reader) : base(reader)
        {
        }
        #endregion

        #region Methods
        public override void Init(IDataReader reader)
        {
            this.EventId = new Guid(reader[nameof(this.EventId)].ToString());
            this.MatchId = new Guid(reader[nameof(this.MatchId)].ToString());
            this.Name = Convert.ToString(reader[nameof(this.Name)]);
            this.TeamIdOfWinner = new Guid(reader[nameof(this.TeamIdOfWinner)].ToString());
        }
        public override void Init(IDataReader reader, List<string> fields)
        {
            if (fields.Contains(nameof(EventId)))
            {
                this.EventId = new Guid(reader[nameof(this.EventId)].ToString());
            }
            if (fields.Contains(nameof(MatchId)))
            {
                this.MatchId = new Guid(reader[nameof(this.MatchId)].ToString());
            }
            if (fields.Contains(nameof(Name)))
            {
                this.Name = Convert.ToString(reader[nameof(this.Name)]);
            }
            if (fields.Contains(nameof(TeamIdOfWinner)))
            {
                this.TeamIdOfWinner = new Guid(reader[nameof(this.TeamIdOfWinner)].ToString());
            }
        }
        public override string GetTableName()
        {
            return nameof(TMatch);
        }
        #endregion
    }
}
