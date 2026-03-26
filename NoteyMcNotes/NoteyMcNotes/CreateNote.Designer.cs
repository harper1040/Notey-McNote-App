namespace NoteyMcNotes
{
    partial class CreateNote
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
            buttonSave = new Button();
            comboBoxCat = new ComboBox();
            label1 = new Label();
            textBoxNote = new TextBox();
            textBoxName = new TextBox();
            label2 = new Label();
            buttonCancel = new Button();
            SuspendLayout();
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(65, 433);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(94, 29);
            buttonSave.TabIndex = 4;
            buttonSave.Text = "SAVE";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // comboBoxCat
            // 
            comboBoxCat.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCat.FormattingEnabled = true;
            comboBoxCat.Location = new Point(287, 41);
            comboBoxCat.Name = "comboBoxCat";
            comboBoxCat.Size = new Size(210, 28);
            comboBoxCat.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 18);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 2;
            label1.Text = "Name";
            // 
            // textBoxNote
            // 
            textBoxNote.Location = new Point(34, 98);
            textBoxNote.Multiline = true;
            textBoxNote.Name = "textBoxNote";
            textBoxNote.Size = new Size(463, 305);
            textBoxNote.TabIndex = 3;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(34, 41);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(235, 27);
            textBoxName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(287, 18);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 5;
            label2.Text = "Category";
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(354, 433);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(94, 29);
            buttonCancel.TabIndex = 5;
            buttonCancel.Text = "CANCEL";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // CreateNote
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(547, 492);
            Controls.Add(buttonCancel);
            Controls.Add(label2);
            Controls.Add(textBoxName);
            Controls.Add(textBoxNote);
            Controls.Add(label1);
            Controls.Add(comboBoxCat);
            Controls.Add(buttonSave);
            Name = "CreateNote";
            StartPosition = FormStartPosition.CenterParent;
            Text = "CreateNote";
            Load += CreateNote_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonSave;
        private ComboBox comboBoxCat;
        private Label label1;
        private TextBox textBoxNote;
        private TextBox textBoxName;
        private Label label2;
        private Button buttonCancel;
    }
}