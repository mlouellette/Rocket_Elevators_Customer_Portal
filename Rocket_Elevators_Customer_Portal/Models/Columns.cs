using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Diagnostics.CodeAnalysis;
using System.ComponentModel.DataAnnotations;


namespace Rocket_Elevators_Customer_Portal.Models
{
    public class Columns
    {
        [Key]
        public int id { get; set; }
        public string? status { get; set; }
        public int battery_id { get; set; }
        public string? column_type { get; set; }
    }
}
