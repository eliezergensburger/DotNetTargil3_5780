﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Host
    {
        public string HostName { get; set; }
        public List<HostingUnit> Units { get; set; }
    }
}
