using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Act
        //活动、行为
    {
        public int ActID { get; set; }
        public int UserID { get; set; }
        public string ActName { get; set; }
        public string ActContent { get; set; }
        public string Sort { get; set; }
        public string ActLogo { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime EndTime { get; set; }
       
        
    }
}
