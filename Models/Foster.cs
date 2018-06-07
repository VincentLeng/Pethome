using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Foster
        //领养
    {
        public int FosterID { get; set; }
        public int UserID { get; set; }
        public string FosterAdd { get; set; }
        public DateTime FosterTime { get; set; }
        public string FosterUserPhone { get; set; }
        public string FosterContent { get; set; }
        public string FosterStatus { get; set; }
        public string FosterPetPhoto { get; set; }
    }
}
