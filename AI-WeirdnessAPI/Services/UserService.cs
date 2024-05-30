using AI_WeirdnessAPI.Models;
using MongoDB.Driver;

namespace AI_WeirdnessAPI.Services
{
	public class UserService : IUserService
	{
		private readonly IMongoCollection<User> _users;

		public UserService(IAiWeirdnessDatabaseSettings settings, IMongoClient mongoClient) //Implement the settings (json) and mongoclient to retrieve the data.
		{
			var database = mongoClient.GetDatabase(settings.DatabaseName); //retrieve the database through the settings.
			_users = database.GetCollection<User>(settings.UserCollectionName); //retrieve the correct collection through the settings.
		}

		public List<User> GetUsers()
		{
			return _users.Find(user => true).ToList();
			
		}

		public User GetUserById(string id)
		{
			return _users.Find(user => user.Id == id).FirstOrDefault();
		}

		public User Create(User user)
		{
			_users.InsertOne(user);
			return user;
		}

		public void Update(string id, User user)
		{
			_users.ReplaceOne(student => student.Id == id, user);
		}

		public void Delete(string id)
		{
			_users.DeleteOne(student => student.Id == id);
		}
	}
}
