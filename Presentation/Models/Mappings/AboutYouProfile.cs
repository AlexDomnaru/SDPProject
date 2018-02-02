using AutoMapper;
using Data.Domain;

namespace Presentation.Models.Mappings
{
	internal class AboutYouProfile : Profile
	{
		public AboutYouProfile()
		{
			CreateMap<AboutYouModel, AboutYouForm>().ReverseMap();
		}
	}
}
