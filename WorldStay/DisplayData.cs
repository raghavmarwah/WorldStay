using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldStay
{
    class DisplayData
    {
        public int SuiteId { get; set; }
        public String HotelName { get; set; }
        public String RoomType { get; set; }
        public String RoomNumber { get; set; }
        public int NumBedrooms { get; set; }
        public int NumBathrooms { get; set; }
        public int NightlyRate { get; set; }
        public String Country { get; set; }
        public String ThumbnailURL { get;set;}
        public bool IsAvailable { get; set; }
    }
}
