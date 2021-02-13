using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    //Temel voidler için başlangıç...
    public interface IResult
    {
        bool Success { get; } //Sadece okunabilir bir değer döndürür.(T-F)...
        string Message { get; } // String döndürür. Bilgilendirme metinlerini döndürür...
    }
}
