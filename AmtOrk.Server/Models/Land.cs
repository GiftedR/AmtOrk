using System.ComponentModel.DataAnnotations.Schema;

namespace AmtOrk.Server.Models
{
	public class Land : RootModel
	{
		public string LandName { get; set; } = string.Empty;
		public string LandDescription { get; set; } = string.Empty;
		public string LandLocation { get; set; } = string.Empty;
		[ForeignKey("Kingdom")]
		public int KingdomId { get; set; }
		
		public virtual AmtUser? Monarch { get; set; }
		public virtual AmtUser? Regent { get; set; }
		public virtual AmtUser? Champion { get; set; }
		public virtual AmtUser? PrimeMinister { get; set; }
		public virtual AmtUser? GMR { get; set; }

		public virtual List<Event>? LandEvents { get; set; }
	}
}