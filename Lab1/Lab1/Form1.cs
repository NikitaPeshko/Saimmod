using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ZedGraph;

namespace Lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int A, M, R0;
        private double Rn_1, Rn;
        private int N = 10000000, K = 20;


        private double LehmerAlgorithm()
        {
            Rn_1 = Rn;
            Rn = (A * Rn_1) % M;
            return Rn / M;
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
            pane.XAxis.Max = 1.1;
            pane.XAxis.Min = -0.1;
            pane.YAxis.Title = "P";
            PointPairList Chart = new PointPairList();
            for (int i = 0; i < K; i++)
            {
                Chart.Add(Values[i], Ordinate[i]);
            }
            BarItem curve = pane.AddBar("Histogramm", Chart, Color.DarkSlateGray);
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

        private void CheckUniformity(List<double> Random)
        {
            int Count = 0;
            for (int i = 0; i < N / 2; i++)
            {
                if (Math.Pow(Random[2 * i], 2) + Math.Pow(Random[2 * i + 1], 2) < 1)
                {
                    Count++;
                }
            }
            Uniformity_value.Text = Convert.ToString(2 * (double)Count / (double)N);

        }

        private void AperiodicInterval(List<double> Random)
        {

            double Xv = LehmerAlgorithm();
            int i1 = -1, i2 = -1;

            int Count = 1;
            bool exit = false;
            for (int i = 0; i < N; i++)
            {
                if (Random[i] == Xv)
                {
                    switch (Count)
                    {
                        case 1:
                            i1 = i;
                            Count++;
                            break;
                        case 2:
                            i2 = i;
                            Count++;
                            break;
                        default:
                            exit = true;
                            break;
                    }
                    if (exit)
                        break;
                }
            }

            int P = i2 - i1;
            int i3 = 0;
            int L;

            if (i1 == -1 || i2 == -1)
            {
                L = Math.Min(N, M);
            }
            else
            {
                for (int i = i2; i > P; i--)
                {
                    if (Random[i] != Random[i-P])
                    {
                        i3 = i;
                        break;
                    }

                }
                if (i3 == 0) i3 = i1;
                L = i3 + P;
            }
            AperiodInterval_value.Text = Convert.ToString(L);
            Period_value.Text = Convert.ToString(P);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<double> Random = new List<double>();
            A = Convert.ToInt32(a_textBox.Text);
            M = Convert.ToInt32(m_textBox.Text);
            R0 = Convert.ToInt32(R0_textBox.Text);
            Rn = R0;

            for (int i = 0; i < N; i++)
            {
                Random.Add(LehmerAlgorithm());
            }

            CalcHistogram(Random);
            calcEstimations(Random);
            CheckUniformity(Random);
            AperiodicInterval(Random);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BarChart_zedGraph.Size = new System.Drawing.Size(this.ClientSize.Width - 20, this.ClientSize.Height - 140);
            Pi_4_value.Text = (Convert.ToString(Math.PI / 4));
            List<double> Random = new List<double>();
            A = Convert.ToInt32(a_textBox.Text);
            M = Convert.ToInt32(m_textBox.Text);
            R0 = Convert.ToInt32(R0_textBox.Text);
            Rn = R0;

            for (int i = 0; i < N; i++)
            {
                Random.Add(LehmerAlgorithm());
            }

            CalcHistogram(Random);
            calcEstimations(Random);
            CheckUniformity(Random);
            AperiodicInterval(Random);
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {

            this.BarChart_zedGraph.Size = new System.Drawing.Size(this.ClientSize.Width - 20, this.ClientSize.Height - 140);
            this.calcButton.Location = new System.Drawing.Point(this.ClientSize.Width - 85, 5);
        }

    }
}
