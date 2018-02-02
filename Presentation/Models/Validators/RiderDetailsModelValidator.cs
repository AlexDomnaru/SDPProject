using FluentValidation;

namespace Presentation.Models.Validators
{
	internal class RiderDetailsModelValidator : AbstractValidator<RiderDetailsModel>
	{
		public RiderDetailsModelValidator()
		{
			RuleFor(vm => vm.OccupationType).NotEmpty()
				.WithMessage("Please choose the category that best describes your full time occupation.");
			RuleFor(vm => vm.Occupation).NotEmpty().WithMessage("Please enter a valid occupation");
			RuleFor(vm => vm.Industry).NotEmpty().WithMessage("Please enter a valid industry");
			RuleFor(vm => vm.MotorcycleLicence).NotEmpty().WithMessage("Please enter which motorcycle licence you have");
		}
	}
}