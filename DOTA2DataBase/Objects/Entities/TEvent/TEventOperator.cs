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
        public static bool DbDelete(this TEvent entity, DbSession session)
        {
            var query = IDbQueryBuilder.GetDbQueryBuilder(session);
            query.DeleteBuilder.ComponentWhere.Wheres.Add(new PDMDbPropertyOperateValue(TEventProperties.EventId, OperatorType.Equal, entity.EventId));
            return IDbQueryOperator.GetQueryOperator(session).Delete<TEvent>(session, query);
        }
        public static bool DbDelete(this List<TEvent> entities, DbSession session)
        {
            var query = IDbQueryBuilder.GetDbQueryBuilder(session);
            var Ids = entities.Select(c =>c.EventId );
            query.DeleteBuilder.ComponentWhere.Wheres.Add(new PDMDbPropertyOperateValue(TEventProperties.EventId, OperatorType.In, Ids));
            return IDbQueryOperator.GetQueryOperator(session).Delete<TEvent>(session, query);
        }
        public static bool DbInsert(this TEvent entity, DbSession session)
        {
            var query = IDbQueryBuilder.GetDbQueryBuilder(session);
            InsertBuilder builder = new InsertBuilder();
            builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TEventProperties.EventId, entity.EventId));
            builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TEventProperties.Name, entity.Name));
            builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TEventProperties.NameAbbr, entity.NameAbbr));
            builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TEventProperties.Bonus, entity.Bonus));
            query.InsertBuilders.Add(builder);
            return IDbQueryOperator.GetQueryOperator(session).Insert<TEvent>(session, query);
        }
        public static bool DbInsert(this List<TEvent> entities, DbSession session)
        {
            var query = IDbQueryBuilder.GetDbQueryBuilder(session);
            foreach (var entity in entities)
            {
                InsertBuilder builder = new InsertBuilder();
                builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TEventProperties.EventId, entity.EventId));
                builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TEventProperties.Name, entity.Name));
                builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TEventProperties.NameAbbr, entity.NameAbbr));
                builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TEventProperties.Bonus, entity.Bonus));
                query.InsertBuilders.Add(builder);
            }
            return IDbQueryOperator.GetQueryOperator(session).InsertAll<TEvent>(session, query);
        }
        public static bool DbUpdate(this TEvent entity, DbSession session, params string[] fields)
        {
            var query = IDbQueryBuilder.GetDbQueryBuilder(session);
            UpdateBuilder builder = new UpdateBuilder();
            builder.ComponentWhere.Wheres.Add(new PDMDbPropertyOperateValue(TEventProperties.EventId, OperatorType.Equal, entity.EventId));
            if (fields.Contains(TEventProperties.Name.Title))
            {
                builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TEventProperties.Name, entity.Name));
            }
            if (fields.Contains(TEventProperties.NameAbbr.Title))
            {
                builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TEventProperties.NameAbbr, entity.NameAbbr));
            }
            if (fields.Contains(TEventProperties.Bonus.Title))
            {
                builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TEventProperties.Bonus, entity.Bonus));
            }
            query.UpdateBuilders.Add(builder);
            return IDbQueryOperator.GetQueryOperator(session).Update<TEvent>(session, query);
        }
        public static bool DbUpdate(this List<TEvent> entities, DbSession session, params string[] fields)
        {
            var query = IDbQueryBuilder.GetDbQueryBuilder(session);
            foreach (var entity in entities)
            {
                UpdateBuilder builder = new UpdateBuilder();
                builder.ComponentWhere.Wheres.Add(new PDMDbPropertyOperateValue(TEventProperties.EventId, OperatorType.Equal, entity.EventId));
                if (fields.Contains(TEventProperties.Name.Title))
                {
                    builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TEventProperties.Name, entity.Name));
                }
                if (fields.Contains(TEventProperties.NameAbbr.Title))
                {
                    builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TEventProperties.NameAbbr, entity.NameAbbr));
                }
                if (fields.Contains(TEventProperties.Bonus.Title))
                {
                    builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TEventProperties.Bonus, entity.Bonus));
                }
                query.UpdateBuilders.Add(builder);
            }
            return IDbQueryOperator.GetQueryOperator(session).UpdateAll<TEvent>(session, query);
        }
        #endregion
        #region 读
        public static TEvent DbSelect(this TEvent entity, DbSession session, params string[] fields)
        {
            var query = IDbQueryBuilder.GetDbQueryBuilder(session);
            SelectBuilder builder = new SelectBuilder();
            foreach (var field in fields)
            {
                builder.ComponentFieldAliases.FieldAliases.Add(new FieldAlias(field));
            }
            builder.ComponentWhere.Wheres.Add(new PDMDbPropertyOperateValue(TEventProperties.EventId, OperatorType.Equal, entity.EventId));
            query.SelectBuilders.Add(builder);
            return IDbQueryOperator.GetQueryOperator(session).Select<TEvent>(session, query);
        }
        public static List<TEvent> DbSelect(this List<TEvent> entities, DbSession session, params string[] fields)
        {
            var query = IDbQueryBuilder.GetDbQueryBuilder(session);
            SelectBuilder builder = new SelectBuilder();
            foreach (var field in fields)
            {
                builder.ComponentFieldAliases.FieldAliases.Add(new FieldAlias(field));
            }
            var Ids = entities.Select(c =>c.EventId );
            if (Ids.Count() != 0)
            {
                builder.ComponentWhere.Wheres.Add(new PDMDbPropertyOperateValue(TEventProperties.EventId, OperatorType.In, Ids));
            }
            query.SelectBuilders.Add(builder);
            return IDbQueryOperator.GetQueryOperator(session).SelectAll<TEvent>(session, query);
        }
        #endregion
        #endregion
    }
}
