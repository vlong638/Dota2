using System.Runtime.Serialization;

namespace DOTA2DataBase.Objects.Enums
{
    [DataContract]
    public enum ECourseType
    {
        /// <summary>
        /// 语文
        /// </summary>
        [EnumMember]
        Chinese = 1,
        /// <summary>
        /// 英语
        /// </summary>
        [EnumMember]
        English = 2,
    }
}
