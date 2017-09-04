using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02350Demo.Model
{
    // The Line class has a reference to 2 shapes, that it connects.
    public class Edge
    {

        public ClassBox Source {get; set;}

        public ClassBox Sink { get; set; }

        public EdgeType Type { get; set; }
    }

    public enum EdgeType
    {
        NORMAL
    }

}
