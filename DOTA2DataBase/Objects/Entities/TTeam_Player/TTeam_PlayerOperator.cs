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
        public static bool DbDelete(this TTeam_Player entity, DbSession session)
        {
            var query = IDbQueryBuilder.GetDbQueryBuilder(session);
            return IDbQueryOperator.GetQueryOperator(session).Delete<TTeam_Player>(session, query);
        }
        public static bool DbDelete(this List<TTeam_Player> entities, DbSession session)
        {
            var query = IDbQueryBuilder.GetDbQueryBuilder(session);
            return IDbQueryOperator.GetQueryOperator(session).Delete<TTeam_Player>(session, query);
        }
        public static bool DbInsert(this TTeam_Player entity, DbSession session)
        {
            var query = IDbQueryBuilder.GetDbQueryBuilder(session);
            InsertBuilder builder = new InsertBuilder();
            builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TTeam_PlayerProperties.TeamId, entity.TeamId));
            builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TTeam_PlayerProperties.PlayerId, entity.PlayerId));
            if (entity.StartTime.HasValue)
            {
                builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TTeam_PlayerProperties.StartTime, entity.StartTime.Value));
            }
            if (entity.EndTime.HasValue)
            {
                builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TTeam_PlayerProperties.EndTime, entity.EndTime.Value));
            }
            builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TTeam_PlayerProperties.Remark, entity.Remark));
            query.InsertBuilders.Add(builder);
            return IDbQueryOperator.GetQueryOperator(session).Insert<TTeam_Player>(session, query);
        }
        public static bool DbInsert(this List<TTeam_Player> entities, DbSession session)
        {
            var query = IDbQueryBuilder.GetDbQueryBuilder(session);
            foreach (var entity in entities)
            {
                InsertBuilder builder = new InsertBuilder();
                builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TTeam_PlayerProperties.TeamId, entity.TeamId));
                builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TTeam_PlayerProperties.PlayerId, entity.PlayerId));
                if (entity.StartTime.HasValue)
                {
                    builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TTeam_PlayerProperties.StartTime, entity.StartTime.Value));
                }
                if (entity.EndTime.HasValue)
                {
                    builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TTeam_PlayerProperties.EndTime, entity.EndTime.Value));
                }
                builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TTeam_PlayerProperties.Remark, entity.Remark));
                query.InsertBuilders.Add(builder);
            }
            return IDbQueryOperator.GetQueryOperator(session).InsertAll<TTeam_Player>(session, query);
        }
        public static bool DbUpdate(this TTeam_Player entity, DbSession session, params string[] fields)
        {
            var query = IDbQueryBuilder.GetDbQueryBuilder(session);
            UpdateBuilder builder = new UpdateBuilder();
            if (fields.Contains(TTeam_PlayerProperties.TeamId.Title))
            {
                builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TTeam_PlayerProperties.TeamId, entity.TeamId));
            }
            if (fields.Contains(TTeam_PlayerProperties.PlayerId.Title))
            {
                builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TTeam_PlayerProperties.PlayerId, entity.PlayerId));
            }
            if (fields.Contains(TTeam_PlayerProperties.StartTime.Title))
            {
                builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TTeam_PlayerProperties.StartTime, entity.StartTime));
            }
            if (fields.Contains(TTeam_PlayerProperties.EndTime.Title))
            {
                builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TTeam_PlayerProperties.EndTime, entity.EndTime));
            }
            if (fields.Contains(TTeam_PlayerProperties.Remark.Title))
            {
                builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TTeam_PlayerProperties.Remark, entity.Remark));
            }
            query.UpdateBuilders.Add(builder);
            return IDbQueryOperator.GetQueryOperator(session).Update<TTeam_Player>(session, query);
        }
        public static bool DbUpdate(this List<TTeam_Player> entities, DbSession session, params string[] fields)
        {
            var query = IDbQueryBuilder.GetDbQueryBuilder(session);
            foreach (var entity in entities)
            {
                UpdateBuilder builder = new UpdateBuilder();
                if (fields.Contains(TTeam_PlayerProperties.TeamId.Title))
                {
                    builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TTeam_PlayerProperties.TeamId, entity.TeamId));
                }
                if (fields.Contains(TTeam_PlayerProperties.PlayerId.Title))
                {
                    builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TTeam_PlayerProperties.PlayerId, entity.PlayerId));
                }
                if (fields.Contains(TTeam_PlayerProperties.StartTime.Title))
                {
                    builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TTeam_PlayerProperties.StartTime, entity.StartTime));
                }
                if (fields.Contains(TTeam_PlayerProperties.EndTime.Title))
                {
                    builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TTeam_PlayerProperties.EndTime, entity.EndTime));
                }
                if (fields.Contains(TTeam_PlayerProperties.Remark.Title))
                {
                    builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TTeam_PlayerProperties.Remark, entity.Remark));
                }
                query.UpdateBuilders.Add(builder);
            }
            return IDbQueryOperator.GetQueryOperator(session).UpdateAll<TTeam_Player>(session, query);
        }
        #endregion
        #region 读
        public static TTeam_Player DbSelect(this TTeam_Player entity, DbSession session, params string[] fields)
        {
            var query = IDbQueryBuilder.GetDbQueryBuilder(session);
            SelectBuilder builder = new SelectBuilder();
            foreach (var field in fields)
            {
                builder.ComponentFieldAliases.FieldAliases.Add(new FieldAlias(field));
            }
            query.SelectBuilders.Add(builder);
            return IDbQueryOperator.GetQueryOperator(session).Select<TTeam_Player>(session, query);
        }
        public static List<TTeam_Player> DbSelect(this List<TTeam_Player> entities, DbSession session, params string[] fields)
        {
            var query = IDbQueryBuilder.GetDbQueryBuilder(session);
            SelectBuilder builder = new SelectBuilder();
            foreach (var field in fields)
            {
                builder.ComponentFieldAliases.FieldAliases.Add(new FieldAlias(field));
            }
            query.SelectBuilders.Add(builder);
            return IDbQueryOperator.GetQueryOperator(session).SelectAll<TTeam_Player>(session, query);
        }
        #endregion
        #endregion
    }
}
