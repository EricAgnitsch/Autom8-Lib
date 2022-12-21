using Lib.Algorithms;
using Lib.Graphs.Weighted;

namespace LibTests.Graphs.Weighted;

public class WeightedGraphTests
{
    [Test]
    public void DijkstraTest()
    {
        var graph = new WeightedGraph();

        var vertex = new Vertex(0);
        vertex.AddEdge(1, 4);
        vertex.AddEdge(2, 4);
        
        graph.AddVertex(vertex);

        vertex = new Vertex(1);
        vertex.AddEdge(0, 4);
        vertex.AddEdge(2, 2);
        
        graph.AddVertex(vertex);

        vertex = new Vertex(2);
        vertex.AddEdge(0, 4);
        vertex.AddEdge(1, 2);
        vertex.AddEdge(3, 3);
        vertex.AddEdge(4, 1);
        vertex.AddEdge(5, 6);
        
        graph.AddVertex(vertex);

        vertex = new Vertex(3);
        vertex.AddEdge(2, 3);
        vertex.AddEdge(5, 2);
        
        graph.AddVertex(vertex);

        vertex = new Vertex(4);
        vertex.AddEdge(2, 1);
        vertex.AddEdge(5, 3);
        
        graph.AddVertex(vertex);

        vertex = new Vertex(5);
        vertex.AddEdge(2, 6);
        vertex.AddEdge(3, 2);
        vertex.AddEdge(4, 3);
        
        graph.AddVertex(vertex);

        // Console.WriteLine(graph);

        new Dijkstra().Run(graph, 0);
    }
}