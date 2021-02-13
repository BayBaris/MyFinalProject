using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        //Read-only yapılar constructor ile set edilebilir...
        //Bu işlem kodları daha okunabilir ve standardize hala getirir...
        //this,class içinde kendini çağırır...
        public Result(bool success, string message):this(success) //Yalnızca success içeren constructoru da çalıştırır...
        {
            Message = message;
        }
        //Overloading...
        //Yalnızca bool döndüren yapı...
        public Result(bool success)
        {            
            Success = success;
        }

        // => karşısındaki ifadeyi return eder...
        // Success => example codes...
        public bool Success { get; }

        public string Message { get; }
    }
}
