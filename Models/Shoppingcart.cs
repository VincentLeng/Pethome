using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Shoppingcart
        //购物车
    {
        public int ShoppingID { get; set; }
        public int UserID { get; set; }
        public int ProductID { get; set; }
        public DateTime CreateTime { get; set; }
        public string UnitPrices { get; set; }
        public string Allprices { get; set; }
        public string Quality { get; set; }
    }
}
