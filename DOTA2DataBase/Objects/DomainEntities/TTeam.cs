using VL.Common.DAS.Objects;
using VL.Common.ORM.Utilities.QueryBuilders;
using VL.Common.ORM.Utilities.QueryOperators;

namespace DOTA2DataBase.Objects.Entities
{
    public static class TTeamEx
    {
        public static bool CheckExistenceByName(this TTeam tTeam,DbSession session)
        {
            var queryOperator= IDbQueryOperator.GetQueryOperator(session);
            SelectBuilder builder = new SelectBuilder();
            builder.ComponentFieldAliases.FieldAliases.Add(new FieldAlias("1"));
            builder.TableName = nameof(TTeam);
            builder.ComponentWhere.Wheres.Add(new PDMDbPropertyOperateValue(TTeamProperties.Name, OperatorType.Equal, tTeam.Name));
            var result = queryOperator.SelectAsInt(session, builder);
            if (result!=null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
