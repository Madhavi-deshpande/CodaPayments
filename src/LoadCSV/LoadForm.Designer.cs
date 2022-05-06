namespace LoadCSV
{
    partial class LoadForm
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
            this.Browse = new System.Windows.Forms.Button();
            this.openFileDialog_CSV = new System.Windows.Forms.OpenFileDialog();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.ErrorInfo = new System.Windows.Forms.Label();
            this.labelInfo = new System.Windows.Forms.Label();
            this.buttonOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Browse
            // 
            this.Browse.Location = new System.Drawing.Point(320, 33);
            this.Browse.Name = "Browse";
            this.Browse.Size = new System.Drawing.Size(75, 23);
            this.Browse.TabIndex = 0;
            this.Browse.Text = "Browse the input CSV file";
            this.Browse.UseVisualStyleBackColor = true;
            this.Browse.Click += new System.EventHandler(this.Browse_Click);
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(67, 33);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(219, 22);
            this.txtFileName.TabIndex = 1;
            // 
            // ErrorInfo
            // 
            this.ErrorInfo.Location = new System.Drawing.Point(0, 0);
            this.ErrorInfo.Name = "ErrorInfo";
            this.ErrorInfo.Size = new System.Drawing.Size(100, 23);
            this.ErrorInfo.TabIndex = 0;
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Location = new System.Drawing.Point(28, 102);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(31, 17);
            this.labelInfo.TabIndex = 2;
            this.labelInfo.Text = "Info";
            this.labelInfo.Visible = false;
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(124, 151);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(95, 38);
            this.buttonOk.TabIndex = 3;
            this.buttonOk.Text = "ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Visible = false;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // LoadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 332);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.ErrorInfo);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.Browse);
            this.Name = "LoadForm";
            this.Text = "Load CSV";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Browse;
        private System.Windows.Forms.OpenFileDialog openFileDialog_CSV;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Label ErrorInfo;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Button buttonOk;
    }
}

