using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class SuccessDataResult<T> : DataResult<T>
    {
        //Mesaj ile Data gönder...
        public SuccessDataResult(T data,string message) : base(data,true,message)
        {

        }
        //Yalnızca Data gönder...
        public SuccessDataResult(T data):base(data,true)
        {

        }
        //Yalnızca Mesaj gönder...
        public SuccessDataResult(string message):base(default,true,message)
        {

        }
        //Hiç bir şey gönderme...
        public SuccessDataResult():base(default,true)
        {

        }
    }
}
