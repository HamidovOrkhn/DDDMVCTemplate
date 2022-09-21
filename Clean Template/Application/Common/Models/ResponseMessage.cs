using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.Models
{
    public class ResponseMessage<T>
    {
        public int Code { get; set; }
        public T Data { get; set; }
        public T Errors { get; set; }
        public string Message { get; set; }

        public static ResponseMessage<T> Fail(int code = 500, string message = "Xəta baş verdi.", T errors = default(T))
        {
            return new ResponseMessage<T> { Code = code, Errors = errors, Message = message };
        }

        public static ResponseMessage<T> Success(T data = default(T))
        {
            return new ResponseMessage<T> { Code = 200, Data = data, Errors = default(T), Message = "Əməliyyat uğurla başa çatdı." };
        }

    }
}
