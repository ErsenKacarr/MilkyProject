using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkyProject.EntityLayer.Concrete
{
    public class Address
    {
        public int AddressId { get; set; }
        public string AddressDetail { get; set; }
        public string Phone { get; set; }
        public string EmailAddress { get; set; }
        public string WeekdayBusinessHours { get; set; }
        public string WeekendBusinessHours { get; set; }
    }
}
