using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Data.Persistence
{
	public interface IFormDbContext
	{
		DbSet<Data.Domain.AboutYouForm> AboutYouForms { get; set; }
		DbSet<Data.Domain.RiderDetailsForm> RiderDetailsForms { get; set; }
		Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken));
		EntityEntry Entry(object entity);
	}
}
