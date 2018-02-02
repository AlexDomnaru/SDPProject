using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Data.Domain;

namespace Business
{
	public interface IFormRepository
	{
		Task<bool> AddAboutYouForm(AboutYouForm form);
		Task<bool> DeleteAboutYouForm(AboutYouForm form);
		Task<bool> EditAboutYouForm(AboutYouForm form);
		Task<AboutYouForm> GetAboutYouFormById(Guid Id);
		Task<List<AboutYouForm>> GetAllAboutYouForms();
		Task<bool> AboutYouFormExists(Guid id);
		Task<bool> AddRiderDetailsForm(RiderDetailsForm form);
		Task<bool> DeleteRiderDetailForm(RiderDetailsForm form);
		Task<bool> EditRiderDetailsForm(RiderDetailsForm form);
		Task<RiderDetailsForm> GetRiderDetailsFormById(Guid Id);
		Task<List<RiderDetailsForm>> GetAllRiderDetailsForms();
		Task<bool> RiderDetailsFormExists(Guid id);
	}
}