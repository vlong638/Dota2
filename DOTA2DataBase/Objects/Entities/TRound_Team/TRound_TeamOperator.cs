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
        public static bool DbDelete(this TRound_Team entity, DbSession session)
        {
            var query = IDbQueryBuilder.GetDbQueryBuilder(session);
            query.DeleteBuilder.ComponentWhere.Wheres.Add(new PDMDbPropertyOperateValue(TRound_TeamProperties.RoundId, OperatorType.Equal, entity.RoundId));
            query.DeleteBuilder.ComponentWhere.Wheres.Add(new PDMDbPropertyOperateValue(TRound_TeamProperties.TeamId, OperatorType.Equal, entity.TeamId));
            return IDbQueryOperator.GetQueryOperator(session).Delete<TRound_Team>(session, query);
        }
        public static bool DbDelete(this List<TRound_Team> entities, DbSession session)
        {
            var query = IDbQueryBuilder.GetDbQueryBuilder(session);
            var Ids = entities.Select(c =>c.RoundId );
            query.DeleteBuilder.ComponentWhere.Wheres.Add(new PDMDbPropertyOperateValue(TRound_TeamProperties.RoundId, OperatorType.In, Ids));
            return IDbQueryOperator.GetQueryOperator(session).Delete<TRound_Team>(session, query);
        }
        public static bool DbInsert(this TRound_Team entity, DbSession session)
        {
            var query = IDbQueryBuilder.GetDbQueryBuilder(session);
            InsertBuilder builder = new InsertBuilder();
            builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TRound_TeamProperties.RoundId, entity.RoundId));
            builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TRound_TeamProperties.TeamId, entity.TeamId));
            builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TRound_TeamProperties.Side, entity.Side));
            builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TRound_TeamProperties.BP, entity.BP));
            query.InsertBuilders.Add(builder);
            return IDbQueryOperator.GetQueryOperator(session).Insert<TRound_Team>(session, query);
        }
        public static bool DbInsert(this List<TRound_Team> entities, DbSession session)
        {
            var query = IDbQueryBuilder.GetDbQueryBuilder(session);
            foreach (var entity in entities)
            {
                InsertBuilder builder = new InsertBuilder();
                builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TRound_TeamProperties.RoundId, entity.RoundId));
                builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TRound_TeamProperties.TeamId, entity.TeamId));
                builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TRound_TeamProperties.Side, entity.Side));
                builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TRound_TeamProperties.BP, entity.BP));
                query.InsertBuilders.Add(builder);
            }
            return IDbQueryOperator.GetQueryOperator(session).InsertAll<TRound_Team>(session, query);
        }
        public static bool DbUpdate(this TRound_Team entity, DbSession session, params string[] fields)
        {
            var query = IDbQueryBuilder.GetDbQueryBuilder(session);
            UpdateBuilder builder = new UpdateBuilder();
            builder.ComponentWhere.Wheres.Add(new PDMDbPropertyOperateValue(TRound_TeamProperties.RoundId, OperatorType.Equal, entity.RoundId));
            builder.ComponentWhere.Wheres.Add(new PDMDbPropertyOperateValue(TRound_TeamProperties.TeamId, OperatorType.Equal, entity.TeamId));
            if (fields.Contains(TRound_TeamProperties.Side.Title))
            {
                builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TRound_TeamProperties.Side, entity.Side));
            }
            if (fields.Contains(TRound_TeamProperties.BP.Title))
            {
                builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TRound_TeamProperties.BP, entity.BP));
            }
            query.UpdateBuilders.Add(builder);
            return IDbQueryOperator.GetQueryOperator(session).Update<TRound_Team>(session, query);
        }
        public static bool DbUpdate(this List<TRound_Team> entities, DbSession session, params string[] fields)
        {
            var query = IDbQueryBuilder.GetDbQueryBuilder(session);
            foreach (var entity in entities)
            {
                UpdateBuilder builder = new UpdateBuilder();
                builder.ComponentWhere.Wheres.Add(new PDMDbPropertyOperateValue(TRound_TeamProperties.RoundId, OperatorType.Equal, entity.RoundId));
                builder.ComponentWhere.Wheres.Add(new PDMDbPropertyOperateValue(TRound_TeamProperties.TeamId, OperatorType.Equal, entity.TeamId));
                if (fields.Contains(TRound_TeamProperties.Side.Title))
                {
                    builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TRound_TeamProperties.Side, entity.Side));
                }
                if (fields.Contains(TRound_TeamProperties.BP.Title))
                {
                    builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TRound_TeamProperties.BP, entity.BP));
                }
                query.UpdateBuilders.Add(builder);
            }
            return IDbQueryOperator.GetQueryOperator(session).UpdateAll<TRound_Team>(session, query);
        }
        #endregion
        #region 读
        public static TRound_Team DbSelect(this TRound_Team entity, DbSession session, params string[] fields)
        {
            var query = IDbQueryBuilder.GetDbQueryBuilder(session);
            SelectBuilder builder = new SelectBuilder();
            foreach (var field in fields)
            {
                builder.ComponentFieldAliases.FieldAliases.Add(new FieldAlias(field));
            }
            builder.ComponentWhere.Wheres.Add(new PDMDbPropertyOperateValue(TRound_TeamProperties.RoundId, OperatorType.Equal, entity.RoundId));
            builder.ComponentWhere.Wheres.Add(new PDMDbPropertyOperateValue(TRound_TeamProperties.TeamId, OperatorType.Equal, entity.TeamId));
            query.SelectBuilders.Add(builder);
            return IDbQueryOperator.GetQueryOperator(session).Select<TRound_Team>(session, query);
        }
        public static List<TRound_Team> DbSelect(this List<TRound_Team> entities, DbSession session, params string[] fields)
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
                builder.ComponentWhere.Wheres.Add(new PDMDbPropertyOperateValue(TRound_TeamProperties.RoundId, OperatorType.In, Ids));
            }
            query.SelectBuilders.Add(builder);
            return IDbQueryOperator.GetQueryOperator(session).SelectAll<TRound_Team>(session, query);
        }
        #endregion
        #endregion
    }
}
