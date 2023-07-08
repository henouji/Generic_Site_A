using System;
using SiteAPI.ControllerModels;
using SiteAPI.Models;

namespace SiteAPI.Services.Contracts
{
	public interface IUserService
	{
		Task<List<User>> GetAllUserAsync(int pageSize, int pageNumber);
		Task<User> GetUserAsync(string userId);
		Task CreateUserAsync(UserRequest user);
		Task UpdateUserAsync(UserRequest user, string id);
		Task DeleteUserAsync(string id);
	}
}

