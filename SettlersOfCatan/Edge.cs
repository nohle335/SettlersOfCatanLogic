using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SettlersOfCatan
{
    public class Edge : Position
    {
        public Guid ID { get; init; }
        public Guid VertexA { get; init; }
        public Guid VertexB { get; init; }

        public Edge(Guid id, Guid vertexA, Guid vertexB)
        {
            ID = id;
            VertexA = vertexA;
            VertexB = vertexB;
        }
    }
}
