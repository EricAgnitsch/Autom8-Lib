namespace Lib.Graphs.Weighted;

public class Vertex
{
    public int Value { get; set; }
    public List<Edge> Edges { get; set; } = new();

    // dijkstra
    public bool Visited { get; set; }
    public int DistanceFromSource { get; set; } = int.MaxValue;

    public Vertex(int value)
    {
        Value = value;
    }

    public void AddEdge(int target, int weight)
    {
        Edges.Add(new Edge(target, weight));
    }

    public override string ToString()
    {
        var result = $"Vertex >> {Value}\n";
        
        foreach (var edge in Edges)
        {
            result += edge + "\n";
        }

        return result;
    }
}