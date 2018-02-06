using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Presentation.Models
{
    public class RiderDetailsModel
    {
		[Required(ErrorMessage = "Please choose the category that best describes your full time occupation.")]
		[MinLength(1, ErrorMessage = "Please choose the category that best describes your full time occupation.")]
		public string OccupationType { get; set; }

		[Required(ErrorMessage = "Please enter a valid occupation")]
		[MinLength(1, ErrorMessage = "Please enter a valid occupation")]
	    public string Occupation { get; set; }

		[Required(ErrorMessage = "Please enter a valid industry")]
		[MinLength(1, ErrorMessage = "Please enter a valid industry")]
	    public string Industry { get; set; }

		[Required(ErrorMessage = "Please enter which motorcycle licence you have")]
	    public string MotorcycleLicence { get; set; }

		[Required(ErrorMessage = "Please select the date your licence was obtained.")]
		[DataType(DataType.Date)]
		[DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM-yyyy}")]
		public DateTime DateObtained { get; set; }

	    public bool HasLicence { get; set; } = true;

		[Required(ErrorMessage = "Riders insured field cannot be empty")]
	    public string RidersInsured { get; set; }

	    public List<AccidentModel> Accidents { get; set; }
	    public List<ConvictionModel> Convictions { get; set; }
	}
}
