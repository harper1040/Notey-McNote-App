namespace NoteyMcNotes
{
    partial class MoveNote
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
            labelCurrentNote = new Label();
            textBoxCurNote = new TextBox();
            buttonMove = new Button();
            comboBoxNewCat = new ComboBox();
            textBoxCurCat = new TextBox();
            labelCurrentCat = new Label();
            labelNewCat = new Label();
            buttonCancel = new Button();
            SuspendLayout();
            // 
            // labelCurrentNote
            // 
            labelCurrentNote.AutoSize = true;
            labelCurrentNote.Location = new Point(24, 32);
            labelCurrentNote.Name = "labelCurrentNote";
            labelCurrentNote.Size = new Size(133, 20);
            labelCurrentNote.TabIndex = 0;
            labelCurrentNote.Text = "Note To Be Moved";
            // 
            // textBoxCurNote
            // 
            textBoxCurNote.BackColor = SystemColors.Window;
            textBoxCurNote.Location = new Point(24, 55);
            textBoxCurNote.Name = "textBoxCurNote";
            textBoxCurNote.ReadOnly = true;
            textBoxCurNote.Size = new Size(241, 27);
            textBoxCurNote.TabIndex = 1;
            textBoxCurNote.TabStop = false;
            // 
            // buttonMove
            // 
            buttonMove.Location = new Point(288, 112);
            buttonMove.Name = "buttonMove";
            buttonMove.Size = new Size(94, 29);
            buttonMove.TabIndex = 4;
            buttonMove.Text = "Move";
            buttonMove.UseVisualStyleBackColor = true;
            buttonMove.Click += buttonMove_Click;
            // 
            // comboBoxNewCat
            // 
            comboBoxNewCat.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxNewCat.FormattingEnabled = true;
            comboBoxNewCat.Location = new Point(554, 54);
            comboBoxNewCat.Name = "comboBoxNewCat";
            comboBoxNewCat.Size = new Size(199, 28);
            comboBoxNewCat.TabIndex = 3;
            // 
            // textBoxCurCat
            // 
            textBoxCurCat.BackColor = SystemColors.Window;
            textBoxCurCat.Location = new Point(288, 55);
            textBoxCurCat.Name = "textBoxCurCat";
            textBoxCurCat.ReadOnly = true;
            textBoxCurCat.Size = new Size(241, 27);
            textBoxCurCat.TabIndex = 2;
            textBoxCurCat.TabStop = false;
            // 
            // labelCurrentCat
            // 
            labelCurrentCat.AutoSize = true;
            labelCurrentCat.Location = new Point(288, 32);
            labelCurrentCat.Name = "labelCurrentCat";
            labelCurrentCat.Size = new Size(121, 20);
            labelCurrentCat.TabIndex = 5;
            labelCurrentCat.Text = "Current Category";
            // 
            // labelNewCat
            // 
            labelNewCat.AutoSize = true;
            labelNewCat.Location = new Point(554, 32);
            labelNewCat.Name = "labelNewCat";
            labelNewCat.Size = new Size(103, 20);
            labelNewCat.TabIndex = 6;
            labelNewCat.Text = "New Category";
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(435, 112);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(94, 29);
            buttonCancel.TabIndex = 5;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // MoveNote
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(787, 155);
            Controls.Add(buttonCancel);
            Controls.Add(labelNewCat);
            Controls.Add(labelCurrentCat);
            Controls.Add(textBoxCurCat);
            Controls.Add(comboBoxNewCat);
            Controls.Add(buttonMove);
            Controls.Add(textBoxCurNote);
            Controls.Add(labelCurrentNote);
            Name = "MoveNote";
            StartPosition = FormStartPosition.CenterParent;
            Text = "MoveNote";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelCurrentNote;
        private TextBox textBoxCurNote;
        private Button buttonMove;
        private ComboBox comboBoxNewCat;
        private TextBox textBoxCurCat;
        private Label labelCurrentCat;
        private Label labelNewCat;
        private Button buttonCancel;
    }
}