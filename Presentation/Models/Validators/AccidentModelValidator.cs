using FluentValidation;

namespace Presentation.Models.Validators
{
	internal class AccidentModelValidator : AbstractValidator<AccidentModel>
	{
		public AccidentModelValidator()
		{
			RuleFor(vm => vm.IncidentDate).NotEmpty().WithMessage("Please select the date of this incident");
			RuleFor(vm => vm.Cause).NotEmpty().WithMessage("Please enter a cause or description for your claim");
			RuleFor(vm => vm.OccuredOnMIP).NotEmpty()
				.WithMessage("Please enter if this claim occurred on a motorcycle insurance policy");
		}
	}
}