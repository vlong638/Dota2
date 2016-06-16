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
        public static bool DbDelete(this THero entity, DbSession session)
        {
            var query = IDbQueryBuilder.GetDbQueryBuilder(session);
            query.DeleteBuilder.ComponentWhere.Wheres.Add(new PDMDbPropertyOperateValue(THeroProperties.HeroId, OperatorType.Equal, entity.HeroId));
            return IDbQueryOperator.GetQueryOperator(session).Delete<THero>(session, query);
        }
        public static bool DbDelete(this List<THero> entities, DbSession session)
        {
            var query = IDbQueryBuilder.GetDbQueryBuilder(session);
            var Ids = entities.Select(c =>c.HeroId );
            query.DeleteBuilder.ComponentWhere.Wheres.Add(new PDMDbPropertyOperateValue(THeroProperties.HeroId, OperatorType.In, Ids));
            return IDbQueryOperator.GetQueryOperator(session).Delete<THero>(session, query);
        }
        public static bool DbInsert(this THero entity, DbSession session)
        {
            var query = IDbQueryBuilder.GetDbQueryBuilder(session);
            InsertBuilder builder = new InsertBuilder();
            builder.ComponentValue.Values.Add(new PDMDbPropertyValue(THeroProperties.HeroId, entity.HeroId));
            builder.ComponentValue.Values.Add(new PDMDbPropertyValue(THeroProperties.Name, entity.Name));
            builder.ComponentValue.Values.Add(new PDMDbPropertyValue(THeroProperties.NameAbbr, entity.NameAbbr));
            query.InsertBuilders.Add(builder);
            return IDbQueryOperator.GetQueryOperator(session).Insert<THero>(session, query);
        }
        public static bool DbInsert(this List<THero> entities, DbSession session)
        {
            var query = IDbQueryBuilder.GetDbQueryBuilder(session);
            foreach (var entity in entities)
            {
                InsertBuilder builder = new InsertBuilder();
                builder.ComponentValue.Values.Add(new PDMDbPropertyValue(THeroProperties.HeroId, entity.HeroId));
                builder.ComponentValue.Values.Add(new PDMDbPropertyValue(THeroProperties.Name, entity.Name));
                builder.ComponentValue.Values.Add(new PDMDbPropertyValue(THeroProperties.NameAbbr, entity.NameAbbr));
                query.InsertBuilders.Add(builder);
            }
            return IDbQueryOperator.GetQueryOperator(session).InsertAll<THero>(session, query);
        }
        public static bool DbUpdate(this THero entity, DbSession session, params string[] fields)
        {
            var query = IDbQueryBuilder.GetDbQueryBuilder(session);
            UpdateBuilder builder = new UpdateBuilder();
            builder.ComponentWhere.Wheres.Add(new PDMDbPropertyOperateValue(THeroProperties.HeroId, OperatorType.Equal, entity.HeroId));
            if (fields.Contains(THeroProperties.Name.Title))
            {
                builder.ComponentValue.Values.Add(new PDMDbPropertyValue(THeroProperties.Name, entity.Name));
            }
            if (fields.Contains(THeroProperties.NameAbbr.Title))
            {
                builder.ComponentValue.Values.Add(new PDMDbPropertyValue(THeroProperties.NameAbbr, entity.NameAbbr));
            }
            query.UpdateBuilders.Add(builder);
            return IDbQueryOperator.GetQueryOperator(session).Update<THero>(session, query);
        }
        public static bool DbUpdate(this List<THero> entities, DbSession session, params string[] fields)
        {
            var query = IDbQueryBuilder.GetDbQueryBuilder(session);
            foreach (var entity in entities)
            {
                UpdateBuilder builder = new UpdateBuilder();
                builder.ComponentWhere.Wheres.Add(new PDMDbPropertyOperateValue(THeroProperties.HeroId, OperatorType.Equal, entity.HeroId));
                if (fields.Contains(THeroProperties.Name.Title))
                {
                    builder.ComponentValue.Values.Add(new PDMDbPropertyValue(THeroProperties.Name, entity.Name));
                }
                if (fields.Contains(THeroProperties.NameAbbr.Title))
                {
                    builder.ComponentValue.Values.Add(new PDMDbPropertyValue(THeroProperties.NameAbbr, entity.NameAbbr));
                }
                query.UpdateBuilders.Add(builder);
            }
            return IDbQueryOperator.GetQueryOperator(session).UpdateAll<THero>(session, query);
        }
        #endregion
        #region 读
        public static THero DbSelect(this THero entity, DbSession session, params string[] fields)
        {
            var query = IDbQueryBuilder.GetDbQueryBuilder(session);
            SelectBuilder builder = new SelectBuilder();
            foreach (var field in fields)
            {
                builder.ComponentFieldAliases.FieldAliases.Add(new FieldAlias(field));
            }
            builder.ComponentWhere.Wheres.Add(new PDMDbPropertyOperateValue(THeroProperties.HeroId, OperatorType.Equal, entity.HeroId));
            query.SelectBuilders.Add(builder);
            return IDbQueryOperator.GetQueryOperator(session).Select<THero>(session, query);
        }
        public static List<THero> DbSelect(this List<THero> entities, DbSession session, params string[] fields)
        {
            var query = IDbQueryBuilder.GetDbQueryBuilder(session);
            SelectBuilder builder = new SelectBuilder();
            foreach (var field in fields)
            {
                builder.ComponentFieldAliases.FieldAliases.Add(new FieldAlias(field));
            }
            var Ids = entities.Select(c =>c.HeroId );
            if (Ids.Count() != 0)
            {
                builder.ComponentWhere.Wheres.Add(new PDMDbPropertyOperateValue(THeroProperties.HeroId, OperatorType.In, Ids));
            }
            query.SelectBuilders.Add(builder);
            return IDbQueryOperator.GetQueryOperator(session).SelectAll<THero>(session, query);
        }
        #endregion
        #endregion
    }
}
