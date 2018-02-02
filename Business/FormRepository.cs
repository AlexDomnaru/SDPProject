using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Data.Domain;
using Data.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Business
{
    public class FormRepository : IFormRepository
    {
	    private readonly IFormDbContext _formDbContext;

	    public FormRepository(IFormDbContext dbContext)
	    {
		    _formDbContext = dbContext;
	    }

		//About You area
	    public async Task<bool> AddAboutYouForm(AboutYouForm form)
	    {
		    form.Id = Guid.NewGuid();
		    _formDbContext.AboutYouForms.Add(form);
		    return (await _formDbContext.SaveChangesAsync() != 0);
	    }

	    public async Task<bool> DeleteAboutYouForm(AboutYouForm form)
	    {
		    _formDbContext.AboutYouForms.Remove(form);
			return await _formDbContext.SaveChangesAsync() > 0;
		}

	    public async Task<bool> EditAboutYouForm(AboutYouForm form)
	    {
		    _formDbContext.Entry(form).State = EntityState.Modified;
			return await _formDbContext.SaveChangesAsync() != 0;
	    }

	    public async Task<AboutYouForm> GetAboutYouFormById(Guid Id)
	    {
		    return await _formDbContext.AboutYouForms.SingleOrDefaultAsync(form => form.Id == Id);
	    }

	    public async Task<List<AboutYouForm>> GetAllAboutYouForms()
	    {
		    return await _formDbContext.AboutYouForms.ToListAsync();
	    }

	    public async Task<bool> AboutYouFormExists(Guid id)
	    {
		    return await _formDbContext.AboutYouForms.AnyAsync(e => e.Id == id);
		}

		//Rider Details area
	    public async Task<bool> AddRiderDetailsForm(RiderDetailsForm form)
	    {
		    _formDbContext.RiderDetailsForms.Add(form);
		    return (await _formDbContext.SaveChangesAsync() != 0);
	    }

	    public async Task<bool> DeleteRiderDetailForm(RiderDetailsForm form)
	    {
		    _formDbContext.RiderDetailsForms.Remove(form);
		    return await _formDbContext.SaveChangesAsync() > 0;
	    }

	    public async Task<bool> EditRiderDetailsForm(RiderDetailsForm form)
	    {
		    _formDbContext.Entry(form).State = EntityState.Modified;
		    return await _formDbContext.SaveChangesAsync() != 0;
	    }

	    public async Task<RiderDetailsForm> GetRiderDetailsFormById(Guid Id)
	    {
		    return await _formDbContext.RiderDetailsForms.SingleOrDefaultAsync(form => form.Id == Id);
	    }

	    public async Task<List<RiderDetailsForm>> GetAllRiderDetailsForms()
	    {
		    return await _formDbContext.RiderDetailsForms.ToListAsync();
	    }

	    public async Task<bool> RiderDetailsFormExists(Guid id)
	    {
		    return await _formDbContext.RiderDetailsForms.AnyAsync(e => e.Id == id);
	    }
	}
}
