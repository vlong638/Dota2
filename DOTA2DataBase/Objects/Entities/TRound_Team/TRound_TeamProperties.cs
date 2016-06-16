using VL.Common.ORM.Objects;

namespace DOTA2DataBase.Objects.Entities
{
    public class TRound_TeamProperties
    {
        #region Properties
        public static PDMDbProperty RoundId { get; set; } = new PDMDbProperty(nameof(RoundId), "RoundId", "回合Id", true, PDMDataType.uniqueidentifier, 0, 0, true, null);
        public static PDMDbProperty TeamId { get; set; } = new PDMDbProperty(nameof(TeamId), "TeamId", "战队Id", true, PDMDataType.uniqueidentifier, 0, 0, true, null);
        public static PDMDbProperty Side { get; set; } = new PDMDbProperty(nameof(Side), "Side", "阵营", false, PDMDataType.numeric, 0, 0, true, null);
        public static PDMDbProperty BP { get; set; } = new PDMDbProperty(nameof(BP), "BP", "办选人", false, PDMDataType.varchar, 200, 0, true, null);
        #endregion
    }
}
