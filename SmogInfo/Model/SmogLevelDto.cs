﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmogInfo.Model
{
    public class SmogLevelDto
    {
        public int Id { get; set; }

        public DateTime DateTime { get; set; } 

        public decimal PM10Concentration { get; set; }

        public decimal PM25Concentration { get; set; }




    }
}
