using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{   // Hóa đơn thanh toán
    public class Payment_invoice : BaseEntity
    {
        public long ID { get; set; }
        public int Payment_ID { get; set; }
        //Hóa đơn
        public int Invoice_ID { get; set; }
        public double Amount { get; set; }
        // Khóa lựa chọn
        public int Optlock { get; set; }
    }
}
