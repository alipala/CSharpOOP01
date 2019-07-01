using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class36
{
    public class DbMigrator
    {
        private readonly ILogger _logger;

        public DbMigrator(ILogger logger)
        {
            _logger = logger;
        }

        public void Migrate()
        {
            _logger.LogInfo("Migrating is started at {0}" + DateTime.Now);

            _logger.LogInfo("Migrating is finished at {0}" + DateTime.Now);

        }
    }
}
