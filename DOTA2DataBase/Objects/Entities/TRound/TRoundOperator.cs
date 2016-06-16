using System.Collections.Generic;
using System.Linq;
using VL.Common.DAS.Objects;
using VL.Common.ORM.Utilities.QueryBuilders;
using VL.Common.ORM.Utilities.QueryOperators;

namespace DOTA2DataBase.Objects.Entities
{
    public static partial class EntityOperator
    {
        #region Methods
        #region 写
        public static bool DbDelete(this TRound entity, DbSession session)
        {
            var query = IDbQueryBuilder.GetDbQueryBuilder(session);
            query.DeleteBuilder.ComponentWhere.Wheres.Add(new PDMDbPropertyOperateValue(TRoundProperties.RoundId, OperatorType.Equal, entity.RoundId));
            return IDbQueryOperator.GetQueryOperator(session).Delete<TRound>(session, query);
        }
        public static bool DbDelete(this List<TRound> entities, DbSession session)
        {
            var query = IDbQueryBuilder.GetDbQueryBuilder(session);
            var Ids = entities.Select(c =>c.RoundId );
            query.DeleteBuilder.ComponentWhere.Wheres.Add(new PDMDbPropertyOperateValue(TRoundProperties.RoundId, OperatorType.In, Ids));
            return IDbQueryOperator.GetQueryOperator(session).Delete<TRound>(session, query);
        }
        public static bool DbInsert(this TRound entity, DbSession session)
        {
            var query = IDbQueryBuilder.GetDbQueryBuilder(session);
            InsertBuilder builder = new InsertBuilder();
            builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TRoundProperties.MatchId, entity.MatchId));
            builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TRoundProperties.RoundId, entity.RoundId));
            builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TRoundProperties.RoundNumber, entity.RoundNumber));
            builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TRoundProperties.RoundStatus, entity.RoundStatus));
            builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TRoundProperties.TeamIdOfWinner, entity.TeamIdOfWinner));
            query.InsertBuilders.Add(builder);
            return IDbQueryOperator.GetQueryOperator(session).Insert<TRound>(session, query);
        }
        public static bool DbInsert(this List<TRound> entities, DbSession session)
        {
            var query = IDbQueryBuilder.GetDbQueryBuilder(session);
            foreach (var entity in entities)
            {
                InsertBuilder builder = new InsertBuilder();
                builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TRoundProperties.MatchId, entity.MatchId));
                builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TRoundProperties.RoundId, entity.RoundId));
                builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TRoundProperties.RoundNumber, entity.RoundNumber));
                builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TRoundProperties.RoundStatus, entity.RoundStatus));
                builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TRoundProperties.TeamIdOfWinner, entity.TeamIdOfWinner));
                query.InsertBuilders.Add(builder);
            }
            return IDbQueryOperator.GetQueryOperator(session).InsertAll<TRound>(session, query);
        }
        public static bool DbUpdate(this TRound entity, DbSession session, params string[] fields)
        {
            var query = IDbQueryBuilder.GetDbQueryBuilder(session);
            UpdateBuilder builder = new UpdateBuilder();
            builder.ComponentWhere.Wheres.Add(new PDMDbPropertyOperateValue(TRoundProperties.RoundId, OperatorType.Equal, entity.RoundId));
            if (fields.Contains(TRoundProperties.MatchId.Title))
            {
                builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TRoundProperties.MatchId, entity.MatchId));
            }
            if (fields.Contains(TRoundProperties.RoundNumber.Title))
            {
                builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TRoundProperties.RoundNumber, entity.RoundNumber));
            }
            if (fields.Contains(TRoundProperties.RoundStatus.Title))
            {
                builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TRoundProperties.RoundStatus, entity.RoundStatus));
            }
            if (fields.Contains(TRoundProperties.TeamIdOfWinner.Title))
            {
                builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TRoundProperties.TeamIdOfWinner, entity.TeamIdOfWinner));
            }
            query.UpdateBuilders.Add(builder);
            return IDbQueryOperator.GetQueryOperator(session).Update<TRound>(session, query);
        }
        public static bool DbUpdate(this List<TRound> entities, DbSession session, params string[] fields)
        {
            var query = IDbQueryBuilder.GetDbQueryBuilder(session);
            foreach (var entity in entities)
            {
                UpdateBuilder builder = new UpdateBuilder();
                builder.ComponentWhere.Wheres.Add(new PDMDbPropertyOperateValue(TRoundProperties.RoundId, OperatorType.Equal, entity.RoundId));
                if (fields.Contains(TRoundProperties.MatchId.Title))
                {
                    builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TRoundProperties.MatchId, entity.MatchId));
                }
                if (fields.Contains(TRoundProperties.RoundNumber.Title))
                {
                    builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TRoundProperties.RoundNumber, entity.RoundNumber));
                }
                if (fields.Contains(TRoundProperties.RoundStatus.Title))
                {
                    builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TRoundProperties.RoundStatus, entity.RoundStatus));
                }
                if (fields.Contains(TRoundProperties.TeamIdOfWinner.Title))
                {
                    builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TRoundProperties.TeamIdOfWinner, entity.TeamIdOfWinner));
                }
                query.UpdateBuilders.Add(builder);
            }
            return IDbQueryOperator.GetQueryOperator(session).UpdateAll<TRound>(session, query);
        }
        #endregion
        #region 读
        public static TRound DbSelect(this TRound entity, DbSession session, params string[] fields)
        {
            var query = IDbQueryBuilder.GetDbQueryBuilder(session);
            SelectBuilder builder = new SelectBuilder();
            foreach (var field in fields)
            {
                builder.ComponentFieldAliases.FieldAliases.Add(new FieldAlias(field));
            }
            builder.ComponentWhere.Wheres.Add(new PDMDbPropertyOperateValue(TRoundProperties.RoundId, OperatorType.Equal, entity.RoundId));
            query.SelectBuilders.Add(builder);
            return IDbQueryOperator.GetQueryOperator(session).Select<TRound>(session, query);
        }
        public static List<TRound> DbSelect(this List<TRound> entities, DbSession session, params string[] fields)
        {
            var query = IDbQueryBuilder.GetDbQueryBuilder(session);
            SelectBuilder builder = new SelectBuilder();
            foreach (var field in fields)
            {
                builder.ComponentFieldAliases.FieldAliases.Add(new FieldAlias(field));
            }
            var Ids = entities.Select(c =>c.RoundId );
            if (Ids.Count() != 0)
            {
                builder.ComponentWhere.Wheres.Add(new PDMDbPropertyOperateValue(TRoundProperties.RoundId, OperatorType.In, Ids));
            }
            query.SelectBuilders.Add(builder);
            return IDbQueryOperator.GetQueryOperator(session).SelectAll<TRound>(session, query);
        }
        #endregion
        #endregion
    }
}
