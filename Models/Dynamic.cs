using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Dynamic
        //动态
    {
        public int DynamicID { get; set; }
        public string DyContent { get; set; }
        public DateTime CreateTime { get; set; }
        public int UserID { get; set; }
    }
}
