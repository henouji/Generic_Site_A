using System;
using SiteAPI.Models;

namespace SiteAPI.ControllerModels
{
	public class UserRequest
	{
		public User ToUser()
		{
			return new User()
			{
				FirstName = FirstName,
				LastName = LastName,
				ContactNumber = ContactNumber
			};
		}
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string ContactNumber { get; set; }
	}
}

