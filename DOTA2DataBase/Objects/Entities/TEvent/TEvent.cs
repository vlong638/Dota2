using System.Runtime.Serialization;
using System;
using System.Collections.Generic;
using System.Data;
using VL.Common.ORM.Objects;
using DOTA2DataBase.Objects.Enums;

namespace DOTA2DataBase.Objects.Entities
{
    [DataContract]
    public partial class TEvent : IPDMTBase
    {
        #region Properties
        [DataMember]
        public Guid EventId { get; set; }
        [DataMember]
        public String Name { get; set; }
        [DataMember]
        public String NameAbbr { get; set; }
        [DataMember]
        public String Bonus { get; set; }
        #endregion

        #region Constructors
        public TEvent()
        {
        }
        public TEvent(IDataReader reader) : base(reader)
        {
        }
        #endregion

        #region Methods
        public override void Init(IDataReader reader)
        {
            this.EventId = new Guid(reader[nameof(this.EventId)].ToString());
            this.Name = Convert.ToString(reader[nameof(this.Name)]);
            this.NameAbbr = Convert.ToString(reader[nameof(this.NameAbbr)]);
            this.Bonus = Convert.ToString(reader[nameof(this.Bonus)]);
        }
        public override void Init(IDataReader reader, List<string> fields)
        {
            if (fields.Contains(nameof(EventId)))
            {
                this.EventId = new Guid(reader[nameof(this.EventId)].ToString());
            }
            if (fields.Contains(nameof(Name)))
            {
                this.Name = Convert.ToString(reader[nameof(this.Name)]);
            }
            if (fields.Contains(nameof(NameAbbr)))
            {
                this.NameAbbr = Convert.ToString(reader[nameof(this.NameAbbr)]);
            }
            if (fields.Contains(nameof(Bonus)))
            {
                this.Bonus = Convert.ToString(reader[nameof(this.Bonus)]);
            }
        }
        public override string GetTableName()
        {
            return nameof(TEvent);
        }
        #endregion
    }
}
