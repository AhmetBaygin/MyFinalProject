using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        //readonly yani sadece get varsa constructor 'ın içinde değer verilebilir başka yerde değer atanamaz
        public Result(bool success,string message):this(success)
        //this derken bulundugu classtan bahsediyor parantez içinde tek parametre olduğu için diğer ctor çalışır ve kod tekrarı olmaz
        {
            Message = message;
            

        }
        public Result(bool success)
        {
            Success = success;

        }
        public bool Success { get; }

        public string Message { get; }
    }
}
