using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceBasic
{
    internal interface IBasic
    {
        int TestInstanceMethod();
        int TestPreoperty { get; set; }
    }
}
    