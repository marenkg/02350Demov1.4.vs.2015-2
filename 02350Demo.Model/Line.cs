using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02350Demo.Model
{
    // The Line class has a reference to 2 shapes, that it connects.
    public class Line : NotifyBase
    {
        private ClassBox source;
        private ClassBox sink;
        private EdgeType type;


        public ClassBox Source { get { return source; } set { source = value; NotifyPropertyChanged(); } }
        
        public ClassBox Sink { get { return sink; } set { sink = value; NotifyPropertyChanged(); } }

        public EdgeType Type { get { return type; } set { type = value; NotifyPropertyChanged(); } }
    }

    public enum EdgeType
    {
        NORMAL
    }

}
