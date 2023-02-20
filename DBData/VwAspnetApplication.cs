﻿using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class VwAspnetApplication
    {
        public string ApplicationName { get; set; } = null!;
        public string LoweredApplicationName { get; set; } = null!;
        public Guid ApplicationId { get; set; }
        public string? Description { get; set; }
    }
}
