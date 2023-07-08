using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace SiteAPI.Models
{
	public class User
	{
		[BsonId]
		[BsonRepresentation(BsonType.ObjectId)]
		public string? Id { get; set; }
		public string FirstName { get; set; } = null!;
		public string LastName { get; set; } = null!;
		public string ContactNumber { get; set; } = null!;
    }
}

