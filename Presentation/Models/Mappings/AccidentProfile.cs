using AutoMapper;
using Data.Domain;
using Data.Domain.Entities;

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
