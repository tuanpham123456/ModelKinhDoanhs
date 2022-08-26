using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class Invoice : BaseEntity
    {
        public long Id { get; set; }
        // Quy trình thanh toán
        public int Billing_Process_ID { get; set; }
        public int User_ID { get; set; }
        // Hóa đơn được ủy quyền
        public int Delegated_Invoice_ID { get; set; }
        // Ngày đáo hạn
        public DateTime Dude_date  { get; set; }
        public double Total { get; set; }
        public int Payment_attempts { get; set; }
        public int Status_ID { get; set; }
        public double Balance { get; set; }
        // Số dư đã thực hiện
        public double Carried_Balance { get; set; }
        // Đang trong quá trình thanh toán
        public int In_process_payment { get; set; }
        // Đánh giá
        public int Is_Review { get; set; }
        // Tiền tệ
        public int Currency_ID  { get; set; }
        public int Deleted { get; set; }
        // Lô hóa đơn thanh toán
        public int Payment_Invoice_Batch_ID { get; set; }
        // Ghi chú khách hàng
        public string Customer_Notes { get; set; }
        public string Public_Number { get; set; }
        // Lời nhắc nhở cuối cùng
        public DateTime Last_reminder { get; set; }
        // Bước quá hạn
        public int Overdue_Step { get; set; }
        public int Optlock { get; set; }



    }
}
