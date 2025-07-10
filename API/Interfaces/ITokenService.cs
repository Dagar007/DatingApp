using API.Entities;

namespace API.Interfaces;

public interface ITokenService
{
    string CreateToken(AppUser user);
    // string CreateRefreshToken();
    // bool ValidateRefreshToken(string refreshToken);
    // void RevokeRefreshToken(string refreshToken);
    // Task<AppUser> GetUserFromRefreshTokenAsync(string refreshToken);
}
