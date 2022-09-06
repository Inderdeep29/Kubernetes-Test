using System;
using System.Collections.Generic;

namespace Common.Models
{
    public partial class ExportLicenseReservation
    {
        public string Id { get; set; } = null!;
        public DateTime? ExportDate { get; set; }
        public string? LicenseId { get; set; }
        public string? LineId { get; set; }
        public string? ReservationStatus { get; set; }
        public int ReservedQuantity { get; set; }
        public double ReservedValue { get; set; }
        public string? TransactionId { get; set; }
    }
}
