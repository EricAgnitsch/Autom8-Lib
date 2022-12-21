namespace Lib.Graphs.Weighted;

public class Edge
{
    public int Target { get; set; }
    public int Weight { get; set; }

    public Edge(int target, int weight)
    {
        Target = target;
        Weight = weight;
    }

    public override string ToString()
    {
        return $"\tEdge >> {Target} | weight: {Weight}";
    }
}