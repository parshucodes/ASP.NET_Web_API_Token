using jwt11april.Model_Request;
using jwt11april.Models;

namespace jwt11april.Interfaces
{
    public interface IAuthService
    {
        User AddUser(User user);
        string login(LoginRequest loginRequest);

    }
}
