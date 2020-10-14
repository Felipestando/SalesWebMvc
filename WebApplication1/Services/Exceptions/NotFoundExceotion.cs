using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Services.Exceptions
{
    public class NotFoundExceotion : ApplicationException
    {
        public NotFoundExceotion(string message) : base(message) { }
    }
}
