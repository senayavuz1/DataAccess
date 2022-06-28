using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO.NET
{
    public partial class NorthwindFrom : Form
    {
       
        DataSet dataSet; // DataTable'lari Collection olarak tutan nesne
        DataTable tbl; // Database uzerindeki table similasyonudur
        SqlDataAdapter adap ; // SqlCommand , SqlConnection , SqlDataReader 'i icerisinde barindiran 
                             // Butunlesik bir nesnedir   
        SqlConnection sqlConnection; 
        SqlCommandBuilder cmdBuilder; // SqlDataAdaptor icin CRUD (Create,Update,Delete) komutlarini cikaran nesnedir
        String constr = @"Data Source = (localdb)\MSSQLLocalDB;Initial Catalog = Northwind; Integrated Security = True; Connect Timeout = 30; Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public NorthwindFrom()
        {
            InitializeComponent();
            dataSet = new DataSet();
            tbl = new DataTable("Products");
            sqlConnection = new SqlConnection(constr);
            // Product tablosu icin gerekli komut
            // 1. Once DataTable'i doldur ve olusan datatable'i dataset'e ekle
            adap = new SqlDataAdapter("Select * from Products", sqlConnection);
            adap.Fill(tbl);
           
            // CommandBuilder nesnesi calisacagi SqlDataAdaptor'u bilmek ister. 
            // O yuzden New edilirken bildirilmesi gerekir
            cmdBuilder = new SqlCommandBuilder(adap);

            adap.InsertCommand = cmdBuilder.GetInsertCommand();
            adap.UpdateCommand = cmdBuilder.GetUpdateCommand();



            dataSet.Tables.Add(tbl);

            //2.Yol Customer icin gerek li komut 
            // dataset'e table olarak ekle
            //adap.SelectCommand = new SqlCommand("Select * from Customers", sqlConnection);
            //adap.Fill(dataSet, "Customers");
           
            // Supplier icin de benzer kodlar 

            adap.SelectCommand = new SqlCommand("Select * from suppliers", sqlConnection);
            adap.Fill(dataSet, "Suppliers");
            
        }

        private void NorthwindFrom_Load(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dataSet.Tables["Customers"];

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dataSet.Tables["Products"];

        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dataSet.Tables["Suppliers"];

        }

        private void button4_Click(object sender, EventArgs e)
        {
            

            DataRelation relation = new DataRelation("product2Supplier", 
                dataSet.Tables["Suppliers"].Columns["SupplierID"], 
                dataSet.Tables["Products"].Columns["SupplierID"],true);
            
            

            dataSet.Relations.Add(relation);
            dataGridView1.DataSource = dataSet.Tables[1].DefaultView;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
