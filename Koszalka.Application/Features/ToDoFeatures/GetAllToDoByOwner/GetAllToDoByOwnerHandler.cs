using AutoMapper;
using Koszalka.Application.Features.ToDoFeatures.GetAllTodo;
using Koszalka.Application.Features.ToDoResponse;
using Koszalka.Application.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koszalka.Application.Features.ToDoFeatures.GetAllToDoByOwner
{
    public sealed class GetAllTodoByOwnerHandler : IRequestHandler<GetAllToDoByOwnerRequest, List<RequestResponse>>
    {
        private readonly IToDoRepository _userRepository;
        private readonly IMapper _mapper;

        public GetAllTodoByOwnerHandler(IToDoRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public async Task<List<RequestResponse>> Handle(GetAllToDoByOwnerRequest request, CancellationToken cancellationToken)
        {
            var users = _userRepository.GetByOwner(request, cancellationToken,  request.Owner);
            return _mapper.Map<List<RequestResponse>>(users);
        }
    }
}
