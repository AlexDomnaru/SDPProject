using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Interfaces;
using Data.Domain.Entities;
using Data.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Business.Repositories
{
    public class AboutYouRepository: IAboutYouRepository<AboutYou>
    {
	    private readonly IFormDbContext _context;

	    public AboutYouRepository(IFormDbContext context)
	    {
		    _context = context;
	    }

	    public async Task<IEnumerable<AboutYou>> GetAll()
	    {
			return await _context.AboutYouForms.ToListAsync();
		}

	    public async Task<AboutYou> GetById(Guid id)
	    {
			return await _context.AboutYouForms.SingleOrDefaultAsync(form => form.Id == id);
		}

	    public async Task<bool> Create(AboutYou entity)
	    {
			entity.Id = Guid.NewGuid();
		    _context.AboutYouForms.Add(entity);
		    return (await _context.SaveChangesAsync() != 0);
		}

	    public async Task<bool> Update(AboutYou entity)
	    {
			_context.Entry(entity).State = EntityState.Modified;
		    return await _context.SaveChangesAsync() != 0;
		}

	    public async Task<bool> Delete(AboutYou entity)
	    {
			_context.AboutYouForms.Remove(entity);
		    return await _context.SaveChangesAsync() > 0;
		}

	    public async Task<bool> Exists(Guid id)
	    {
			return await _context.AboutYouForms.AnyAsync(e => e.Id == id);
		}
    }
}
