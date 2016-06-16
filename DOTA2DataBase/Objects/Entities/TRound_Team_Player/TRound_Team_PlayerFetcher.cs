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
        public static bool FetchTPlayer(this TRound_Team_Player tRound_Team_Player, DbSession session)
        {
            var query = IDbQueryBuilder.GetDbQueryBuilder(session);
            SelectBuilder builder = new SelectBuilder();
            builder.ComponentWhere.Wheres.Add(new PDMDbPropertyOperateValue(TPlayerProperties.PlayerId, OperatorType.Equal, tRound_Team_Player.PlayerId));
            query.SelectBuilders.Add(builder);
            tRound_Team_Player.Player = IDbQueryOperator.GetQueryOperator(session).Select<TPlayer>(session, query);
            if (tRound_Team_Player.Player == null)
            {
                throw new NotImplementedException(string.Format("1..* 关联未查询到匹配数据, Parent:{0}; Child: {1}", nameof(TRound_Team_Player), nameof(TPlayer)));
            }
            return true;
        }
        public static bool FetchTRound(this TRound_Team_Player tRound_Team_Player, DbSession session)
        {
            var query = IDbQueryBuilder.GetDbQueryBuilder(session);
            SelectBuilder builder = new SelectBuilder();
            builder.ComponentWhere.Wheres.Add(new PDMDbPropertyOperateValue(TRoundProperties.RoundId, OperatorType.Equal, tRound_Team_Player.RoundId));
            query.SelectBuilders.Add(builder);
            tRound_Team_Player.Round = IDbQueryOperator.GetQueryOperator(session).Select<TRound>(session, query);
            if (tRound_Team_Player.Round == null)
            {
                throw new NotImplementedException(string.Format("1..* 关联未查询到匹配数据, Parent:{0}; Child: {1}", nameof(TRound_Team_Player), nameof(TRound)));
            }
            return true;
        }
        public static bool FetchTTeam(this TRound_Team_Player tRound_Team_Player, DbSession session)
        {
            var query = IDbQueryBuilder.GetDbQueryBuilder(session);
            SelectBuilder builder = new SelectBuilder();
            builder.ComponentWhere.Wheres.Add(new PDMDbPropertyOperateValue(TTeamProperties.TeamId, OperatorType.Equal, tRound_Team_Player.TeamId));
            query.SelectBuilders.Add(builder);
            tRound_Team_Player.Team = IDbQueryOperator.GetQueryOperator(session).Select<TTeam>(session, query);
            if (tRound_Team_Player.Team == null)
            {
                throw new NotImplementedException(string.Format("1..* 关联未查询到匹配数据, Parent:{0}; Child: {1}", nameof(TRound_Team_Player), nameof(TTeam)));
            }
            return true;
        }
        #endregion
    }
}
