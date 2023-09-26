using AutoMapper;
using Koszalka.Application.Repositories;
using MediatR;

namespace Koszalka.Application.Features.ToDoFeatures.GetAllTodoByOwner
{
    public sealed class GetAllToDoByOwnerHandler : IRequestHandler<GetAllToDoByOwnerRequest, List<GetAllToDoByOwnerResponse>>
    {
        private readonly IToDoRepository _userRepository;
        private readonly IMapper _mapper;

        public GetAllToDoByOwnerHandler(IToDoRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public async Task<List<GetAllToDoByOwnerResponse>> Handle(GetAllToDoByOwnerRequest request, CancellationToken cancellationToken)
        {
            return _mapper.Map<List<GetAllToDoByOwnerResponse>>(users);
        }
    }
}
