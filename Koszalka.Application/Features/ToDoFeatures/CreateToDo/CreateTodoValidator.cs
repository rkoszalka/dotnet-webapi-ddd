using FluentValidation;

// @todo: validate with fluent or validate in the entity class?
namespace Koszalka.Application.Features.ToDoFeatures.CreateToDoTask
{
    public sealed class CreateToDoValidator : AbstractValidator<CreateTodoRequest>
    {
        public CreateToDoValidator()
        {
            RuleFor(x => x.Task).NotEmpty().MinimumLength(3).MaximumLength(150);
            RuleFor(x => x.Owner).NotEmpty().MinimumLength(3).MaximumLength(75);
        }
    }
}
