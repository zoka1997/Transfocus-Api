using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class BookingPrintOption
    {
        public BookingPrintOption()
        {
            Companies = new HashSet<Company>();
        }

        public Guid Id { get; set; }
        public bool UserCnote { get; set; }
        public bool UserLabel { get; set; }
        public bool UserPod { get; set; }
        public bool CustomerCnote { get; set; }
        public bool CustomerLabel { get; set; }
        public bool EmailUserCnote { get; set; }
        public bool EmailUserLabel { get; set; }
        public bool EmailUserPod { get; set; }
        public bool EmailCustomerCnote { get; set; }
        public bool EmailCustomerLabel { get; set; }
        public bool PrintManifest { get; set; }
        public bool EmailManifest { get; set; }

        public virtual ICollection<Company> Companies { get; set; }
    }
}
