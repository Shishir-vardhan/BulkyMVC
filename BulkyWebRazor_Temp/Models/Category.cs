using System.ComponentModel.DataAnnotations;

namespace BulkyWebRazor_Temp.Models
{
	public class Category
	{
		public int Id { get; set; }
		[Required]
		[StringLength(30)]
		public string Name { get; set; }

		[Range(0, 1000)]
		public int DisplayOrder { get; set; }
	}
}
