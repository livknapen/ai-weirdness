using AI_WeirdnessAPI.Models;

namespace AI_WeirdnessAPI.Services
{
	public interface IUserService
	{
		public List<User> GetUsers();
		public User GetUserById(string id);
		public User Create(User user);
		public void Update(string id, User user);
		public void Delete(string id);

	}
}
