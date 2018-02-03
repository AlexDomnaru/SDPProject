using AutoMapper;
using Data.Domain;
using Data.Domain.Entities;

namespace Presentation.Models.Mappings
{
    public class RiderDetailsProfile : Profile
    {
	    public RiderDetailsProfile()
	    {
		    CreateMap<RiderDetailsModel, RiderDetails>().ReverseMap();
	    }
    }
}
