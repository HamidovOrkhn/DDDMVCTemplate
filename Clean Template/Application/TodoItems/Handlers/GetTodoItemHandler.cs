using Application.Common.Models;
using Application.TodoItems.Queries;
using Infrastructure.Persistence;
using MediatR;

namespace Application.TodoItems.Handlers
{
    internal class GetTodoItemHandler : IRequestHandler<GetTodoItemQuery, ResponseMessage<object>>
    {
        private readonly ApplicationDbContext _db;
        public GetTodoItemHandler(ApplicationDbContext db)
        {
            _db = db;
        }
        public Task<ResponseMessage<object>> Handle(GetTodoItemQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(ResponseMessage<object>.Success(request));
        }
    }
}
