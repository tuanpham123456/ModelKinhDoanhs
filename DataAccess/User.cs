using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class User : BaseEntity
    {
        public long ID { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        
        public char Password { get; set; }
        public int status_id { get; set; }
        public int currency_id { get; set; }
        public DateTime last_login { get; set; }              
        public string FullName { get; set; }

        public string Email { get; set; }

        public string Address { get; set; }

        public string PhoneNumber { get; set; }
        public bool IsActived { get; set; }


    }
}
