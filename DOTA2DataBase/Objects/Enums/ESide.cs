using System.Runtime.Serialization;

namespace DOTA2DataBase.Objects.Enums
{
    [DataContract]
    public enum ESide
    {
        /// <summary>
        /// 未指定
        /// </summary>
        [EnumMember]
        None = 0,
        /// <summary>
        /// 天辉
        /// </summary>
        [EnumMember]
        radiant = 1,
        /// <summary>
        /// 夜魇(肉山)
        /// </summary>
        [EnumMember]
        dire = 2,
    }
}
