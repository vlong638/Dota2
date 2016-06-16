using System;
using System.Collections.Generic;
using VL.Common.DAS.Objects;
using VL.Common.ORM.Utilities.QueryBuilders;
using VL.Common.ORM.Utilities.QueryOperators;

namespace DOTA2DataBase.Objects.Entities
{
    public static partial class EntityFetcher
    {
        #region Methods
        public static bool FetchTMatch(this TRound tRound, DbSession session)
        {
            var query = IDbQueryBuilder.GetDbQueryBuilder(session);
            SelectBuilder builder = new SelectBuilder();
            builder.ComponentWhere.Wheres.Add(new PDMDbPropertyOperateValue(TMatchProperties.MatchId, OperatorType.Equal, tRound.MatchId));
            query.SelectBuilders.Add(builder);
            tRound.Match = IDbQueryOperator.GetQueryOperator(session).Select<TMatch>(session, query);
            if (tRound.Match == null)
            {
                throw new NotImplementedException(string.Format("1..* 关联未查询到匹配数据, Parent:{0}; Child: {1}", nameof(TRound), nameof(TMatch)));
            }
            return true;
        }
        public static bool FetchRound_Team(this TRound tRound, DbSession session)
        {
            var query = IDbQueryBuilder.GetDbQueryBuilder(session);
            SelectBuilder builder = new SelectBuilder();
            builder.ComponentWhere.Wheres.Add(new PDMDbPropertyOperateValue(TRound_TeamProperties.RoundId, OperatorType.Equal, tRound.RoundId));
            query.SelectBuilders.Add(builder);
            tRound.Round_Team = IDbQueryOperator.GetQueryOperator(session).SelectAll<TRound_Team>(session, query);
            return tRound.Round_Team.Count > 0;
        }
        public static bool FetchRound_Team_Player(this TRound tRound, DbSession session)
        {
            var query = IDbQueryBuilder.GetDbQueryBuilder(session);
            SelectBuilder builder = new SelectBuilder();
            builder.ComponentWhere.Wheres.Add(new PDMDbPropertyOperateValue(TRound_Team_PlayerProperties.RoundId, OperatorType.Equal, tRound.RoundId));
            query.SelectBuilders.Add(builder);
            tRound.Round_Team_Player = IDbQueryOperator.GetQueryOperator(session).SelectAll<TRound_Team_Player>(session, query);
            return tRound.Round_Team_Player.Count > 0;
        }
        #endregion
    }
}
