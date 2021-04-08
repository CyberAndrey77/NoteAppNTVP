
namespace NoteAppUI
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.addNoteToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.editNoteToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.removeNoteToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.labelException = new System.Windows.Forms.Label();
            this.buttonRemoveNote = new System.Windows.Forms.Button();
            this.buttonEditNote = new System.Windows.Forms.Button();
            this.buttonAddNote = new System.Windows.Forms.Button();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.notesListBox = new System.Windows.Forms.ListBox();
            this.labelShowCategory = new System.Windows.Forms.Label();
            this.modifiedLabel = new System.Windows.Forms.Label();
            this.createdLabel = new System.Windows.Forms.Label();
            this.noteTextRichTextBox = new System.Windows.Forms.RichTextBox();
            this.labelDataLastModifed = new System.Windows.Forms.Label();
            this.labelDataCreated = new System.Windows.Forms.Label();
            this.categorylabel = new System.Windows.Forms.Label();
            this.labelCategory = new System.Windows.Forms.Label();
            this.nameNoteLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenu,
            this.editToolStripMenu,
            this.helpToolStripMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1114, 30);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenu
            // 
            this.fileToolStripMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenu});
            this.fileToolStripMenu.Name = "fileToolStripMenu";
            this.fileToolStripMenu.Size = new System.Drawing.Size(46, 26);
            this.fileToolStripMenu.Text = "File";
            // 
            // exitToolStripMenu
            // 
            this.exitToolStripMenu.Name = "exitToolStripMenu";
            this.exitToolStripMenu.Size = new System.Drawing.Size(116, 26);
            this.exitToolStripMenu.Text = "Exit";
            this.exitToolStripMenu.Click += new System.EventHandler(this.exitToolStripMenu_Click);
            // 
            // editToolStripMenu
            // 
            this.editToolStripMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNoteToolStripMenu,
            this.editNoteToolStripMenu,
            this.removeNoteToolStripMenu});
            this.editToolStripMenu.Name = "editToolStripMenu";
            this.editToolStripMenu.Size = new System.Drawing.Size(49, 26);
            this.editToolStripMenu.Text = "Edit";
            // 
            // addNoteToolStripMenu
            // 
            this.addNoteToolStripMenu.Name = "addNoteToolStripMenu";
            this.addNoteToolStripMenu.Size = new System.Drawing.Size(215, 26);
            this.addNoteToolStripMenu.Text = "Add Note";
            this.addNoteToolStripMenu.Click += new System.EventHandler(this.addNoteToolStripMenu_Click);
            // 
            // editNoteToolStripMenu
            // 
            this.editNoteToolStripMenu.Name = "editNoteToolStripMenu";
            this.editNoteToolStripMenu.Size = new System.Drawing.Size(215, 26);
            this.editNoteToolStripMenu.Text = "Edit Note";
            this.editNoteToolStripMenu.Click += new System.EventHandler(this.editNoteToolStripMenu_Click);
            // 
            // removeNoteToolStripMenu
            // 
            this.removeNoteToolStripMenu.Name = "removeNoteToolStripMenu";
            this.removeNoteToolStripMenu.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.removeNoteToolStripMenu.Size = new System.Drawing.Size(215, 26);
            this.removeNoteToolStripMenu.Text = "Remove Note";
            this.removeNoteToolStripMenu.Click += new System.EventHandler(this.removeNoteToolStripMenu_Click);
            // 
            // helpToolStripMenu
            // 
            this.helpToolStripMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenu});
            this.helpToolStripMenu.Name = "helpToolStripMenu";
            this.helpToolStripMenu.Size = new System.Drawing.Size(55, 26);
            this.helpToolStripMenu.Text = "Help";
            // 
            // aboutToolStripMenu
            // 
            this.aboutToolStripMenu.Name = "aboutToolStripMenu";
            this.aboutToolStripMenu.Size = new System.Drawing.Size(133, 26);
            this.aboutToolStripMenu.Text = "About";
            this.aboutToolStripMenu.Click += new System.EventHandler(this.aboutToolStripMenu_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(0, 28);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.Controls.Add(this.labelException);
            this.splitContainer1.Panel1.Controls.Add(this.buttonRemoveNote);
            this.splitContainer1.Panel1.Controls.Add(this.buttonEditNote);
            this.splitContainer1.Panel1.Controls.Add(this.buttonAddNote);
            this.splitContainer1.Panel1.Controls.Add(this.categoryComboBox);
            this.splitContainer1.Panel1.Controls.Add(this.notesListBox);
            this.splitContainer1.Panel1.Controls.Add(this.labelShowCategory);
            this.splitContainer1.Panel1MinSize = 160;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.modifiedLabel);
            this.splitContainer1.Panel2.Controls.Add(this.createdLabel);
            this.splitContainer1.Panel2.Controls.Add(this.noteTextRichTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.labelDataLastModifed);
            this.splitContainer1.Panel2.Controls.Add(this.labelDataCreated);
            this.splitContainer1.Panel2.Controls.Add(this.categorylabel);
            this.splitContainer1.Panel2.Controls.Add(this.labelCategory);
            this.splitContainer1.Panel2.Controls.Add(this.nameNoteLabel);
            this.splitContainer1.Panel2MinSize = 320;
            this.splitContainer1.Size = new System.Drawing.Size(1114, 555);
            this.splitContainer1.SplitterDistance = 355;
            this.splitContainer1.TabIndex = 1;
            // 
            // labelException
            // 
            this.labelException.AutoSize = true;
            this.labelException.ForeColor = System.Drawing.Color.Red;
            this.labelException.Location = new System.Drawing.Point(6, 494);
            this.labelException.Name = "labelException";
            this.labelException.Size = new System.Drawing.Size(0, 17);
            this.labelException.TabIndex = 6;
            // 
            // buttonRemoveNote
            // 
            this.buttonRemoveNote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonRemoveNote.FlatAppearance.BorderSize = 0;
            this.buttonRemoveNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemoveNote.Image = global::NoteAppUI.Properties.Resources.RemoveGuide_16x;
            this.buttonRemoveNote.Location = new System.Drawing.Point(83, 517);
            this.buttonRemoveNote.Name = "buttonRemoveNote";
            this.buttonRemoveNote.Size = new System.Drawing.Size(33, 27);
            this.buttonRemoveNote.TabIndex = 6;
            this.buttonRemoveNote.UseVisualStyleBackColor = true;
            this.buttonRemoveNote.Click += new System.EventHandler(this.removeNoteButton_Click);
            // 
            // buttonEditNote
            // 
            this.buttonEditNote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonEditNote.FlatAppearance.BorderSize = 0;
            this.buttonEditNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditNote.Image = global::NoteAppUI.Properties.Resources.EditDocument_16x;
            this.buttonEditNote.Location = new System.Drawing.Point(45, 517);
            this.buttonEditNote.Name = "buttonEditNote";
            this.buttonEditNote.Size = new System.Drawing.Size(33, 27);
            this.buttonEditNote.TabIndex = 5;
            this.buttonEditNote.UseVisualStyleBackColor = true;
            this.buttonEditNote.Click += new System.EventHandler(this.editNoteButton_Click);
            // 
            // buttonAddNote
            // 
            this.buttonAddNote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAddNote.FlatAppearance.BorderSize = 0;
            this.buttonAddNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddNote.Image = global::NoteAppUI.Properties.Resources.AddDocument_16x;
            this.buttonAddNote.Location = new System.Drawing.Point(6, 517);
            this.buttonAddNote.Name = "buttonAddNote";
            this.buttonAddNote.Size = new System.Drawing.Size(33, 27);
            this.buttonAddNote.TabIndex = 4;
            this.buttonAddNote.UseVisualStyleBackColor = true;
            this.buttonAddNote.Click += new System.EventHandler(this.addNoteButton_Click);
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.categoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(116, 5);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(236, 24);
            this.categoryComboBox.TabIndex = 2;
            this.categoryComboBox.SelectedIndexChanged += new System.EventHandler(this.categoryComboBox_SelectedIndexChanged);
            // 
            // notesListBox
            // 
            this.notesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.notesListBox.BackColor = System.Drawing.SystemColors.MenuBar;
            this.notesListBox.FormattingEnabled = true;
            this.notesListBox.ItemHeight = 16;
            this.notesListBox.Location = new System.Drawing.Point(6, 47);
            this.notesListBox.Name = "notesListBox";
            this.notesListBox.Size = new System.Drawing.Size(346, 452);
            this.notesListBox.TabIndex = 3;
            this.notesListBox.SelectedIndexChanged += new System.EventHandler(this.notesListBox_SelectedIndexChanged);
            // 
            // labelShowCategory
            // 
            this.labelShowCategory.AutoSize = true;
            this.labelShowCategory.Location = new System.Drawing.Point(3, 10);
            this.labelShowCategory.Name = "labelShowCategory";
            this.labelShowCategory.Size = new System.Drawing.Size(107, 17);
            this.labelShowCategory.TabIndex = 0;
            this.labelShowCategory.Text = "Show Category:";
            // 
            // modifiedLabel
            // 
            this.modifiedLabel.AutoSize = true;
            this.modifiedLabel.Location = new System.Drawing.Point(351, 67);
            this.modifiedLabel.Name = "modifiedLabel";
            this.modifiedLabel.Size = new System.Drawing.Size(0, 17);
            this.modifiedLabel.TabIndex = 9;
            // 
            // createdLabel
            // 
            this.createdLabel.AutoSize = true;
            this.createdLabel.Location = new System.Drawing.Point(93, 67);
            this.createdLabel.Name = "createdLabel";
            this.createdLabel.Size = new System.Drawing.Size(0, 17);
            this.createdLabel.TabIndex = 8;
            // 
            // noteTextRichTextBox
            // 
            this.noteTextRichTextBox.AcceptsTab = true;
            this.noteTextRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.noteTextRichTextBox.BackColor = System.Drawing.SystemColors.MenuBar;
            this.noteTextRichTextBox.Location = new System.Drawing.Point(18, 99);
            this.noteTextRichTextBox.Name = "noteTextRichTextBox";
            this.noteTextRichTextBox.ReadOnly = true;
            this.noteTextRichTextBox.Size = new System.Drawing.Size(725, 444);
            this.noteTextRichTextBox.TabIndex = 7;
            this.noteTextRichTextBox.Text = "";
            // 
            // labelDataLastModifed
            // 
            this.labelDataLastModifed.AutoSize = true;
            this.labelDataLastModifed.Location = new System.Drawing.Point(273, 67);
            this.labelDataLastModifed.Name = "labelDataLastModifed";
            this.labelDataLastModifed.Size = new System.Drawing.Size(62, 17);
            this.labelDataLastModifed.TabIndex = 4;
            this.labelDataLastModifed.Text = "Modifed:";
            // 
            // labelDataCreated
            // 
            this.labelDataCreated.AutoSize = true;
            this.labelDataCreated.Location = new System.Drawing.Point(15, 67);
            this.labelDataCreated.Name = "labelDataCreated";
            this.labelDataCreated.Size = new System.Drawing.Size(62, 17);
            this.labelDataCreated.TabIndex = 3;
            this.labelDataCreated.Text = "Created:";
            // 
            // categorylabel
            // 
            this.categorylabel.AutoSize = true;
            this.categorylabel.Location = new System.Drawing.Point(93, 38);
            this.categorylabel.Name = "categorylabel";
            this.categorylabel.Size = new System.Drawing.Size(0, 17);
            this.categorylabel.TabIndex = 2;
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Location = new System.Drawing.Point(15, 38);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(69, 17);
            this.labelCategory.TabIndex = 1;
            this.labelCategory.Text = "Category:";
            // 
            // nameNoteLabel
            // 
            this.nameNoteLabel.AutoSize = true;
            this.nameNoteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameNoteLabel.Location = new System.Drawing.Point(13, -1);
            this.nameNoteLabel.Name = "nameNoteLabel";
            this.nameNoteLabel.Size = new System.Drawing.Size(0, 29);
            this.nameNoteLabel.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1114, 583);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1132, 630);
            this.Name = "MainForm";
            this.Text = "NoteApp";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem addNoteToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem editNoteToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem removeNoteToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenu;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label labelShowCategory;
        private System.Windows.Forms.ListBox notesListBox;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.Label labelDataLastModifed;
        private System.Windows.Forms.Label labelDataCreated;
        private System.Windows.Forms.Label categorylabel;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.Label nameNoteLabel;
        private System.Windows.Forms.RichTextBox noteTextRichTextBox;
        private System.Windows.Forms.Button buttonAddNote;
        private System.Windows.Forms.Button buttonEditNote;
        private System.Windows.Forms.Button buttonRemoveNote;
        private System.Windows.Forms.Label labelException;
        private System.Windows.Forms.Label modifiedLabel;
        private System.Windows.Forms.Label createdLabel;
    }
}

