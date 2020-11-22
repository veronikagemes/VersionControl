using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fejlesztesimintak.Entities;

namespace Fejlesztesimintak.Abstractions
{
    public interface IToyFactory
    {
        Toy CreateNew();
    }
}
