using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_CoinFlipTracker
{
    public partial class Settings : Form
    {
        private Form1 MainForm { get; set; }

        public Settings(Form1 mainForm)
        {
            MainForm = mainForm;
            InitializeComponent();
            cbSideSelecter.Checked = MainForm.ButtonTSide.Visible;

        }

        private void cbSideSelecter_CheckedChanged(object sender, EventArgs e)
        {
            MainForm.ButtonTSide.Visible = cbSideSelecter.Checked;
            MainForm.ButtonCTSide.Visible = cbSideSelecter.Checked;
        }
    }
}