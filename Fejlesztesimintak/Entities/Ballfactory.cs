using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fejlesztesimintak.Entities
{
    public class Ballfactory
    {
        public Ball CreateNew()
        {
            return new Ball();
        }
    }
}
