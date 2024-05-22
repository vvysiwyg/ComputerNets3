using MathNet.Numerics.Statistics;

namespace ComputerNets3
{
    public partial class Form1 : Form
    {
        public static double R { get; private set; }

        public static int N { get; private set; }

        public Dictionary<double, double> MeanNumberOfNodesInMainComponent { get; set; }        // ключ - n или r

        public Dictionary<double, double> NodeExpectations { get; set; }                       // ключ - n или r
        
        private ResultVisualisation ResultVisualisation { get; set; }

        public Form1()
        {
            InitializeComponent();
            R = -1;
            N = 0;
            ResultVisualisation = new ResultVisualisation(this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int experimentsCount;

            if (!string.IsNullOrEmpty(nTextBox.Text) &&
                !string.IsNullOrEmpty(rTextBox.Text) &&
                int.TryParse(experimentsCountTextBox.Text, out experimentsCount))
            {
                MeanNumberOfNodesInMainComponent = new Dictionary<double, double>();
                NodeExpectations = new Dictionary<double, double>();

                string[] rArray = rTextBox.Text.Split(',');
                for (int i = 0; i < rArray.Length; i++)
                    rArray[i] = rArray[i].Trim();

                N = int.Parse(nTextBox.Text);

                foreach (string r in rArray)
                {
                    R = double.Parse(r);

                    List<double> numberOfNodesInMainComponent = new List<double>();
                    Dictionary<int, double> nodesDegreeSum = new Dictionary<int, double>();

                    for (int i = 0; i < experimentsCount; i++)
                    {
                        WirelessNet wn = new WirelessNet(N);
                        wn.LinkNodes();
                        numberOfNodesInMainComponent.Add(wn.GetNumberOfNodesInMainComponent());

                        int nodeDegree = wn.GetNodeDegree(0);           // получаем степень нулевой вершины
                        if (nodesDegreeSum.ContainsKey(nodeDegree))
                            nodesDegreeSum[nodeDegree]++;
                        else
                            nodesDegreeSum.Add(nodeDegree, 1);
                    }

                    double expectation = 0.0;
                    foreach (var item in nodesDegreeSum)
                        expectation += item.Key * (item.Value / experimentsCount);

                    NodeExpectations.Add(R, expectation);
                    MeanNumberOfNodesInMainComponent.Add(R, numberOfNodesInMainComponent.Mean());

                }

                ResultVisualisation.VisualizeR(MeanNumberOfNodesInMainComponent, NodeExpectations, N);
            }
            else
            {
                MessageBox.Show("Заполнены не все поля");
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int experimentsCount;

            if (!string.IsNullOrEmpty(nTextBox.Text) &&
                !string.IsNullOrEmpty(rTextBox.Text) &&
                int.TryParse(experimentsCountTextBox.Text, out experimentsCount))
            {
                MeanNumberOfNodesInMainComponent = new Dictionary<double, double>();
                NodeExpectations = new Dictionary<double, double>();

                string[] nArray = nTextBox.Text.Split(',');
                for (int i = 0; i < nArray.Length; i++)
                    nArray[i] = nArray[i].Trim();

                R = double.Parse(rTextBox.Text);

                foreach (string n in nArray)
                {
                    N = int.Parse(n);

                    List<double> numberOfNodesInMainComponent = new List<double>();
                    Dictionary<int, double> nodesDegreeSum = new Dictionary<int, double>();

                    for (int i = 0; i < experimentsCount; i++)
                    {
                        WirelessNet wn = new WirelessNet(N);
                        wn.LinkNodes();
                        numberOfNodesInMainComponent.Add(wn.GetNumberOfNodesInMainComponent());

                        int nodeDegree = wn.GetNodeDegree(0);       // получаем степень нулевой вершины
                        if (nodesDegreeSum.ContainsKey(nodeDegree))
                            nodesDegreeSum[nodeDegree]++;
                        else
                            nodesDegreeSum.Add(nodeDegree, 1);
                    }

                    double expectation = 0.0;
                    foreach (var item in nodesDegreeSum)
                        expectation += item.Key * (item.Value / experimentsCount);

                    NodeExpectations.Add(N, expectation);
                    MeanNumberOfNodesInMainComponent.Add(N, numberOfNodesInMainComponent.Mean());
                }

                ResultVisualisation.VisualizeN(MeanNumberOfNodesInMainComponent, NodeExpectations, R);
            }
            else
            {
                MessageBox.Show("Заполнены не все поля");
                return;
            }
        }
    }
}
