using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace _02350Demo.Model
{
    // The Line class has a reference to 2 shapes, that it connects.
    public class Edge
    {

        public ClassBox Source {get; set;}

        public ClassBox Sink { get; set; }

        public EdgeType Type { get; set; }

        // Tuple <SourcePoint,SinkPoint>
        public Tuple<Point, Point> FindPreferedPoints()
        {
            // Calculat distance between points, use shortest. 
            Point prefSource = Source.North;
            Point prefSink = Sink.North;
            // ShortestDist = Length of Sinkpoint - SourcePoint. 
            double shortestDist = Point.Subtract(prefSink, prefSource).Length;
            double tempDist;

            var sourcePoints = new Point[4];
            var sinkPoints = new Point[4];

            // Fill in arrays for iterations
            sourcePoints[0] = Source.North;
            sourcePoints[1] = Source.South;
            sourcePoints[2] = Source.East;
            sourcePoints[3] = Source.West;
            sinkPoints[0] = Sink.North;
            sinkPoints[1] = Sink.South;
            sinkPoints[2] = Sink.East;
            sinkPoints[3] = Sink.West;

            foreach (Point sourcPoint in sourcePoints)
            {
                foreach (Point sinkPoint in sinkPoints)
                {
                    tempDist = Point.Subtract(sinkPoint, sourcPoint).Length;
                    if (tempDist < shortestDist)
                    {
                        prefSource = sourcPoint;
                        prefSink = sinkPoint;
                        shortestDist = tempDist;
                    }
                }
            }


            return Tuple.Create(prefSource, prefSink);
        }

    }

    public enum EdgeType
    {
        NORMAL
    }

}
