﻿using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class SubcontractorStaff
    {
        public Guid Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? Telephone { get; set; }
        public Guid SubcontractorId { get; set; }
        public string? Address { get; set; }
        public string Username { get; set; } = null!;
    }
}
