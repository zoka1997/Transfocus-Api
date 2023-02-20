using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class BookingTemplate
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string ViewName { get; set; } = null!;
    }
}
