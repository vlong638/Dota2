using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VL.Common.DAS.Objects;

namespace DOTA2DataManager.Utilities
{
    public class DbHelper
    {
        public static string DbNameOfDota2DataBase = "Dota2DataBase";
        public static DbSession DbSessionOfDota2DataBase { get { return Dota2Context.DatabaseConfig.GetDbConfigItem(DbNameOfDota2DataBase).GetDbSession(); } }
    }
}
