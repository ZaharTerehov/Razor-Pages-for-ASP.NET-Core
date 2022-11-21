using System.ComponentModel.DataAnnotations;

namespace RazorPagesApp.Model
{
	public class Category
	{
		[Key]
		public Guid Id { get; set; }

		[Required(ErrorMessage = "Enter your name!")]
		[StringLength(30, MinimumLength = 3, ErrorMessage = "It is very short name!")]
		public string Name { get; set; }

		public int DisplayOrder { get; set; }
	}
}
