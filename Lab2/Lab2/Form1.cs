using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZedGraph;

namespace Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int A, M, R0;
        private int Ny;
        private double Rn_1, Rn, mx, sx, Ly, a, b;
        private int N = 1000000, K = 20;

        private double LehmerAlgorithm()
        {
            Rn_1 = Rn;
            Rn = (A * Rn_1) % M;
            return Rn / M;
        }

        private double TriangleDistribution()
        {
            double R1, R2;
            R1 = LehmerAlgorithm();
            R2 = LehmerAlgorithm();
            double X;
            if (right_button.Checked)
            {
                X = a + (b - a) * Math.Max(R1, R2);
            }
            else
            {
                X = a + (b - a) * Math.Min(R1, R2);
            }

            return X;
        }

        private void CalcHistogram(List<double> Random)
        {
            
            int[] Number = new int[K];
            double[] Values = new double[K];
            double[] Ordinate = new double[K];

            double Rvar = Random.Max() - Random.Min();
            double D = Rvar / K;

            double Left = Random.Min();
            double Right = Left + D;

            for (int i = 0; i < K; i++)
            {
                for (int j = 0; j < Random.Count; j++)
                {
                    if (Random[j] >= Left && Random[j] < Right)
                    {
                        Number[i]++;
                    }
                }

                Values[i] = (Left + Right) / 2;

                Left += D;
                Right += D;

                Ordinate[i] = (double)Number[i] / (double)Random.Count();
            }

            GraphPane pane = BarChart_zedGraph.GraphPane;

            pane.CurveList.Clear();
            pane.Title = "Histogramm";
            pane.XAxis.Title = "Values";
            pane.XAxis.Max = Random.Max() + 0.05 * (Math.Abs(Random.Min()) + Math.Abs(Random.Max()));
            pane.XAxis.Min = Random.Min() - 0.05 * (Math.Abs(Random.Min()) + Math.Abs(Random.Max()));
            pane.YAxis.Title = "P";
            PointPairList Chart = new PointPairList();
            for (int i = 0; i < K; i++)
            {
                Chart.Add(Values[i], Ordinate[i]);
            }
            BarItem curve = pane.AddBar("Histogramm", Chart, Color.Orange);
            pane.MinClusterGap = 0;
            pane.ClusterScaleWidth = D;
            BarChart_zedGraph.AxisChange();
            BarChart_zedGraph.Invalidate();
        }

        private void calcEstimations(List<double> Random)
        {
            double Mx = 0, Dx = 0;

            for (int i = 0; i < N; i++)
            {
                Mx += Random[i];
            }

            Mx /= (double)N;

            for (int i = 0; i < N; i++)
            {
                Dx += Math.Pow((Random[i] - Mx), 2);
            }

            Dx /= N - 1;

            Mx_value.Text = Convert.ToString(Mx);
            Dx_value.Text = Convert.ToString(Dx);
            Sx_value.Text = Convert.ToString(Math.Sqrt(Dx));
        }

        double randomNumber(int method)
        {
            if (method == 0) return uniformDistribution();
            if (method == 1) return gaussianDistribution();
            if (method == 2) return exponentialDistribution();
            if (method == 3) return gammalDistribution();
            if (method == 4) return TriangleDistribution();
            if (method == 5) return simpsonDistribution();
            return 0;
        }

        private void Calculation(int method)
        {           
            List<double> Random = new List<double>();
            A = Convert.ToInt32(AValue.Text);
            M = Convert.ToInt32(MValue.Text);
            R0 = Convert.ToInt32(R0Value.Text);
            a = Convert.ToDouble(a_value.Text);
            b = Convert.ToDouble(b_value.Text);
            mx = Convert.ToDouble(mxTextbox.Text);
            sx = Convert.ToDouble(sxTextBox.Text);
            Ly = Convert.ToDouble(lyTextBox.Text);
            Ny = Convert.ToInt32(nuTextBox.Text);

            Rn = R0;

            for (int i = 0; i < N; i++)
            {
                Random.Add(randomNumber(method));
            }             
            calcEstimations(Random);
            CalcHistogram(Random);

            Random.Clear();
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            int selectedDistribution = functionListBox.SelectedIndex;          
            Calculation(selectedDistribution);
        }

        private void Form1_Load(object sender, EventArgs e)
        {          
            Calculation(0);
        }

        private void right_button_CheckedChanged(object sender, EventArgs e)
        {
            Calculation(4);
        }

        private void left_button_CheckedChanged(object sender, EventArgs e)
        {
            Calculation(4);
        }

        private void functionListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            /*
            this.BarChart_zedGraph.Size = new System.Drawing.Size(this.ClientSize.Width - 20, this.ClientSize.Height - 105);
            this.calcButton.Location = new System.Drawing.Point(this.ClientSize.Width - 80, 7);
            this.AValue.Location = new System.Drawing.Point(this.ClientSize.Width - 170, 7);
            this.MValue.Location = new System.Drawing.Point(this.ClientSize.Width - 170, 37);
            this.R0Value.Location = new System.Drawing.Point(this.ClientSize.Width - 170, 67);
            this.ALabel.Location = new System.Drawing.Point(this.ClientSize.Width - 190, 10);
            this.MLabel.Location = new System.Drawing.Point(this.ClientSize.Width - 190, 40);
            this.R0Label.Location = new System.Drawing.Point(this.ClientSize.Width - 190, 70);*/
        }

        //-------------------------------------------------

        private double uniformDistribution()
        {
            double R1;
            R1 = LehmerAlgorithm();
            double X;

            X = a + (b - a) * R1;

            return X;
        }

        private void calcEstimationsUniformDistribution(List<double> Random)
        {
            double Mx = 0, Dx = 0;

            Mx = ((double)a + (double)b) / 2;

            Dx = Math.Pow(b - a, 2) / 12;

            Mx_value.Text = Convert.ToString(Mx);
            Dx_value.Text = Convert.ToString(Dx);
            Sx_value.Text = Convert.ToString(Math.Sqrt(Dx));
        }

        //-------------------------------------------------

        private double gaussianDistribution()
        {
            List<double> R1 = new List<double>();
            for (int i = 0; i < 12; i++)
            {
                R1.Add(LehmerAlgorithm());
            }
            double X;
            X = mx + sx * (R1.Sum() - 6);

            return X;
        }

        //-------------------------------------------------

        private double exponentialDistribution()
        {
            double R1;
            R1 = LehmerAlgorithm();
            double X;

            X = (-1) * Math.Log(R1) / Ly;

            return X;
        }

        private void calcEstimationsExponentialDistribution(List<double> Random)
        {
            double Mx = 0, Dx = 0;

            Mx = 1 / Ly;

            Dx = Math.Pow(Mx, 2);

            Mx_value.Text = Convert.ToString(Mx);
            Dx_value.Text = Convert.ToString(Dx);
            Sx_value.Text = Convert.ToString(Mx);
        }

        //-------------------------------------------------
        private double gammalDistribution()
        {
            List<double> R1 = new List<double>();
            for (int i = 0; i < Ny; i++)
            {
                R1.Add(LehmerAlgorithm());
            }
            double X, sum = 0;

            for (int i = 0; i < Ny; i++)
            {
                sum += Math.Log(R1[i]);
            }
            X = (-1) * sum / Ly ;
            return X;
        }

        private void calcEstimationsGammalDistribution(List<double> Random)
        {
            double Mx = 0, Dx = 0;

            Mx = (double) Ny / Ly;

            Dx = (double)Ny / Math.Pow(Ly, 2);

            Mx_value.Text = Convert.ToString(Mx);
            Dx_value.Text = Convert.ToString(Dx);
            Sx_value.Text = Convert.ToString(Math.Sqrt(Dx));
        }

        //-------------------------------------------------

        private double simpsonDistribution()
        {
            double R1, R2;
            R1 = LehmerAlgorithm();
            R2 = LehmerAlgorithm();
            double X;

            X = (Math.Max(a, b) - Math.Min(a, b)) * (R1 + R2) / 2 + a;

            return X;
        }

    }
}
