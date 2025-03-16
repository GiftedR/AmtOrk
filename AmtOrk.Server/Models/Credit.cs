using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AmtOrk.Server.Models
{
	public class Credit : RootModel
	{
		public DateOnly CreditDate { get; set; }

		[ForeignKey("CreditKingdom")]
		public virtual int CreditKingdomId { get; set; }

		[ForeignKey("CreditPark")]
		public virtual int CreditParkId { get; set; }

		[ForeignKey("CreditEvent")]
		public virtual int CreditEventId { get; set; }

		[ForeignKey("CreditClass")]
		public virtual int CreditClassId { get; set; }

		public int CreditCount { get; set; } = 1; // Credits default to 1, they have to be changed manually normally
	}
}