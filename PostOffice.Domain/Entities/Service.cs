﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostOffice.Domain.Entities
{
    public class Service
    {
        public int Id { get; set; }
        public string ServiceName { get; set; }
        public virtual IEnumerable<ServiceAttribute> Attributes { get; set; }
    }
}
