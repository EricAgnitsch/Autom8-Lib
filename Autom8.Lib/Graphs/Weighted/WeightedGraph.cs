namespace Lib.Graphs.Weighted;

public class WeightedGraph<T> where T : Vertex
{
    public List<T> Vertices { get; set; } = new();

    public void AddVertex(T vertex)
    {
        Vertices.Add(vertex);
    }

    public T FindVertex(int value)
    {
        return Vertices.FirstOrDefault(v => v.Value == value) ?? throw new Exception("Can't find Vertex.");
    }

    public override string ToString()
    {
        return Vertices.Aggregate("", (current, vertex) => current + vertex);
    }
}