﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotelSystem.Model
{
    public class Guest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int PassportNumber { get; set; }

        public virtual ICollection<Booking> BookingRelation { get; set; }
    }
}