using Domain.Users;

namespace Application.Abstractions.Authentication;

public interface ITokenProvider
{
    Task<string> Create(User user);
}
