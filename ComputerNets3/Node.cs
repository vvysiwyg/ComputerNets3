namespace ComputerNets3
{
    public struct Node
    {
        public int Number { get; set; }
        public double X { get; set; }
        public double Y { get; set; }

        public Node(int Number, double X, double Y)
        {
            this.Number = Number;
            this.X = X;
            this.Y = Y;
        }

        public bool InRadius(Node node)
        {
            if (Form1.R != -1)
            {
                return Math.Pow(node.X - X, 2) + Math.Pow(node.Y - Y, 2) < Math.Pow(Form1.R, 2);
            }
            else
                throw new Exception("Не задан радиус");
        }
    }
}
