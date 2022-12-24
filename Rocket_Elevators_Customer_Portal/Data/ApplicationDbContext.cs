using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Rocket_Elevators_Customer_Portal.Controllers;
using Rocket_Elevators_Customer_Portal.Models;

namespace Rocket_Elevators_Customer_Portal.Data
{
	public class ApplicationDbContext : IdentityDbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
			: base(options)
		{


		}
        
    }
}