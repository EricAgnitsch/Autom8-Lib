namespace Lib.Graphs.Weighted;

public class Vertex
{
    public int Value { get; set; }
    public List<Edge> Edges { get; set; } = new();

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

        return Edges.Aggregate(result, (current, edge) => current + (edge + "\n"));
    }
}