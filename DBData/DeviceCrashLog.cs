using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class DeviceCrashLog
    {
        public Guid Id { get; set; }
        public string? LogType { get; set; }
        public Guid? DriverId { get; set; }
        public DateTime TimeStamp { get; set; }
        public string? NetworkName { get; set; }
        public string? NetworkType { get; set; }
        public string? CrashName { get; set; }
        public string? AppVersion { get; set; }
        public string? AndroidVersion { get; set; }
        public string? DeviceType { get; set; }
        public string? DeviceSerialNumber { get; set; }
        public Guid? CompanyId { get; set; }

        public virtual Company? Company { get; set; }
        public virtual User? Driver { get; set; }
    }
}
