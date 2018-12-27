namespace IntSys03_ID3_AccordFW
{
    partial class Form1
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
            this.btnStart = new System.Windows.Forms.Button();
            this.btnTrainingPath = new System.Windows.Forms.Button();
            this.btnDataPath = new System.Windows.Forms.Button();
            this.btnOutputPath = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tboxTrainingPath = new System.Windows.Forms.TextBox();
            this.tboxInputPath = new System.Windows.Forms.TextBox();
            this.tboxOutputPath = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(534, 146);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnTrainingPath
            // 
            this.btnTrainingPath.Location = new System.Drawing.Point(580, 20);
            this.btnTrainingPath.Name = "btnTrainingPath";
            this.btnTrainingPath.Size = new System.Drawing.Size(29, 23);
            this.btnTrainingPath.TabIndex = 1;
            this.btnTrainingPath.Text = "...";
            this.btnTrainingPath.UseVisualStyleBackColor = true;
            this.btnTrainingPath.Click += new System.EventHandler(this.btnTrainingPath_Click);
            // 
            // btnDataPath
            // 
            this.btnDataPath.Location = new System.Drawing.Point(580, 60);
            this.btnDataPath.Name = "btnDataPath";
            this.btnDataPath.Size = new System.Drawing.Size(29, 23);
            this.btnDataPath.TabIndex = 2;
            this.btnDataPath.Text = "...";
            this.btnDataPath.UseVisualStyleBackColor = true;
            this.btnDataPath.Click += new System.EventHandler(this.btnDataPath_Click);
            // 
            // btnOutputPath
            // 
            this.btnOutputPath.Location = new System.Drawing.Point(580, 100);
            this.btnOutputPath.Name = "btnOutputPath";
            this.btnOutputPath.Size = new System.Drawing.Size(29, 23);
            this.btnOutputPath.TabIndex = 3;
            this.btnOutputPath.Text = "...";
            this.btnOutputPath.UseVisualStyleBackColor = true;
            this.btnOutputPath.Click += new System.EventHandler(this.btnOutputPath_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Training data file (.csv):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Input file (.csv):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Output location:";
            // 
            // tboxTrainingPath
            // 
            this.tboxTrainingPath.Location = new System.Drawing.Point(154, 22);
            this.tboxTrainingPath.Name = "tboxTrainingPath";
            this.tboxTrainingPath.Size = new System.Drawing.Size(404, 20);
            this.tboxTrainingPath.TabIndex = 7;
            // 
            // tboxInputPath
            // 
            this.tboxInputPath.Location = new System.Drawing.Point(154, 62);
            this.tboxInputPath.Name = "tboxInputPath";
            this.tboxInputPath.Size = new System.Drawing.Size(404, 20);
            this.tboxInputPath.TabIndex = 8;
            // 
            // tboxOutputPath
            // 
            this.tboxOutputPath.Location = new System.Drawing.Point(154, 102);
            this.tboxOutputPath.Name = "tboxOutputPath";
            this.tboxOutputPath.Size = new System.Drawing.Size(404, 20);
            this.tboxOutputPath.TabIndex = 9;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(12, 163);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 13);
            this.lblStatus.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 185);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.tboxOutputPath);
            this.Controls.Add(this.tboxInputPath);
            this.Controls.Add(this.tboxTrainingPath);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOutputPath);
            this.Controls.Add(this.btnDataPath);
            this.Controls.Add(this.btnTrainingPath);
            this.Controls.Add(this.btnStart);
            this.Name = "Form1";
            this.Text = "ID3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnTrainingPath;
        private System.Windows.Forms.Button btnDataPath;
        private System.Windows.Forms.Button btnOutputPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tboxTrainingPath;
        private System.Windows.Forms.TextBox tboxInputPath;
        private System.Windows.Forms.TextBox tboxOutputPath;
        private System.Windows.Forms.Label lblStatus;
    }
}

