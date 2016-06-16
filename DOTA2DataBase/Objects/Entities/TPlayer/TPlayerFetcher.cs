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
        public static bool FetchRound_Team_Player(this TPlayer tPlayer, DbSession session)
        {
            var query = IDbQueryBuilder.GetDbQueryBuilder(session);
            SelectBuilder builder = new SelectBuilder();
            builder.ComponentWhere.Wheres.Add(new PDMDbPropertyOperateValue(TRound_Team_PlayerProperties.PlayerId, OperatorType.Equal, tPlayer.PlayerId));
            query.SelectBuilders.Add(builder);
            tPlayer.Round_Team_Player = IDbQueryOperator.GetQueryOperator(session).SelectAll<TRound_Team_Player>(session, query);
            return tPlayer.Round_Team_Player.Count > 0;
        }
        #endregion
    }
}
