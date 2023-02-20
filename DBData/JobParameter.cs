﻿using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class JobParameter
    {
        public long JobId { get; set; }
        public string Name { get; set; } = null!;
        public string? Value { get; set; }

        public virtual Job1 Job { get; set; } = null!;
    }
}
