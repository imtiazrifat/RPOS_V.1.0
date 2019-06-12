using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPOS_V._1._0.Entities
{
   public  class CatagoryVm
    {
       public int CatagoryId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Details { get; set; }
        public bool Status { get; set; }
    }
}
