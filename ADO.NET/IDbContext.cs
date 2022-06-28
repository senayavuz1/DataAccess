using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET
{
    public  interface IDbContext
    {
        public int ExecuteNonQuery(string sql);

        public DbDataReader ExecuteQuery(string sql);

    }
}
