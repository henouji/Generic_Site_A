using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace SiteAPI.Models
{
	public class Post
	{
		public int Id { get; set; }
		public string Title { get; set; }
		public string Content { get; set; }
		public DateTime CreationDate { get; set; }

		[ForeignKey("User_FK")]
		public User User { get; set; }
	}
}

