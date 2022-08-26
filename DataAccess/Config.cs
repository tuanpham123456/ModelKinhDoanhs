using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class Config : BaseEntity
    {
        public long ID { get; set; }
        public string Key { get; set; }
        
        public string Value { get; set; }
    }
}
