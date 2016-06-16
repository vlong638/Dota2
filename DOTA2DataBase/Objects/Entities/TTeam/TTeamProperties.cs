using VL.Common.ORM.Objects;

namespace DOTA2DataBase.Objects.Entities
{
    public class TTeamProperties
    {
        #region Properties
        public static PDMDbProperty TeamId { get; set; } = new PDMDbProperty(nameof(TeamId), "TeamId", "战队Id", true, PDMDataType.uniqueidentifier, 0, 0, true, null);
        public static PDMDbProperty Name { get; set; } = new PDMDbProperty(nameof(Name), "Name", "战队名称", false, PDMDataType.nvarchar, 20, 0, true, null);
        public static PDMDbProperty NameAbbr { get; set; } = new PDMDbProperty(nameof(NameAbbr), "NameAbbr", "战队名称(缩写)", false, PDMDataType.nvarchar, 20, 0, true, null);
        public static PDMDbProperty MMR { get; set; } = new PDMDbProperty(nameof(MMR), "MMR", "比赛匹配分级", false, PDMDataType.numeric, 0, 0, true, null);
        #endregion
    }
}
