using System.Windows.Forms.DataVisualization.Charting;

namespace ComputerNets3
{
    public class ResultVisualisation
    {
        private Form1 Form { get; set; }
        private Chart MeanNumberOfNodesInMainComponentChartN { get; set; }
        private Chart MeanNumberOfNodesInMainComponentChartR { get; set; }
        private Chart NodesExpectationsChartN { get; set; }
        private Chart NodesExpectationsChartR { get; set; }
        private Dictionary<double, Series> MeanNumberOfNodesInMainComponentSeriesN { get; set; }                // ключ - r
        private Dictionary<double, Series> MeanNumberOfNodesInMainComponentSeriesR { get; set; }                // ключ - n
        private Dictionary<double, Series> NodesExpectationsSeriesN { get; set; }                               // ключ - r
        private Dictionary<double, Series> NodesExpectationsSeriesR { get; set; }                               // ключ - n

        public ResultVisualisation()
        {
            Form = new Form1();
            MeanNumberOfNodesInMainComponentSeriesN = new Dictionary<double, Series>();
            NodesExpectationsSeriesN = new Dictionary<double, Series>();
            MeanNumberOfNodesInMainComponentSeriesR = new Dictionary<double, Series>();
            NodesExpectationsSeriesR = new Dictionary<double, Series>();
        }

        public ResultVisualisation(Form1 Form)
        {
            this.Form = Form;

            MeanNumberOfNodesInMainComponentSeriesN = new Dictionary<double, Series>();
            NodesExpectationsSeriesN = new Dictionary<double, Series>();
            MeanNumberOfNodesInMainComponentSeriesR = new Dictionary<double, Series>();
            NodesExpectationsSeriesR = new Dictionary<double, Series>();

            MeanNumberOfNodesInMainComponentChartN = new Chart();
            ChartArea MeanNumberOfNodesInMainComponentChartAreaN = new ChartArea();
            MeanNumberOfNodesInMainComponentChartN.ChartAreas.Add(MeanNumberOfNodesInMainComponentChartAreaN);

            MeanNumberOfNodesInMainComponentChartR = new Chart();
            ChartArea MeanNumberOfNodesInMainComponentChartAreaR = new ChartArea();
            MeanNumberOfNodesInMainComponentChartR.ChartAreas.Add(MeanNumberOfNodesInMainComponentChartAreaR);

            NodesExpectationsChartN = new Chart();
            ChartArea NodesExpectationsChartAreaN = new ChartArea();
            NodesExpectationsChartN.ChartAreas.Add(NodesExpectationsChartAreaN);

            NodesExpectationsChartR = new Chart();
            ChartArea NodesExpectationsChartAreaR = new ChartArea();
            NodesExpectationsChartR.ChartAreas.Add(NodesExpectationsChartAreaR);

            MeanNumberOfNodesInMainComponentChartN.Dock = DockStyle.Fill;
            MeanNumberOfNodesInMainComponentChartR.Dock = DockStyle.Fill;
            NodesExpectationsChartN.Dock = DockStyle.Fill;
            NodesExpectationsChartR.Dock = DockStyle.Fill;

            TabPage MeanNumberOfNodesInMainComponentTabPageN = this.Form.Controls.Find("tabPage4", true)[0] as TabPage;
            TabPage MeanNumberOfNodesInMainComponentTabPageR = this.Form.Controls.Find("tabPage5", true)[0] as TabPage;
            TabPage NodesExpectationsTabPageN = this.Form.Controls.Find("tabPage6", true)[0] as TabPage;
            TabPage NodesExpectationsTabPageR = this.Form.Controls.Find("tabPage7", true)[0] as TabPage;

            MeanNumberOfNodesInMainComponentTabPageN.Controls.Add(MeanNumberOfNodesInMainComponentChartN);
            MeanNumberOfNodesInMainComponentTabPageR.Controls.Add(MeanNumberOfNodesInMainComponentChartR);
            NodesExpectationsTabPageN.Controls.Add(NodesExpectationsChartN);
            NodesExpectationsTabPageR.Controls.Add(NodesExpectationsChartR);
        }

        public void VisualizeN(Dictionary<double, double> MeanNumberOfNodesInMainComponent, Dictionary<double, double> NodesExpectations, double r)
        {
            Series MeanNumberOfNodesInMainComponentSeries, NodesExpectationsSeries;

            if (!MeanNumberOfNodesInMainComponentSeriesN.TryGetValue(r, out MeanNumberOfNodesInMainComponentSeries))
            {
                MeanNumberOfNodesInMainComponentSeries = new Series();
                MeanNumberOfNodesInMainComponentSeries.Name = $"r = {r}";
                MeanNumberOfNodesInMainComponentSeries.ChartType = SeriesChartType.Line;
                MeanNumberOfNodesInMainComponentSeries.BorderWidth = 2;
                MeanNumberOfNodesInMainComponentChartN.Series.Add(MeanNumberOfNodesInMainComponentSeries);
                MeanNumberOfNodesInMainComponentChartN.Legends.Add(r.ToString());
                MeanNumberOfNodesInMainComponentSeriesN.Add(r, MeanNumberOfNodesInMainComponentSeries);
            }

            if (!NodesExpectationsSeriesN.TryGetValue(r, out NodesExpectationsSeries))
            {
                NodesExpectationsSeries = new Series();
                NodesExpectationsSeries.Name = $"r = {r}";
                NodesExpectationsSeries.ChartType = SeriesChartType.Line;
                NodesExpectationsSeries.BorderWidth = 3;
                NodesExpectationsChartN.Series.Add(NodesExpectationsSeries);
                Legend legend = NodesExpectationsChartN.Legends.Add(r.ToString());
                NodesExpectationsSeriesN.Add(r, NodesExpectationsSeries);
            }

            MeanNumberOfNodesInMainComponentSeries.Points.DataBindXY(MeanNumberOfNodesInMainComponent.Keys, MeanNumberOfNodesInMainComponent.Values);
            NodesExpectationsSeries.Points.DataBindXY(NodesExpectations.Keys, NodesExpectations.Values);

            MeanNumberOfNodesInMainComponentSeries.Points.Clear();
            NodesExpectationsSeries.Points.Clear();

            foreach(var item in MeanNumberOfNodesInMainComponent)
                MeanNumberOfNodesInMainComponentSeries.Points.AddXY(item.Key, item.Value);

            foreach (var item in NodesExpectations)
                NodesExpectationsSeries.Points.AddXY(item.Key, item.Value);
        }


        public void VisualizeR(Dictionary<double, double> MeanNumberOfNodesInMainComponent, Dictionary<double, double> NodesExpectations, double n)
        {
            Series MeanNumberOfNodesInMainComponentSeries, NodesExpectationsSeries;

            if (!MeanNumberOfNodesInMainComponentSeriesR.TryGetValue(n, out MeanNumberOfNodesInMainComponentSeries))
            {
                MeanNumberOfNodesInMainComponentSeries = new Series();
                MeanNumberOfNodesInMainComponentSeries.Name = $"n = {n}";
                MeanNumberOfNodesInMainComponentSeries.ChartType = SeriesChartType.Line;
                MeanNumberOfNodesInMainComponentSeries.BorderWidth = 4;
                MeanNumberOfNodesInMainComponentChartR.Series.Add(MeanNumberOfNodesInMainComponentSeries);
                MeanNumberOfNodesInMainComponentChartR.Legends.Add(n.ToString());
                MeanNumberOfNodesInMainComponentSeriesR.Add(n, MeanNumberOfNodesInMainComponentSeries);
            }

            if (!NodesExpectationsSeriesR.TryGetValue(n, out NodesExpectationsSeries))
            {
                NodesExpectationsSeries = new Series();
                NodesExpectationsSeries.Name = $"n = {n}";
                NodesExpectationsSeries.ChartType = SeriesChartType.Line;
                NodesExpectationsSeries.BorderWidth = 5;
                NodesExpectationsChartR.Series.Add(NodesExpectationsSeries);
                Legend legend = NodesExpectationsChartR.Legends.Add(n.ToString());
                NodesExpectationsSeriesR.Add(n, NodesExpectationsSeries);
            }

            MeanNumberOfNodesInMainComponentSeries.Points.DataBindXY(MeanNumberOfNodesInMainComponent.Keys, MeanNumberOfNodesInMainComponent.Values);
            NodesExpectationsSeries.Points.DataBindXY(NodesExpectations.Keys, NodesExpectations.Values);

            MeanNumberOfNodesInMainComponentSeries.Points.Clear();
            NodesExpectationsSeries.Points.Clear();

            foreach (var item in MeanNumberOfNodesInMainComponent)
                MeanNumberOfNodesInMainComponentSeries.Points.AddXY(item.Key, item.Value);

            foreach (var item in NodesExpectations)
                NodesExpectationsSeries.Points.AddXY(item.Key, item.Value);
        }
    }
}
