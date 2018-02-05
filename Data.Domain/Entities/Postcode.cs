using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Domain.Entities
{
    public class Postcode
    {
	    public string Code { get; set; }
		public List<Address> Addresses { get; set; }
	    public string City { get; set; }
	}
}
