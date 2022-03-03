using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApi.Domain.Commons.Exceptions
{
    public class ApiException : ApplicationException
    {
        public new string Message { get; set; }
        public string StatusCode { get; set; }
        public ApiException(string message, string statusCode)
            : base(message)
        {
            Message = message;
            StatusCode = statusCode;
        }
    }
}
