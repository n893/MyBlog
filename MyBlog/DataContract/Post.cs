﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyBlog.DataContract
{
	[Table("Post")]
	public class Post
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int PostId { get; set; }
		public string Name { get; set; }
		public DateTime Date { get; set; }
		public string Text { get; set; }
	}
}