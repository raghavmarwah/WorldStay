using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldStay
{
    class ActiveBooking
    {
        public int BookingId { get; set; }
        public int UserId { get; set; }
        public int SuiteId { get; set; }
        public DateTime CheckInDate { get; set; }
        public int StayDuration { get; set; }
    }
}
