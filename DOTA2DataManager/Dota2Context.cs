using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VL.Common.DAS.Utilities;
using VL.Common.Logger.Objects;
using VL.Common.Protocol;
using VL.Common.Protocol.IService;

namespace DOTA2DataManager
{
    public class Dota2Context : ServiceContext
    {
        public Dota2Context(DbConfigEntity databaseConfig, ProtocolConfig protocolConfig, ILogger serviceLogger) : base(databaseConfig, protocolConfig, serviceLogger)
        {
        }

        protected override bool InitOthers()
        {
            return true;
        }
    }
}
