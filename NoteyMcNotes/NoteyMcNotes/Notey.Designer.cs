namespace NoteyMcNotes
{
    partial class Notey
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
            listCategory = new ListBox();
            listNotes = new ListBox();
            textName = new TextBox();
            textContent = new TextBox();
            TheStrip = new MenuStrip();
            fileToolStrip = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            addCategoryToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            helpToolStrip = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            LoginItem = new ToolStripMenuItem();
            AddCat = new Button();
            DeleteCat = new Button();
            EditNote = new Button();
            DeleteNote = new Button();
            MoveTo = new Button();
            comboSort = new ComboBox();
            NewNote = new Button();
            ImportCSV = new Button();
            labelName = new Label();
            labelCat = new Label();
            textBoxCat = new TextBox();
            buttonShow = new Button();
            labelNContent = new Label();
            groupBoxCat = new GroupBox();
            groupBoxNote = new GroupBox();
            ExportCSV = new Button();
            checkBoxHeader = new CheckBox();
            TheStrip.SuspendLayout();
            groupBoxCat.SuspendLayout();
            groupBoxNote.SuspendLayout();
            SuspendLayout();
            // 
            // listCategory
            // 
            listCategory.FormattingEnabled = true;
            listCategory.Location = new Point(6, 26);
            listCategory.Name = "listCategory";
            listCategory.Size = new Size(174, 404);
            listCategory.TabIndex = 0;
            listCategory.SelectedIndexChanged += listCategory_SelectedIndexChanged;
            // 
            // listNotes
            // 
            listNotes.FormattingEnabled = true;
            listNotes.Location = new Point(6, 26);
            listNotes.Name = "listNotes";
            listNotes.Size = new Size(291, 404);
            listNotes.TabIndex = 3;
            listNotes.SelectedIndexChanged += listNotes_SelectedIndexChanged;
            // 
            // textName
            // 
            textName.BackColor = SystemColors.Window;
            textName.Location = new Point(545, 67);
            textName.Name = "textName";
            textName.ReadOnly = true;
            textName.Size = new Size(326, 27);
            textName.TabIndex = 7;
            textName.TabStop = false;
            // 
            // textContent
            // 
            textContent.BackColor = SystemColors.Window;
            textContent.Location = new Point(545, 131);
            textContent.Multiline = true;
            textContent.Name = "textContent";
            textContent.ReadOnly = true;
            textContent.Size = new Size(645, 344);
            textContent.TabIndex = 9;
            textContent.TabStop = false;
            // 
            // TheStrip
            // 
            TheStrip.ImageScalingSize = new Size(20, 20);
            TheStrip.Items.AddRange(new ToolStripItem[] { fileToolStrip, helpToolStrip, LoginItem });
            TheStrip.Location = new Point(0, 0);
            TheStrip.Name = "TheStrip";
            TheStrip.Size = new Size(1226, 28);
            TheStrip.TabIndex = 5;
            TheStrip.Text = "TheStrip";
            // 
            // fileToolStrip
            // 
            fileToolStrip.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, addCategoryToolStripMenuItem, exitToolStripMenuItem });
            fileToolStrip.Name = "fileToolStrip";
            fileToolStrip.Size = new Size(46, 24);
            fileToolStrip.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            newToolStripMenuItem.Size = new Size(236, 26);
            newToolStripMenuItem.Text = "New";
            newToolStripMenuItem.Click += newToolStripMenuItem_Click;
            // 
            // addCategoryToolStripMenuItem
            // 
            addCategoryToolStripMenuItem.Name = "addCategoryToolStripMenuItem";
            addCategoryToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.A;
            addCategoryToolStripMenuItem.Size = new Size(236, 26);
            addCategoryToolStripMenuItem.Text = "Add Category";
            addCategoryToolStripMenuItem.Click += addCategoryToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Q;
            exitToolStripMenuItem.Size = new Size(236, 26);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // helpToolStrip
            // 
            helpToolStrip.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
            helpToolStrip.Name = "helpToolStrip";
            helpToolStrip.Size = new Size(55, 24);
            helpToolStrip.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.I;
            aboutToolStripMenuItem.Size = new Size(179, 26);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // LoginItem
            // 
            LoginItem.Alignment = ToolStripItemAlignment.Right;
            LoginItem.Margin = new Padding(0, 0, 15, 0);
            LoginItem.Name = "LoginItem";
            LoginItem.Size = new Size(60, 24);
            LoginItem.Text = "Login";
            LoginItem.Click += LoginItem_Click;
            // 
            // AddCat
            // 
            AddCat.Location = new Point(19, 448);
            AddCat.Name = "AddCat";
            AddCat.Size = new Size(134, 29);
            AddCat.TabIndex = 1;
            AddCat.Text = "Add Category";
            AddCat.UseVisualStyleBackColor = true;
            AddCat.Click += AddCat_Click;
            // 
            // DeleteCat
            // 
            DeleteCat.Location = new Point(19, 483);
            DeleteCat.Name = "DeleteCat";
            DeleteCat.Size = new Size(134, 29);
            DeleteCat.TabIndex = 2;
            DeleteCat.Text = "Delete Category";
            DeleteCat.UseVisualStyleBackColor = true;
            DeleteCat.Click += DeleteCat_Click;
            // 
            // EditNote
            // 
            EditNote.Location = new Point(545, 524);
            EditNote.Name = "EditNote";
            EditNote.Size = new Size(94, 29);
            EditNote.TabIndex = 11;
            EditNote.Text = "Edit";
            EditNote.UseVisualStyleBackColor = true;
            EditNote.Click += EditNote_Click;
            // 
            // DeleteNote
            // 
            DeleteNote.Location = new Point(144, 483);
            DeleteNote.Name = "DeleteNote";
            DeleteNote.Size = new Size(94, 29);
            DeleteNote.TabIndex = 5;
            DeleteNote.Text = "Delete";
            DeleteNote.UseVisualStyleBackColor = true;
            DeleteNote.Click += DeleteNote_Click;
            // 
            // MoveTo
            // 
            MoveTo.Location = new Point(31, 447);
            MoveTo.Name = "MoveTo";
            MoveTo.Size = new Size(94, 29);
            MoveTo.TabIndex = 4;
            MoveTo.Text = "Move To";
            MoveTo.UseVisualStyleBackColor = true;
            MoveTo.Click += MoveTo_Click;
            // 
            // comboSort
            // 
            comboSort.FormattingEnabled = true;
            comboSort.Items.AddRange(new object[] { "Date Asc", "Date Desc" });
            comboSort.Location = new Point(144, 448);
            comboSort.Name = "comboSort";
            comboSort.Size = new Size(123, 28);
            comboSort.TabIndex = 6;
            comboSort.Text = "SORT";
            comboSort.SelectedIndexChanged += comboSort_SelectedIndexChanged;
            // 
            // NewNote
            // 
            NewNote.Location = new Point(31, 483);
            NewNote.Name = "NewNote";
            NewNote.Size = new Size(94, 29);
            NewNote.TabIndex = 10;
            NewNote.Text = "New";
            NewNote.UseVisualStyleBackColor = true;
            NewNote.Click += NewNote_Click;
            // 
            // ImportCSV
            // 
            ImportCSV.Location = new Point(777, 524);
            ImportCSV.Name = "ImportCSV";
            ImportCSV.Size = new Size(94, 29);
            ImportCSV.TabIndex = 12;
            ImportCSV.Text = "Import";
            ImportCSV.UseVisualStyleBackColor = true;
            ImportCSV.Click += ImportCSV_Click;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(545, 44);
            labelName.Name = "labelName";
            labelName.Size = new Size(86, 20);
            labelName.TabIndex = 14;
            labelName.Text = "Note Name";
            // 
            // labelCat
            // 
            labelCat.AutoSize = true;
            labelCat.Location = new Point(920, 43);
            labelCat.Name = "labelCat";
            labelCat.Size = new Size(106, 20);
            labelCat.TabIndex = 15;
            labelCat.Text = "Note Category";
            // 
            // textBoxCat
            // 
            textBoxCat.BackColor = SystemColors.Window;
            textBoxCat.Location = new Point(920, 66);
            textBoxCat.Name = "textBoxCat";
            textBoxCat.ReadOnly = true;
            textBoxCat.Size = new Size(270, 27);
            textBoxCat.TabIndex = 8;
            textBoxCat.TabStop = false;
            // 
            // buttonShow
            // 
            buttonShow.Location = new Point(1096, 524);
            buttonShow.Name = "buttonShow";
            buttonShow.Size = new Size(94, 29);
            buttonShow.TabIndex = 16;
            buttonShow.Text = "Show All Notes";
            buttonShow.UseVisualStyleBackColor = true;
            buttonShow.Visible = false;
            buttonShow.Click += buttonShow_Click;
            // 
            // labelNContent
            // 
            labelNContent.AutoSize = true;
            labelNContent.Location = new Point(545, 108);
            labelNContent.Name = "labelNContent";
            labelNContent.Size = new Size(98, 20);
            labelNContent.TabIndex = 19;
            labelNContent.Text = "Note Content";
            // 
            // groupBoxCat
            // 
            groupBoxCat.Controls.Add(listCategory);
            groupBoxCat.Controls.Add(AddCat);
            groupBoxCat.Controls.Add(DeleteCat);
            groupBoxCat.Location = new Point(12, 43);
            groupBoxCat.Name = "groupBoxCat";
            groupBoxCat.Size = new Size(186, 540);
            groupBoxCat.TabIndex = 20;
            groupBoxCat.TabStop = false;
            groupBoxCat.Text = "Categories";
            // 
            // groupBoxNote
            // 
            groupBoxNote.Controls.Add(listNotes);
            groupBoxNote.Controls.Add(DeleteNote);
            groupBoxNote.Controls.Add(MoveTo);
            groupBoxNote.Controls.Add(comboSort);
            groupBoxNote.Controls.Add(NewNote);
            groupBoxNote.Location = new Point(204, 43);
            groupBoxNote.Name = "groupBoxNote";
            groupBoxNote.Size = new Size(303, 540);
            groupBoxNote.TabIndex = 21;
            groupBoxNote.TabStop = false;
            groupBoxNote.Text = "Notes";
            // 
            // ExportCSV
            // 
            ExportCSV.Location = new Point(664, 524);
            ExportCSV.Name = "ExportCSV";
            ExportCSV.Size = new Size(94, 29);
            ExportCSV.TabIndex = 22;
            ExportCSV.Text = "Export";
            ExportCSV.UseVisualStyleBackColor = true;
            ExportCSV.Click += ExportCSV_Click;
            // 
            // checkBoxHeader
            // 
            checkBoxHeader.AutoSize = true;
            checkBoxHeader.Location = new Point(888, 526);
            checkBoxHeader.Name = "checkBoxHeader";
            checkBoxHeader.Size = new Size(93, 24);
            checkBoxHeader.TabIndex = 23;
            checkBoxHeader.Text = "Headers?";
            checkBoxHeader.UseVisualStyleBackColor = true;
            // 
            // Notey
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1226, 600);
            Controls.Add(checkBoxHeader);
            Controls.Add(ExportCSV);
            Controls.Add(groupBoxNote);
            Controls.Add(groupBoxCat);
            Controls.Add(labelNContent);
            Controls.Add(buttonShow);
            Controls.Add(textBoxCat);
            Controls.Add(labelCat);
            Controls.Add(labelName);
            Controls.Add(ImportCSV);
            Controls.Add(EditNote);
            Controls.Add(textContent);
            Controls.Add(textName);
            Controls.Add(TheStrip);
            MainMenuStrip = TheStrip;
            Name = "Notey";
            Text = "NoteyMcNote";
            Load += Notey_Load;
            TheStrip.ResumeLayout(false);
            TheStrip.PerformLayout();
            groupBoxCat.ResumeLayout(false);
            groupBoxNote.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listCategory;
        private ListBox listNotes;
        private TextBox textName;
        private TextBox textContent;
        private MenuStrip TheStrip;
        private ToolStripMenuItem fileToolStrip;
        private Button AddCat;
        private Button DeleteCat;
        private Button EditNote;
        private Button DeleteNote;
        private Button MoveTo;
        private ComboBox comboSort;
        private Button NewNote;
        private Button ImportCSV;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem addCategoryToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem helpToolStrip;
        private Label labelName;
        private Label labelCat;
        private TextBox textBoxCat;
        private Button buttonShow;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private Label labelNContent;
        private GroupBox groupBoxCat;
        private GroupBox groupBoxNote;
        private ToolStripMenuItem LoginItem;
        private Button ExportCSV;
        private CheckBox checkBoxHeader;
    }
}
