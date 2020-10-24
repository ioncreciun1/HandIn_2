using HandIn_2.Models;

namespace HandIn_2.Data
{
    public interface IUserService
    {
        User ValidateUser(string userName, string Password);
    }
}