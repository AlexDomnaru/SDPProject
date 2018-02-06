using System;
using Presentation.Models.Validators;

namespace Presentation.Models
{
	public class ConvictionModel
	{
		public DateTime ConvictionDate { get; set; }
		public string OffenceCode { get; set; }
		public int PointsReceived { get; set; }
		public int Fine { get; set; }
		public int BanDuration { get; set; }
	}
}