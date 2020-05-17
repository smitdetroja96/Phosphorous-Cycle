using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form2 : Form
    {
        private int x;
        private int y;
        private int z;

        public Form2()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterScreen;
            MaximizeBox = false;

            this.Closing += new CancelEventHandler(Window1_Closing);


            double[] years = new double[51];
                years[0] = 0;
                years[18] = 0.655;
                double max = years[18] * 1000.0;

                Random rand = new Random();
                //cout<<max<<endl;
                for (int i = 17; i > 0; i--)
                {
                    double temp = rand.Next(0, (int)max);
                    double tmp;
                    if ((max - temp) <= 9 && temp != 0)
                    {
                        double t = max - temp;
                        temp = max + t;
                        tmp = temp / 1000.0;
                        years[i] = tmp;
                        max = temp;
                    }
                    else
                    {
                        i++;
                    }
                }

                max = years[18] * 1000;
                for (int i = 19; i <= 50; i++)
                {
                    Random rand1 = new Random();
                    double temp = rand1.Next(0, (int)max);
                    double tmp = temp * 0.001;
                    if ((max - temp) <= 11 && temp != 0)
                    {
                        tmp = temp / 1000.0;
                        years[i] = tmp;
                        max = temp;
                    }
                    else
                    {
                        i--;
                    }
                }





                double[] pland = new double[51];
                double[] priver = new double[51];
                double[] psediment = new double[51];
                double[] porganic = new double[51];
                double[] pinorganic = new double[51];

                int org_soil = x;
                int uptake = y;


                chart1.Size = new Size(700,500);
                //chart1.Series.Add("River");
                chart1.Series.Add("Land");
                //chart1.Series.Add("Organic");
                //chart1.Series.Add("Inorganic");
                //chart1.Series.Add("Sediment");

                chart1.ChartAreas[0].AxisX.ScaleView.Zoom(2001, 2050);
                chart1.ChartAreas[0].AxisY.ScaleView.Zoom(17,30);

                chart1.ChartAreas[0].CursorX.IsUserEnabled = true;
                chart1.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
                chart1.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
                chart1.ChartAreas[0].RecalculateAxesScale();


                chart1.Series[0].Points.AddXY(2001, 20);
                chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                
                //chart1.Series[1].Points.AddXY(2000, 13);
                //chart1.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                
                //chart1.Series[2].Points.AddXY(2000, 13);
                //chart1.Series[2].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                
                //chart1.Series[3].Points.AddXY(2000, 13);
                //chart1.Series[3].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                
                //chart1.Series[4].Points.AddXY(2000, 13);
                //chart1.Series[4].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            
            for (int year = 1; year <= 500; year++)
                {

                    //year = year - 2000;
                    double River, Land;
                    Random rand2 = new Random();
                    int land = rand2.Next(197, 304 - year/20);
                    Land = (double)land / 11.0;
                    Land = Math.Round(Land, 3);
                /*
                    //-----------------------phosphorus in River
                    Random rand3 = new Random();
                    int river = rand3.Next(790, 1329 - year/3);
                    River = (double)river / 100.0;
                    River = Math.Round(River, 3);

                  /*  while (Land - River <= 10.0)
                    {
                        Random rand4 = new Random();
                        river = rand4.Next(790, 1329);
                        River = (double)river / 100.0;
                        River = Math.Round(River, 3);
                    }

                    //----------------------phosphorus in organic
                    double veggie, Ku, N;
                    Ku = (double)uptake * 1.0;

                    N = (double)org_soil * 1.0;
                    Random rand5 = new Random();
                    int zr = rand5.Next(1640, 1929);

                    Double Zr;
                    Zr = (double)zr / 10.0;
                    veggie = (((Ku * N * years[year] * Land * 1.0) / 0.4) / (Zr * 1.0)) / 2.0;
                    veggie = Math.Round(veggie, 3);

                    Double Inorg;
                    Inorg = Land - veggie - River;
                    Inorg = Math.Round(Inorg, 3);

                    Random rand6 = new Random();
                    int sediment = rand2.Next(1000, 1999);
                    double Sediment = (double)sediment / 100000;
                    Sediment = Sediment * Land;
                    Sediment = Math.Round(Sediment, 3);


                    pland[year] = Land;
                    priver[year] = River;
                    porganic[year] = veggie;
                    pinorganic[year] = Inorg;
                    psediment[year] = Sediment;
                    */
                    //MessageBox.Show((Land - River).ToString());
                   // chart1.Series[0].Points.AddXY(year + 2000, River);
                    //chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                    chart1.Series[0].Points.AddXY(year + 2000, Land);
                    chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                    //chart1.Series[2].Points.AddXY(year + 2000, veggie);
                    //chart1.Series[2].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                    //chart1.Series[3].Points.AddXY(year + 2000, Inorg);
                    //chart1.Series[3].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                    //chart1.Series[3].Points.AddXY(year + 2000, Sediment);
                    //chart1.Series[3].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

                    System.Threading.Thread.Sleep(10);
                
            }
        }

        public Form2(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        void Window1_Closing(object sender, CancelEventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void chart1_Click(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {

            double[] years = new double[51];
            years[0] = 0;
            years[18] = 0.655;
            double max = years[18] * 1000.0;

            Random rand = new Random();
            //cout<<max<<endl;
            for (int i = 17; i > 0; i--)
            {
                double temp = rand.Next(0, (int)max);
                double tmp;
                if ((max - temp) <= 9 && temp != 0)
                {
                    double t = max - temp;
                    temp = max + t;
                    tmp = temp / 1000.0;
                    years[i] = tmp;
                    max = temp;
                }
                else
                {
                    i++;
                }
            }

            max = years[18] * 1000;
            for (int i = 19; i <= 50; i++)
            {
                Random rand1 = new Random();
                double temp = rand1.Next(0, (int)max);
                double tmp = temp * 0.001;
                if ((max - temp) <= 11 && temp != 0)
                {
                    tmp = temp / 1000.0;
                    years[i] = tmp;
                    max = temp;
                }
                else
                {
                    i--;
                }
            }





            double[] pland = new double[51];
            double[] priver = new double[51];
            double[] psediment = new double[51];
            double[] porganic = new double[51];
            double[] pinorganic = new double[51];

           int  org_soil = x;
           int  uptake = y;


            chart1.Size = new Size(800, 600);
            chart1.Series.Add("River1");
            chart1.Series.Add("Land");
            chart1.Series.Add("Organic");
            chart1.Series.Add("Inorganic");
            chart1.Series.Add("Sediment");

            chart1.ChartAreas[0].AxisX.ScaleView.Zoom(2000, 2050);
            chart1.ChartAreas[0].AxisY.ScaleView.Zoom(0, 20);

            chart1.ChartAreas[0].CursorX.IsUserEnabled = true;
            chart1.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
            chart1.ChartAreas[0].AxisX.ScaleView.Zoomable  = true;
            chart1.ChartAreas[0].RecalculateAxesScale();


            chart1.Series[1].Points.AddXY(2000, 13);
            chart1.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

            chart1.Series[2].Points.AddXY(2000, 13);
            chart1.Series[2].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

            chart1.Series[3].Points.AddXY(2000, 13);
            chart1.Series[3].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

            chart1.Series[4].Points.AddXY(2000, 13);
            chart1.Series[4].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

            chart1.Series[5].Points.AddXY(2000, 13);
            chart1.Series[5].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;













            for (int year=1; year<=50; year++)
            {

                //year = year - 2000;
                double River, Land;
                Random rand2 = new Random();
                int land = rand2.Next(197, 304);
                Land = (double)land / 11.0;
                Land = Math.Round(Land, 3);
               
                //-----------------------phosphorus in River
                Random rand3 = new Random();
                int river = rand3.Next(790, 1329);
                River = (double)river / 100.0;
                River = Math.Round(River, 3);

                while (Land - River <= 10.0)
                {
                    Random rand4 = new Random();
                    river = rand4.Next(790, 1329);
                    River = (double)river / 100.0;
                    River = Math.Round(River, 3);
                }

                //----------------------phosphorus in organic
                double veggie, Ku, N;
                Ku = (double)uptake * 1.0;

                N = (double)org_soil * 1.0;
                Random rand5 = new Random();
                int zr = rand5.Next(1640, 1929);

                Double Zr;
                Zr = (double)zr / 10.0;
                veggie = (((Ku * N * years[year] * Land * 1.0) / 0.4) / (Zr * 1.0)) / 2.0;
                veggie = Math.Round(veggie, 3);

                Double Inorg;
                Inorg = Land - veggie - River;
                Inorg = Math.Round(Inorg, 3);




                pland[year] = Land;
                priver[year] = River;
                porganic[year] = veggie;
                pinorganic[year] = Inorg;
                psediment[year] = 0;

                chart1.Series[1].Points.AddXY(year+2000, River);
                chart1.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                chart1.Series[2].Points.AddXY(year + 2000, priver[year]);
                chart1.Series[2].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                chart1.Series[3].Points.AddXY(year + 2000, psediment[year]);
                chart1.Series[3].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                chart1.Series[4].Points.AddXY(year + 2000, porganic[year]);
                chart1.Series[4].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                chart1.Series[5].Points.AddXY(year + 2000, pinorganic[year]);
                chart1.Series[5].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

                System.Threading.Thread.Sleep(10);



            }
            

            for (int i = 0; i < 50; i++)
            {

            }
        /*   
            chart1.Series["Series1"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart1.Series["Series1"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart1.Series["Series1"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart1.Series["Series1"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            */

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form3 ss = new Form3();
            ss.Show();
            this.Hide();
        }
    }
}
