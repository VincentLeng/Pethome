using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Models
{
    public class Comments
        //评论
    {
        public int ComID { get; set; }
        public DateTime ComTime { get; set; }
        public string ComContent { get; set; }
        public int UserID { get; set; }
        public int ActID { get; set; }
    }
}
