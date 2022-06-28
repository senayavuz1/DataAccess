using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET.Models
{
    public class ProductDto
    {
        // ProductID,
        public int ProductId { get; set; }
        // ProductName,
        public string ProductName { get; set; }

        //Suppliers.CompanyName ,
        public string SupplierName { get; set; }
        //Categories.CategoryName ,
        public string CategoryName { get; set; }

        //Products.UnitPrice,
        public decimal  UnitPrice { get; set; }

        //Products.UnitsInStock

        public int UnitsInStock { get; set; }
    }
}
