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
        public static bool DbDelete(this TRound_Team_Player entity, DbSession session)
        {
            var query = IDbQueryBuilder.GetDbQueryBuilder(session);
            query.DeleteBuilder.ComponentWhere.Wheres.Add(new PDMDbPropertyOperateValue(TRound_Team_PlayerProperties.RoundId, OperatorType.Equal, entity.RoundId));
            query.DeleteBuilder.ComponentWhere.Wheres.Add(new PDMDbPropertyOperateValue(TRound_Team_PlayerProperties.TeamId, OperatorType.Equal, entity.TeamId));
            query.DeleteBuilder.ComponentWhere.Wheres.Add(new PDMDbPropertyOperateValue(TRound_Team_PlayerProperties.PlayerId, OperatorType.Equal, entity.PlayerId));
            return IDbQueryOperator.GetQueryOperator(session).Delete<TRound_Team_Player>(session, query);
        }
        public static bool DbDelete(this List<TRound_Team_Player> entities, DbSession session)
        {
            var query = IDbQueryBuilder.GetDbQueryBuilder(session);
            var Ids = entities.Select(c =>c.RoundId );
            query.DeleteBuilder.ComponentWhere.Wheres.Add(new PDMDbPropertyOperateValue(TRound_Team_PlayerProperties.RoundId, OperatorType.In, Ids));
            return IDbQueryOperator.GetQueryOperator(session).Delete<TRound_Team_Player>(session, query);
        }
        public static bool DbInsert(this TRound_Team_Player entity, DbSession session)
        {
            var query = IDbQueryBuilder.GetDbQueryBuilder(session);
            InsertBuilder builder = new InsertBuilder();
            builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TRound_Team_PlayerProperties.RoundId, entity.RoundId));
            builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TRound_Team_PlayerProperties.TeamId, entity.TeamId));
            builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TRound_Team_PlayerProperties.PlayerId, entity.PlayerId));
            builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TRound_Team_PlayerProperties.HeroId, entity.HeroId));
            builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TRound_Team_PlayerProperties.KDA, entity.KDA));
            builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TRound_Team_PlayerProperties.KDADetail, entity.KDADetail));
            builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TRound_Team_PlayerProperties.GPM, entity.GPM));
            builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TRound_Team_PlayerProperties.XPM, entity.XPM));
            if (entity.IsGodLike.HasValue)
            {
                builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TRound_Team_PlayerProperties.IsGodLike, entity.IsGodLike.Value));
            }
            query.InsertBuilders.Add(builder);
            return IDbQueryOperator.GetQueryOperator(session).Insert<TRound_Team_Player>(session, query);
        }
        public static bool DbInsert(this List<TRound_Team_Player> entities, DbSession session)
        {
            var query = IDbQueryBuilder.GetDbQueryBuilder(session);
            foreach (var entity in entities)
            {
                InsertBuilder builder = new InsertBuilder();
                builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TRound_Team_PlayerProperties.RoundId, entity.RoundId));
                builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TRound_Team_PlayerProperties.TeamId, entity.TeamId));
                builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TRound_Team_PlayerProperties.PlayerId, entity.PlayerId));
                builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TRound_Team_PlayerProperties.HeroId, entity.HeroId));
                builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TRound_Team_PlayerProperties.KDA, entity.KDA));
                builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TRound_Team_PlayerProperties.KDADetail, entity.KDADetail));
                builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TRound_Team_PlayerProperties.GPM, entity.GPM));
                builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TRound_Team_PlayerProperties.XPM, entity.XPM));
                if (entity.IsGodLike.HasValue)
                {
                    builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TRound_Team_PlayerProperties.IsGodLike, entity.IsGodLike.Value));
                }
                query.InsertBuilders.Add(builder);
            }
            return IDbQueryOperator.GetQueryOperator(session).InsertAll<TRound_Team_Player>(session, query);
        }
        public static bool DbUpdate(this TRound_Team_Player entity, DbSession session, params string[] fields)
        {
            var query = IDbQueryBuilder.GetDbQueryBuilder(session);
            UpdateBuilder builder = new UpdateBuilder();
            builder.ComponentWhere.Wheres.Add(new PDMDbPropertyOperateValue(TRound_Team_PlayerProperties.RoundId, OperatorType.Equal, entity.RoundId));
            builder.ComponentWhere.Wheres.Add(new PDMDbPropertyOperateValue(TRound_Team_PlayerProperties.TeamId, OperatorType.Equal, entity.TeamId));
            builder.ComponentWhere.Wheres.Add(new PDMDbPropertyOperateValue(TRound_Team_PlayerProperties.PlayerId, OperatorType.Equal, entity.PlayerId));
            if (fields.Contains(TRound_Team_PlayerProperties.HeroId.Title))
            {
                builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TRound_Team_PlayerProperties.HeroId, entity.HeroId));
            }
            if (fields.Contains(TRound_Team_PlayerProperties.KDA.Title))
            {
                builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TRound_Team_PlayerProperties.KDA, entity.KDA));
            }
            if (fields.Contains(TRound_Team_PlayerProperties.KDADetail.Title))
            {
                builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TRound_Team_PlayerProperties.KDADetail, entity.KDADetail));
            }
            if (fields.Contains(TRound_Team_PlayerProperties.GPM.Title))
            {
                builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TRound_Team_PlayerProperties.GPM, entity.GPM));
            }
            if (fields.Contains(TRound_Team_PlayerProperties.XPM.Title))
            {
                builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TRound_Team_PlayerProperties.XPM, entity.XPM));
            }
            if (fields.Contains(TRound_Team_PlayerProperties.IsGodLike.Title))
            {
                builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TRound_Team_PlayerProperties.IsGodLike, entity.IsGodLike));
            }
            query.UpdateBuilders.Add(builder);
            return IDbQueryOperator.GetQueryOperator(session).Update<TRound_Team_Player>(session, query);
        }
        public static bool DbUpdate(this List<TRound_Team_Player> entities, DbSession session, params string[] fields)
        {
            var query = IDbQueryBuilder.GetDbQueryBuilder(session);
            foreach (var entity in entities)
            {
                UpdateBuilder builder = new UpdateBuilder();
                builder.ComponentWhere.Wheres.Add(new PDMDbPropertyOperateValue(TRound_Team_PlayerProperties.RoundId, OperatorType.Equal, entity.RoundId));
                builder.ComponentWhere.Wheres.Add(new PDMDbPropertyOperateValue(TRound_Team_PlayerProperties.TeamId, OperatorType.Equal, entity.TeamId));
                builder.ComponentWhere.Wheres.Add(new PDMDbPropertyOperateValue(TRound_Team_PlayerProperties.PlayerId, OperatorType.Equal, entity.PlayerId));
                if (fields.Contains(TRound_Team_PlayerProperties.HeroId.Title))
                {
                    builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TRound_Team_PlayerProperties.HeroId, entity.HeroId));
                }
                if (fields.Contains(TRound_Team_PlayerProperties.KDA.Title))
                {
                    builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TRound_Team_PlayerProperties.KDA, entity.KDA));
                }
                if (fields.Contains(TRound_Team_PlayerProperties.KDADetail.Title))
                {
                    builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TRound_Team_PlayerProperties.KDADetail, entity.KDADetail));
                }
                if (fields.Contains(TRound_Team_PlayerProperties.GPM.Title))
                {
                    builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TRound_Team_PlayerProperties.GPM, entity.GPM));
                }
                if (fields.Contains(TRound_Team_PlayerProperties.XPM.Title))
                {
                    builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TRound_Team_PlayerProperties.XPM, entity.XPM));
                }
                if (fields.Contains(TRound_Team_PlayerProperties.IsGodLike.Title))
                {
                    builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TRound_Team_PlayerProperties.IsGodLike, entity.IsGodLike));
                }
                query.UpdateBuilders.Add(builder);
            }
            return IDbQueryOperator.GetQueryOperator(session).UpdateAll<TRound_Team_Player>(session, query);
        }
        #endregion
        #region 读
        public static TRound_Team_Player DbSelect(this TRound_Team_Player entity, DbSession session, params string[] fields)
        {
            var query = IDbQueryBuilder.GetDbQueryBuilder(session);
            SelectBuilder builder = new SelectBuilder();
            foreach (var field in fields)
            {
                builder.ComponentFieldAliases.FieldAliases.Add(new FieldAlias(field));
            }
            builder.ComponentWhere.Wheres.Add(new PDMDbPropertyOperateValue(TRound_Team_PlayerProperties.RoundId, OperatorType.Equal, entity.RoundId));
            builder.ComponentWhere.Wheres.Add(new PDMDbPropertyOperateValue(TRound_Team_PlayerProperties.TeamId, OperatorType.Equal, entity.TeamId));
            builder.ComponentWhere.Wheres.Add(new PDMDbPropertyOperateValue(TRound_Team_PlayerProperties.PlayerId, OperatorType.Equal, entity.PlayerId));
            query.SelectBuilders.Add(builder);
            return IDbQueryOperator.GetQueryOperator(session).Select<TRound_Team_Player>(session, query);
        }
        public static List<TRound_Team_Player> DbSelect(this List<TRound_Team_Player> entities, DbSession session, params string[] fields)
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
                builder.ComponentWhere.Wheres.Add(new PDMDbPropertyOperateValue(TRound_Team_PlayerProperties.RoundId, OperatorType.In, Ids));
            }
            query.SelectBuilders.Add(builder);
            return IDbQueryOperator.GetQueryOperator(session).SelectAll<TRound_Team_Player>(session, query);
        }
        #endregion
        #endregion
    }
}
