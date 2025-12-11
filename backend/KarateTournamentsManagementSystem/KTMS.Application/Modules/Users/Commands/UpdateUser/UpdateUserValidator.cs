using FluentValidation;

namespace KTMS.Application.Modules.Users.Commands.UpdateUser
{
    public sealed class UpdateUserValidator : AbstractValidator<UpdateUserCommand>
    {
        public UpdateUserValidator()
        {
            // Id je obavezno
            RuleFor(x => x.Id)
                .GreaterThan(0).WithMessage("User Id must be greater than 0.");

            // Name je opcionalan, ali ako postoji, mora biti validan
            When(x => !string.IsNullOrEmpty(x.Name), () =>
            {
                RuleFor(x => x.Name)
                    .MaximumLength(30).WithMessage("Name must not exceed 30 characters.");
            });

            // Surname je opcionalan
            When(x => !string.IsNullOrEmpty(x.Surname), () =>
            {
                RuleFor(x => x.Surname)
                    .MaximumLength(30).WithMessage("Surname must not exceed 30 characters.");
            });

            // PhoneNumber je opcionalan
            When(x => !string.IsNullOrEmpty(x.PhoneNumber), () =>
            {
                RuleFor(x => x.PhoneNumber)
                    .Matches(@"^\+[1-9]\d{1,14}$")
                    .WithMessage("Phone must be in international format, e.g. +38762123456 (no spaces).");
            });

            // Email je opcionalan
            When(x => !string.IsNullOrEmpty(x.Email), () =>
            {
                RuleFor(x => x.Email)
                    .EmailAddress().WithMessage("A valid email is required.")
                    .MaximumLength(50).WithMessage("Email must not exceed 50 characters.");
            });

            // Username je opcionalan
            When(x => !string.IsNullOrEmpty(x.Username), () =>
            {
                RuleFor(x => x.Username)
                    .MaximumLength(20).WithMessage("Username must not exceed 20 characters.");
            });

            // Password je opcionalan
            When(x => !string.IsNullOrEmpty(x.Password), () =>
            {
                RuleFor(x => x.Password)
                    .MinimumLength(8).WithMessage("Password must be at least 8 characters.")
                    .MaximumLength(50).WithMessage("Password cannot exceed 50 characters.")
                    .Matches("[A-Z]").WithMessage("Password must contain at least one uppercase letter.")
                    .Matches("[a-z]").WithMessage("Password must contain at least one lowercase letter.")
                    .Matches("[0-9]").WithMessage("Password must contain at least one number.")
                    .Matches("[^a-zA-Z0-9]").WithMessage("Password must contain at least one special character.")
                    .Matches(@"^\S+$").WithMessage("Password cannot contain spaces.");
            });
        }
    }
}
