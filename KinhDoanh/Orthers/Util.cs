﻿//using Microsoft.AspNetCore.Http;
using System.Net.Sockets;
using System.Net;
using System;
using System.Security.Cryptography;
using System.Text;
using System.Web;
namespace KinhDoanh.Orthers
{
    public class Util
    {
        public static string Md5(string sInput)
        {
            HashAlgorithm algorithmType = default(HashAlgorithm);
            ASCIIEncoding enCoder = new ASCIIEncoding();
            byte[] valueByteArr = enCoder.GetBytes(sInput);
            byte[] hashArray = null;
            // Encrypt Input string 
            algorithmType = new MD5CryptoServiceProvider();
            hashArray = algorithmType.ComputeHash(valueByteArr);
            //Convert byte hash to HEX
            StringBuilder sb = new StringBuilder();
            foreach (byte b in hashArray)
            {
                sb.AppendFormat("{0:x2}", b);
            }
            return sb.ToString();
        }

        public static string Sha256(string data)
        {
            using (var sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array  
                var bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(data));

                // Convert byte array to a string   
                var builder = new StringBuilder();
                foreach (var t in bytes)
                {
                    builder.Append(t.ToString("x2"));
                }
                return builder.ToString();
            }
        }

        //public static string GetIpAddress()
        //{
        //    var host = Dns.GetHostEntry(Dns.GetHostName());
        //    foreach (var ip in host.AddressList)
        //    {
        //        if (ip.AddressFamily == AddressFamily.InterNetwork)
        //        {
        //            return ip.ToString();
        //        }
        //    }
        //    throw new Exception("No network adapters with an IPv4 address in the system!");
        //}
        public static string GetIpAddress()
        {
            string ipAddress = "";
            //try
            //{
            //    ipAddress = HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"];

            //    if (string.IsNullOrEmpty(ipAddress) || (ipAddress.ToLower() == "unknown"))
            //        ipAddress = HttpContext.Current.Request.ServerVariables["REMOTE_ADDR"];
            //}
            //catch (Exception ex)
            //{
            //    ipAddress = "Invalid IP:" + ex.Message;
            //}

            return ipAddress;
        }
    }
}
