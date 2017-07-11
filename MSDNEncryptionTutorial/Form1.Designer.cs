namespace MSDNEncryptionTutorial
{
    partial class btnImportPublicKey
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
            this.linkLabelSource = new System.Windows.Forms.Button();
            this.btnDecryptFile = new System.Windows.Forms.Button();
            this.btnCreateAsmKeys = new System.Windows.Forms.Button();
            this.btnExportPublicKey = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnGetPrivateKey = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // linkLabelSource
            // 
            this.linkLabelSource.Location = new System.Drawing.Point(31, 27);
            this.linkLabelSource.Name = "linkLabelSource";
            this.linkLabelSource.Size = new System.Drawing.Size(104, 29);
            this.linkLabelSource.TabIndex = 0;
            this.linkLabelSource.Text = "Encrypt File";
            this.linkLabelSource.UseVisualStyleBackColor = true;
            // 
            // btnDecryptFile
            // 
            this.btnDecryptFile.Location = new System.Drawing.Point(141, 27);
            this.btnDecryptFile.Name = "btnDecryptFile";
            this.btnDecryptFile.Size = new System.Drawing.Size(104, 29);
            this.btnDecryptFile.TabIndex = 0;
            this.btnDecryptFile.Text = "Decrypt File";
            this.btnDecryptFile.UseVisualStyleBackColor = true;
            // 
            // btnCreateAsmKeys
            // 
            this.btnCreateAsmKeys.Location = new System.Drawing.Point(31, 95);
            this.btnCreateAsmKeys.Name = "btnCreateAsmKeys";
            this.btnCreateAsmKeys.Size = new System.Drawing.Size(104, 29);
            this.btnCreateAsmKeys.TabIndex = 0;
            this.btnCreateAsmKeys.Text = "Create Keys";
            this.btnCreateAsmKeys.UseVisualStyleBackColor = true;
            // 
            // btnExportPublicKey
            // 
            this.btnExportPublicKey.Location = new System.Drawing.Point(31, 160);
            this.btnExportPublicKey.Name = "btnExportPublicKey";
            this.btnExportPublicKey.Size = new System.Drawing.Size(104, 29);
            this.btnExportPublicKey.TabIndex = 0;
            this.btnExportPublicKey.Text = "Export Public Key";
            this.btnExportPublicKey.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(141, 160);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 29);
            this.button2.TabIndex = 0;
            this.button2.Text = "Import Public Key";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnGetPrivateKey
            // 
            this.btnGetPrivateKey.Location = new System.Drawing.Point(141, 95);
            this.btnGetPrivateKey.Name = "btnGetPrivateKey";
            this.btnGetPrivateKey.Size = new System.Drawing.Size(104, 29);
            this.btnGetPrivateKey.TabIndex = 0;
            this.btnGetPrivateKey.Text = "Get Private Key";
            this.btnGetPrivateKey.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(28, 244);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(521, 13);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "https://docs.microsoft.com/en-us/dotnet/standard/security/walkthrough-creating-a-" +
    "cryptographic-application";
            // 
            // btnImportPublicKey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 266);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGetPrivateKey);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnExportPublicKey);
            this.Controls.Add(this.btnCreateAsmKeys);
            this.Controls.Add(this.btnDecryptFile);
            this.Controls.Add(this.linkLabelSource);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "btnImportPublicKey";
            this.Text = "File Encryption";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button linkLabelSource;
        private System.Windows.Forms.Button btnDecryptFile;
        private System.Windows.Forms.Button btnCreateAsmKeys;
        private System.Windows.Forms.Button btnExportPublicKey;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnGetPrivateKey;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

