using MathNet.Numerics.Statistics;

namespace ComputerNets3
{
    public partial class Form1 : Form
    {
        public static double R { get; private set; }

        public static int N { get; private set; }

        public List<double> NumberOfNodesInMainComponent { get; set; }

        public Dictionary<double, double> MeanNumberOfNodesInMainComponent { get; set; }        // ключ - n или r

        public Dictionary<double, double> NodesExpectations { get; set; }                       // ключ - n или r
        
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
                NumberOfNodesInMainComponent = new List<double>();
                MeanNumberOfNodesInMainComponent = new Dictionary<double, double>();
                NodesExpectations = new Dictionary<double, double>();

                string[] rArray = rTextBox.Text.Split(',');
                for (int i = 0; i < rArray.Length; i++)
                    rArray[i] = rArray[i].Trim();

                N = int.Parse(nTextBox.Text);

                foreach (string r in rArray)
                {
                    R = double.Parse(r);

                    List<double> localNumberOfNodesInMainComponent = new List<double>();
                    Dictionary<int, double> localNodesDegreeSum = new Dictionary<int, double>();

                    for (int i = 0; i < experimentsCount; i++)
                    {
                        WirelessNet wn = new WirelessNet(N);
                        wn.LinkNodes();
                        localNumberOfNodesInMainComponent.Add(wn.GetNumberOfNodesInMainComponent());

                        int nodeDegree = wn.GetNodeDegree(0);
                        if (localNodesDegreeSum.ContainsKey(nodeDegree))
                            localNodesDegreeSum[nodeDegree]++;
                        else
                            localNodesDegreeSum.Add(nodeDegree, 1);
                    }

                    double expectation = 0.0;
                    foreach (var item in localNodesDegreeSum)
                        expectation += item.Key * (item.Value / experimentsCount);

                    NodesExpectations.Add(N, expectation);
                    MeanNumberOfNodesInMainComponent.Add(R, localNumberOfNodesInMainComponent.Mean());

                }

                ResultVisualisation.VisualizeR(MeanNumberOfNodesInMainComponent, NodesExpectations, N);
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
                NumberOfNodesInMainComponent = new List<double>();
                MeanNumberOfNodesInMainComponent = new Dictionary<double, double>();
                NodesExpectations = new Dictionary<double, double>();

                string[] nArray = nTextBox.Text.Split(',');
                for (int i = 0; i < nArray.Length; i++)
                    nArray[i] = nArray[i].Trim();

                R = double.Parse(rTextBox.Text);

                foreach (string n in nArray)
                {
                    N = int.Parse(n);

                    List<double> localNumberOfNodesInMainComponent = new List<double>();
                    Dictionary<int, double> localNodesDegreeSum = new Dictionary<int, double>();

                    for (int i = 0; i < experimentsCount; i++)
                    {
                        WirelessNet wn = new WirelessNet(N);
                        wn.LinkNodes();
                        localNumberOfNodesInMainComponent.Add(wn.GetNumberOfNodesInMainComponent());

                        int nodeDegree = wn.GetNodeDegree(0);
                        if (localNodesDegreeSum.ContainsKey(nodeDegree))
                            localNodesDegreeSum[nodeDegree]++;
                        else
                            localNodesDegreeSum.Add(nodeDegree, 1);
                    }

                    double expectation = 0.0;
                    foreach (var item in localNodesDegreeSum)
                        expectation += item.Key * (item.Value / experimentsCount);

                    NodesExpectations.Add(N, expectation);
                    MeanNumberOfNodesInMainComponent.Add(N, localNumberOfNodesInMainComponent.Mean());
                }

                ResultVisualisation.VisualizeN(MeanNumberOfNodesInMainComponent, NodesExpectations, R);
            }
            else
            {
                MessageBox.Show("Заполнены не все поля");
                return;
            }
        }
    }
}
