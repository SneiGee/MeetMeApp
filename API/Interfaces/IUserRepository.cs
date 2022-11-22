using API.Dtos;
using API.Entities;

namespace API.Interfaces
{
    public interface IUserRepository
    {
         void Update(AppUser user);
         Task<bool> SaveAllAsync();
         Task<IEnumerable<AppUser>> GetUsersAsync();
         Task<AppUser> GetUserAsync(int id);
         Task<AppUser> GetUserByUsername(string username);
         Task<IEnumerable<MemberDto>> GetMembersAsync();
         Task<MemberDto> GetMemberAsync(string username);
    }
}