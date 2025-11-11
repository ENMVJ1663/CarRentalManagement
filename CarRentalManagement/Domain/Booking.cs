using System.ComponentModel.DataAnnotations.Schema;

namespace CarRentalManagement.Domain
{
    public class Booking : BaseDomainModel
    {
        public DateTime DateOut { get; set; }
        public DateTime DateIn { get; set; }
        [ForeignKey("Vehicle")] public int VehicleId { get; set; }
        [ForeignKey("Customer")] public int CustomerId { get; set; }
        
    }
}
