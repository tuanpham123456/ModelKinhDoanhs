using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class Payment_authorization : BaseEntity
    {
        public long ID { get; set; }
        public int Payment_ID { get; set; }
        // Bộ xử lý
        public string Processor { get; set; }
        public string Code1 { get; set; }
        public string Code2 { get; set; }
        public string Code3 { get; set; }
        // Mã phê duyệt
        public string Approval_code { get; set; }
        // Hệ thống xác mình địa chỉ (Address Verification System)
        public string Avs { get; set; }
        // Giao dịch
        public string Transaction_ID { get; set; }
        // Message-Digest Algorithm 
        public string Md5 { get; set; }
        // Mã thẻ
        public string Card_code { get; set; }
        // Tin nhắn phản hồi
        public string Response_message { get; set; }
        //Khóa lực chọn
        public int Optlock { get; set; }

    }
}
