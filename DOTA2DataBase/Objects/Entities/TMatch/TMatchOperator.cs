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
        public static bool DbDelete(this TMatch entity, DbSession session)
        {
            var query = IDbQueryBuilder.GetDbQueryBuilder(session);
            query.DeleteBuilder.ComponentWhere.Wheres.Add(new PDMDbPropertyOperateValue(TMatchProperties.MatchId, OperatorType.Equal, entity.MatchId));
            return IDbQueryOperator.GetQueryOperator(session).Delete<TMatch>(session, query);
        }
        public static bool DbDelete(this List<TMatch> entities, DbSession session)
        {
            var query = IDbQueryBuilder.GetDbQueryBuilder(session);
            var Ids = entities.Select(c =>c.MatchId );
            query.DeleteBuilder.ComponentWhere.Wheres.Add(new PDMDbPropertyOperateValue(TMatchProperties.MatchId, OperatorType.In, Ids));
            return IDbQueryOperator.GetQueryOperator(session).Delete<TMatch>(session, query);
        }
        public static bool DbInsert(this TMatch entity, DbSession session)
        {
            var query = IDbQueryBuilder.GetDbQueryBuilder(session);
            InsertBuilder builder = new InsertBuilder();
            builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TMatchProperties.EventId, entity.EventId));
            builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TMatchProperties.MatchId, entity.MatchId));
            builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TMatchProperties.Name, entity.Name));
            builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TMatchProperties.TeamIdOfWinner, entity.TeamIdOfWinner));
            query.InsertBuilders.Add(builder);
            return IDbQueryOperator.GetQueryOperator(session).Insert<TMatch>(session, query);
        }
        public static bool DbInsert(this List<TMatch> entities, DbSession session)
        {
            var query = IDbQueryBuilder.GetDbQueryBuilder(session);
            foreach (var entity in entities)
            {
                InsertBuilder builder = new InsertBuilder();
                builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TMatchProperties.EventId, entity.EventId));
                builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TMatchProperties.MatchId, entity.MatchId));
                builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TMatchProperties.Name, entity.Name));
                builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TMatchProperties.TeamIdOfWinner, entity.TeamIdOfWinner));
                query.InsertBuilders.Add(builder);
            }
            return IDbQueryOperator.GetQueryOperator(session).InsertAll<TMatch>(session, query);
        }
        public static bool DbUpdate(this TMatch entity, DbSession session, params string[] fields)
        {
            var query = IDbQueryBuilder.GetDbQueryBuilder(session);
            UpdateBuilder builder = new UpdateBuilder();
            builder.ComponentWhere.Wheres.Add(new PDMDbPropertyOperateValue(TMatchProperties.MatchId, OperatorType.Equal, entity.MatchId));
            if (fields.Contains(TMatchProperties.EventId.Title))
            {
                builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TMatchProperties.EventId, entity.EventId));
            }
            if (fields.Contains(TMatchProperties.Name.Title))
            {
                builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TMatchProperties.Name, entity.Name));
            }
            if (fields.Contains(TMatchProperties.TeamIdOfWinner.Title))
            {
                builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TMatchProperties.TeamIdOfWinner, entity.TeamIdOfWinner));
            }
            query.UpdateBuilders.Add(builder);
            return IDbQueryOperator.GetQueryOperator(session).Update<TMatch>(session, query);
        }
        public static bool DbUpdate(this List<TMatch> entities, DbSession session, params string[] fields)
        {
            var query = IDbQueryBuilder.GetDbQueryBuilder(session);
            foreach (var entity in entities)
            {
                UpdateBuilder builder = new UpdateBuilder();
                builder.ComponentWhere.Wheres.Add(new PDMDbPropertyOperateValue(TMatchProperties.MatchId, OperatorType.Equal, entity.MatchId));
                if (fields.Contains(TMatchProperties.EventId.Title))
                {
                    builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TMatchProperties.EventId, entity.EventId));
                }
                if (fields.Contains(TMatchProperties.Name.Title))
                {
                    builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TMatchProperties.Name, entity.Name));
                }
                if (fields.Contains(TMatchProperties.TeamIdOfWinner.Title))
                {
                    builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TMatchProperties.TeamIdOfWinner, entity.TeamIdOfWinner));
                }
                query.UpdateBuilders.Add(builder);
            }
            return IDbQueryOperator.GetQueryOperator(session).UpdateAll<TMatch>(session, query);
        }
        #endregion
        #region 读
        public static TMatch DbSelect(this TMatch entity, DbSession session, params string[] fields)
        {
            var query = IDbQueryBuilder.GetDbQueryBuilder(session);
            SelectBuilder builder = new SelectBuilder();
            foreach (var field in fields)
            {
                builder.ComponentFieldAliases.FieldAliases.Add(new FieldAlias(field));
            }
            builder.ComponentWhere.Wheres.Add(new PDMDbPropertyOperateValue(TMatchProperties.MatchId, OperatorType.Equal, entity.MatchId));
            query.SelectBuilders.Add(builder);
            return IDbQueryOperator.GetQueryOperator(session).Select<TMatch>(session, query);
        }
        public static List<TMatch> DbSelect(this List<TMatch> entities, DbSession session, params string[] fields)
        {
            var query = IDbQueryBuilder.GetDbQueryBuilder(session);
            SelectBuilder builder = new SelectBuilder();
            foreach (var field in fields)
            {
                builder.ComponentFieldAliases.FieldAliases.Add(new FieldAlias(field));
            }
            var Ids = entities.Select(c =>c.MatchId );
            if (Ids.Count() != 0)
            {
                builder.ComponentWhere.Wheres.Add(new PDMDbPropertyOperateValue(TMatchProperties.MatchId, OperatorType.In, Ids));
            }
            query.SelectBuilders.Add(builder);
            return IDbQueryOperator.GetQueryOperator(session).SelectAll<TMatch>(session, query);
        }
        #endregion
        #endregion
    }
}
