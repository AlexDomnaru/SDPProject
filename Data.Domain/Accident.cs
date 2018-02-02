using System;

namespace Data.Domain
{
	public class Accident
	{
		public Guid AccidentId { get; set; }
		public DateTime IncidentDate { get; set; }
		public string Cause { get; set; }
		public bool LiableForClaim { get; set; } = false;
		public bool Injured { get; set; } = false;
		public bool OccuredOnMIP { get; set; }
	}
}