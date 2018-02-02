using System;
using System.Collections.Generic;

namespace Data.Domain
{
    public class RiderDetailsForm
    {
		public Guid Id { get; set; }
	    public string OccupationType { get; set; }
	    public string Occupation { get; set; }
	    public string Industry { get; set; }
	    public string MotorcycleLicence { get; set; }
	    public DateTime DateObtained { get; set; }
	    public bool HasLicence { get; set; } = true;
	    public string RidersInsured { get; set; }
	    public List<Accident> Accidents { get; set; }
	    public List<Conviction> Convictions { get; set; }
	}
}
