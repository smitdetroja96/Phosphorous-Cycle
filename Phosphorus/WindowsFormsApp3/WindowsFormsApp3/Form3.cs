using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace WindowsFormsApp3
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();


            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterScreen;
            MaximizeBox = false;
            this.Closing += new CancelEventHandler(Window1_Closing); 

            //-------------------------------------listbox1

            // Loop through 3 and 5  items to the ListBox.
            for (int x = 3; x <= 5; x++)
            {
                comboBox1.Items.Add(x);
            }
            // Allow the ListBox to repaint and display the new items.


            //-----------------------------------------listbox2

            for (int x = 7; x <= 14; x++)
            {
                comboBox2.Items.Add(x);
            }


            //-----------------------------------------------listbox3

            for (int x = 2001; x <= 2050; x++)
            {
                comboBox3.Items.Add(x);
            }

        }

        void Window1_Closing(object sender, CancelEventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            int x, y, z;
            try
            {
                x = Int32.Parse(comboBox1.Text);
                y = Int32.Parse(comboBox2.Text);
                z = Int32.Parse(comboBox3.Text);
                if (x >= 3 && x <= 5 && y >= 7 && y <= 14 && z >= 2001 && z <= 2050)
                {
                }
                else
                {
                    MessageBox.Show("Please enter every values given in menu");
                    return;

                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("Please enter every values given in menu");
                return;
            }
            WindowsFormsApp1.Form1 ss = new WindowsFormsApp1.Form1(x,y,z);
            Form2 ss2 = new Form2(x, y, z);

            ss.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 ss = new Form4();
            ss.Show();
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
