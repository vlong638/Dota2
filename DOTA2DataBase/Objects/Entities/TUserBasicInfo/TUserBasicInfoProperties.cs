using VL.Common.ORM.Objects;

namespace DOTA2DataBase.Objects.Entities
{
    public class TUserBasicInfoProperties
    {
        #region Properties
        public static PDMDbProperty UserId { get; set; } = new PDMDbProperty(nameof(UserId), "UserId", "用户Id", true, PDMDataType.uniqueidentifier, 0, 0, true, null);
        public static PDMDbProperty Gender { get; set; } = new PDMDbProperty(nameof(Gender), "Gender", "性别", false, PDMDataType.numeric, 1, 0, true, null);
        public static PDMDbProperty Birthday { get; set; } = new PDMDbProperty(nameof(Birthday), "Birthday", "出生日期", false, PDMDataType.datetime, 0, 0, true, null);
        public static PDMDbProperty Mobile { get; set; } = new PDMDbProperty(nameof(Mobile), "Mobile", "手机", false, PDMDataType.numeric, 11, 0, true, null);
        public static PDMDbProperty Email { get; set; } = new PDMDbProperty(nameof(Email), "Email", "电子邮箱(不区分大小写)", false, PDMDataType.nvarchar, 32, 0, true, null);
        #endregion
    }
}
