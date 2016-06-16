using VL.Common.ORM.Objects;

namespace DOTA2DataBase.Objects.Entities
{
    public class TEventRewardProperties
    {
        #region Properties
        public static PDMDbProperty EventIdRewardId { get; set; } = new PDMDbProperty(nameof(EventIdRewardId), "EventIdRewardId", "赛事奖励Id", true, PDMDataType.uniqueidentifier, 0, 0, true, null);
        public static PDMDbProperty EventId { get; set; } = new PDMDbProperty(nameof(EventId), "EventId", "赛事Id", false, PDMDataType.uniqueidentifier, 0, 0, true, null);
        public static PDMDbProperty Area { get; set; } = new PDMDbProperty(nameof(Area), "Area", "获奖区间(如第一名,2-3...)", false, PDMDataType.nvarchar, 40, 0, true, null);
        public static PDMDbProperty Description { get; set; } = new PDMDbProperty(nameof(Description), "Description", "描述(冠亚季,四五六等奖...)", false, PDMDataType.nvarchar, 40, 0, true, null);
        public static PDMDbProperty Bonus { get; set; } = new PDMDbProperty(nameof(Bonus), "Bonus", "奖金情况", false, PDMDataType.nvarchar, 40, 0, true, null);
        #endregion
    }
}
