namespace SimplesClient
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
            this.btnGetEvenNumbers = new System.Windows.Forms.Button();
            this.btnGetOddNumbers = new System.Windows.Forms.Button();
            this.btnClearResults = new System.Windows.Forms.Button();
            this.listBoxForEven = new System.Windows.Forms.ListBox();
            this.listBoxForOdd = new System.Windows.Forms.ListBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // btnGetEvenNumbers
            // 
            this.btnGetEvenNumbers.Location = new System.Drawing.Point(12, 64);
            this.btnGetEvenNumbers.Name = "btnGetEvenNumbers";
            this.btnGetEvenNumbers.Size = new System.Drawing.Size(208, 23);
            this.btnGetEvenNumbers.TabIndex = 0;
            this.btnGetEvenNumbers.Text = "Get Even Numbers";
            this.btnGetEvenNumbers.UseVisualStyleBackColor = true;
            this.btnGetEvenNumbers.Click += new System.EventHandler(this.btnGetEvenNumbers_Click);
            // 
            // btnGetOddNumbers
            // 
            this.btnGetOddNumbers.Location = new System.Drawing.Point(250, 64);
            this.btnGetOddNumbers.Name = "btnGetOddNumbers";
            this.btnGetOddNumbers.Size = new System.Drawing.Size(228, 23);
            this.btnGetOddNumbers.TabIndex = 1;
            this.btnGetOddNumbers.Text = "Get Odd Numbers";
            this.btnGetOddNumbers.UseVisualStyleBackColor = true;
            this.btnGetOddNumbers.Click += new System.EventHandler(this.btnGetOddNumbers_Click);
            // 
            // btnClearResults
            // 
            this.btnClearResults.Location = new System.Drawing.Point(42, 354);
            this.btnClearResults.Name = "btnClearResults";
            this.btnClearResults.Size = new System.Drawing.Size(404, 23);
            this.btnClearResults.TabIndex = 2;
            this.btnClearResults.Text = "Clear Results";
            this.btnClearResults.UseVisualStyleBackColor = true;
            this.btnClearResults.Click += new System.EventHandler(this.btnClearResults_Click);
            // 
            // listBoxForEven
            // 
            this.listBoxForEven.FormattingEnabled = true;
            this.listBoxForEven.Location = new System.Drawing.Point(12, 103);
            this.listBoxForEven.Name = "listBoxForEven";
            this.listBoxForEven.Size = new System.Drawing.Size(208, 225);
            this.listBoxForEven.TabIndex = 3;
            // 
            // listBoxForOdd
            // 
            this.listBoxForOdd.FormattingEnabled = true;
            this.listBoxForOdd.Location = new System.Drawing.Point(250, 101);
            this.listBoxForOdd.Name = "listBoxForOdd";
            this.listBoxForOdd.Size = new System.Drawing.Size(228, 225);
            this.listBoxForOdd.TabIndex = 4;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            this.backgroundWorker2.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker2_RunWorkerCompleted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 492);
            this.Controls.Add(this.listBoxForOdd);
            this.Controls.Add(this.listBoxForEven);
            this.Controls.Add(this.btnClearResults);
            this.Controls.Add(this.btnGetOddNumbers);
            this.Controls.Add(this.btnGetEvenNumbers);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGetEvenNumbers;
        private System.Windows.Forms.Button btnGetOddNumbers;
        private System.Windows.Forms.Button btnClearResults;
        private System.Windows.Forms.ListBox listBoxForEven;
        private System.Windows.Forms.ListBox listBoxForOdd;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
    }
}

