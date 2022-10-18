using Common.Infraestructure.EF.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Infraestructure.EF.Common
{
    internal class CommonDBContext : BaseContext
    {
        public CommonDBContext(string connectionString)
         : base(connectionString) { }
    }
}
