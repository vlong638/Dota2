using VL.Common.ORM.Objects;

namespace DOTA2DataBase.Objects.Entities
{
    public class TRoundProperties
    {
        #region Properties
        public static PDMDbProperty MatchId { get; set; } = new PDMDbProperty(nameof(MatchId), "MatchId", "对阵Id", false, PDMDataType.uniqueidentifier, 0, 0, true, null);
        public static PDMDbProperty RoundId { get; set; } = new PDMDbProperty(nameof(RoundId), "RoundId", "回合Id", true, PDMDataType.uniqueidentifier, 0, 0, true, null);
        public static PDMDbProperty RoundNumber { get; set; } = new PDMDbProperty(nameof(RoundNumber), "RoundNumber", "回合号", false, PDMDataType.nvarchar, 20, 0, true, null);
        public static PDMDbProperty RoundStatus { get; set; } = new PDMDbProperty(nameof(RoundStatus), "RoundStatus", "回合进行状态", false, PDMDataType.numeric, 0, 0, true, null);
        public static PDMDbProperty TeamIdOfWinner { get; set; } = new PDMDbProperty(nameof(TeamIdOfWinner), "TeamIdOfWinner", "胜者队", false, PDMDataType.uniqueidentifier, 0, 0, true, null);
        #endregion
    }
}
