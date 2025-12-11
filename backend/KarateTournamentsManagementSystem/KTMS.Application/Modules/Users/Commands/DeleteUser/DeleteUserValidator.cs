using FluentValidation;

namespace KTMS.Application.Modules.Users.Commands.DeleteUser
{
    public sealed class DeleteUserValidator : AbstractValidator<DeleteUserCommand>
    {
        public DeleteUserValidator()
        {
            RuleFor(x => x.Id)
                .NotEmpty().WithMessage("User ID must not be empty.");
        }
    }
}
