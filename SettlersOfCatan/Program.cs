using System;

namespace SettlersOfCatan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }

        /// <summary>
        /// Zählt die Gesamtanzahl der Linien (Kanten) in einem beliebigen Hex-Grid.
        /// </summary>
        /// <param name="hexList">Eine Menge von Axialkoordinaten (q, r)</param>
        /// <returns>Anzahl der eindeutigen Kanten</returns>
        public static int CountHexGridEdges(HashSet<(int q, int r)> hexList)
        {
            // Ein HashSet für eindeutige, ungerichtete Kanten
            var edges = new HashSet<((int q, int r) p1, (int q, int r) p2)>();

            // Die 6 Standard-Nachbarrichtungen in axialen Koordinaten
            (int q, int r)[] directions = { (1, 0), (1, -1), (0, -1), (-1, 0), (-1, 1), (0, 1) };

            foreach (var h in hexList)
            {
                foreach (var d in directions)
                {
                    var neighbor = (q: h.q + d.q, r: h.r + d.r);

                    // Kante sortieren (A-B wird zu B-A, falls B "kleiner" ist), 
                    // damit geteilte innere Kanten nur 1x gezählt werden.
                    var orderedEdge = OrderHexPair(h, neighbor);
                    edges.Add(orderedEdge);
                }
            }

            return edges.Count;
        }

        private static ((int q, int r) p1, (int q, int r) p2) OrderHexPair((int q, int r) a, (int q, int r) b)
        {
            // Bestimmt eine konsistente Reihenfolge für das Tupel
            bool aFirst = a.q < b.q || (a.q == b.q && a.r < b.r);
            return aFirst ? (a, b) : (b, a);
        }
    }
}