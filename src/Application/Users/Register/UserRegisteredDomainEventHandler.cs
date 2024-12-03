using Domain.Users;
using MediatR;

namespace Application.Users.Register;

internal sealed class UserRegisteredDomainEventHandler : INotificationHandler<UserRegisteredDomainEvent>
{
    public Task Handle(UserRegisteredDomainEvent notification, CancellationToken cancellationToken)
    {
        // Email verification would be implemented here
        // Steps would include:
        // 1. Generate a unique verification token
        // 2. Store the token with an expiration time
        // 3. Create a verification URL with the token
        // 4. Send an email to the user with the verification link
        // 5. Create an endpoint to handle verification
        return Task.CompletedTask;
    }
}
