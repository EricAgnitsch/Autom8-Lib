namespace Lib.Graphs.Weighted;

public class WeightedGraph
{
    public List<Vertex> Vertices { get; set; } = new();

    public void AddVertex(Vertex vertex)
    {
        Vertices.Add(vertex);
    }

    public Vertex FindVertex(int value)
    {
        return Vertices.FirstOrDefault(v => v.Value == value) ?? throw new Exception("Can't find Vertex.");
    }

    public override string ToString()
    {
        return Vertices.Aggregate("", (current, vertex) => current + vertex);
    }
}