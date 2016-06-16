using System.Runtime.Serialization;
using System;
using System.Collections.Generic;
using System.Data;
using VL.Common.ORM.Objects;
using DOTA2DataBase.Objects.Enums;

namespace DOTA2DataBase.Objects.Entities
{
    [DataContract]
    public partial class TEventReward : IPDMTBase
    {
        #region Properties
        [DataMember]
        public Guid EventIdRewardId { get; set; }
        [DataMember]
        public Guid EventId { get; set; }
        [DataMember]
        public String Area { get; set; }
        [DataMember]
        public String Description { get; set; }
        [DataMember]
        public String Bonus { get; set; }
        #endregion

        #region Constructors
        public TEventReward()
        {
        }
        public TEventReward(IDataReader reader) : base(reader)
        {
        }
        #endregion

        #region Methods
        public override void Init(IDataReader reader)
        {
            this.EventIdRewardId = new Guid(reader[nameof(this.EventIdRewardId)].ToString());
            this.EventId = new Guid(reader[nameof(this.EventId)].ToString());
            this.Area = Convert.ToString(reader[nameof(this.Area)]);
            this.Description = Convert.ToString(reader[nameof(this.Description)]);
            this.Bonus = Convert.ToString(reader[nameof(this.Bonus)]);
        }
        public override void Init(IDataReader reader, List<string> fields)
        {
            if (fields.Contains(nameof(EventIdRewardId)))
            {
                this.EventIdRewardId = new Guid(reader[nameof(this.EventIdRewardId)].ToString());
            }
            if (fields.Contains(nameof(EventId)))
            {
                this.EventId = new Guid(reader[nameof(this.EventId)].ToString());
            }
            if (fields.Contains(nameof(Area)))
            {
                this.Area = Convert.ToString(reader[nameof(this.Area)]);
            }
            if (fields.Contains(nameof(Description)))
            {
                this.Description = Convert.ToString(reader[nameof(this.Description)]);
            }
            if (fields.Contains(nameof(Bonus)))
            {
                this.Bonus = Convert.ToString(reader[nameof(this.Bonus)]);
            }
        }
        public override string GetTableName()
        {
            return nameof(TEventReward);
        }
        #endregion
    }
}
