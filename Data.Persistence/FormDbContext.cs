using Microsoft.EntityFrameworkCore;

namespace Data.Persistence
{

	public class FormDbContext : DbContext, IFormDbContext
	{
		public FormDbContext(DbContextOptions<FormDbContext> options): base((DbContextOptions) options)
	    {
		    
	    }

	    public DbSet<Data.Domain.AboutYouForm> AboutYouForms { get; set; }
		public DbSet<Data.Domain.RiderDetailsForm> RiderDetailsForms { get; set; }
    }
}
