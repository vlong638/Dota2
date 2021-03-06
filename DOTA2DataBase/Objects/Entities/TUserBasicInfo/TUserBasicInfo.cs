using System.Runtime.Serialization;
using System;
using System.Collections.Generic;
using System.Data;
using VL.Common.ORM.Objects;
using DOTA2DataBase.Objects.Enums;

namespace DOTA2DataBase.Objects.Entities
{
    [DataContract]
    public partial class TUserBasicInfo : IPDMTBase
    {
        #region Properties
        [DataMember]
        public Guid UserId { get; set; }
        [DataMember]
        public EGender (Shortcut) Gender { get; set; }
        [DataMember]
        public DateTime Birthday { get; set; }
        [DataMember]
        public Int16 Mobile { get; set; }
        [DataMember]
        public String Email { get; set; }
        #endregion

        #region Constructors
        public TUserBasicInfo()
        {
        }
        public TUserBasicInfo(IDataReader reader) : base(reader)
        {
        }
        #endregion

        #region Methods
        public override void Init(IDataReader reader)
        {
            this.UserId = new Guid(reader[nameof(this.UserId)].ToString());
            this.Gender = (EGender (Shortcut))Enum.Parse(typeof(EGender (Shortcut)), reader[nameof(this.Gender)].ToString());
            this.Birthday = Convert.ToDateTime(reader[nameof(this.Birthday)]);
            this.Mobile = Convert.ToInt16(reader[nameof(this.Mobile)]);
            this.Email = Convert.ToString(reader[nameof(this.Email)]);
        }
        public override void Init(IDataReader reader, List<string> fields)
        {
            if (fields.Contains(nameof(UserId)))
            {
                this.UserId = new Guid(reader[nameof(this.UserId)].ToString());
            }
            if (fields.Contains(nameof(Gender)))
            {
                this.Gender = (EGender (Shortcut))Enum.Parse(typeof(EGender (Shortcut)), reader[nameof(this.Gender)].ToString());
            }
            if (fields.Contains(nameof(Birthday)))
            {
                this.Birthday = Convert.ToDateTime(reader[nameof(this.Birthday)]);
            }
            if (fields.Contains(nameof(Mobile)))
            {
                this.Mobile = Convert.ToInt16(reader[nameof(this.Mobile)]);
            }
            if (fields.Contains(nameof(Email)))
            {
                this.Email = Convert.ToString(reader[nameof(this.Email)]);
            }
        }
        public override string GetTableName()
        {
            return nameof(TUserBasicInfo);
        }
        #endregion
    }
}
