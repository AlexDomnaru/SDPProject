using AutoMapper;
using Data.Domain;
using Data.Domain.Entities;

namespace Presentation.Models.Mappings
{
    public class ConvictionProfile : Profile
    {
	    public ConvictionProfile()
	    {
		    CreateMap<ConvictionModel, Conviction>().ReverseMap();
	    }
    }
}
