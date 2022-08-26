using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class Invoice_line : BaseEntity
    {
        public long ID { get; set; }

        public long invoice_ID { get; set; }

        public int type_id { get; set; }

        public int amount { get; set; }

        public double quantity { get; set; }

        public string description { get; set; }
    }
}
