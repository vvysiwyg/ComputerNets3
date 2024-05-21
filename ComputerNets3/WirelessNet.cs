namespace ComputerNets3
{
    public class WirelessNet
    {
        public Dictionary<Node, List<Node>> Graph { get; set; }
        public List<Node> Nodes { get; set; }

        public WirelessNet(int n)
        {
            Nodes = new List<Node>();
            Graph = new Dictionary<Node, List<Node>>();

            // Генерация координат узлов
            for (int i = 0; i < n; i++)
            {
                double x = Helper.GenerateGaussDistribution(), y = Helper.GenerateUniformDistribution();
                Node newNode = new Node(i, x, y);
                Nodes.Add(newNode);
                Graph.Add(newNode, new List<Node>());
            }
        }

        public void LinkNodes()
        {
            for(int i = 0; i < Graph.Count; i++)
            {
                Node nodei = Graph.FirstOrDefault(f => f.Key.Number == i).Key;
                for (int j = i; j < Graph.Count; j++)
                {
                    if (j + 1 == Graph.Count)
                        break;

                    Node nodej = Graph.FirstOrDefault(f => f.Key.Number == j + 1).Key;
                    if (nodei.InRadius(nodej))
                    {
                        Graph[nodei].Add(nodej);
                        Graph[nodej].Add(nodei);
                    }
                }
            }
        }

        public double GetNumberOfNodesInMainComponent()
        {
            return FindMainComponent().Count;
        }

        public int GetNodeDegree(int nodeNumber)
        {
            if (Graph.Count > 0)
            {
                Node node = Graph.FirstOrDefault(f => f.Key.Number == nodeNumber).Key;
                return Graph[node].Count;
            }
            else
                throw new Exception("Граф не задан");
        }

        public void DFS(Node vertex, HashSet<Node> visited, List<Node> component)
        {
            visited.Remove(vertex);
            component.Add(vertex);

            foreach (var neighbor in Graph[vertex])
            {
                if (visited.Contains(neighbor))
                {
                    DFS(neighbor, visited, component);
                }
            }
        }

        public List<Node> FindMainComponent()
        {
            var mainComponent = new List<Node>();

            if (Graph != null && Graph.Count > 0)
            {
                // Помечаем все вершины как непосещенные
                HashSet<Node> visited = [.. Graph.Keys];

                // Находим главную компоненту
                foreach (var vertex in Graph.Keys)
                {
                    if (visited.Contains(vertex))
                    {
                        List<Node> component = new List<Node>();
                        DFS(vertex, visited, component);
                        if (component.Count > mainComponent.Count)
                        {
                            mainComponent = component;
                        }
                    }
                }

                return mainComponent;
            }
            else return mainComponent;
        }
    }
}
