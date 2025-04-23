namespace CodeTestSample
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
            this.btnAddInteger = new System.Windows.Forms.Button();
            this.btnWeight = new System.Windows.Forms.Button();
            this.btnGrade = new System.Windows.Forms.Button();
            this.btnPrize = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddInteger
            // 
            this.btnAddInteger.Location = new System.Drawing.Point(45, 225);
            this.btnAddInteger.Name = "btnAddInteger";
            this.btnAddInteger.Size = new System.Drawing.Size(203, 99);
            this.btnAddInteger.TabIndex = 0;
            this.btnAddInteger.Text = "Add Five Integer ";
            this.btnAddInteger.UseVisualStyleBackColor = true;
            this.btnAddInteger.Click += new System.EventHandler(this.btnAddInteger_Click);
            // 
            // btnWeight
            // 
            this.btnWeight.Location = new System.Drawing.Point(321, 225);
            this.btnWeight.Name = "btnWeight";
            this.btnWeight.Size = new System.Drawing.Size(203, 99);
            this.btnWeight.TabIndex = 1;
            this.btnWeight.Text = "Weight Converter";
            this.btnWeight.UseVisualStyleBackColor = true;
            this.btnWeight.Click += new System.EventHandler(this.btnWeight_Click);
            // 
            // btnGrade
            // 
            this.btnGrade.Location = new System.Drawing.Point(600, 225);
            this.btnGrade.Name = "btnGrade";
            this.btnGrade.Size = new System.Drawing.Size(203, 99);
            this.btnGrade.TabIndex = 2;
            this.btnGrade.Text = "Student Grade Calculator";
            this.btnGrade.UseVisualStyleBackColor = true;
            this.btnGrade.Click += new System.EventHandler(this.btnGrade_Click);
            // 
            // btnPrize
            // 
            this.btnPrize.Location = new System.Drawing.Point(862, 225);
            this.btnPrize.Name = "btnPrize";
            this.btnPrize.Size = new System.Drawing.Size(203, 99);
            this.btnPrize.TabIndex = 3;
            this.btnPrize.Text = "Prize";
            this.btnPrize.UseVisualStyleBackColor = true;
            this.btnPrize.Click += new System.EventHandler(this.btnPrize_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1324, 779);
            this.Controls.Add(this.btnPrize);
            this.Controls.Add(this.btnGrade);
            this.Controls.Add(this.btnWeight);
            this.Controls.Add(this.btnAddInteger);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddInteger;
        private System.Windows.Forms.Button btnWeight;
        private System.Windows.Forms.Button btnGrade;
        private System.Windows.Forms.Button btnPrize;
    }
}