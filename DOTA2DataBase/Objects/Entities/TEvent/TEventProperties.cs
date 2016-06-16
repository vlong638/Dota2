using VL.Common.ORM.Objects;

namespace DOTA2DataBase.Objects.Entities
{
    public class TEventProperties
    {
        #region Properties
        public static PDMDbProperty EventId { get; set; } = new PDMDbProperty(nameof(EventId), "EventId", "赛事Id", true, PDMDataType.uniqueidentifier, 0, 0, true, null);
        public static PDMDbProperty Name { get; set; } = new PDMDbProperty(nameof(Name), "Name", "赛事名称", false, PDMDataType.nvarchar, 40, 0, true, null);
        public static PDMDbProperty NameAbbr { get; set; } = new PDMDbProperty(nameof(NameAbbr), "NameAbbr", "赛事名称(缩写)", false, PDMDataType.nvarchar, 40, 0, true, null);
        public static PDMDbProperty Bonus { get; set; } = new PDMDbProperty(nameof(Bonus), "Bonus", "奖金情况", false, PDMDataType.nvarchar, 40, 0, true, null);
        #endregion
    }
}
