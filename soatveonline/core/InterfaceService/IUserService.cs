﻿

using soatveonline.Model;
using soatveonline.ViewModel;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace soatveonline.Core.InterfaceService
{
    public interface IUserService
    {
        Task<bool> AddAsync(UserVM_Input input);
        Task<bool> DeleteAsync(int id);
        Task<bool> ChangePassword(int id, UserVM_ChangePassword input);
        
        Task<bool> UpdateRoleAsync(UserVM_UpdateRole input);
        Task<List<UserVM>> GetAllAsync();
        Task<bool> UpdateInfoAsync(UserVM_UpdateInfo input);
        Task<User> GetByPhone(string phone);
    }
}
