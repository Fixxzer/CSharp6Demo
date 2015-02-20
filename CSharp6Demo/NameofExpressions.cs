using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp6Demo
{
    public static class NameofExpressions
    {
        public static void ThrowArgumentNullExceptionUsingNameOf(string param1)
        {
            throw new ArgumentNullException(nameof(param1));
        }
    }
}
