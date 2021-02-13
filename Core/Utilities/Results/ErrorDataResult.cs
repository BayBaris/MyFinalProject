using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class ErrorDataResult<T> : DataResult<T>
    {
        //Mesaj ile Data gönder...
        public ErrorDataResult(T data, string message) : base(data, false, message)
        {

        }
        //Yalnızca Data gönder...
        public ErrorDataResult(T data) : base(data, false)
        {

        }
        //Yalnızca Mesaj gönder...
        public ErrorDataResult(string message) : base(default, false, message)
        {

        }
        //Hiç bir şey gönderme...
        public ErrorDataResult() : base(default, false)
        {

        }
    }
}
