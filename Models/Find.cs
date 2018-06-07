using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Find
        //发现流浪狗
    {
        public int FindID { get; set; }
        public int UserID { get; set; }
        public string FindAdd { get; set; }
        public DateTime FindTime { get; set; }
        public string FindUserPhone { get; set; }
        public string FindContent { get; set; }
        public string FindStatus { get; set; }
        public string FindPetPhoto { get; set; }
    }
}
