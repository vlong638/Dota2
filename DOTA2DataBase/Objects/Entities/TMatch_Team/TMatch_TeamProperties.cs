using VL.Common.ORM.Objects;

namespace DOTA2DataBase.Objects.Entities
{
    public class TMatch_TeamProperties
    {
        #region Properties
        public static PDMDbProperty MatchId { get; set; } = new PDMDbProperty(nameof(MatchId), "MatchId", "对阵Id", true, PDMDataType.uniqueidentifier, 0, 0, true, null);
        public static PDMDbProperty TeamId { get; set; } = new PDMDbProperty(nameof(TeamId), "TeamId", "战队Id", true, PDMDataType.uniqueidentifier, 0, 0, true, null);
        #endregion
    }
}
