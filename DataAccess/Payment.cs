using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class Payment : BaseEntity
    {
        public long ID { get; set; }
        public string User_ID { get; set; } 
        // thử
        public string attempt { get; set; } 
        // kết quả
        public string result_ID { get; set; }
        // số lượng
        public double amount { get; set; }
        // ngày thanh toán
        public DateTime? Payment_Date { get; set; }
        // Phương thức
        public string Method_ID { get; set; }
        public string Credit_Car_ID { get; set; }
        public int Deleted { get; set; } 
        // Tiền hoàn lại
        public int Is_Refund { get; set; }
        // Xác thực trước
        public int Is_PreAuth{ get; set; }
        public int Payment_ID { get; set; }
        // Tiền tệ
        public int Currency_ID { get; set; }
        public int Payout_ID { get; set; }
        // Thanh toán bù trừ tự động
        public int Ach_ID { get; set; }
        // giá
        public double Balance { get; set; }
        // khóa lựa chọn
        public int Optlock { get; set; }
        // Kỳ thanh toán
        public int Payment_Period { get; set; }
        // Ghi chú thanh toán
        public string Payment_Notes { get; set; }

                    
    }
}
