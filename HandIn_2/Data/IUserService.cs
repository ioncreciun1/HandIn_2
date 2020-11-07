using System.Threading.Tasks;
using HandIn_2.Models;

namespace HandIn_2.Data
{
    public interface IUserService
    {
        Task<User> ValidateUser(string userName, string Password);
    }
}