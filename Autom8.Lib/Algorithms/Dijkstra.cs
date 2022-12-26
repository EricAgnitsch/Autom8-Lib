using Lib.Graphs.Weighted;

namespace Lib.Algorithms;

public class Dijkstra
{
    public IEnumerable<int> Run(WeightedGraph<DijkstraVertex> graph, int source)
    {
        var paths = Enumerable.Repeat(-1, graph.Vertices.Count).ToList();

        graph.FindVertex(source).DistanceFromSource = 0;
        
        while (graph.Vertices.Any(v => v.Visited == false))
        {
            var minDistanceVertex = graph.Vertices
                .Where(v => v.Visited == false)
                .OrderBy(v => v.DistanceFromSource)
                .First();
            minDistanceVertex.Visited = true;

            // Console.WriteLine("Min Vertex: " + minDistanceVertex.Value);

            foreach (var edge in minDistanceVertex.Edges.Where(e => graph.FindVertex(e.Target).Visited == false))
            {
                var tempDistance = minDistanceVertex.DistanceFromSource + edge.Weight;
                // Console.WriteLine($"\tAnalyzing edge {edge.Target} with tempDistance {tempDistance}");

                if (tempDistance < graph.FindVertex(edge.Target).DistanceFromSource)
                {
                    // Console.WriteLine($"\t\tEdge distance ({tempDistance}) is less than {graph.FindVertex(edge.Target).DistanceFromSource}. Added {minDistanceVertex.Value} to path in {edge.Target}.");
                    graph.FindVertex(edge.Target).DistanceFromSource = tempDistance;
                    paths[edge.Target] = minDistanceVertex.Value;
                }
            }
        }
        // Console.WriteLine("Path: [" + string.Join(", ", paths) + "]");

        return paths;
    }
}