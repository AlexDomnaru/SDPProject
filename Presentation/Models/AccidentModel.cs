﻿using System;

namespace Presentation.Models
{ 
	public class AccidentModel
	{
		public DateTime IncidentDate { get; set; }
		public string Cause { get; set; }
		public bool LiableForClaim { get; set; } = false;
		public bool Injured { get; set; } = false;
		public bool OccuredOnMIP { get; set; }
	}
}