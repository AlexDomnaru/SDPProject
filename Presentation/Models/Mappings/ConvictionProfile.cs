using AutoMapper;
using Data.Domain;

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
