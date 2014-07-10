using System;
using System.ComponentModel.DataAnnotations;

namespace MyBlog.Models
{
	public class PostModel
	{
		[Key]
		public int PostId { get; set; }
		public string Name { get; set; }
		public DateTime Date { get; set; }
		public string Text { get; set; }
	}
}