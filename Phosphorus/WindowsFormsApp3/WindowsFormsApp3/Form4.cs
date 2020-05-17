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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterScreen;
            MaximizeBox = false;
            try
            {
                string url = @"C:\Program Files (x86)\Group-16\Group16 Phosphorus Setup\intro_final.pdf";
                webBrowser1.Navigate(url);
            }
            catch(Exception ex)
            {
                MessageBox.Show("File does not exist");
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}
