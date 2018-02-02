using System;

namespace Data.Domain
{
	public class Conviction
	{
		public Guid ConvictionId { get; set; }
		public DateTime ConvictionDate { get; set; }
		public string OffenceCode { get; set; }
		public int PointsReceived { get; set; }
		public int Fine { get; set; }
		public int BanDuration { get; set; }
	}
}