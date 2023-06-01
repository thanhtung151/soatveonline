
using soatveonline.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace soatveonline.Core.InterfaceService
{
    public interface ITicketService
    {
       
        Task<List<tickets>> GetAllAsync();
        Task<List<tickets>> GetByUserId(int userId);
        Task<tickets> GetByIdAsync(Guid ticketId);
    }
}
