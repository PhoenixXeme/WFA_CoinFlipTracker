namespace WFA_CoinFlipTracker
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnWon = new Button();
            tbStartAmount = new TextBox();
            btnStartAmount = new Button();
            label2 = new Label();
            panelTop = new Panel();
            label4 = new Label();
            label3 = new Label();
            cbTopMost = new CheckBox();
            btnLost = new Button();
            lblProfit = new Label();
            label1 = new Label();
            lblDisplayText = new Label();
            tbNextBetAmount = new TextBox();
            btnPatten = new Button();
            label5 = new Label();
            lblTotalProfit = new Label();
            tbOppo = new TextBox();
            label6 = new Label();
            btnTSide = new Button();
            btnCTSide = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            groupBox1 = new GroupBox();
            cbSideSelecter = new CheckBox();
            panelTop.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnWon
            // 
            btnWon.Anchor = AnchorStyles.None;
            btnWon.FlatStyle = FlatStyle.Flat;
            btnWon.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnWon.ForeColor = Color.FromArgb(128, 255, 128);
            btnWon.Location = new Point(40, 147);
            btnWon.Name = "btnWon";
            btnWon.Size = new Size(95, 44);
            btnWon.TabIndex = 0;
            btnWon.Text = "Won";
            btnWon.UseVisualStyleBackColor = true;
            btnWon.Click += btnWon_Click;
            // 
            // tbStartAmount
            // 
            tbStartAmount.Anchor = AnchorStyles.None;
            tbStartAmount.BackColor = Color.FromArgb(61, 61, 61);
            tbStartAmount.BorderStyle = BorderStyle.FixedSingle;
            tbStartAmount.ForeColor = Color.White;
            tbStartAmount.Location = new Point(94, 229);
            tbStartAmount.Name = "tbStartAmount";
            tbStartAmount.Size = new Size(190, 23);
            tbStartAmount.TabIndex = 2;
            tbStartAmount.TextChanged += textBox2_TextChanged;
            // 
            // btnStartAmount
            // 
            btnStartAmount.Anchor = AnchorStyles.None;
            btnStartAmount.FlatStyle = FlatStyle.Flat;
            btnStartAmount.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnStartAmount.ForeColor = Color.White;
            btnStartAmount.Location = new Point(13, 229);
            btnStartAmount.Name = "btnStartAmount";
            btnStartAmount.Size = new Size(75, 23);
            btnStartAmount.TabIndex = 4;
            btnStartAmount.Text = "Enter";
            btnStartAmount.UseVisualStyleBackColor = true;
            btnStartAmount.Click += btnStartAmount_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(72, -2);
            label2.Name = "label2";
            label2.Size = new Size(161, 25);
            label2.TabIndex = 5;
            label2.Text = "Coin Flip Tracker";
            // 
            // panelTop
            // 
            panelTop.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelTop.BackColor = Color.FromArgb(61, 61, 61);
            panelTop.Controls.Add(label4);
            panelTop.Controls.Add(label3);
            panelTop.Controls.Add(label2);
            panelTop.Controls.Add(cbTopMost);
            panelTop.Location = new Point(-5, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(304, 42);
            panelTop.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(87, 23);
            label4.Name = "label4";
            label4.Size = new Size(129, 15);
            label4.TabIndex = 12;
            label4.Text = "Made by PhoenixXeme";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 24);
            label3.Name = "label3";
            label3.Size = new Size(28, 15);
            label3.TabIndex = 6;
            label3.Text = "v0.9";
            // 
            // cbTopMost
            // 
            cbTopMost.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cbTopMost.AutoSize = true;
            cbTopMost.FlatStyle = FlatStyle.Popup;
            cbTopMost.Location = new Point(224, 21);
            cbTopMost.Name = "cbTopMost";
            cbTopMost.Size = new Size(73, 19);
            cbTopMost.TabIndex = 6;
            cbTopMost.Text = "Top Most";
            cbTopMost.UseVisualStyleBackColor = true;
            cbTopMost.CheckedChanged += cbTopMost_CheckedChanged;
            // 
            // btnLost
            // 
            btnLost.Anchor = AnchorStyles.None;
            btnLost.FlatStyle = FlatStyle.Flat;
            btnLost.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnLost.ForeColor = Color.Red;
            btnLost.Location = new Point(163, 147);
            btnLost.Name = "btnLost";
            btnLost.Size = new Size(95, 44);
            btnLost.TabIndex = 0;
            btnLost.Text = "Lost";
            btnLost.UseVisualStyleBackColor = true;
            btnLost.Click += btnLost_Click;
            // 
            // lblProfit
            // 
            lblProfit.AutoSize = true;
            lblProfit.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblProfit.ForeColor = Color.White;
            lblProfit.Location = new Point(59, 1);
            lblProfit.Name = "lblProfit";
            lblProfit.Size = new Size(23, 25);
            lblProfit.TabIndex = 7;
            lblProfit.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(65, 25);
            label1.TabIndex = 8;
            label1.Text = "Profit:";
            // 
            // lblDisplayText
            // 
            lblDisplayText.Anchor = AnchorStyles.Top;
            lblDisplayText.AutoSize = true;
            lblDisplayText.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDisplayText.Location = new Point(90, 63);
            lblDisplayText.Name = "lblDisplayText";
            lblDisplayText.Size = new Size(124, 21);
            lblDisplayText.TabIndex = 9;
            lblDisplayText.Text = "You should bet";
            lblDisplayText.TextAlign = ContentAlignment.MiddleCenter;
            lblDisplayText.Click += label3_Click;
            // 
            // tbNextBetAmount
            // 
            tbNextBetAmount.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbNextBetAmount.BackColor = Color.FromArgb(31, 31, 31);
            tbNextBetAmount.BorderStyle = BorderStyle.None;
            tbNextBetAmount.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            tbNextBetAmount.ForeColor = Color.White;
            tbNextBetAmount.Location = new Point(10, 85);
            tbNextBetAmount.Name = "tbNextBetAmount";
            tbNextBetAmount.ReadOnly = true;
            tbNextBetAmount.Size = new Size(281, 43);
            tbNextBetAmount.TabIndex = 11;
            tbNextBetAmount.TextAlign = HorizontalAlignment.Center;
            // 
            // btnPatten
            // 
            btnPatten.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnPatten.FlatStyle = FlatStyle.Flat;
            btnPatten.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnPatten.Location = new Point(218, 2);
            btnPatten.Name = "btnPatten";
            btnPatten.Size = new Size(75, 23);
            btnPatten.TabIndex = 12;
            btnPatten.Text = "W/L Patten";
            btnPatten.UseVisualStyleBackColor = true;
            btnPatten.Click += btnPatten_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 26);
            label5.Name = "label5";
            label5.Size = new Size(67, 15);
            label5.TabIndex = 13;
            label5.Text = "Total Profit:";
            // 
            // lblTotalProfit
            // 
            lblTotalProfit.AutoSize = true;
            lblTotalProfit.Location = new Point(70, 27);
            lblTotalProfit.Name = "lblTotalProfit";
            lblTotalProfit.Size = new Size(13, 15);
            lblTotalProfit.TabIndex = 14;
            lblTotalProfit.Text = "0";
            // 
            // tbOppo
            // 
            tbOppo.Anchor = AnchorStyles.None;
            tbOppo.BackColor = Color.FromArgb(61, 61, 61);
            tbOppo.BorderStyle = BorderStyle.FixedSingle;
            tbOppo.ForeColor = Color.White;
            tbOppo.Location = new Point(94, 200);
            tbOppo.Name = "tbOppo";
            tbOppo.Size = new Size(190, 23);
            tbOppo.TabIndex = 15;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(16, 203);
            label6.Name = "label6";
            label6.Size = new Size(70, 17);
            label6.TabIndex = 16;
            label6.Text = "Opponent";
            label6.Click += label6_Click;
            // 
            // btnTSide
            // 
            btnTSide.FlatStyle = FlatStyle.Flat;
            btnTSide.Location = new Point(8, 44);
            btnTSide.Name = "btnTSide";
            btnTSide.Size = new Size(31, 23);
            btnTSide.TabIndex = 17;
            btnTSide.Text = "T";
            btnTSide.UseVisualStyleBackColor = true;
            btnTSide.Click += btnTSide_Click;
            // 
            // btnCTSide
            // 
            btnCTSide.FlatStyle = FlatStyle.Flat;
            btnCTSide.Location = new Point(43, 44);
            btnCTSide.Name = "btnCTSide";
            btnCTSide.Size = new Size(31, 23);
            btnCTSide.TabIndex = 17;
            btnCTSide.Text = "CT";
            btnCTSide.UseVisualStyleBackColor = true;
            btnCTSide.Click += btnCTSide_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(-5, 41);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(304, 289);
            tabControl1.TabIndex = 18;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.FromArgb(31, 31, 31);
            tabPage1.Controls.Add(btnLost);
            tabPage1.Controls.Add(btnCTSide);
            tabPage1.Controls.Add(tbStartAmount);
            tabPage1.Controls.Add(btnTSide);
            tabPage1.Controls.Add(btnStartAmount);
            tabPage1.Controls.Add(lblDisplayText);
            tabPage1.Controls.Add(btnWon);
            tabPage1.Controls.Add(tbNextBetAmount);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(tbOppo);
            tabPage1.Controls.Add(btnPatten);
            tabPage1.Controls.Add(lblTotalProfit);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(lblProfit);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(296, 261);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Main";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.FromArgb(31, 31, 31);
            tabPage2.Controls.Add(groupBox1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(296, 261);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Settings";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbSideSelecter);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(6, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(284, 252);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Settings";
            // 
            // cbSideSelecter
            // 
            cbSideSelecter.AutoSize = true;
            cbSideSelecter.Checked = true;
            cbSideSelecter.CheckState = CheckState.Checked;
            cbSideSelecter.FlatStyle = FlatStyle.Flat;
            cbSideSelecter.Location = new Point(7, 22);
            cbSideSelecter.Name = "cbSideSelecter";
            cbSideSelecter.Size = new Size(89, 19);
            cbSideSelecter.TabIndex = 0;
            cbSideSelecter.Text = "Side Selecter";
            cbSideSelecter.UseVisualStyleBackColor = true;
            cbSideSelecter.CheckedChanged += cbSideSlecter_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 31, 31);
            ClientSize = new Size(295, 323);
            Controls.Add(tabControl1);
            Controls.Add(panelTop);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(311, 362);
            MinimizeBox = false;
            MinimumSize = new Size(311, 362);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Coin Flip Tracker";
            Load += Form1_Load;
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnWon;
        private TextBox tbStartAmount;
        private Button btnStartAmount;
        private Label label2;
        private Button btnLost;
        private Label lblProfit;
        private Label label1;
        private Label lblDisplayText;
        private TextBox tbNextBetAmount;
        private CheckBox cbTopMost;
        private Panel panelTop;
        private Label label4;
        private Label label3;
        private Button btnPatten;
        private Label label5;
        private Label lblTotalProfit;
        private TextBox tbOppo;
        private Label label6;
        private Button btnTSide;
        private Button btnCTSide;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private GroupBox groupBox1;
        private CheckBox cbSideSelecter;
    }
}