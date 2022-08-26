using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class Member : BaseEntity
    {
        public long ID { get; set; }
     
        public string FullName { get; set; }

        public string Email { get; set; }

        public string Address { get; set; }

        public string PhoneNumber { get; set; }

        public string FacebookId { get; set; }

        public string FacebookAvatarUrl { get; set; }
        
        public bool IsActived { get; set; }

        public virtual List<Payment> Payment { get; set; }

    }
}
