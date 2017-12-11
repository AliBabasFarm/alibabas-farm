using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Direction_optimized
{
    public class Edge
    {
        public string p1_name;
        public string p2_name;
        public double distance;
        public Edge(string Name1, string Name2, double dist)
        {
            p1_name = Name1;
            p2_name = Name2;
            distance = dist;
        }
        public Edge(Edge _edge)
        {
            p1_name = _edge.p1_name;
            p2_name = _edge.p2_name;
            distance = _edge.distance;
        }
        public Edge()
        { }
    }
}

