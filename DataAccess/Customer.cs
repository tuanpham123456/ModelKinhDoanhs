using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class Customer : BaseEntity
    {
        public long ID { get; set; }
        public int user_id { get; set; }
        public int partner_id { get; set; }
        public int auto_payment_type { get; set; }
        public int due_date_unit_id { get; set; } // hạn thanh toán 
        public int due_date_value { get; set; }
        public int parent_id { get; set; }
        public int invoice_child { get; set; }
        public int optlock { get; set; }
        public int balance_type { get; set; }
        
        
    }
}
