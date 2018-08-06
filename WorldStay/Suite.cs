using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldStay
{
    class Suite
    {
        public String RoomNumber { get; set; }
        public String Floor { get; set; }
        public String RoomType { get; set; }
        public int NumberOfBedrooms { get; set; }
        public int NumberOfBathrooms { get; set; }
        public float NightlyRate { get; set; }
        public bool IsAvailable { get; set; }
        public String Description { get; set; }
        public String ThumbnailURL { get; set; }
        public int HotelId { get; set; }

        public Suite() { }
    }

}
