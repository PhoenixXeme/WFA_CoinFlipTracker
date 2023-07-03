namespace WFA_CoinFlipTracker
{
    partial class WLPatten
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WLPatten));
            tbMain = new TextBox();
            panel1 = new Panel();
            label6 = new Label();
            cbTopMostwlp = new CheckBox();
            panel2 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // tbMain
            // 
            tbMain.BackColor = Color.FromArgb(31, 31, 31);
            tbMain.BorderStyle = BorderStyle.None;
            tbMain.Dock = DockStyle.Fill;
            tbMain.ForeColor = Color.White;
            tbMain.Location = new Point(0, 0);
            tbMain.Multiline = true;
            tbMain.Name = "tbMain";
            tbMain.ReadOnly = true;
            tbMain.ScrollBars = ScrollBars.Vertical;
            tbMain.Size = new Size(297, 266);
            tbMain.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(61, 61, 61);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(cbTopMostwlp);
            panel1.Location = new Point(-3, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(304, 42);
            panel1.TabIndex = 1;
            // 
            // label6
            // 
            label6.FlatStyle = FlatStyle.Flat;
            label6.ForeColor = Color.White;
            label6.Location = new Point(3, 5);
            label6.Name = "label6";
            label6.Size = new Size(88, 33);
            label6.TabIndex = 16;
            label6.Text = "Martingale System On Top";
            // 
            // cbTopMostwlp
            // 
            cbTopMostwlp.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cbTopMostwlp.AutoSize = true;
            cbTopMostwlp.BackColor = Color.FromArgb(61, 61, 61);
            cbTopMostwlp.FlatStyle = FlatStyle.Popup;
            cbTopMostwlp.ForeColor = Color.White;
            cbTopMostwlp.Location = new Point(218, 19);
            cbTopMostwlp.Name = "cbTopMostwlp";
            cbTopMostwlp.Size = new Size(73, 19);
            cbTopMostwlp.TabIndex = 0;
            cbTopMostwlp.Text = "Top Most";
            cbTopMostwlp.UseVisualStyleBackColor = false;
            cbTopMostwlp.CheckedChanged += cbTopMostwlp_CheckedChanged;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(tbMain);
            panel2.Location = new Point(0, 40);
            panel2.Name = "panel2";
            panel2.Size = new Size(297, 266);
            panel2.TabIndex = 2;
            // 
            // WLPatten
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 31, 31);
            ClientSize = new Size(295, 305);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(311, 900);
            MinimizeBox = false;
            MinimumSize = new Size(311, 344);
            Name = "WLPatten";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Win/Lose Patten";
            Load += WLPatten_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox tbMain;
        private Panel panel1;
        private Panel panel2;
        private CheckBox cbTopMostwlp;
        private Label label6;
    }
}