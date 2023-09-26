using Koszalka.Application.Features.ToDoFeatures.PutToDoTask;
using Koszalka.Application.Features.ToDoFeatures.DeleteToDoResponse;
using Koszalka.Application.Features.ToDoFeatures.GetAllTodo;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Koszalka.Application.Features.ToDoFeatures.CreateToDoTask;
using Koszalka.Domain.Entities;
using Koszalka.Persistence.Repositories;
using Koszalka.Application.Features.ToDoFeatures.GetAllTodoByOwner;

namespace Koszalka.WebAPI.Controllers
{
    [ApiController]
    [Route("todo")]
    public class ToDoController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly ToDoRepository _toDoRepository;

        public ToDoController(IMediator mediator, ToDoRepository toDoRepository)
        {
            _mediator = mediator;
            _toDoRepository = toDoRepository;
        }


        [HttpGet]
        public async Task<ActionResult<List<GetAllToDoResponse>>> GetAll(CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(new GetAllToDoRequest(), cancellationToken);
            return Ok(response);
        }

        // @todo: fix this 
        [HttpGet("byOwner")]
        public async Task<IQueryable<ToDo>> GetByOwner([FromQuery] string owner, CancellationToken cancellationToken)
        {
            // var response = await _mediator.Send(request, cancellationToken);
            var response = _toDoRepository.GetByOwner(owner, cancellationToken);
            return (IQueryable<ToDo>)Ok(response);

        }

        [HttpPost]
        public async Task<ActionResult<CreateTodoResponse>> Create(CreateTodoRequest request,
            CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return Ok(response);
        }

        [HttpDelete]
        public async Task<ActionResult<DeleteToDoResponse>> Delete(DeleteToDoRequest request,
            CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return Ok(response);
        }

        [HttpPut]
        public async Task<ActionResult<PutToDoResponse>> Put(PutToDoRequest request,
            CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return Ok(response);
        }
    }

}
