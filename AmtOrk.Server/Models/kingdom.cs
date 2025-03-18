using System.ComponentModel.DataAnnotations.Schema;
using System.Text.RegularExpressions;

namespace AmtOrk.Server.Models
{
	public class Kingdom : RootModel
	{
		public string KingdomName { get; set; } = default!;
		public string? KingdomDesciption { get; set;}
		public string? KingdomIconPath { get; set; }
		public virtual List<Land> Lands { get; set; } = default!;
		public virtual AmtUser? Monarch { get; set; }
		public virtual AmtUser? Regent { get; set; }
		public virtual AmtUser? Champion { get; set; }
		public virtual AmtUser? PrimeMinister { get; set; }
		public virtual AmtUser? GMR { get; set; }
		public virtual List<Event>? KingdomEvents { get; set; }
		[NotMapped]
		public virtual string KingdomSlug { get => Regex.Replace(KingdomName.ToLower(), @"\s", "-");}
	}
}