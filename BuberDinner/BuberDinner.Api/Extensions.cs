using BuberDinner.Application.Services.Authentication;
using BuberDinner.Contracts.Authentication;

namespace BuberDinner.Api;

public static class Extensions{

    public static AuthenticationResponse ToAuthenticationResponse(this AuthenticationResult authResult) => 
        new AuthenticationResponse(authResult.Id, authResult.FirstName, authResult.LastName, authResult.Email, authResult.Token);
}