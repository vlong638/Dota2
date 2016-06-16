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
        public static bool DbDelete(this TEventReward entity, DbSession session)
        {
            var query = IDbQueryBuilder.GetDbQueryBuilder(session);
            query.DeleteBuilder.ComponentWhere.Wheres.Add(new PDMDbPropertyOperateValue(TEventRewardProperties.EventIdRewardId, OperatorType.Equal, entity.EventIdRewardId));
            return IDbQueryOperator.GetQueryOperator(session).Delete<TEventReward>(session, query);
        }
        public static bool DbDelete(this List<TEventReward> entities, DbSession session)
        {
            var query = IDbQueryBuilder.GetDbQueryBuilder(session);
            var Ids = entities.Select(c =>c.EventIdRewardId );
            query.DeleteBuilder.ComponentWhere.Wheres.Add(new PDMDbPropertyOperateValue(TEventRewardProperties.EventIdRewardId, OperatorType.In, Ids));
            return IDbQueryOperator.GetQueryOperator(session).Delete<TEventReward>(session, query);
        }
        public static bool DbInsert(this TEventReward entity, DbSession session)
        {
            var query = IDbQueryBuilder.GetDbQueryBuilder(session);
            InsertBuilder builder = new InsertBuilder();
            builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TEventRewardProperties.EventIdRewardId, entity.EventIdRewardId));
            builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TEventRewardProperties.EventId, entity.EventId));
            builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TEventRewardProperties.Area, entity.Area));
            builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TEventRewardProperties.Description, entity.Description));
            builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TEventRewardProperties.Bonus, entity.Bonus));
            query.InsertBuilders.Add(builder);
            return IDbQueryOperator.GetQueryOperator(session).Insert<TEventReward>(session, query);
        }
        public static bool DbInsert(this List<TEventReward> entities, DbSession session)
        {
            var query = IDbQueryBuilder.GetDbQueryBuilder(session);
            foreach (var entity in entities)
            {
                InsertBuilder builder = new InsertBuilder();
                builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TEventRewardProperties.EventIdRewardId, entity.EventIdRewardId));
                builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TEventRewardProperties.EventId, entity.EventId));
                builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TEventRewardProperties.Area, entity.Area));
                builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TEventRewardProperties.Description, entity.Description));
                builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TEventRewardProperties.Bonus, entity.Bonus));
                query.InsertBuilders.Add(builder);
            }
            return IDbQueryOperator.GetQueryOperator(session).InsertAll<TEventReward>(session, query);
        }
        public static bool DbUpdate(this TEventReward entity, DbSession session, params string[] fields)
        {
            var query = IDbQueryBuilder.GetDbQueryBuilder(session);
            UpdateBuilder builder = new UpdateBuilder();
            builder.ComponentWhere.Wheres.Add(new PDMDbPropertyOperateValue(TEventRewardProperties.EventIdRewardId, OperatorType.Equal, entity.EventIdRewardId));
            if (fields.Contains(TEventRewardProperties.EventId.Title))
            {
                builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TEventRewardProperties.EventId, entity.EventId));
            }
            if (fields.Contains(TEventRewardProperties.Area.Title))
            {
                builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TEventRewardProperties.Area, entity.Area));
            }
            if (fields.Contains(TEventRewardProperties.Description.Title))
            {
                builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TEventRewardProperties.Description, entity.Description));
            }
            if (fields.Contains(TEventRewardProperties.Bonus.Title))
            {
                builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TEventRewardProperties.Bonus, entity.Bonus));
            }
            query.UpdateBuilders.Add(builder);
            return IDbQueryOperator.GetQueryOperator(session).Update<TEventReward>(session, query);
        }
        public static bool DbUpdate(this List<TEventReward> entities, DbSession session, params string[] fields)
        {
            var query = IDbQueryBuilder.GetDbQueryBuilder(session);
            foreach (var entity in entities)
            {
                UpdateBuilder builder = new UpdateBuilder();
                builder.ComponentWhere.Wheres.Add(new PDMDbPropertyOperateValue(TEventRewardProperties.EventIdRewardId, OperatorType.Equal, entity.EventIdRewardId));
                if (fields.Contains(TEventRewardProperties.EventId.Title))
                {
                    builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TEventRewardProperties.EventId, entity.EventId));
                }
                if (fields.Contains(TEventRewardProperties.Area.Title))
                {
                    builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TEventRewardProperties.Area, entity.Area));
                }
                if (fields.Contains(TEventRewardProperties.Description.Title))
                {
                    builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TEventRewardProperties.Description, entity.Description));
                }
                if (fields.Contains(TEventRewardProperties.Bonus.Title))
                {
                    builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TEventRewardProperties.Bonus, entity.Bonus));
                }
                query.UpdateBuilders.Add(builder);
            }
            return IDbQueryOperator.GetQueryOperator(session).UpdateAll<TEventReward>(session, query);
        }
        #endregion
        #region 读
        public static TEventReward DbSelect(this TEventReward entity, DbSession session, params string[] fields)
        {
            var query = IDbQueryBuilder.GetDbQueryBuilder(session);
            SelectBuilder builder = new SelectBuilder();
            foreach (var field in fields)
            {
                builder.ComponentFieldAliases.FieldAliases.Add(new FieldAlias(field));
            }
            builder.ComponentWhere.Wheres.Add(new PDMDbPropertyOperateValue(TEventRewardProperties.EventIdRewardId, OperatorType.Equal, entity.EventIdRewardId));
            query.SelectBuilders.Add(builder);
            return IDbQueryOperator.GetQueryOperator(session).Select<TEventReward>(session, query);
        }
        public static List<TEventReward> DbSelect(this List<TEventReward> entities, DbSession session, params string[] fields)
        {
            var query = IDbQueryBuilder.GetDbQueryBuilder(session);
            SelectBuilder builder = new SelectBuilder();
            foreach (var field in fields)
            {
                builder.ComponentFieldAliases.FieldAliases.Add(new FieldAlias(field));
            }
            var Ids = entities.Select(c =>c.EventIdRewardId );
            if (Ids.Count() != 0)
            {
                builder.ComponentWhere.Wheres.Add(new PDMDbPropertyOperateValue(TEventRewardProperties.EventIdRewardId, OperatorType.In, Ids));
            }
            query.SelectBuilders.Add(builder);
            return IDbQueryOperator.GetQueryOperator(session).SelectAll<TEventReward>(session, query);
        }
        #endregion
        #endregion
    }
}
