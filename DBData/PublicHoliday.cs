using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class PublicHoliday
    {
        public Guid Id { get; set; }
        public int CountryId { get; set; }
        public Guid? CompanyId { get; set; }
        public DateTime HolidayDate { get; set; }
        public string? States { get; set; }
        public string Name { get; set; } = null!;

        public virtual Company? Company { get; set; }
        public virtual Country Country { get; set; } = null!;
    }
}
