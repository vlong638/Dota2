using VL.Common.ORM.Objects;

namespace DOTA2DataBase.Objects.Entities
{
    public class TRound_Team_PlayerProperties
    {
        #region Properties
        public static PDMDbProperty RoundId { get; set; } = new PDMDbProperty(nameof(RoundId), "RoundId", "回合Id", true, PDMDataType.uniqueidentifier, 0, 0, true, null);
        public static PDMDbProperty TeamId { get; set; } = new PDMDbProperty(nameof(TeamId), "TeamId", "战队Id", true, PDMDataType.uniqueidentifier, 0, 0, true, null);
        public static PDMDbProperty PlayerId { get; set; } = new PDMDbProperty(nameof(PlayerId), "PlayerId", "选手Id", true, PDMDataType.uniqueidentifier, 0, 0, true, null);
        public static PDMDbProperty HeroId { get; set; } = new PDMDbProperty(nameof(HeroId), "HeroId", "英雄Id", false, PDMDataType.uniqueidentifier, 0, 0, true, null);
        public static PDMDbProperty KDA { get; set; } = new PDMDbProperty(nameof(KDA), "KDA", "人头贡献比", false, PDMDataType.numeric, 0, 0, true, null);
        public static PDMDbProperty KDADetail { get; set; } = new PDMDbProperty(nameof(KDADetail), "KDADetail", "人头贡献比明细", false, PDMDataType.varchar, 20, 0, true, null);
        public static PDMDbProperty GPM { get; set; } = new PDMDbProperty(nameof(GPM), "GPM", "经济分钟", false, PDMDataType.numeric, 0, 0, true, null);
        public static PDMDbProperty XPM { get; set; } = new PDMDbProperty(nameof(XPM), "XPM", "经验分钟", false, PDMDataType.numeric, 0, 0, true, null);
        public static PDMDbProperty IsGodLike { get; set; } = new PDMDbProperty(nameof(IsGodLike), "IsGodLike", "是否超神", false, PDMDataType.boolean, 0, 0, false, null);
        #endregion
    }
}
