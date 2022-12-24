using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Diagnostics.CodeAnalysis;
using System.ComponentModel.DataAnnotations;

namespace Rocket_Elevators_Customer_Portal.Models
{
    public class Interventions
    {

        [Key]
        public int? id { get; set; }
        public long? Author { get; set; }
        public long? CustomerID { get; set; }
        public long? BuildingID { get; set; }
        public long? BatteryID { get; set; }
        public long? ColumnID { get; set; }
        public long? ElevatorID { get; set; }
        public long? EmployeeID { get; set; }
        public string? Status { get; set; }
        public DateTime? Start { get; set; }
        public DateTime? End { get; set; }

        public DateTime? created_at { get; set; }
        public DateTime? updated_at { get; set; }

    }
}
