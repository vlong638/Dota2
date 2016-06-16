using VL.Common.ORM.Objects;

namespace DOTA2DataBase.Objects.Entities
{
    public class TTeam_PlayerProperties
    {
        #region Properties
        public static PDMDbProperty TeamId { get; set; } = new PDMDbProperty(nameof(TeamId), "TeamId", "战队Id", false, PDMDataType.uniqueidentifier, 0, 0, true, null);
        public static PDMDbProperty PlayerId { get; set; } = new PDMDbProperty(nameof(PlayerId), "PlayerId", "选手Id", false, PDMDataType.uniqueidentifier, 0, 0, true, null);
        public static PDMDbProperty StartTime { get; set; } = new PDMDbProperty(nameof(StartTime), "StartTime", "开始时间", false, PDMDataType.datetime, 0, 0, false, null);
        public static PDMDbProperty EndTime { get; set; } = new PDMDbProperty(nameof(EndTime), "EndTime", "结束时间", false, PDMDataType.datetime, 0, 0, false, null);
        public static PDMDbProperty Remark { get; set; } = new PDMDbProperty(nameof(Remark), "Remark", "关系备注(如合约,临时外援...)", false, PDMDataType.nvarchar, 20, 0, false, null);
        #endregion
    }
}
