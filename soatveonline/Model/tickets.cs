using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace soatveonline.Model
{
    public class tickets
    {
        public int Price { get; set; }
        public string Code { get; set; }
        public bool Status { get; set; }
        public int UserID { get; set; }
        public virtual User User { get; set; }
        public int TicketTypeId { get; set; }
        public virtual TicketTypes TicketTypess { get; set; }
    }
}
