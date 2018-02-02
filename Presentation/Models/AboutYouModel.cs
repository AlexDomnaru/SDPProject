using System;
using FluentValidation.Attributes;
using Presentation.Models.Validators;

namespace Presentation.Models
{
	[Validator(typeof(AboutYouModelValidator))]
    public class AboutYouModel
    {
	    public string Title { get; set; }
	    public string FirstName { get; set; }
	    public string Surname { get; set; }
	    public string EmailAddress { get; set; }
	    public string PhoneNum { get; set; }
	    public DateTime BirthDate { get; set; }
	    public string MaritalStatus { get; set; }
	    public string PostCode { get; set; }
	    public string HouseNumberOrName { get; set; }
	    public string StreetName { get; set; }
	    public string Town { get; set; }
	    public string City { get; set; }
	    public bool HomeOwner { get; set; }
	    public string ResidentSince { get; set; }
	}
}
