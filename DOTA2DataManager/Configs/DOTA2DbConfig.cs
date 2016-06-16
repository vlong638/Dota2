using DOTA2DataManager.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VL.Common.DAS.Utilities;

namespace DOTA2DataManager.Configs
{
    public class DOTA2DbConfig : DbConfigEntity
    {
        public DOTA2DbConfig(string fileName = nameof(DOTA2DbConfig)) : base(fileName)
        {
        }

        protected override List<DbConfigItem> GetDbConfigItems()
        {
            List<DbConfigItem> result = new List<DbConfigItem>()
            {
                new DbConfigItem(DbHelper.DbNameOfDota2DataBase),
            };
            return result;
        }
    }
}
