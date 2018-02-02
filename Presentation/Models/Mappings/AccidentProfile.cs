using AutoMapper;
using Data.Domain;

namespace Presentation.Models.Mappings
{
    public class AccidentProfile : Profile
    {
	    public AccidentProfile()
	    {
		    CreateMap<AccidentModel, Accident>().ReverseMap();
	    }
    }
}
