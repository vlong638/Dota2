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
        public static bool FetchEventRewards(this TEvent tEvent, DbSession session)
        {
            var query = IDbQueryBuilder.GetDbQueryBuilder(session);
            SelectBuilder builder = new SelectBuilder();
            builder.ComponentWhere.Wheres.Add(new PDMDbPropertyOperateValue(TEventRewardProperties.EventId, OperatorType.Equal, tEvent.EventId));
            query.SelectBuilders.Add(builder);
            tEvent.EventRewards = IDbQueryOperator.GetQueryOperator(session).SelectAll<TEventReward>(session, query);
            return tEvent.EventRewards.Count > 0;
        }
        public static bool FetchMatches(this TEvent tEvent, DbSession session)
        {
            var query = IDbQueryBuilder.GetDbQueryBuilder(session);
            SelectBuilder builder = new SelectBuilder();
            builder.ComponentWhere.Wheres.Add(new PDMDbPropertyOperateValue(TMatchProperties.EventId, OperatorType.Equal, tEvent.EventId));
            query.SelectBuilders.Add(builder);
            tEvent.Matches = IDbQueryOperator.GetQueryOperator(session).SelectAll<TMatch>(session, query);
            return tEvent.Matches.Count > 0;
        }
        #endregion
    }
}
