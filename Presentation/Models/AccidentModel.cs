using System;
using FluentValidation.Attributes;
using Presentation.Models.Validators;

namespace Presentation.Models
{
	[Validator(typeof(AccidentModelValidator))]
	public class AccidentModel
	{
		public DateTime IncidentDate { get; set; }
		public string Cause { get; set; }
		public bool LiableForClaim { get; set; } = false;
		public bool Injured { get; set; } = false;
		public bool OccuredOnMIP { get; set; }
	}
}