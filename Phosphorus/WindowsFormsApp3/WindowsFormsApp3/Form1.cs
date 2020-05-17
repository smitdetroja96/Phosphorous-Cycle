using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int timeleft1 = 99;
        int timeleft2 = 100;
        int timeleft3 = 100;
        int timeleft4 = 100;
        int timeleft5 = 100;
        int timeleft6 = 100;
        int timeleft7 = 100;

        int x, y, z;
        int org_soil, uptake, year;
        string s;
        double[] years = new double[51];
        double[] pland = new double[51];
        double[] priver = new double[51];
        double[] psediment = new double[51];
        double[] porganic = new double[51];
        double[] pinorganic = new double[51];



        public Form1()
        {
            
        }

        public Form1(int x, int y, int z)
        {

            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterScreen;
            MaximizeBox = false;

            this.Closing += new CancelEventHandler(Window1_Closing);

            

            //--------------------------------soilmoisture


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
            

            this.x = x;
            this.y = y;
            this.z = z;
        }


        void Window1_Closing(object sender, CancelEventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }


        //--------------------------------For mountain to soil
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (timeleft1 > 0)
            {
                timeleft1 = timeleft1 - 1;
                ovalShape2.Location = new Point(ovalShape2.Location.X - 3, ovalShape2.Location.Y+3);
                ovalShape1.Location = new Point(ovalShape1.Location.X + 4, ovalShape1.Location.Y+3);
            }

            else
            {
                timer1.Stop();
                button3.Show();
                button6.Show();
                ovalShape2.Hide();
                ovalShape1.Hide();
                ovalShape3.Location = new Point(ovalShape2.Location.X, ovalShape2.Location.Y);
                ovalShape4.Location = new Point(ovalShape2.Location.X, ovalShape2.Location.Y);
                ovalShape1.Location = new Point(ovalShape2.Location.X, ovalShape2.Location.Y);
                timer2.Start();
                //timeleft1 = 100;
            }

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if(timeleft7>0)
            {
                timeleft7 = timeleft7 - 1;
            }
            else
            {
                timer2.Stop();
                ovalShape3.Show();
                ovalShape4.Show();
                timer3.Start();
                //timeleft7 = 100;
            }
        }
        //--------------------------------For soil to inorganic and organic
        private void timer3_Tick(object sender, EventArgs e)
        {
            if (timeleft3 > 0)
            {

                timeleft3 = timeleft3 - 1;
                ovalShape4.Location = new Point(ovalShape4.Location.X + 2, ovalShape4.Location.Y);
                ovalShape3.Location = new Point(ovalShape3.Location.X + 7, ovalShape3.Location.Y - 1);
            }


            else
            {
                timer3.Stop();
                button4.Show();
                button5.Show();
                ovalShape3.Hide();
                ovalShape4.Hide();
                ovalShape6.Location = new Point(ovalShape4.Location.X+1, ovalShape4.Location.Y);
                ovalShape7.Location = new Point(ovalShape3.Location.X + 2, ovalShape3.Location.Y + 7);
                timer5.Start();
                //timeleft3 = 100;
            }

        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            if (timeleft2 > 0)
            {
                timeleft2 = timeleft2 - 1;
            }
            else
            {
                timer5.Stop();
                ovalShape7.Show();
                ovalShape6.Show();
                timer4.Start();
                //timeleft2 = 100;
            }
        }



        //--------------------------------For inorganic and organic to water
        private void timer4_Tick(object sender, EventArgs e)
        {
            if (timeleft4 > 0)
            {
                timeleft4 = timeleft4 - 1;
                ovalShape6.Location = new Point(ovalShape6.Location.X + 5, ovalShape6.Location.Y);
                ovalShape7.Location = new Point(ovalShape7.Location.X, ovalShape7.Location.Y + 1);

            }
            else
            {
                timer4.Stop();
                ovalShape6.Hide();
                ovalShape7.Hide();
                ovalShape5.Location = new Point(ovalShape6.Location.X, ovalShape6.Location.Y);
                timer7.Start();
                //timeleft4 = 100;
            }
        }

        private void timer7_Tick(object sender, EventArgs e)
        {
            if (timeleft6 > 0)
            {
                timeleft6 = timeleft6 - 1;
            }

            else
            {
                timer7.Stop();
                ovalShape5.Show();
                timer6.Start();
                //timeleft6 = 100;
            }

        }


        //--------------------------------For water to sadiments
        private void timer6_Tick(object sender, EventArgs e)
        {
            if (timeleft5 > 0)
            {

                timeleft5 = timeleft5 - 1;
                ovalShape5.Location = new Point(ovalShape5.Location.X-4, ovalShape5.Location.Y+1);

            }
            else
            {
                button7.Show();
                ovalShape5.Hide();
                timer6.Stop();
                richTextBox1.Show();
                richTextBox2.Show();
                richTextBox3.Show();
                richTextBox4.Show();
                richTextBox5.Show();
                //timeleft5 = 100;
            }
                

        }




        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                timeleft1 = 99;
                timeleft2 = 100;
                timeleft3 = 100;
                timeleft4 = 100;
                timeleft5 = 100;
                timeleft6 = 100;
                timeleft7 = 100;

                ovalShape2.Location = new Point(400, 170);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter every values given in menu");
                return;
            }

           
            //-------------------------phosphorus in land
            org_soil = x;
            uptake = y;
            year = z;
            year = year - 2000;
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

            Random rand6 = new Random();
            int sediment = rand2.Next(1000, 1999);
            double Sediment = (double) sediment / 100000;
            Sediment = Sediment * Land;
            Sediment=Math.Round(Sediment,3);

            richTextBox1.Text = Land.ToString()+"*10 ";
            richTextBox1.Select(richTextBox1.Text.Length-1, richTextBox1.Text.Length);
            richTextBox1.SelectionCharOffset = 7;
            richTextBox1.SelectedText = "12";
            richTextBox1.SelectionCharOffset = 0;
            richTextBox1.AppendText(" gm");


            richTextBox2.Text = River.ToString()+"*10 ";
            richTextBox2.Select(richTextBox2.Text.Length - 1, richTextBox2.Text.Length);
            richTextBox2.SelectionCharOffset = 7;
            richTextBox2.SelectedText = "12";
            richTextBox2.SelectionCharOffset = 0;
            richTextBox2.AppendText(" gm");

            richTextBox3.Text = veggie.ToString()+ "*10 ";
            richTextBox3.Select(richTextBox3.Text.Length - 1, richTextBox3.Text.Length);
            richTextBox3.SelectionCharOffset = 7;
            richTextBox3.SelectedText = "12";
            richTextBox3.SelectionCharOffset = 0;
            richTextBox3.AppendText(" gm");


            richTextBox4.Text = Inorg.ToString()+ "*10 ";
            richTextBox4.Select(richTextBox4.Text.Length - 1, richTextBox4.Text.Length);
            richTextBox4.SelectionCharOffset = 7;
            richTextBox4.SelectedText = "12";
            richTextBox4.SelectionCharOffset = 0;
            richTextBox4.AppendText(" gm");

            richTextBox5.Text = Sediment.ToString() + "*10 ";
            richTextBox5.Select(richTextBox5.Text.Length - 1, richTextBox5.Text.Length);
            richTextBox5.SelectionCharOffset = 7;
            richTextBox5.SelectedText = "12";
            richTextBox5.SelectionCharOffset = 0;
            richTextBox5.AppendText(" gm");


            button2.Show();
            timer1.Start();
            ovalShape1.Location = new Point(410, 180);
            ovalShape1.Show();
            ovalShape2.Show();
            button1.Hide();
        }



        private void Form1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void richTextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged_1(object sender, EventArgs e)
        {

        }


        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox4_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void ovalShape2_Click(object sender, EventArgs e)
        {

        }

        private void lineShape4_Click(object sender, EventArgs e)
        {

        }

        private void lineShape3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void richTextBox4_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void richTextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            WindowsFormsApp3.Form3 ss = new WindowsFormsApp3.Form3();
            ss.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Please click ok and wait till graph appears!!!");
            WindowsFormsApp3.Form2 ss = new WindowsFormsApp3.Form2();
            ss.Show();
            this.Hide();


        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
