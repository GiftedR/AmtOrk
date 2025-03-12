using System.ComponentModel.DataAnnotations;

namespace AmtOrk.Server.Models
{
	public class Credit : RootModel
	{
		public DateOnly CreditDate { get; set; }
	}
}