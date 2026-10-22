using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SettlersOfCatan
{
    public class Vertex : Position
    {
        public Guid Id { get; init; }
        public List<Guid> AdjacentHexFields { get; init; }
        public List<Guid> AdjacentEdges { get; init; }

        public Vertex(Guid id, List<Guid> adjacentHexFields, List<Guid> adjacentEdges)
        {
            Id = id;
            AdjacentHexFields = adjacentHexFields;
            AdjacentEdges = adjacentEdges;
        }
    }
}