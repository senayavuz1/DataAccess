using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
namespace ADO.NET
{
    public class PostgreDbContext : IDbContext
    {
        NpgsqlConnection npgsql;
        NpgsqlCommand cmd;
        NpgsqlDataReader rdr;
        string constr = "Host=127.0.0.1;Username=postgres;Password=qweasd;Database=Northwind";



        public PostgreDbContext(string connectionstring=null)
        {
            if (String.IsNullOrEmpty(connectionstring))
                npgsql = new NpgsqlConnection(constr);
            else
                npgsql = new NpgsqlConnection(connectionstring);


        }
        public int ExecuteNonQuery(string sql)
        {
            if (npgsql.State == System.Data.ConnectionState.Closed)
                npgsql.Open();
            cmd = new NpgsqlCommand(sql, npgsql);

            return cmd.ExecuteNonQuery();
        }

        public DbDataReader ExecuteQuery(string sql)
        {
            if (npgsql.State == System.Data.ConnectionState.Closed)
                npgsql.Open();
            cmd = new NpgsqlCommand(sql, npgsql);

            return cmd.ExecuteReader();
        }
    }
}
