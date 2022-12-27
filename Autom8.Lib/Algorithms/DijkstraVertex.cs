using Lib.Graphs.Weighted;

namespace Lib.Algorithms;

public class DijkstraVertex : Vertex
{
    public bool Visited { get; set; }
    public int DistanceFromSource { get; set; } = int.MaxValue;
    
    public DijkstraVertex(int value) : base(value)
    {
    }
}