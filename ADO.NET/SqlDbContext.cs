using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET
{
    public class SqlDbContext
    {

        //1- Ado.Net icerisinde veriye erisim icin gerekli olan ilk nesnemiz
        // SqlConnection nesnesidir. Görevi ise SqlServer'a baglanmaktir.
        private const  string _sqlconstr = @"Data Source = (localdb)\MSSQLLocalDB;Initial Catalog = Northwind; Integrated Security = True; Connect Timeout = 30; Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        
       
       //1. SqlConnection NEsnesi  
        public SqlConnection sqlConnection;

        // 2. Nesne SqlCommand Nesnesi
        public SqlCommand cmd;



        public SqlDbContext(string sqlconnStr=null)
        {
            if(!String.IsNullOrEmpty(sqlconnStr))
                sqlConnection = new SqlConnection(sqlconnStr);
            else
                sqlConnection = new SqlConnection(_sqlconstr);
        }

        public string SqlBaglantiDurumu()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
                return "Sql Baglantisi Acik";
            else
                return "Sql Baglantisi Kapali";
        }
        public bool SqlBaglatiAc()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
                sqlConnection.Open();
                
            
            return true;
        }
        public int Guncelle(string sql)
        {
            //Update Shippers   Set CompanyName=Aras Kargo , Phone=444 0 555 Where ShipperId=8
            // Update Shippers set Phone = '123456' Where Id = 1
            cmd = new SqlCommand();
            cmd.Connection = sqlConnection;
            cmd.CommandText = sql;
            SqlBaglatiAc();
          
            return cmd.ExecuteNonQuery();
        }
        public SqlDataReader SorguCalistir(string sql)
        {
            /*
             SqlCommand Nesnesi SqlConnection uzerinden Database ile iletisim kurar .
             İki turlu calisir. 
            1- CommandText vererek , 2- StoredProcedure calistirarak.
             
             Geriye 
            1- SqlDataReader doner ;

             */
            cmd = new SqlCommand();
            cmd.Connection = sqlConnection;
            cmd.CommandText = sql;
            SqlBaglatiAc();
            
            return cmd.ExecuteReader();

        }
        public SqlDataReader SorguCalistirSP(string sql)
        {
            /*
             SqlCommand Nesnesi SqlConnection uzerinden Database ile iletisim kurar .
             İki turlu calisir. 
            1- CommandText vererek , 2- StoredProcedure calistirarak.
             
             Geriye 
            1- SqlDataReader doner ;

             */
            cmd = new SqlCommand();
            cmd.Connection = sqlConnection;
            cmd.CommandText = sql;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            SqlBaglatiAc();

            return cmd.ExecuteReader();

        }
    }
}
