using System.Threading;
using System.Threading.Tasks;
using Data.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Data.Persistence
{
	public interface IFormDbContext
	{
		DbSet<AboutYou> AboutYouForms { get; set; }
		DbSet<RiderDetails> RiderDetailsForms { get; set; }
		Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken));
		EntityEntry Entry(object entity);
	}
}