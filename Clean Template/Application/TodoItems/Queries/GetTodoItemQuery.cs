using Application.Common.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.TodoItems.Queries
{
    public class GetTodoItemQuery:IRequest<ResponseMessage<object>>
    {
    }
}
