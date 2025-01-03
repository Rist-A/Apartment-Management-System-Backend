using HouseRental.Modules;

namespace HouseRental.Interfaces
{
    public interface IUserRepository
    {
        // Retrieve all users
        IEnumerable<User> GetAllUsers();

        // Add a new user
        void AddUser(User user);

        // Delete a user by ID
        void DeleteUser(int userId);
        User AuthenticateUser(string username, string password);
    }
}
