using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Products
    {
        public int ProductID { get; set; }
        public int ProName { get; set; }
        public int CategoriesID { get; set; }
        public string Prices { get; set; }
        public string Sales { get; set; }
        public string Information { get; set; }
        public int UserID { get; set; }
        public string ProdPhoto { get; set; }
    }
}
