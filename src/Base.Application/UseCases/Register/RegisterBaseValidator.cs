using Base.Communication.Requests;
using FluentValidation;

namespace Base.Application.UseCases.Register;

public class BaseValidator : AbstractValidator<RequestRegisterBaseJson>
{
    public BaseValidator()
    {
        RuleFor(e => e.Name).NotEmpty().WithMessage("Name is required.");
    }
}
