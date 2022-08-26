using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    // Kiểm tra thông tin thanh toán
    public class Payment_info_cheque : BaseEntity
    {
        public long ID { get; set; }
        public int Paymet_ID { get; set; }
        public string Bank { get; set; }
        // số kiểm tra
        public string Cheque_number { get; set; }
        // Ngày kiểm tra
        public DateTime Cheque_date { get; set; }
        // khóa lựa chọn
        public int Optlock { get; set; }
    }
}
