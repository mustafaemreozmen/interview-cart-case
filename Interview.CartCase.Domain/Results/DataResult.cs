using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.CartCase.Domain.Results
{
    public class DataResult<T> : Result, IDataResult<T>
    {
        public T Data { get; set; }
        public DataResult(bool isSuccess, T data): base(isSuccess)
        {
            Data = data;
        }

        public DataResult(string message, bool isSuccess, T data) : base(message, isSuccess)
        {
            Data = data;
        }
    }
}
