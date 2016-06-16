using VL.Common.ORM.Objects;

namespace DOTA2DataBase.Objects.Entities
{
    public class TMatchProperties
    {
        #region Properties
        public static PDMDbProperty EventId { get; set; } = new PDMDbProperty(nameof(EventId), "EventId", "赛事Id", false, PDMDataType.uniqueidentifier, 0, 0, true, null);
        public static PDMDbProperty MatchId { get; set; } = new PDMDbProperty(nameof(MatchId), "MatchId", "赛事Id", true, PDMDataType.uniqueidentifier, 0, 0, true, null);
        public static PDMDbProperty Name { get; set; } = new PDMDbProperty(nameof(Name), "Name", "名称,描述(某Event第n轮)", false, PDMDataType.nvarchar, 20, 0, true, null);
        public static PDMDbProperty TeamIdOfWinner { get; set; } = new PDMDbProperty(nameof(TeamIdOfWinner), "TeamIdOfWinner", "胜者队", false, PDMDataType.uniqueidentifier, 0, 0, true, null);
        #endregion
    }
}
