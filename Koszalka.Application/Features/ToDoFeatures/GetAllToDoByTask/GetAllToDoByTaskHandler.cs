using AutoMapper;
using Koszalka.Application.Features.ToDoFeatures.GetAllToDoByOwner;
using Koszalka.Application.Features.ToDoResponse;
using Koszalka.Application.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koszalka.Application.Features.ToDoFeatures.GetAllToDoByTask
{
    public sealed class GetAllTodoByTaskHandler : IRequestHandler<GetAllToDoByTaskRequest, List<RequestResponse>>
    {
        private readonly IToDoRepository _userRepository;
        private readonly IMapper _mapper;

        public GetAllTodoByTaskHandler(IToDoRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public async Task<List<RequestResponse>> Handle(GetAllToDoByTaskRequest request, CancellationToken cancellationToken)
        {
            var users = _userRepository.GetByTask(request, cancellationToken, request.Task);
            return _mapper.Map<List<RequestResponse>>(users);
        }
    }
}
