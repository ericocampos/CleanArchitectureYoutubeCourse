using ErrorOr;

namespace BuberDinner.Domain.Errors;

public static partial class Errors
{
    public static class Authentication
    {
        public static Error InvalidCretendials = Error.Validation(code: "Auth.InvalidCredentials", description: "Invalid credentials.");
    }
}