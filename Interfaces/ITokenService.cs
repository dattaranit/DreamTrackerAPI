using DreamTrackerAPI.Entities;

namespace DreamTrackerAPI.Interfaces
{
    public interface ITokenService
    {
        string CreateToken(AppUser user);
    }
}
