using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework05
{
    internal class IncorrectIputException :ArgumentException
    {
        public IncorrectIputException(string message) { }
    }
}
