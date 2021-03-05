﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.CartCase.Domain.Results
{
    public class ErrorDataResult<T>: DataResult<T>
    {
        public ErrorDataResult(T data): base(false, data)
        {
        }

        public ErrorDataResult(string message, T data): base(message, false, data)
        {
        }
    }
}
