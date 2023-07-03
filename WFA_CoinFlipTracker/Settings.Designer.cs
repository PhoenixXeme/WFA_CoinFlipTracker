namespace WFA_CoinFlipTracker
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            panel1 = new Panel();
            label1 = new Label();
            cbSideSelecter = new CheckBox();
            groupBox1 = new GroupBox();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(61, 61, 61);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-5, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(304, 42);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(107, 8);
            label1.Name = "label1";
            label1.Size = new Size(84, 25);
            label1.TabIndex = 0;
            label1.Text = "Settings";
            // 
            // cbSideSelecter
            // 
            cbSideSelecter.AutoSize = true;
            cbSideSelecter.Checked = true;
            cbSideSelecter.CheckState = CheckState.Checked;
            cbSideSelecter.FlatStyle = FlatStyle.Flat;
            cbSideSelecter.ForeColor = Color.White;
            cbSideSelecter.Location = new Point(6, 22);
            cbSideSelecter.Name = "cbSideSelecter";
            cbSideSelecter.Size = new Size(89, 19);
            cbSideSelecter.TabIndex = 1;
            cbSideSelecter.Text = "Side Selecter";
            cbSideSelecter.UseVisualStyleBackColor = true;
            cbSideSelecter.CheckedChanged += cbSideSelecter_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbSideSelecter);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(12, 49);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(271, 262);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Settings";
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 31, 31);
            ClientSize = new Size(295, 323);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(311, 362);
            MinimizeBox = false;
            MinimumSize = new Size(311, 362);
            Name = "Settings";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Settings";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private CheckBox cbSideSelecter;
        private GroupBox groupBox1;
    }
}