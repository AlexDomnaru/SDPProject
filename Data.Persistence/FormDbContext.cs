using System.Threading;
using System.Threading.Tasks;
using Data.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Data.Persistence
{
	public class FormDbContext : DbContext, IFormDbContext
	{
		public FormDbContext(DbContextOptions<FormDbContext> options): base((DbContextOptions) options)
	    {
		    
	    }

	    public DbSet<Data.Domain.Entities.AboutYou> AboutYouForms { get; set; }
		public DbSet<Data.Domain.Entities.RiderDetails> RiderDetailsForms { get; set; }
	}
}
