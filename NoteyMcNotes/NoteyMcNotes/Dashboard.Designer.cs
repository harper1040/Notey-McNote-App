namespace NoteyMcNotes
{
    partial class Dashboard
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
            labelDescript = new Label();
            buttonLogout = new Button();
            groupDashboard = new GroupBox();
            buttonApply = new Button();
            labelColor = new Label();
            trackColorMode = new TrackBar();
            groupDashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackColorMode).BeginInit();
            SuspendLayout();
            // 
            // labelDescript
            // 
            labelDescript.AutoSize = true;
            labelDescript.Location = new Point(17, 54);
            labelDescript.Name = "labelDescript";
            labelDescript.Size = new Size(176, 20);
            labelDescript.TabIndex = 4;
            labelDescript.Text = "Change your color mode.";
            // 
            // buttonLogout
            // 
            buttonLogout.Location = new Point(40, 311);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Size = new Size(130, 29);
            buttonLogout.TabIndex = 3;
            buttonLogout.Text = "LogOut";
            buttonLogout.UseVisualStyleBackColor = true;
            buttonLogout.Click += buttonLogout_Click;
            // 
            // groupDashboard
            // 
            groupDashboard.Controls.Add(buttonApply);
            groupDashboard.Controls.Add(labelColor);
            groupDashboard.Controls.Add(trackColorMode);
            groupDashboard.Controls.Add(buttonLogout);
            groupDashboard.Controls.Add(labelDescript);
            groupDashboard.Location = new Point(27, 24);
            groupDashboard.Name = "groupDashboard";
            groupDashboard.Size = new Size(217, 396);
            groupDashboard.TabIndex = 3;
            groupDashboard.TabStop = false;
            groupDashboard.Text = "groupBox1";
            // 
            // buttonApply
            // 
            buttonApply.Location = new Point(40, 223);
            buttonApply.Name = "buttonApply";
            buttonApply.Size = new Size(130, 29);
            buttonApply.TabIndex = 2;
            buttonApply.Text = "Apply";
            buttonApply.UseVisualStyleBackColor = true;
            buttonApply.Click += buttonApply_Click;
            // 
            // labelColor
            // 
            labelColor.AutoSize = true;
            labelColor.Location = new Point(80, 177);
            labelColor.Name = "labelColor";
            labelColor.Size = new Size(43, 20);
            labelColor.TabIndex = 5;
            labelColor.Text = "color";
            // 
            // trackColorMode
            // 
            trackColorMode.LargeChange = 3;
            trackColorMode.Location = new Point(40, 109);
            trackColorMode.Maximum = 3;
            trackColorMode.Name = "trackColorMode";
            trackColorMode.Size = new Size(130, 56);
            trackColorMode.TabIndex = 1;
            trackColorMode.Scroll += trackColorMode_Scroll;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(277, 450);
            Controls.Add(groupDashboard);
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Dashboard";
            Load += Dashboard_Load;
            groupDashboard.ResumeLayout(false);
            groupDashboard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackColorMode).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label labelDescript;
        private Button buttonLogout;
        private GroupBox groupDashboard;
        private TrackBar trackColorMode;
        private Label labelColor;
        private Button buttonApply;
    }
}