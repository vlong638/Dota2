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
        public static bool DbDelete(this TTeam entity, DbSession session)
        {
            var query = IDbQueryBuilder.GetDbQueryBuilder(session);
            query.DeleteBuilder.ComponentWhere.Wheres.Add(new PDMDbPropertyOperateValue(TTeamProperties.TeamId, OperatorType.Equal, entity.TeamId));
            return IDbQueryOperator.GetQueryOperator(session).Delete<TTeam>(session, query);
        }
        public static bool DbDelete(this List<TTeam> entities, DbSession session)
        {
            var query = IDbQueryBuilder.GetDbQueryBuilder(session);
            var Ids = entities.Select(c =>c.TeamId );
            query.DeleteBuilder.ComponentWhere.Wheres.Add(new PDMDbPropertyOperateValue(TTeamProperties.TeamId, OperatorType.In, Ids));
            return IDbQueryOperator.GetQueryOperator(session).Delete<TTeam>(session, query);
        }
        public static bool DbInsert(this TTeam entity, DbSession session)
        {
            var query = IDbQueryBuilder.GetDbQueryBuilder(session);
            InsertBuilder builder = new InsertBuilder();
            builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TTeamProperties.TeamId, entity.TeamId));
            builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TTeamProperties.Name, entity.Name));
            builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TTeamProperties.NameAbbr, entity.NameAbbr));
            builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TTeamProperties.MMR, entity.MMR));
            query.InsertBuilders.Add(builder);
            return IDbQueryOperator.GetQueryOperator(session).Insert<TTeam>(session, query);
        }
        public static bool DbInsert(this List<TTeam> entities, DbSession session)
        {
            var query = IDbQueryBuilder.GetDbQueryBuilder(session);
            foreach (var entity in entities)
            {
                InsertBuilder builder = new InsertBuilder();
                builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TTeamProperties.TeamId, entity.TeamId));
                builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TTeamProperties.Name, entity.Name));
                builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TTeamProperties.NameAbbr, entity.NameAbbr));
                builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TTeamProperties.MMR, entity.MMR));
                query.InsertBuilders.Add(builder);
            }
            return IDbQueryOperator.GetQueryOperator(session).InsertAll<TTeam>(session, query);
        }
        public static bool DbUpdate(this TTeam entity, DbSession session, params string[] fields)
        {
            var query = IDbQueryBuilder.GetDbQueryBuilder(session);
            UpdateBuilder builder = new UpdateBuilder();
            builder.ComponentWhere.Wheres.Add(new PDMDbPropertyOperateValue(TTeamProperties.TeamId, OperatorType.Equal, entity.TeamId));
            if (fields.Contains(TTeamProperties.Name.Title))
            {
                builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TTeamProperties.Name, entity.Name));
            }
            if (fields.Contains(TTeamProperties.NameAbbr.Title))
            {
                builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TTeamProperties.NameAbbr, entity.NameAbbr));
            }
            if (fields.Contains(TTeamProperties.MMR.Title))
            {
                builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TTeamProperties.MMR, entity.MMR));
            }
            query.UpdateBuilders.Add(builder);
            return IDbQueryOperator.GetQueryOperator(session).Update<TTeam>(session, query);
        }
        public static bool DbUpdate(this List<TTeam> entities, DbSession session, params string[] fields)
        {
            var query = IDbQueryBuilder.GetDbQueryBuilder(session);
            foreach (var entity in entities)
            {
                UpdateBuilder builder = new UpdateBuilder();
                builder.ComponentWhere.Wheres.Add(new PDMDbPropertyOperateValue(TTeamProperties.TeamId, OperatorType.Equal, entity.TeamId));
                if (fields.Contains(TTeamProperties.Name.Title))
                {
                    builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TTeamProperties.Name, entity.Name));
                }
                if (fields.Contains(TTeamProperties.NameAbbr.Title))
                {
                    builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TTeamProperties.NameAbbr, entity.NameAbbr));
                }
                if (fields.Contains(TTeamProperties.MMR.Title))
                {
                    builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TTeamProperties.MMR, entity.MMR));
                }
                query.UpdateBuilders.Add(builder);
            }
            return IDbQueryOperator.GetQueryOperator(session).UpdateAll<TTeam>(session, query);
        }
        #endregion
        #region 读
        public static TTeam DbSelect(this TTeam entity, DbSession session, params string[] fields)
        {
            var query = IDbQueryBuilder.GetDbQueryBuilder(session);
            SelectBuilder builder = new SelectBuilder();
            foreach (var field in fields)
            {
                builder.ComponentFieldAliases.FieldAliases.Add(new FieldAlias(field));
            }
            builder.ComponentWhere.Wheres.Add(new PDMDbPropertyOperateValue(TTeamProperties.TeamId, OperatorType.Equal, entity.TeamId));
            query.SelectBuilders.Add(builder);
            return IDbQueryOperator.GetQueryOperator(session).Select<TTeam>(session, query);
        }
        public static List<TTeam> DbSelect(this List<TTeam> entities, DbSession session, params string[] fields)
        {
            var query = IDbQueryBuilder.GetDbQueryBuilder(session);
            SelectBuilder builder = new SelectBuilder();
            foreach (var field in fields)
            {
                builder.ComponentFieldAliases.FieldAliases.Add(new FieldAlias(field));
            }
            var Ids = entities.Select(c =>c.TeamId );
            if (Ids.Count() != 0)
            {
                builder.ComponentWhere.Wheres.Add(new PDMDbPropertyOperateValue(TTeamProperties.TeamId, OperatorType.In, Ids));
            }
            query.SelectBuilders.Add(builder);
            return IDbQueryOperator.GetQueryOperator(session).SelectAll<TTeam>(session, query);
        }
        #endregion
        #endregion
    }
}
