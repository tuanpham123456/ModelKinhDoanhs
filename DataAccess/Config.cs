using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class Config : BaseEntity
    {
        public int ID { get; set; }
        public string key { get; set; }
        public string value { get; set; }
    }
}
