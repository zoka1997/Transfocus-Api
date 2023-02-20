using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class OpeningHour
    {
        public Guid Id { get; set; }
        public Guid? LocationId { get; set; }
        public int? Day { get; set; }
        public string? OpenTime { get; set; }
        public string? CloseTime { get; set; }

        public virtual Location? Location { get; set; }
    }
}
