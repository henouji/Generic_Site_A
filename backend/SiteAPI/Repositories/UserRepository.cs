using System.Collections.Generic;
using System.Threading.Tasks;
using MongoDB.Driver;
using SiteAPI.Models;
using SiteAPI.Repositories.Contracts;

namespace SiteAPI.Repositories
{
	public class UserRepository : IUserRepository
	{
		private readonly IMongoCollection<User> _userCollection;
		public UserRepository(IMongoDatabase mongoDb)
		{
			_userCollection = mongoDb.GetCollection<User>("Users");
		}

        public async Task<List<User>> GetAllUsersAsync(int pageSize, int pageNumber)
        {
            int skipCount = pageSize * (pageNumber - 1);
            return await _userCollection.Find(_ => true)
                .Skip(skipCount)
                .Limit(pageSize)
                .ToListAsync();
        }

        public async Task<User> GetUserAsync(string userId)
        {
            return await _userCollection.Find(u => u.Id == userId).FirstOrDefaultAsync();
        }

        public async Task CreateUserAsync(User user)
        {
            await _userCollection.InsertOneAsync(user);
        }

        public async Task UpdateUserAsync(User user, string id)
        {
            user.Id = id;
            await _userCollection.ReplaceOneAsync(x => x.Id == id, user);
        }

        public async Task DeleteUserAsync(string id)
        {
            await _userCollection.DeleteOneAsync(x => x.Id == id);
        }

    }
}

