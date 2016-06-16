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
        public static bool FetchTEvent(this TMatch tMatch, DbSession session)
        {
            var query = IDbQueryBuilder.GetDbQueryBuilder(session);
            SelectBuilder builder = new SelectBuilder();
            builder.ComponentWhere.Wheres.Add(new PDMDbPropertyOperateValue(TEventProperties.EventId, OperatorType.Equal, tMatch.EventId));
            query.SelectBuilders.Add(builder);
            tMatch.Event = IDbQueryOperator.GetQueryOperator(session).Select<TEvent>(session, query);
            if (tMatch.Event == null)
            {
                throw new NotImplementedException(string.Format("1..* 关联未查询到匹配数据, Parent:{0}; Child: {1}", nameof(TMatch), nameof(TEvent)));
            }
            return true;
        }
        public static bool FetchMatch_Team(this TMatch tMatch, DbSession session)
        {
            var query = IDbQueryBuilder.GetDbQueryBuilder(session);
            SelectBuilder builder = new SelectBuilder();
            builder.ComponentWhere.Wheres.Add(new PDMDbPropertyOperateValue(TMatch_TeamProperties.MatchId, OperatorType.Equal, tMatch.MatchId));
            query.SelectBuilders.Add(builder);
            tMatch.Match_Team = IDbQueryOperator.GetQueryOperator(session).SelectAll<TMatch_Team>(session, query);
            return tMatch.Match_Team.Count > 0;
        }
        public static bool FetchRounds(this TMatch tMatch, DbSession session)
        {
            var query = IDbQueryBuilder.GetDbQueryBuilder(session);
            SelectBuilder builder = new SelectBuilder();
            builder.ComponentWhere.Wheres.Add(new PDMDbPropertyOperateValue(TRoundProperties.MatchId, OperatorType.Equal, tMatch.MatchId));
            query.SelectBuilders.Add(builder);
            tMatch.Rounds = IDbQueryOperator.GetQueryOperator(session).SelectAll<TRound>(session, query);
            return tMatch.Rounds.Count > 0;
        }
        #endregion
    }
}
