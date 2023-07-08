using System;
using SiteAPI.Models;

namespace SiteAPI.Repositories.Contracts
{
	public interface IUserRepository
	{
		Task<List<User>> GetAllUsersAsync(int pageSize, int pageNumber);
		Task<User> GetUserAsync(string userId);
		Task CreateUserAsync(User user);
		Task UpdateUserAsync(User user, string id);
		Task DeleteUserAsync(string id);

    }
}

