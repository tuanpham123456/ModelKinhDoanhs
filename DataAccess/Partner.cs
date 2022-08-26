﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class Partner : BaseEntity
    {
        public int ID { get; set; }
        public int user_id { get; set; }
        public double balance { get; set; }
        public double total_payment { get; set; }
        public double total_refunds { get; set; }
        public double total_payouts { get; set; }
        public DateTime next_payout_date { get; set; }
        public string FacebookId { get; set; }
        public string FacebookAvatarUrl { get; set; }
        public bool IsActived { get; set; }
        public DateTime last_login { get; set; }
        public int status_id { get; set; }

        public int optlock { get; set; }


    }
}