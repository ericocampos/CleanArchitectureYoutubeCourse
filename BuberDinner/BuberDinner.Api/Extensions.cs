using BuberDinner.Application.Services.Authentication;
using BuberDinner.Contracts.Authentication;

namespace BuberDinner.Api;

public static class Extensions{

    public static AuthenticationResponse ToAuthenticationResponse(this AuthenticationResult authResult) => 
        new AuthenticationResponse(authResult.User.Id, authResult.User.FirstName, authResult.User.LastName, authResult.User.Email, authResult.Token);
}