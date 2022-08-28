using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobDomain.Entities.Company
{
    internal class Address : Base
    {
        public string Road { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int CompanyId { get; set; }
    }
}
