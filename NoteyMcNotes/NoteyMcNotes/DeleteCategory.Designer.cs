namespace NoteyMcNotes
{
    partial class DeleteCategory
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
            labelMessage = new Label();
            checkDeleteCat = new CheckBox();
            buttonDeleteCat = new Button();
            labelCatName = new Label();
            radioMoveNote = new RadioButton();
            radioDeleteNote = new RadioButton();
            groupRadios = new GroupBox();
            buttonCancel = new Button();
            groupRadios.SuspendLayout();
            SuspendLayout();
            // 
            // labelMessage
            // 
            labelMessage.AutoSize = true;
            labelMessage.Location = new Point(32, 42);
            labelMessage.Name = "labelMessage";
            labelMessage.Size = new Size(223, 20);
            labelMessage.TabIndex = 0;
            labelMessage.Text = "Are you sure you want to delete ";
            // 
            // checkDeleteCat
            // 
            checkDeleteCat.AutoSize = true;
            checkDeleteCat.Checked = true;
            checkDeleteCat.CheckState = CheckState.Checked;
            checkDeleteCat.Location = new Point(54, 78);
            checkDeleteCat.Name = "checkDeleteCat";
            checkDeleteCat.Size = new Size(170, 24);
            checkDeleteCat.TabIndex = 1;
            checkDeleteCat.Text = "Delete this Category!";
            checkDeleteCat.UseVisualStyleBackColor = true;
            checkDeleteCat.CheckedChanged += checkDeleteCat_CheckedChanged;
            // 
            // buttonDeleteCat
            // 
            buttonDeleteCat.Location = new Point(67, 242);
            buttonDeleteCat.Name = "buttonDeleteCat";
            buttonDeleteCat.Size = new Size(94, 29);
            buttonDeleteCat.TabIndex = 4;
            buttonDeleteCat.Text = "Delete";
            buttonDeleteCat.UseVisualStyleBackColor = true;
            buttonDeleteCat.Click += buttonDeleteCat_Click;
            // 
            // labelCatName
            // 
            labelCatName.AutoSize = true;
            labelCatName.Location = new Point(251, 42);
            labelCatName.Name = "labelCatName";
            labelCatName.Size = new Size(0, 20);
            labelCatName.TabIndex = 3;
            // 
            // radioMoveNote
            // 
            radioMoveNote.AutoSize = true;
            radioMoveNote.Location = new Point(16, 56);
            radioMoveNote.Name = "radioMoveNote";
            radioMoveNote.Size = new Size(297, 24);
            radioMoveNote.TabIndex = 3;
            radioMoveNote.Text = "Move Notes to Uncategorized Category!";
            radioMoveNote.UseVisualStyleBackColor = true;
            // 
            // radioDeleteNote
            // 
            radioDeleteNote.AutoSize = true;
            radioDeleteNote.Checked = true;
            radioDeleteNote.Location = new Point(16, 26);
            radioDeleteNote.Name = "radioDeleteNote";
            radioDeleteNote.Size = new Size(248, 24);
            radioDeleteNote.TabIndex = 2;
            radioDeleteNote.TabStop = true;
            radioDeleteNote.Text = "Delete all Notes in this Category!";
            radioDeleteNote.UseVisualStyleBackColor = true;
            // 
            // groupRadios
            // 
            groupRadios.Controls.Add(radioDeleteNote);
            groupRadios.Controls.Add(radioMoveNote);
            groupRadios.Location = new Point(77, 108);
            groupRadios.Name = "groupRadios";
            groupRadios.Size = new Size(328, 103);
            groupRadios.TabIndex = 8;
            groupRadios.TabStop = false;
            groupRadios.Text = "Notes";
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(248, 242);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(94, 29);
            buttonCancel.TabIndex = 5;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // DeleteCategory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(461, 307);
            Controls.Add(buttonCancel);
            Controls.Add(groupRadios);
            Controls.Add(labelCatName);
            Controls.Add(buttonDeleteCat);
            Controls.Add(checkDeleteCat);
            Controls.Add(labelMessage);
            Name = "DeleteCategory";
            StartPosition = FormStartPosition.CenterParent;
            Text = "DeleteCategory";
            groupRadios.ResumeLayout(false);
            groupRadios.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelMessage;
        private CheckBox checkDeleteCat;
        private Button buttonDeleteCat;
        private Label labelCatName;
        private RadioButton radioMoveNote;
        private RadioButton radioDeleteNote;
        private GroupBox groupRadios;
        private Button buttonCancel;
    }
}