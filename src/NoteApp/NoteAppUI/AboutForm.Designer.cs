
namespace NoteAppUI
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.labelNameApp = new System.Windows.Forms.Label();
            this.labelVersion = new System.Windows.Forms.Label();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelGitHub = new System.Windows.Forms.Label();
            this.linkLabelGitHub = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.labelCopyright = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelNameApp
            // 
            this.labelNameApp.AutoSize = true;
            this.labelNameApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNameApp.Location = new System.Drawing.Point(13, 26);
            this.labelNameApp.Name = "labelNameApp";
            this.labelNameApp.Size = new System.Drawing.Size(140, 36);
            this.labelNameApp.TabIndex = 0;
            this.labelNameApp.Text = "NoteApp";
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.Location = new System.Drawing.Point(16, 62);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(55, 17);
            this.labelVersion.TabIndex = 1;
            this.labelVersion.Text = "v. 1.0.0";
            // 
            // labelAuthor
            // 
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.Location = new System.Drawing.Point(16, 106);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(163, 17);
            this.labelAuthor.TabIndex = 2;
            this.labelAuthor.Text = "Author: Lapardin Andrey";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(16, 165);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(133, 17);
            this.labelEmail.TabIndex = 3;
            this.labelEmail.Text = "e-mail for feedback:";
            // 
            // labelGitHub
            // 
            this.labelGitHub.AutoSize = true;
            this.labelGitHub.Location = new System.Drawing.Point(16, 195);
            this.labelGitHub.Name = "labelGitHub";
            this.labelGitHub.Size = new System.Drawing.Size(56, 17);
            this.labelGitHub.TabIndex = 4;
            this.labelGitHub.Text = "GitHub:";
            // 
            // linkLabelGitHub
            // 
            this.linkLabelGitHub.AutoSize = true;
            this.linkLabelGitHub.Location = new System.Drawing.Point(82, 195);
            this.linkLabelGitHub.Name = "linkLabelGitHub";
            this.linkLabelGitHub.Size = new System.Drawing.Size(281, 17);
            this.linkLabelGitHub.TabIndex = 5;
            this.linkLabelGitHub.TabStop = true;
            this.linkLabelGitHub.Text = "https://github.com/CyberAndrey77/NoteApp";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(156, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "lapardin.andrey@mail.ru";
            // 
            // labelCopyright
            // 
            this.labelCopyright.AutoSize = true;
            this.labelCopyright.Location = new System.Drawing.Point(19, 388);
            this.labelCopyright.Name = "labelCopyright";
            this.labelCopyright.Size = new System.Drawing.Size(163, 17);
            this.labelCopyright.TabIndex = 7;
            this.labelCopyright.Text = "2021 Lapardin Andrey ©";
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 416);
            this.Controls.Add(this.labelCopyright);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkLabelGitHub);
            this.Controls.Add(this.labelGitHub);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelAuthor);
            this.Controls.Add(this.labelVersion);
            this.Controls.Add(this.labelNameApp);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AboutForm";
            this.ShowIcon = false;
            this.Text = "About";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNameApp;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelGitHub;
        private System.Windows.Forms.LinkLabel linkLabelGitHub;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelCopyright;
    }
}