using System;
using System.Collections.Generic;
using FluentValidation.Attributes;
using Presentation.Models.Validators;

namespace Presentation.Models
{
	[Validator(typeof(RiderDetailsModelValidator))]
    public class RiderDetailsModel
    {
	    public string OccupationType { get; set; }
	    public string Occupation { get; set; }
	    public string Industry { get; set; }
	    public string MotorcycleLicence { get; set; }
	    public DateTime DateObtained { get; set; }
	    public bool HasLicence { get; set; } = true;
	    public string RidersInsured { get; set; }
	    public List<AccidentModel> Accidents { get; set; }
	    public List<ConvictionModel> Convictions { get; set; }
	}
}
