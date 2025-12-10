using KTMS.Domain.Entities;

namespace KTMS.Application.Abstractions
{
    public interface IJwtService
    {
        string GenerateToken(User user);
    }
}
