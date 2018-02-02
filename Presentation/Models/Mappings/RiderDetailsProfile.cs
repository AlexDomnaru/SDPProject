using AutoMapper;
using Data.Domain;

namespace Presentation.Models.Mappings
{
    public class RiderDetailsProfile : Profile
    {
	    public RiderDetailsProfile()
	    {
		    CreateMap<RiderDetailsModel, RiderDetailsForm>().ReverseMap();
	    }
    }
}
