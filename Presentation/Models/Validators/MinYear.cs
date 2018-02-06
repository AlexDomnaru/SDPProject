using System;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace Presentation.Models.Validators
{
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter)]
	public class MinYear : ValidationAttribute, IClientModelValidator
	{
		private readonly int _minYear;

		public MinYear(int minYear)
		{
			_minYear = minYear;
		}

		public override bool IsValid(object value)
		{
			var date = (DateTime)value;
			var year = date.Year;
			var day = date.Day;
			var month = date.Month;
			var now = DateTime.Now;
			return year < _minYear && year > now.Year && month > now.Month && day > now.Day;
		}

		public void AddValidation(ClientModelValidationContext context)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}

			context.Attributes.Add("data-val-minyear", ErrorMessage);
		}
	}
}