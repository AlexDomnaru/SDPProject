using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using Presentation.Models.Validators;

namespace Presentation.Models
{
    public class AboutYouModel
    {
		[Required]
	    public string Title { get; set; }

		[Required(ErrorMessage = "Please enter your first name")]
	    public string FirstName { get; set; }

		[Required(ErrorMessage = "Please enter your surname")]
	    public string Surname { get; set; }

		[Required(ErrorMessage = "Please enter your email address")]
		[EmailAddress(ErrorMessage = "Please enter a valid email address")]
	    public string EmailAddress { get; set; }

		[Required(ErrorMessage = "Please enter your mobile phone number")]
		[UkNumber]
	    public string PhoneNum { get; set; }

		[Required(ErrorMessage = "Please enter your date of birth")]
		[DataType(DataType.Date)]
	    public DateTime BirthDate { get; set; }

		[Required(ErrorMessage = "Please enter your marital status")]
	    public string MaritalStatus { get; set; }

		[Required(ErrorMessage = "Please enter your postcode and click the find button")]
	    public string PostCode { get; set; }

		[Required(ErrorMessage = "Please enter a house number or name")]
	    public string HouseNumberOrName { get; set; }

		[Required(ErrorMessage = "Please enter a street name")]
	    public string StreetName { get; set; }

	    public string Town { get; set; }

		[Required(ErrorMessage = "Please enter a city")]
	    public string City { get; set; }

		[Required(ErrorMessage = "Home owner cannot be empty")]
	    public bool HomeOwner { get; set; }

		[Required(ErrorMessage = "Please enter how long you have been resident in the UK")]
		[DataType(DataType.Date)]
	    public DateTime ResidentSince { get; set; }
	}
}
