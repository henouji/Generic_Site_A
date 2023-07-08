using System;
using SiteAPI.ControllerModels;
using SiteAPI.Models;
using SiteAPI.Repositories.Contracts;
using SiteAPI.Services.Contracts;

namespace SiteAPI.Services
{
	public class UserService : IUserService
	{
		private readonly IUserRepository _user;
		public UserService(IUserRepository user)
		{
			_user = user;
		}

		public async Task<List<User>> GetAllUserAsync(int pageSize = 10, int pageNumber = 1)
		{
			return await _user.GetAllUsersAsync(pageSize, pageNumber);
		}

		public async Task<User> GetUserAsync(string userId)
		{
			return await _user.GetUserAsync(userId);
		}

		public async Task CreateUserAsync(UserRequest user)
		{
			await _user.CreateUserAsync(user.ToUser());
		}

        async Task IUserService.UpdateUserAsync(UserRequest user, string id)
        {
			await _user.UpdateUserAsync(user.ToUser(), id);
        }

        async Task IUserService.DeleteUserAsync(string id)
        {
			await _user.DeleteUserAsync(id);
        }
    }
}

