using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Order
    {
        public int OrderID { get; set; }
        public int UserID { get; set; }
        public DateTime OrderTime { get; set; }
        public string TotalAmount { get; set; }
        public string OrderStutas { get; set; }
        public string UserAddre { get; set; }
        public string UserPhone { get; set; }
    }
}
