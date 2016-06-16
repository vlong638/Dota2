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
        public static bool DbDelete(this TMatch_Team entity, DbSession session)
        {
            var query = IDbQueryBuilder.GetDbQueryBuilder(session);
            query.DeleteBuilder.ComponentWhere.Wheres.Add(new PDMDbPropertyOperateValue(TMatch_TeamProperties.MatchId, OperatorType.Equal, entity.MatchId));
            query.DeleteBuilder.ComponentWhere.Wheres.Add(new PDMDbPropertyOperateValue(TMatch_TeamProperties.TeamId, OperatorType.Equal, entity.TeamId));
            return IDbQueryOperator.GetQueryOperator(session).Delete<TMatch_Team>(session, query);
        }
        public static bool DbDelete(this List<TMatch_Team> entities, DbSession session)
        {
            var query = IDbQueryBuilder.GetDbQueryBuilder(session);
            var Ids = entities.Select(c =>c.MatchId );
            query.DeleteBuilder.ComponentWhere.Wheres.Add(new PDMDbPropertyOperateValue(TMatch_TeamProperties.MatchId, OperatorType.In, Ids));
            return IDbQueryOperator.GetQueryOperator(session).Delete<TMatch_Team>(session, query);
        }
        public static bool DbInsert(this TMatch_Team entity, DbSession session)
        {
            var query = IDbQueryBuilder.GetDbQueryBuilder(session);
            InsertBuilder builder = new InsertBuilder();
            builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TMatch_TeamProperties.MatchId, entity.MatchId));
            builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TMatch_TeamProperties.TeamId, entity.TeamId));
            query.InsertBuilders.Add(builder);
            return IDbQueryOperator.GetQueryOperator(session).Insert<TMatch_Team>(session, query);
        }
        public static bool DbInsert(this List<TMatch_Team> entities, DbSession session)
        {
            var query = IDbQueryBuilder.GetDbQueryBuilder(session);
            foreach (var entity in entities)
            {
                InsertBuilder builder = new InsertBuilder();
                builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TMatch_TeamProperties.MatchId, entity.MatchId));
                builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TMatch_TeamProperties.TeamId, entity.TeamId));
                query.InsertBuilders.Add(builder);
            }
            return IDbQueryOperator.GetQueryOperator(session).InsertAll<TMatch_Team>(session, query);
        }
        public static bool DbUpdate(this TMatch_Team entity, DbSession session, params string[] fields)
        {
            var query = IDbQueryBuilder.GetDbQueryBuilder(session);
            UpdateBuilder builder = new UpdateBuilder();
            builder.ComponentWhere.Wheres.Add(new PDMDbPropertyOperateValue(TMatch_TeamProperties.MatchId, OperatorType.Equal, entity.MatchId));
            builder.ComponentWhere.Wheres.Add(new PDMDbPropertyOperateValue(TMatch_TeamProperties.TeamId, OperatorType.Equal, entity.TeamId));
            query.UpdateBuilders.Add(builder);
            return IDbQueryOperator.GetQueryOperator(session).Update<TMatch_Team>(session, query);
        }
        public static bool DbUpdate(this List<TMatch_Team> entities, DbSession session, params string[] fields)
        {
            var query = IDbQueryBuilder.GetDbQueryBuilder(session);
            foreach (var entity in entities)
            {
                UpdateBuilder builder = new UpdateBuilder();
                builder.ComponentWhere.Wheres.Add(new PDMDbPropertyOperateValue(TMatch_TeamProperties.MatchId, OperatorType.Equal, entity.MatchId));
                builder.ComponentWhere.Wheres.Add(new PDMDbPropertyOperateValue(TMatch_TeamProperties.TeamId, OperatorType.Equal, entity.TeamId));
                query.UpdateBuilders.Add(builder);
            }
            return IDbQueryOperator.GetQueryOperator(session).UpdateAll<TMatch_Team>(session, query);
        }
        #endregion
        #region 读
        public static TMatch_Team DbSelect(this TMatch_Team entity, DbSession session, params string[] fields)
        {
            var query = IDbQueryBuilder.GetDbQueryBuilder(session);
            SelectBuilder builder = new SelectBuilder();
            foreach (var field in fields)
            {
                builder.ComponentFieldAliases.FieldAliases.Add(new FieldAlias(field));
            }
            builder.ComponentWhere.Wheres.Add(new PDMDbPropertyOperateValue(TMatch_TeamProperties.MatchId, OperatorType.Equal, entity.MatchId));
            builder.ComponentWhere.Wheres.Add(new PDMDbPropertyOperateValue(TMatch_TeamProperties.TeamId, OperatorType.Equal, entity.TeamId));
            query.SelectBuilders.Add(builder);
            return IDbQueryOperator.GetQueryOperator(session).Select<TMatch_Team>(session, query);
        }
        public static List<TMatch_Team> DbSelect(this List<TMatch_Team> entities, DbSession session, params string[] fields)
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
                builder.ComponentWhere.Wheres.Add(new PDMDbPropertyOperateValue(TMatch_TeamProperties.MatchId, OperatorType.In, Ids));
            }
            query.SelectBuilders.Add(builder);
            return IDbQueryOperator.GetQueryOperator(session).SelectAll<TMatch_Team>(session, query);
        }
        #endregion
        #endregion
    }
}
