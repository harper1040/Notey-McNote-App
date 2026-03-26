namespace NoteyMcNotes
{
    partial class CatAdd
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
            buttonAddCat = new Button();
            textCat = new TextBox();
            buttonCancel = new Button();
            labelCatAdd = new Label();
            SuspendLayout();
            // 
            // buttonAddCat
            // 
            buttonAddCat.Location = new Point(87, 100);
            buttonAddCat.Name = "buttonAddCat";
            buttonAddCat.Size = new Size(94, 29);
            buttonAddCat.TabIndex = 2;
            buttonAddCat.Text = "ADD";
            buttonAddCat.UseVisualStyleBackColor = true;
            buttonAddCat.Click += buttonAddCat_Click;
            // 
            // textCat
            // 
            textCat.Location = new Point(87, 57);
            textCat.Name = "textCat";
            textCat.Size = new Size(306, 27);
            textCat.TabIndex = 1;
            this.textCat.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnKeyDownHandler);

            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(299, 100);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(94, 29);
            buttonCancel.TabIndex = 3;
            buttonCancel.Text = "CANCEL";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // labelCatAdd
            // 
            labelCatAdd.AutoSize = true;
            labelCatAdd.Location = new Point(109, 24);
            labelCatAdd.Name = "labelCatAdd";
            labelCatAdd.Size = new Size(263, 20);
            labelCatAdd.TabIndex = 3;
            labelCatAdd.Text = "Please enter a name for your category.";
            // 
            // CatAdd
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(508, 151);
            Controls.Add(labelCatAdd);
            Controls.Add(buttonCancel);
            Controls.Add(textCat);
            Controls.Add(buttonAddCat);
            Name = "CatAdd";
            StartPosition = FormStartPosition.CenterParent;
            Text = "AddCat";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonAddCat;
        private TextBox textCat;
        private Button buttonCancel;
        private Label labelCatAdd;
    }
}