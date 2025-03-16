namespace AmtOrk.Server.Models
{
	public class Kingdom : RootModel
	{
		public string KingdomName { get; set; } = string.Empty;
		public virtual List<Land> Lands { get; set; } = default!;
		public virtual AmtUser? Monarch { get; set; }
		public virtual AmtUser? Regent { get; set; }
		public virtual AmtUser? Champion { get; set; }
		public virtual AmtUser? PrimeMinister { get; set; }
		public virtual AmtUser? GMR { get; set; }
		public virtual List<Event>? KingdomEvents { get; set; }
	}
}