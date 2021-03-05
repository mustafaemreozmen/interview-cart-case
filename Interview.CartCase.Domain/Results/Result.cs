using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.CartCase.Domain.Results
{
    public class Result : IResult
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }

        public Result(bool isSuccess)
        {
            IsSuccess = isSuccess;
        }
        public Result(string message, bool isSuccess): this(isSuccess)
        {
            Message = message;
        }
    }
}
