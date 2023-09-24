using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// @todo: validate with fluent or validate in the entity class?
namespace Koszalka.Application.Features.ToDoFeatures.CreateToDoTask
{
    public sealed class CreateToDoValidator : AbstractValidator<CreateTodoRequest>
    {
        public CreateToDoValidator()
        {
            RuleFor(x => x.Task).NotEmpty().MaximumLength(50);
            RuleFor(x => x.Owner).NotEmpty().MinimumLength(3).MaximumLength(50);
        }
    }
}
