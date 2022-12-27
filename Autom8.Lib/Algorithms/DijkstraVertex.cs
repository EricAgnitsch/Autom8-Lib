using Lib.Graphs.Weighted;

namespace Lib.Algorithms;

public class DijkstraVertex : Vertex
{
    public bool Visited { get; set; }
    public int DistanceFromSource { get; set; } = 100000;
    
    public DijkstraVertex(int value) : base(value)
    {
    }
}