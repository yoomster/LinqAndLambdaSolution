﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqUI.Models
{
    public class AddressModel
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public int HouseNr { get; set; }
        public string City { get; set; }

    }
}
