namespace ViewNxHelper
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.okButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.procNameText = new System.Windows.Forms.TextBox();
            this.progPathText = new System.Windows.Forms.TextBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.loadTreshSpinner = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.intervalSpinner = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.loadTreshSpinner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intervalSpinner)).BeginInit();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.okButton.Location = new System.Drawing.Point(308, 93);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(118, 23);
            this.okButton.TabIndex = 0;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Program Path:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Process Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Load Treshold:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Update Interval:";
            // 
            // procNameText
            // 
            this.procNameText.Location = new System.Drawing.Point(111, 32);
            this.procNameText.Name = "procNameText";
            this.procNameText.Size = new System.Drawing.Size(141, 20);
            this.procNameText.TabIndex = 5;
            // 
            // progPathText
            // 
            this.progPathText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progPathText.Location = new System.Drawing.Point(111, 6);
            this.progPathText.Name = "progPathText";
            this.progPathText.Size = new System.Drawing.Size(263, 20);
            this.progPathText.TabIndex = 6;
            // 
            // browseButton
            // 
            this.browseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.browseButton.Location = new System.Drawing.Point(380, 4);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(46, 23);
            this.browseButton.TabIndex = 7;
            this.browseButton.Text = "...";
            this.browseButton.UseVisualStyleBackColor = true;
            // 
            // loadTreshSpinner
            // 
            this.loadTreshSpinner.Location = new System.Drawing.Point(111, 61);
            this.loadTreshSpinner.Name = "loadTreshSpinner";
            this.loadTreshSpinner.Size = new System.Drawing.Size(67, 20);
            this.loadTreshSpinner.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(184, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "%";
            // 
            // intervalSpinner
            // 
            this.intervalSpinner.Location = new System.Drawing.Point(111, 90);
            this.intervalSpinner.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.intervalSpinner.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.intervalSpinner.Name = "intervalSpinner";
            this.intervalSpinner.Size = new System.Drawing.Size(67, 20);
            this.intervalSpinner.TabIndex = 10;
            this.intervalSpinner.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(184, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "ms";
            // 
            // SettingsForm
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.okButton;
            this.ClientSize = new System.Drawing.Size(438, 128);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.intervalSpinner);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.loadTreshSpinner);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.progPathText);
            this.Controls.Add(this.procNameText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.okButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "NiewNX Helper Settings";
            ((System.ComponentModel.ISupportInitialize)(this.loadTreshSpinner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intervalSpinner)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox procNameText;
        private System.Windows.Forms.TextBox progPathText;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.NumericUpDown loadTreshSpinner;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown intervalSpinner;
        private System.Windows.Forms.Label label6;
    }
}