using SEPUDO.Application.Models.Identity;
using System.Web.Mvc;

namespace SEPUDO.Application.Contracts.Identity
{
    public interface  IAuthService
    {
        Task<AuthResponse> Login(AuthRequest request);

        Task<AuthResponse> ReNewToken(string token);

        Task<RegistrationResponse> Register(RegistrationRequest request);

        Task<RegistrationResponse> UpdateUser(RegistrationRequest request);

        Task<RoleResponse> RegisterRole(RoleRequest request);

        List<RoleResponse> GetRoles();

    }
}
