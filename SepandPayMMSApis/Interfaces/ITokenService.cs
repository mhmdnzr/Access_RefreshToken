using SepandPayMMSApis.Models;
using SepandPayMMSApis.Requests;
using SepandPayMMSApis.Responses;

namespace SepandPayMMSApis.Interfaces
{
    public interface ITokenService
    {
        Task<Tuple<string, string>> GenerateTokensAsync(int userId);
        Task<ValidateRefreshTokenResponse> ValidateRefreshTokenAsync(RefreshTokenRequest refreshTokenRequest);
        Task<bool> RemoveRefreshTokenAsync(User user);
    }
}