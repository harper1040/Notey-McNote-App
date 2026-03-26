namespace NoteyMcNotes
{
    partial class Information
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Information));
            groupInformation = new GroupBox();
            textInfo = new TextBox();
            groupInformation.SuspendLayout();
            SuspendLayout();
            // 
            // groupInformation
            // 
            groupInformation.Controls.Add(textInfo);
            groupInformation.Location = new Point(29, 28);
            groupInformation.Name = "groupInformation";
            groupInformation.Size = new Size(736, 391);
            groupInformation.TabIndex = 0;
            groupInformation.TabStop = false;
            groupInformation.Text = "Information";
            // 
            // textInfo
            // 
            textInfo.BackColor = SystemColors.Window;
            textInfo.Font = new Font("Segoe UI", 11F);
            textInfo.Location = new Point(20, 38);
            textInfo.Multiline = true;
            textInfo.Name = "textInfo";
            textInfo.ReadOnly = true;
            textInfo.ScrollBars = ScrollBars.Vertical;
            textInfo.Size = new Size(694, 330);
            textInfo.TabIndex = 0;
            textInfo.TabStop = false;
            textInfo.Text = resources.GetString("textInfo.Text");
            textInfo.TextAlign = HorizontalAlignment.Center;
            // 
            // Information
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupInformation);
            Name = "Information";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Information";
            groupInformation.ResumeLayout(false);
            groupInformation.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupInformation;
        private TextBox textInfo;
    }
}