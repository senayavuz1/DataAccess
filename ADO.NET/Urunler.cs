using ADO.NET.Models;
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
    public partial class Urunler : Form
    {
        SqlDbContext db;
        string sql = "";
        List<ProductDto> products = new List<ProductDto>();
        DataTable table;
        DataSet dataSet;
        public Urunler()
        {
            InitializeComponent();
            db = new SqlDbContext();
            sql = "Select	ProductID, ";
            sql += "  ProductName, ";
            sql += "    Suppliers.CompanyName , ";
            sql += "    Categories.CategoryName ,";
            sql += "    Products.UnitPrice, ";
            sql += "    Products.UnitsInStock ";
            sql += "    from Products ";
            sql += "    inner join Suppliers on Suppliers.SupplierID = Products.SupplierID ";
            sql += "    inner join Categories on Categories.CategoryID = Products.CategoryID ";

            table = new DataTable();
            dataSet = new DataSet();
        }

        private void Urunler_Load(object sender, EventArgs e)
        {
            DataTableDoldur();

        }

        public void DataTableDoldur()
        {
            SqlDataReader rdr = db.SorguCalistirSP("dbo.GetAllProduct");
            table.TableName = "Products";
            table.Load(rdr);
            rdr.Close();
            dataSet.Tables.Add(table);
            
            //Supplier icin 
            table = new DataTable("Supplier");
            rdr = db.SorguCalistir("Select SupplierId,CompanyName from Suppliers");
            table.Load(rdr);
            dataSet.Tables.Add(table);
            rdr.Close();

            //Category icin 

            table = new DataTable("Category");
            rdr = db.SorguCalistir("Select CategoryId,CategoryName from Categories");
            table.Load(rdr);
            dataSet.Tables.Add(table);
            rdr.Close();



            dataGridView1.DataSource = dataSet.Tables["Products"];

            //Supplier icin ComboBox
            cmbSupplier.DataSource = dataSet.Tables["Supplier"];
            cmbSupplier.DisplayMember = "CompanyName";
            cmbSupplier.ValueMember = "SupplierID";

            //Category icin ComboBox

            cmbCategory.DataSource = dataSet.Tables["Category"];
            cmbCategory.DisplayMember = "CategoryName";
            cmbCategory.ValueMember = "CategoryID";
        }

        public void SqlDataReaderDoldur()
        {
            SqlDataReader rdr = db.SorguCalistirSP("dbo.GetAllProduct");

            while (rdr.Read())
            {
                ProductDto dto = new ProductDto();
                dto.ProductId = rdr.GetInt32("ProductId");   //["ProductID"];
                dto.ProductName = rdr.GetString("ProductName");
                dto.SupplierName = rdr.GetString("CompanyName");
                dto.CategoryName = rdr.GetString("CategoryName");
                dto.UnitPrice = rdr.GetDecimal("UnitPrice");
                dto.UnitsInStock = rdr.GetInt16("UnitsInStock");

                products.Add(dto);

            }
            rdr.Close();

            dataGridView1.DataSource = products;
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string supplier = dataGridView1.CurrentRow.Cells["CompanyName"].Value.ToString();
            string Category = dataGridView1.CurrentRow.Cells["CategoryName"].Value.ToString();

            cmbCategory.Text = Category;
            cmbSupplier.Text = supplier;
            txtProductName.Text = dataGridView1.CurrentRow.Cells["ProductName"].Value.ToString();
            nmrPrice.Value = Convert.ToDecimal(dataGridView1.CurrentRow.Cells["UnitPrice"].Value.ToString());
            nmrStok.Value = Convert.ToDecimal(dataGridView1.CurrentRow.Cells["UnitsInStock"].Value.ToString());
            lblId.Text = dataGridView1.CurrentRow.Cells["ProductId"].Value.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            cmbCategory.SelectedIndex = 0;
            cmbSupplier.SelectedIndex = 0;
            txtProductName.Text = "";
            nmrPrice.Value = 0;
            nmrStok.Value = 0;
            lblId.Text = "0";

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (lblId.Text == "0")
            {

            }
            else
            {
                int supplierId = cmbSupplier.SelectedIndex+1;
                int categoryId = cmbCategory.SelectedIndex+1;
                StringBuilder sql = new StringBuilder();
                sql.Append($"Update Products set ProductName='{txtProductName.Text}' ");
                sql.Append($" , SupplierID={supplierId.ToString()} ");
                sql.Append($" , CategoryID={categoryId.ToString()} ");
                sql.Append($" , UnitPrice={(int)nmrPrice.Value} ");
                sql.Append($" , UnitsInStock={nmrStok.Value.ToString()} ");
                sql.Append($" where ProductId={lblId.Text} ");


                db.Guncelle(sql.ToString());




            }
        }
    }
}
