
using soatveonline.ViewModel;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace soatveonline.Core.InterfaceService
{
    public interface IShowService
    {
        Task<int> AddAsync(ShowVM_Input input);
        Task<int> DeleteAsync(int id);
        Task<int> UpdateAsync(int id, ShowVM_Input input);
        Task<IEnumerable<dynamic>> GetCalendarList();
        Task<List<ShowVM>> GetByDate(DateTime date);
        Task<ShowVM_Details> GetDetailsAsync(int id);
        Task<List<ShowVM>> GetAllAsync();
        Task<bool> AddFavoriteAsync(int userId, int showId);
        Task<bool> DeleteFavoriteAsync(Guid id);
        Task<List<ShowVM_SalesTicket>> GetListShowSalesTicketAsync();
        
    }
}
