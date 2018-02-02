using FluentValidation;

namespace Presentation.Models.Validators
{
	internal class ConvictionModelValidator : AbstractValidator<ConvictionModel>
	{
		public ConvictionModelValidator()
		{
			RuleFor(vm => vm.ConvictionDate).NotEmpty().WithMessage("Please select the date of this conviction");
			RuleFor(vm => vm.OffenceCode).NotEmpty().WithMessage("Please select offence code");
			RuleFor(vm => vm.PointsReceived).NotEmpty().WithMessage("Please select the number of points");
			RuleFor(vm => vm.Fine).NotEmpty().WithMessage("Please select amount of fine");
		}
	}
}