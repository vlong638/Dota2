using VL.Common.ORM.Objects;

namespace DOTA2DataBase.Objects.Entities
{
    public class TPlayerProperties
    {
        #region Properties
        public static PDMDbProperty PlayerId { get; set; } = new PDMDbProperty(nameof(PlayerId), "PlayerId", "选手Id", true, PDMDataType.uniqueidentifier, 0, 0, true, null);
        public static PDMDbProperty Name { get; set; } = new PDMDbProperty(nameof(Name), "Name", "选手名称", false, PDMDataType.nvarchar, 20, 0, true, null);
        public static PDMDbProperty NameAbbr { get; set; } = new PDMDbProperty(nameof(NameAbbr), "NameAbbr", "选手名称(缩写)", false, PDMDataType.nvarchar, 20, 0, true, null);
        #endregion
    }
}
