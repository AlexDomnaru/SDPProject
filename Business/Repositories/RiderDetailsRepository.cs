using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Business.Interfaces;
using Data.Domain.Entities;
using Data.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Business.Repositories
{
    public class RiderDetailsRepository: IRiderDetailsRepository<RiderDetails>
	{
		private readonly IFormDbContext _context;

		public RiderDetailsRepository(IFormDbContext context)
		{
			_context = context;
		}

		public async Task<IEnumerable<RiderDetails>> GetAll()
		{
			return await _context.RiderDetailsForms.ToListAsync();
		}

		public async Task<RiderDetails> GetById(Guid id)
		{
			return await _context.RiderDetailsForms.SingleOrDefaultAsync(form => form.Id == id);
		}

		public async Task<bool> Create(RiderDetails entity)
		{
			entity.Id = Guid.NewGuid();
			_context.RiderDetailsForms.Add(entity);
			return (await _context.SaveChangesAsync() != 0);
		}

		public async Task<bool> Update(RiderDetails entity)
		{
			_context.Entry(entity).State = EntityState.Modified;
			return await _context.SaveChangesAsync() != 0;
		}

		public async Task<bool> Delete(RiderDetails entity)
		{
			_context.RiderDetailsForms.Remove(entity);
			return await _context.SaveChangesAsync() > 0;
		}

		public async Task<bool> Exists(Guid id)
		{
			return await _context.RiderDetailsForms.AnyAsync(e => e.Id == id);
		}
	}
}
