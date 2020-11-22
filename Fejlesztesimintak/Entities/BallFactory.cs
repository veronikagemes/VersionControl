using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fejlesztesimintak.Abstractions;

namespace Fejlesztesimintak.Entities
{
    public class BallFactory : IToyFactory
    {
        public Color BallColor { get; set; }
        public Toy CreateNew()
        {
            return new Ball(Ballcolor);
        }
    }
}
