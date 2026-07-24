using FirstMVCMaktab140.Entity;

namespace FirstMVCMaktab140.Services
{
    public class UserService : IUserService
    {

        private readonly List<User> _users = new List<User>();
       
        public bool EmailExists(string email)
        {
         
            return _users.Any(u => u.Email == email);   
        }

        public bool RegisterUser(string fullName, string Email, string password)
        {
            try
            {


                var user = new User();
                user.Id = Guid.NewGuid();
                user.FullName = fullName;
                user.Email = Email;
                user.Password = password;
                _users.Add(user);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public User? ValidateUser(string email, string password)
        {
            return _users.FirstOrDefault(u => u.Email == email && u.Password == password);
        }

        public List<User> GetAllUsers()
        {
            if(_users.Count == 0)
            {
                SeedUser();
            }   
            return _users;
        }

        public User GetById(Guid id)
        {
            if (_users.Count == 0)
            {
                SeedUser();
            }
            return _users.FirstOrDefault();  
        }

        private void SeedUser()
        {
            var admin = new User();
            admin.Id = Guid.NewGuid();
            admin.Email = "Admin@gmail.com";
            admin.FullName = "Admin";
            admin.Password = "Admin";

            _users.Add(admin);
            
        }
    }
}
