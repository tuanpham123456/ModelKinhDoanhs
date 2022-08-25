using KinhDoanh.Orthers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Configuration;
namespace KinhDoanh.Controllers
{
    public class VnPayController : Controller
    {
        public ActionResult Index()
        {
            return View("/vnpay");
        }
        
        public ActionResult Payment()
        {
            string url = ConfigurationManager.AppSettings["Url"];
            string returnUrl = ConfigurationManager.AppSettings["ReturnUrl"];
            string tmnCode = ConfigurationManager.AppSettings["TmnCode"];
            string hashSecret = ConfigurationManager.AppSettings["HashSecret"];

            PayLib pay = new PayLib();

            pay.AddRequestData("vnp_Version", "2.0.0"); //Phiên bản api mà merchant kết nối. Phiên bản hiện tại là 2.0.0
            pay.AddRequestData("vnp_Command", "pay"); //Mã API sử dụng, mã cho giao dịch thanh toán là 'pay'
            pay.AddRequestData("vnp_TmnCode", tmnCode); //Mã website của merchant trên hệ thống của VNPAY (khi đăng ký tài khoản sẽ có trong mail VNPAY gửi về)
            pay.AddRequestData("vnp_Amount", "1000000"); //số tiền cần thanh toán, công thức: số tiền * 100 - ví dụ 10.000 (mười nghìn đồng) --> 1000000
            pay.AddRequestData("vnp_BankCode", ""); //Mã Ngân hàng thanh toán (tham khảo: https://sandbox.vnpayment.vn/apis/danh-sach-ngan-hang/), có thể để trống, người dùng có thể chọn trên cổng thanh toán VNPAY
            pay.AddRequestData("vnp_CreateDate", DateTime.Now.ToString("yyyyMMddHHmmss")); //ngày thanh toán theo định dạng yyyyMMddHHmmss
            pay.AddRequestData("vnp_CurrCode", "VND"); //Đơn vị tiền tệ sử dụng thanh toán. Hiện tại chỉ hỗ trợ VND
            pay.AddRequestData("vnp_IpAddr", Util.GetIpAddress()); //Địa chỉ IP của khách hàng thực hiện giao dịch
            pay.AddRequestData("vnp_Locale", "vn"); //Ngôn ngữ giao diện hiển thị - Tiếng Việt (vn), Tiếng Anh (en)
            pay.AddRequestData("vnp_OrderInfo", "Thanh toan don hang"); //Thông tin mô tả nội dung thanh toán
            pay.AddRequestData("vnp_OrderType", "other"); //topup: Nạp tiền điện thoại - billpayment: Thanh toán hóa đơn - fashion: Thời trang - other: Thanh toán trực tuyến
            pay.AddRequestData("vnp_ReturnUrl", returnUrl); //URL thông báo kết quả giao dịch khi Khách hàng kết thúc thanh toán
            pay.AddRequestData("vnp_TxnRef", DateTime.Now.Ticks.ToString()); //mã hóa đơn

            string paymentUrl = pay.CreateRequestUrl(url, hashSecret);

            return Redirect(paymentUrl);
        }


        public ActionResult PaymentConfirm()
        {
            string url = ConfigurationManager.AppSettings["Url"];
            string hashSecret = ConfigurationManager.AppSettings["HashSecret"];
            string tmnCode = ConfigurationManager.AppSettings["TmnCode"];
            string orderInfo = Request.Form["vnp_OrderInfo"];
            string orderType = Request.Form["vnp_OrderType"];
            string amount = Request.Form["vnp_Amount"];
            string locale = Request.Form["vnp_Locale"];
            string bankCode = Request.Form["vnp_BankCode"];
            string transactionRef = Request.Form["vnp_TxnRef"];
            string message = Request.Form["vnp_Message"];
            string returnUrl = Request.Form["vnp_ReturnUrl"];
            string transactionTime = Request.Form["vnp_TransactionTime"];
            string transactionId = Request.Form["vnp_TransactionId"];
            string cardType = Request.Form["vnp_CardType"];
            string ipAddress = Request.Form["vnp_IpAddr"];
            string partnerCode = Request.Form["vnp_PartnerCode"];
            string clientIp = Request.Form["vnp_ClientIP"];
            string secureHash = Request.Form["vnp_SecureHash"];
            string secureHashType = Request.Form["vnp_SecureHashType"];
            string responseCode = Request.Form["vnp_ResponseCode"];
            string transInfo = Request.Form["vnp_TransInfo"];
            string description = Request.Form["vnp_Description"];
            string transactionStatus = Request.Form["vnp_TransactionStatus"];
            string bankTranNo = Request.Form["vnp_BankTranNo"];
            string bankTranDate = Request.Form["vnp_BankTranDate"];
            string orderId = Request.Form["vnp_OrderId"];
            string receiverEmail = Request.Form["vnp_ReceiverEmail"];
            string receiverMobile = Request.Form["vnp_ReceiverMobile"];
            string receiverName = Request.Form["vnp_ReceiverName"];



            PayLib pay = new PayLib();
            pay.AddRequestData("vnp_Version", "2.0.0");
            pay.AddRequestData("vnp_Command", "querydr");
            pay.AddRequestData("vnp_TmnCode", tmnCode);
            pay.AddRequestData("vnp_Amount", amount);
            pay.AddRequestData("vnp_Locale", locale);
            pay.AddRequestData("vnp_BankCode", bankCode);
            pay.AddRequestData("vnp_OrderInfo", orderInfo);
            pay.AddRequestData("vnp_OrderType", orderType);
            pay.AddRequestData("vnp_TransactionRef", transactionRef);
            pay.AddRequestData("vnp_TransInfo", transInfo);
            pay.AddRequestData("vnp_Description", description);
            pay.AddRequestData("vnp_TransactionStatus", transactionStatus);
            pay.AddRequestData("vnp_BankTranNo", bankTranNo);
            pay.AddRequestData("vnp_BankTranDate", bankTranDate);
            pay.AddRequestData("vnp_OrderId", orderId);
            pay.AddRequestData("vnp_ReceiverEmail", receiverEmail);
            pay.AddRequestData("vnp_ReceiverMobile", receiverMobile);
            pay.AddRequestData("vnp_ReceiverName", receiverName);
            pay.AddRequestData("vnp_IpAddr", Util.GetIpAddress());
            pay.AddRequestData("vnp_CreateDate", DateTime.Now.ToString("yyyyMMddHHmmss"));
            pay.AddRequestData("vnp_CurrCode", "VND");
            pay.AddRequestData("vnp_ClientIP", clientIp);
            pay.AddRequestData("vnp_SecureHashType", secureHashType);
            pay.AddRequestData("vnp_SecureHash", secureHash);
            pay.AddRequestData("vnp_ResponseCode", responseCode);
            pay.AddRequestData("vnp_TransactionId", transactionId);
            pay.AddRequestData("vnp_TransactionTime", transactionTime);
            pay.AddRequestData("vnp_CardType", cardType);
            pay.AddRequestData("vnp_PartnerCode", partnerCode);
            pay.AddRequestData("vnp_BankCode", bankCode);
            pay.AddRequestData("vnp_BankTranNo", bankTranNo);
            pay.AddRequestData("vnp_BankTranDate", bankTranDate);
            pay.AddRequestData("vnp_OrderId", orderId);
            pay.AddRequestData("vnp_ReceiverEmail", receiverEmail);
            pay.AddRequestData("vnp_ReceiverMobile", receiverMobile);
            pay.AddRequestData("vnp_ReceiverName", receiverName);
            pay.AddRequestData("vnp_IpAddr", Util.GetIpAddress());
            pay.AddRequestData("vnp_CreateDate", DateTime.Now.ToString("yyyyMMddHHmmss"));
            pay.AddRequestData("vnp_CurrCode", "VND");
            pay.AddRequestData("vnp_ClientIP", clientIp);
            pay.AddRequestData("vnp_SecureHashType", secureHashType);
            pay.AddRequestData("vnp_SecureHash", secureHash);
            pay.AddRequestData("vnp_ResponseCode", responseCode);
            pay.AddRequestData("vnp_TransactionId", transactionId);

            string paymentUrl = pay.CreateRequestUrl(url, hashSecret);
            return Redirect(paymentUrl);
            
        }

        //public ActionResult PaymentConfirm()
        //{
        //    if (Request.QueryString.Count > 0)
        //    {
        //        string hashSecret = ConfigurationManager.AppSettings["HashSecret"]; //Chuỗi bí mật
        //        var vnpayData = Request.QueryString;
        //        PayLib pay = new PayLib();

        //        //lấy toàn bộ dữ liệu được trả về
        //        foreach (string s in vnpayData)
        //        {
        //            if (!string.IsNullOrEmpty(s) && s.StartsWith("vnp_"))
        //            {
        //                pay.AddResponseData(s, vnpayData[s]);
        //            }
        //        }

        //        long orderId = Convert.ToInt64(pay.GetResponseData("vnp_TxnRef")); //mã hóa đơn
        //        long vnpayTranId = Convert.ToInt64(pay.GetResponseData("vnp_TransactionNo")); //mã giao dịch tại hệ thống VNPAY
        //        string vnp_ResponseCode = pay.GetResponseData("vnp_ResponseCode"); //response code: 00 - thành công, khác 00 - xem thêm https://sandbox.vnpayment.vn/apis/docs/bang-ma-loi/
        //        string vnp_SecureHash = Request.QueryString["vnp_SecureHash"]; //hash của dữ liệu trả về

        //        bool checkSignature = pay.ValidateSignature(vnp_SecureHash, hashSecret); //check chữ ký đúng hay không?

        //        if (checkSignature)
        //        {
        //            if (vnp_ResponseCode == "00")
        //            {
        //                //Thanh toán thành công
        //                ViewBag.Message = "Thanh toán thành công hóa đơn " + orderId + " | Mã giao dịch: " + vnpayTranId;
        //            }
        //            else
        //            {
        //                //Thanh toán không thành công. Mã lỗi: vnp_ResponseCode
        //                ViewBag.Message = "Có lỗi xảy ra trong quá trình xử lý hóa đơn " + orderId + " | Mã giao dịch: " + vnpayTranId + " | Mã lỗi: " + vnp_ResponseCode;
        //            }
        //        }
        //        else
        //        {
        //            ViewBag.Message = "Có lỗi xảy ra trong quá trình xử lý";
        //        }
        //    }

        //    return View();
        //}
    }
}
