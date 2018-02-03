using AutoMapper;
using Data.Domain;
using Data.Domain.Entities;

namespace Presentation.Models.Mappings
{
	internal class AboutYouProfile : Profile
	{
		public AboutYouProfile()
		{
			CreateMap<AboutYouModel, AboutYou>().ReverseMap();
		}
	}
}
