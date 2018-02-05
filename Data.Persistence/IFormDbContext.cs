using System.Threading;
using System.Threading.Tasks;
using Data.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Data.Persistence
{
	public interface IFormDbContext
	{
		DbSet<Data.Domain.Entities.AboutYou> AboutYouForms { get; set; }
		DbSet<Data.Domain.Entities.RiderDetails> RiderDetailsForms { get; set; }
		Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken));
		EntityEntry Entry(object entity);
	}
}