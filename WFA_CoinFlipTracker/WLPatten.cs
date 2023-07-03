using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WFA_CoinFlipTracker
{
    public partial class WLPatten : Form
    {
        public WLPatten()
        {
            InitializeComponent();
        }

        bool topMost = false;

        private void WLPatten_Load(object sender, EventArgs e)
        {
            ReadFile();
        }

        private void cbTopMostwlp_CheckedChanged(object sender, EventArgs e)
        {
            topMost = !topMost;
            if (topMost)
            {
                topMost = true;
                this.TopMost = true;
            }
            else
            {
                topMost = false;
                this.TopMost = false;
            }
        }

        public void ReadFile()
        {
            string path = "wlp.txt";
            StreamReader sr = new StreamReader(path);

            tbMain.Text = sr.ReadToEnd();
            sr.Close();
            tbMain.Select(0, 0);
        }
    }
}
