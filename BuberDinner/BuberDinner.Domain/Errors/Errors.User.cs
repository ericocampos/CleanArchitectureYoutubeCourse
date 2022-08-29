using ErrorOr;

namespace BuberDinner.Domain.Errors;

public static partial class Errors
{
    public static class User
    {
        public static Error DuplicateEmail = Error.Conflict(code: "User.DuplicateEmail", description: "Email already in use.");
        public static Error DontExists = Error.NotFound(code: "User.DontExist", description: "Email doesn't exists.");
        public static Error InvalidPassword = Error.Validation(code: "User.IncorrectPassword", description: "Incorrect password.");
    }
}