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
        public static bool FetchTMatch(this TMatch_Team tMatch_Team, DbSession session)
        {
            var query = IDbQueryBuilder.GetDbQueryBuilder(session);
            SelectBuilder builder = new SelectBuilder();
            builder.ComponentWhere.Wheres.Add(new PDMDbPropertyOperateValue(TMatchProperties.MatchId, OperatorType.Equal, tMatch_Team.MatchId));
            query.SelectBuilders.Add(builder);
            tMatch_Team.Match = IDbQueryOperator.GetQueryOperator(session).Select<TMatch>(session, query);
            if (tMatch_Team.Match == null)
            {
                throw new NotImplementedException(string.Format("1..* 关联未查询到匹配数据, Parent:{0}; Child: {1}", nameof(TMatch_Team), nameof(TMatch)));
            }
            return true;
        }
        public static bool FetchTTeam(this TMatch_Team tMatch_Team, DbSession session)
        {
            var query = IDbQueryBuilder.GetDbQueryBuilder(session);
            SelectBuilder builder = new SelectBuilder();
            builder.ComponentWhere.Wheres.Add(new PDMDbPropertyOperateValue(TTeamProperties.TeamId, OperatorType.Equal, tMatch_Team.TeamId));
            query.SelectBuilders.Add(builder);
            tMatch_Team.Team = IDbQueryOperator.GetQueryOperator(session).Select<TTeam>(session, query);
            if (tMatch_Team.Team == null)
            {
                throw new NotImplementedException(string.Format("1..* 关联未查询到匹配数据, Parent:{0}; Child: {1}", nameof(TMatch_Team), nameof(TTeam)));
            }
            return true;
        }
        #endregion
    }
}
