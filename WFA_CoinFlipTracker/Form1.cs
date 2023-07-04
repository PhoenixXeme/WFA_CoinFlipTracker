using System.DirectoryServices.ActiveDirectory;

namespace WFA_CoinFlipTracker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private WLPatten wlpattenForm;

        int startAmount = 0;
        int betAmount = 0;
        int totalProfit = 0;
        string opponent = "";
        string side = "";
        bool topMost = false;

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        string path = "wlp.txt";

        private void Form1_Load(object sender, EventArgs e)
        {
            StreamWriter sw = File.AppendText(path);
            sw.WriteLine("------------New-Session------------");
            sw.Close();
        }

        private void btnStartAmount_Click(object sender, EventArgs e)
        {
            try
            {
                lblDisplayText.Text = "You should bet";
                startAmount = int.Parse(tbStartAmount.Text);
                betAmount = int.Parse(tbStartAmount.Text);
                lblProfit.Text = startAmount.ToString();
                tbNextBetAmount.Text = betAmount.ToString();
            }
            catch
            {
                lblDisplayText.Text = "Numbers only";
            }
        }

        private void lblNextBetAmount_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnWon_Click(object sender, EventArgs e)
        {
            opponent = tbOppo.Text;
            StreamWriter sw = File.AppendText(path);
            sw.WriteLine($"Won | ${betAmount} | {opponent} {side}");
            sw.Close();

            betAmount = startAmount;
            tbNextBetAmount.Text = betAmount.ToString();
            totalProfit += startAmount;
            lblTotalProfit.Text = totalProfit.ToString();
            wlpattenForm?.ReadFile();
        }

        private void btnLost_Click(object sender, EventArgs e)
        {
            opponent = tbOppo.Text;
            StreamWriter sw = File.AppendText(path);
            sw.WriteLine($"Lost  | ${betAmount} | {opponent} {side}");
            sw.Close();

            betAmount += betAmount;
            tbNextBetAmount.Text = betAmount.ToString();
            wlpattenForm?.ReadFile();
        }

        private void cbTopMost_CheckedChanged(object sender, EventArgs e)
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

        private void btnPatten_Click(object sender, EventArgs e)
        {

            if (wlpattenForm != null && !wlpattenForm.IsDisposed)
            {
                wlpattenForm.Close();
            }
            else
            {
                wlpattenForm = new WLPatten();
                wlpattenForm.Show();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        public void pbSettings_Click(object sender, EventArgs e)
        {

        }

        public void btnTSide_Click(object sender, EventArgs e)
        {
            side = "| T";
        }

        public void btnCTSide_Click(object sender, EventArgs e)
        {
            side = "| CT";
        }

        private void cbSideSlecter_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSideSelecter.Checked)
            {
                btnTSide.Visible = true;
                btnCTSide.Visible = true;
            }
            else
            {
                btnTSide.Visible = false;
                btnCTSide.Visible = false;

                side = "";
            }
        }
    }
}