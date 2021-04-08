
namespace NoteAppUI
{
    partial class NoteForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NoteForm));
            this.labelTitle = new System.Windows.Forms.Label();
            this.nameNoteTextBox = new System.Windows.Forms.TextBox();
            this.labelCategory = new System.Windows.Forms.Label();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.labelDataCreated = new System.Windows.Forms.Label();
            this.labelDateLastModified = new System.Windows.Forms.Label();
            this.noteTextRichTextBox = new System.Windows.Forms.RichTextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.createdLabel = new System.Windows.Forms.Label();
            this.modifiedLabel = new System.Windows.Forms.Label();
            this.nameNoteToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(14, 13);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(39, 17);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Title:";
            // 
            // nameNoteTextBox
            // 
            this.nameNoteTextBox.Location = new System.Drawing.Point(92, 10);
            this.nameNoteTextBox.Name = "nameNoteTextBox";
            this.nameNoteTextBox.Size = new System.Drawing.Size(696, 22);
            this.nameNoteTextBox.TabIndex = 1;
            this.nameNoteTextBox.Text = "Без названия";
            this.nameNoteTextBox.TextChanged += new System.EventHandler(this.nameNoteTextBox_TextChanged);
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Location = new System.Drawing.Point(14, 58);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(69, 17);
            this.labelCategory.TabIndex = 2;
            this.labelCategory.Text = "Category:";
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(92, 53);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(189, 24);
            this.categoryComboBox.TabIndex = 2;
            this.categoryComboBox.SelectedIndexChanged += new System.EventHandler(this.categoryComboBox_SelectedIndexChanged);
            // 
            // labelDataCreated
            // 
            this.labelDataCreated.AutoSize = true;
            this.labelDataCreated.Location = new System.Drawing.Point(14, 92);
            this.labelDataCreated.Name = "labelDataCreated";
            this.labelDataCreated.Size = new System.Drawing.Size(62, 17);
            this.labelDataCreated.TabIndex = 4;
            this.labelDataCreated.Text = "Created:";
            // 
            // labelDateLastModified
            // 
            this.labelDateLastModified.AutoSize = true;
            this.labelDateLastModified.Location = new System.Drawing.Point(290, 92);
            this.labelDateLastModified.Name = "labelDateLastModified";
            this.labelDateLastModified.Size = new System.Drawing.Size(65, 17);
            this.labelDateLastModified.TabIndex = 6;
            this.labelDateLastModified.Text = "Modified:";
            // 
            // noteTextRichTextBox
            // 
            this.noteTextRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.noteTextRichTextBox.Location = new System.Drawing.Point(17, 127);
            this.noteTextRichTextBox.Name = "noteTextRichTextBox";
            this.noteTextRichTextBox.Size = new System.Drawing.Size(771, 496);
            this.noteTextRichTextBox.TabIndex = 3;
            this.noteTextRichTextBox.Text = "";
            this.noteTextRichTextBox.TextChanged += new System.EventHandler(this.noteTextRichTextBox_TextChanged);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(688, 629);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(100, 30);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonOk
            // 
            this.buttonOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOk.Location = new System.Drawing.Point(582, 629);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(100, 30);
            this.buttonOk.TabIndex = 4;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // createdLabel
            // 
            this.createdLabel.AutoSize = true;
            this.createdLabel.Location = new System.Drawing.Point(89, 92);
            this.createdLabel.Name = "createdLabel";
            this.createdLabel.Size = new System.Drawing.Size(56, 17);
            this.createdLabel.TabIndex = 11;
            this.createdLabel.Text = "created";
            // 
            // modifiedLabel
            // 
            this.modifiedLabel.AutoSize = true;
            this.modifiedLabel.Location = new System.Drawing.Point(371, 92);
            this.modifiedLabel.Name = "modifiedLabel";
            this.modifiedLabel.Size = new System.Drawing.Size(61, 17);
            this.modifiedLabel.TabIndex = 12;
            this.modifiedLabel.Text = "modified";
            // 
            // NoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(800, 664);
            this.Controls.Add(this.modifiedLabel);
            this.Controls.Add(this.createdLabel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.noteTextRichTextBox);
            this.Controls.Add(this.labelDateLastModified);
            this.Controls.Add(this.labelDataCreated);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.labelCategory);
            this.Controls.Add(this.nameNoteTextBox);
            this.Controls.Add(this.labelTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(818, 711);
            this.Name = "NoteForm";
            this.Text = "Add/Edit Note";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.Label labelDataCreated;
        private System.Windows.Forms.Label labelDateLastModified;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOk;
        public System.Windows.Forms.TextBox nameNoteTextBox;
        public System.Windows.Forms.ComboBox categoryComboBox;
        public System.Windows.Forms.RichTextBox noteTextRichTextBox;
        private System.Windows.Forms.Label createdLabel;
        private System.Windows.Forms.Label modifiedLabel;
        private System.Windows.Forms.ToolTip nameNoteToolTip;
    }
}