using blazor_hospital.Models;

namespace blazor_hospital.Data
{
    public interface IUserService
    {
        User validateUser(string userName, string password);
    }
}