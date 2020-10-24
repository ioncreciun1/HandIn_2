using System.Collections.Generic;
using System.Threading.Tasks;
using HandIn_2.Models;

namespace HandIn_2.Data
{
    public interface IAdultService
    {
        Task AddAdultAsync(Adult adult);
        Task<List<Adult>> getAdultsAsync();
        Task RemoveAdultAsync(int adultID);
    }
}