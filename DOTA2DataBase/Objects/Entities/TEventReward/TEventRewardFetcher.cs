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
        public static bool FetchTEvent(this TEventReward tEventReward, DbSession session)
        {
            var query = IDbQueryBuilder.GetDbQueryBuilder(session);
            SelectBuilder builder = new SelectBuilder();
            builder.ComponentWhere.Wheres.Add(new PDMDbPropertyOperateValue(TEventProperties.EventId, OperatorType.Equal, tEventReward.EventId));
            query.SelectBuilders.Add(builder);
            tEventReward.Event = IDbQueryOperator.GetQueryOperator(session).Select<TEvent>(session, query);
            if (tEventReward.Event == null)
            {
                throw new NotImplementedException(string.Format("1..* 关联未查询到匹配数据, Parent:{0}; Child: {1}", nameof(TEventReward), nameof(TEvent)));
            }
            return true;
        }
        #endregion
    }
}
