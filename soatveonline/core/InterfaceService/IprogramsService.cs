using HueFestival_OnlineTicket.ViewModel;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HueFestival_OnlineTicket.Core.InterfaceService
{
    public interface IprogramsService
    {
        Task AddAsync(programsVM_Input input);
        Task<int> DeleteAsync(int id);
        Task<List<programsVM>> GetAllByTypeProgramAsync(int typeProgram);
        Task<programsVM_Details> GetDetailsAsync(int id);
        Task<int> UpdateAsync(int id, programsVM_Input input);
        Task<List<programsVM>> GetAllAsync();
    }
}
