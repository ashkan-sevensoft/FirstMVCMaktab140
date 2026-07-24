using FirstMVCMaktab140.Entity;

namespace FirstMVCMaktab140.Services
{
    public interface IUserService
    {
        bool EmailExists(string email);

        bool RegisterUser(string fullName , string Email , string password);

        
        User? ValidateUser(string email, string password);

        List<User> GetAllUsers();

        User GetById(Guid id);
    }
}
