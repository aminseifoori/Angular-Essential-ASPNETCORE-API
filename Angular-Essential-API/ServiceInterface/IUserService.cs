using Angular_Essential_API.Dtos;
using Microsoft.AspNetCore.Identity;


namespace Angular_Essential_API.ServiceInterface
{
    public interface IUserService
    {
        Task<IdentityResult> RegisterUser(CreateUserDto createUserDto);
        Task<IdentityResult> RegisterAdmin(CreateUserDto createUserDto);
        Task<bool> ValidateUser(LoginDto userForAuth);
        Task<TokenDto> CreateToken(bool populateExp);
        Task<TokenDto> RefreshToken(TokenDto tokenDto);
    }
}
