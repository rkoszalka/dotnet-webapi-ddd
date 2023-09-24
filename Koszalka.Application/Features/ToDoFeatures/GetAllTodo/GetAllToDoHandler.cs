using AutoMapper;
using Koszalka.Application.Repositories;
using MediatR;

namespace Koszalka.Application.Features.ToDoFeatures.GetAllTodo
{
    public sealed class GetAllTodoHandler : IRequestHandler<GetAllToDoRequest, List<GetAllToDoResponse>>
    {
        private readonly IToDoRepository _userRepository;
        private readonly IMapper _mapper;

        public GetAllTodoHandler(IToDoRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public async Task<List<GetAllToDoResponse>> Handle(GetAllToDoRequest request, CancellationToken cancellationToken)
        {
            var users = await _userRepository.GetAll(cancellationToken);
            return _mapper.Map<List<GetAllToDoResponse>>(users);
        }
    }
}
