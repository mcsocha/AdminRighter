namespace AdminRighter
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnGrantAccess = new System.Windows.Forms.Button();
            this.dlgOpen = new System.Windows.Forms.OpenFileDialog();
            this.label4 = new System.Windows.Forms.Label();
            this.lstApps = new System.Windows.Forms.ListBox();
            this.btnRemoveApp = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(445, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select the application you need to run with administrator privilege.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 84);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Application Path:";
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(12, 99);
            this.txtFileName.Margin = new System.Windows.Forms.Padding(2);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(613, 20);
            this.txtFileName.TabIndex = 3;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBrowse.Location = new System.Drawing.Point(629, 100);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(2);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(33, 19);
            this.btnBrowse.TabIndex = 4;
            this.btnBrowse.Text = "...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnGrantAccess
            // 
            this.btnGrantAccess.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGrantAccess.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGrantAccess.Location = new System.Drawing.Point(601, 123);
            this.btnGrantAccess.Margin = new System.Windows.Forms.Padding(2);
            this.btnGrantAccess.Name = "btnGrantAccess";
            this.btnGrantAccess.Size = new System.Drawing.Size(108, 27);
            this.btnGrantAccess.TabIndex = 5;
            this.btnGrantAccess.Text = "Grant Access";
            this.btnGrantAccess.UseVisualStyleBackColor = true;
            this.btnGrantAccess.Click += new System.EventHandler(this.btnGrantAccess_Click);
            // 
            // dlgOpen
            // 
            this.dlgOpen.Filter = "Executable Files (*.EXE)|*.exe";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 135);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(211, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Current Apps with Administrator Permissions";
            // 
            // lstApps
            // 
            this.lstApps.FormattingEnabled = true;
            this.lstApps.Location = new System.Drawing.Point(12, 154);
            this.lstApps.Margin = new System.Windows.Forms.Padding(2);
            this.lstApps.Name = "lstApps";
            this.lstApps.Size = new System.Drawing.Size(697, 160);
            this.lstApps.TabIndex = 7;
            // 
            // btnRemoveApp
            // 
            this.btnRemoveApp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveApp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRemoveApp.Location = new System.Drawing.Point(601, 318);
            this.btnRemoveApp.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemoveApp.Name = "btnRemoveApp";
            this.btnRemoveApp.Size = new System.Drawing.Size(108, 27);
            this.btnRemoveApp.TabIndex = 8;
            this.btnRemoveApp.Text = "Remove Access";
            this.btnRemoveApp.UseVisualStyleBackColor = true;
            this.btnRemoveApp.Click += new System.EventHandler(this.btnRemoveApp_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AdminRighter.Properties.Resources.icon;
            this.pictureBox1.Location = new System.Drawing.Point(637, 3);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(97, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 352);
            this.Controls.Add(this.btnRemoveApp);
            this.Controls.Add(this.lstApps);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnGrantAccess);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Windows 8 Admin Righter V1.0";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnGrantAccess;
        private System.Windows.Forms.OpenFileDialog dlgOpen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lstApps;
        private System.Windows.Forms.Button btnRemoveApp;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

