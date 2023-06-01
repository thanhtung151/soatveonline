
using soatveonline.ViewModell;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace soatveonline.Core.InterfaceService
{
    public interface INewsService
    {
        Task<List<NewsVM>> GetAllAsync();
        Task<bool> AddAsync(NewsVM_Input input);
        Task<bool> DeleteAsync(int id);
        Task<NewsVM_Details> GetDetailsAsync(int id);
        Task<bool> UpdateAsync(int id, NewsVM_Input input);
    }
}
