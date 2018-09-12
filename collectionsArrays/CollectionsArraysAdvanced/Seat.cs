using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsArraysAdvanced
{
    class Seat
    {
        public int SeatNumber { get; set; }
        public bool Availability { get; set; }

        public Seat(int _seat, bool _avail)
        {
            SeatNumber = _seat;
            Availability = _avail;
        }
    }
}
