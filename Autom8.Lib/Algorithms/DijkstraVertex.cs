using Lib.Graphs.Weighted;

namespace Lib.Algorithms;

public class DijkstraVertex : Vertex
{
    public bool Visited { get; set; }
    public int DistanceFromSource { get; set; } = 100000; // I think this could stay as max?
    
    public DijkstraVertex(int value) : base(value)
    {
    }
}