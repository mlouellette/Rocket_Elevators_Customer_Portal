using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Diagnostics.CodeAnalysis;
using System.ComponentModel.DataAnnotations;


namespace Rocket_Elevators_Customer_Portal.Models
{
    public class Customers
    {


        [Key]
        public int CustomerID { get; set; }
        public string? EmailCompanyContact { get; set; }



    }
}
