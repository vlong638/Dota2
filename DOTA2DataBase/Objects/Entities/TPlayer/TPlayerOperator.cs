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
        public static bool DbDelete(this TPlayer entity, DbSession session)
        {
            var query = IDbQueryBuilder.GetDbQueryBuilder(session);
            query.DeleteBuilder.ComponentWhere.Wheres.Add(new PDMDbPropertyOperateValue(TPlayerProperties.PlayerId, OperatorType.Equal, entity.PlayerId));
            return IDbQueryOperator.GetQueryOperator(session).Delete<TPlayer>(session, query);
        }
        public static bool DbDelete(this List<TPlayer> entities, DbSession session)
        {
            var query = IDbQueryBuilder.GetDbQueryBuilder(session);
            var Ids = entities.Select(c =>c.PlayerId );
            query.DeleteBuilder.ComponentWhere.Wheres.Add(new PDMDbPropertyOperateValue(TPlayerProperties.PlayerId, OperatorType.In, Ids));
            return IDbQueryOperator.GetQueryOperator(session).Delete<TPlayer>(session, query);
        }
        public static bool DbInsert(this TPlayer entity, DbSession session)
        {
            var query = IDbQueryBuilder.GetDbQueryBuilder(session);
            InsertBuilder builder = new InsertBuilder();
            builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TPlayerProperties.PlayerId, entity.PlayerId));
            builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TPlayerProperties.Name, entity.Name));
            builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TPlayerProperties.NameAbbr, entity.NameAbbr));
            query.InsertBuilders.Add(builder);
            return IDbQueryOperator.GetQueryOperator(session).Insert<TPlayer>(session, query);
        }
        public static bool DbInsert(this List<TPlayer> entities, DbSession session)
        {
            var query = IDbQueryBuilder.GetDbQueryBuilder(session);
            foreach (var entity in entities)
            {
                InsertBuilder builder = new InsertBuilder();
                builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TPlayerProperties.PlayerId, entity.PlayerId));
                builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TPlayerProperties.Name, entity.Name));
                builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TPlayerProperties.NameAbbr, entity.NameAbbr));
                query.InsertBuilders.Add(builder);
            }
            return IDbQueryOperator.GetQueryOperator(session).InsertAll<TPlayer>(session, query);
        }
        public static bool DbUpdate(this TPlayer entity, DbSession session, params string[] fields)
        {
            var query = IDbQueryBuilder.GetDbQueryBuilder(session);
            UpdateBuilder builder = new UpdateBuilder();
            builder.ComponentWhere.Wheres.Add(new PDMDbPropertyOperateValue(TPlayerProperties.PlayerId, OperatorType.Equal, entity.PlayerId));
            if (fields.Contains(TPlayerProperties.Name.Title))
            {
                builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TPlayerProperties.Name, entity.Name));
            }
            if (fields.Contains(TPlayerProperties.NameAbbr.Title))
            {
                builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TPlayerProperties.NameAbbr, entity.NameAbbr));
            }
            query.UpdateBuilders.Add(builder);
            return IDbQueryOperator.GetQueryOperator(session).Update<TPlayer>(session, query);
        }
        public static bool DbUpdate(this List<TPlayer> entities, DbSession session, params string[] fields)
        {
            var query = IDbQueryBuilder.GetDbQueryBuilder(session);
            foreach (var entity in entities)
            {
                UpdateBuilder builder = new UpdateBuilder();
                builder.ComponentWhere.Wheres.Add(new PDMDbPropertyOperateValue(TPlayerProperties.PlayerId, OperatorType.Equal, entity.PlayerId));
                if (fields.Contains(TPlayerProperties.Name.Title))
                {
                    builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TPlayerProperties.Name, entity.Name));
                }
                if (fields.Contains(TPlayerProperties.NameAbbr.Title))
                {
                    builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TPlayerProperties.NameAbbr, entity.NameAbbr));
                }
                query.UpdateBuilders.Add(builder);
            }
            return IDbQueryOperator.GetQueryOperator(session).UpdateAll<TPlayer>(session, query);
        }
        #endregion
        #region 读
        public static TPlayer DbSelect(this TPlayer entity, DbSession session, params string[] fields)
        {
            var query = IDbQueryBuilder.GetDbQueryBuilder(session);
            SelectBuilder builder = new SelectBuilder();
            foreach (var field in fields)
            {
                builder.ComponentFieldAliases.FieldAliases.Add(new FieldAlias(field));
            }
            builder.ComponentWhere.Wheres.Add(new PDMDbPropertyOperateValue(TPlayerProperties.PlayerId, OperatorType.Equal, entity.PlayerId));
            query.SelectBuilders.Add(builder);
            return IDbQueryOperator.GetQueryOperator(session).Select<TPlayer>(session, query);
        }
        public static List<TPlayer> DbSelect(this List<TPlayer> entities, DbSession session, params string[] fields)
        {
            var query = IDbQueryBuilder.GetDbQueryBuilder(session);
            SelectBuilder builder = new SelectBuilder();
            foreach (var field in fields)
            {
                builder.ComponentFieldAliases.FieldAliases.Add(new FieldAlias(field));
            }
            var Ids = entities.Select(c =>c.PlayerId );
            if (Ids.Count() != 0)
            {
                builder.ComponentWhere.Wheres.Add(new PDMDbPropertyOperateValue(TPlayerProperties.PlayerId, OperatorType.In, Ids));
            }
            query.SelectBuilders.Add(builder);
            return IDbQueryOperator.GetQueryOperator(session).SelectAll<TPlayer>(session, query);
        }
        #endregion
        #endregion
    }
}
