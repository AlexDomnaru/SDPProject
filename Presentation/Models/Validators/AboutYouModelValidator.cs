using FluentValidation;

namespace Presentation.Models.Validators
{
    internal class AboutYouModelValidator : AbstractValidator<AboutYouModel>
    {
	    public AboutYouModelValidator()
	    {
		    RuleFor(vm => vm.Title).NotEmpty().WithMessage("Title cannot be empty");
		    RuleFor(vm => vm.FirstName).NotEmpty().WithMessage("Please enter your first name");
		    RuleFor(vm => vm.Surname).NotEmpty().WithMessage("Please enter your first name");
		    RuleFor(vm => vm.EmailAddress).NotEmpty().WithMessage("Please enter your email address").EmailAddress()
			    .WithMessage("Invalid email address");
		    RuleFor(vm => vm.PhoneNum).NotEmpty().WithMessage("Please enter your mobile phone number");
		    RuleFor(vm => vm.BirthDate).NotEmpty().WithMessage("Please enter your date of birth");
		    RuleFor(vm => vm.MaritalStatus).NotEmpty().WithMessage("Please enter your marital status");
		    RuleFor(vm => vm.PostCode).NotEmpty().WithMessage("Please enter your postcode and click the find button");
		    RuleFor(vm => vm.HouseNumberOrName).NotEmpty().WithMessage("Please enter a house number or name");
		    RuleFor(vm => vm.StreetName).NotEmpty().WithMessage("Please enter a street name");
		    RuleFor(vm => vm.City).NotEmpty().WithMessage("Please enter a city");
		    RuleFor(vm => vm.HomeOwner).NotEmpty().WithMessage("Home owner cannot be empty");
		    RuleFor(vm => vm.ResidentSince).NotEmpty().WithMessage("Please enter how long you have been resident in the UK");
		}
    }
}
