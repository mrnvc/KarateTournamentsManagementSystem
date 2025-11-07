using BCrypt.Net;

namespace KTMS.Application.Common.Security
{
    public static class PasswordHasher
    {
        public static string Hash(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }

        public static bool Verified(string password, string hashedPassword) { 
            return BCrypt.Net.BCrypt.Verify(password, hashedPassword);
        }
    }
}
