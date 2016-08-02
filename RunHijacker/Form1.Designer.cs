namespace RunHijacker
{
    partial class frmMainForm
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
            this.txtOriginal = new System.Windows.Forms.TextBox();
            this.txtNewPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnUnpatch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtOriginal
            // 
            this.txtOriginal.Location = new System.Drawing.Point(74, 6);
            this.txtOriginal.Name = "txtOriginal";
            this.txtOriginal.Size = new System.Drawing.Size(179, 20);
            this.txtOriginal.TabIndex = 0;
            this.txtOriginal.Text = "syskey.exe";
            // 
            // txtNewPath
            // 
            this.txtNewPath.Location = new System.Drawing.Point(74, 32);
            this.txtNewPath.Name = "txtNewPath";
            this.txtNewPath.Size = new System.Drawing.Size(179, 20);
            this.txtNewPath.TabIndex = 1;
            this.txtNewPath.Text = "C:\\fakesyskey.exe";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Original";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "New Path";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(178, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Patch";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.submit);
            // 
            // btnUnpatch
            // 
            this.btnUnpatch.Location = new System.Drawing.Point(97, 58);
            this.btnUnpatch.Name = "btnUnpatch";
            this.btnUnpatch.Size = new System.Drawing.Size(75, 23);
            this.btnUnpatch.TabIndex = 5;
            this.btnUnpatch.Text = "Unpatch";
            this.btnUnpatch.UseVisualStyleBackColor = true;
            this.btnUnpatch.Click += new System.EventHandler(this.btnUnpatch_Click);
            // 
            // frmMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 89);
            this.Controls.Add(this.btnUnpatch);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNewPath);
            this.Controls.Add(this.txtOriginal);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(281, 128);
            this.MinimumSize = new System.Drawing.Size(281, 128);
            this.Name = "frmMainForm";
            this.Text = "RunHijacker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOriginal;
        private System.Windows.Forms.TextBox txtNewPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnUnpatch;
    }
}

