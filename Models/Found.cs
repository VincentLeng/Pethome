using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Found
        //查找宠物
    {
        public int FoundID { get; set; }
        public int UserID { get; set; }
        public string FoundLostAdd { get; set; }
        public DateTime FoundLostTime { get; set; }
        public string FoundUserPhone { get; set; }
        public string FoundContent { get; set; }
        public string FoundStatus { get; set; }
        public string FoundPetPhoto { get; set; }

    }
}
