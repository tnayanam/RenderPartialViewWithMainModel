namespace SecurityClient
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
            this.btnGetMessage = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_Encrypted = new System.Windows.Forms.Button();
            this.btn_Signed = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGetMessage
            // 
            this.btnGetMessage.Location = new System.Drawing.Point(58, 74);
            this.btnGetMessage.Name = "btnGetMessage";
            this.btnGetMessage.Size = new System.Drawing.Size(166, 23);
            this.btnGetMessage.TabIndex = 0;
            this.btnGetMessage.Text = "Get Message";
            this.btnGetMessage.UseVisualStyleBackColor = true;
            this.btnGetMessage.Click += new System.EventHandler(this.btnGetMessage_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(47, 143);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(199, 20);
            this.textBox1.TabIndex = 1;
            // 
            // btn_Encrypted
            // 
            this.btn_Encrypted.Location = new System.Drawing.Point(58, 16);
            this.btn_Encrypted.Name = "btn_Encrypted";
            this.btn_Encrypted.Size = new System.Drawing.Size(166, 23);
            this.btn_Encrypted.TabIndex = 2;
            this.btn_Encrypted.Text = "Get Signed And Encrypted";
            this.btn_Encrypted.UseVisualStyleBackColor = true;
            this.btn_Encrypted.Click += new System.EventHandler(this.btn_Encrypted_Click);
            // 
            // btn_Signed
            // 
            this.btn_Signed.Location = new System.Drawing.Point(58, 45);
            this.btn_Signed.Name = "btn_Signed";
            this.btn_Signed.Size = new System.Drawing.Size(166, 23);
            this.btn_Signed.TabIndex = 3;
            this.btn_Signed.Text = "Get Signed Message";
            this.btn_Signed.UseVisualStyleBackColor = true;
            this.btn_Signed.Click += new System.EventHandler(this.btn_Signed_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btn_Signed);
            this.Controls.Add(this.btn_Encrypted);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnGetMessage);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetMessage;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_Encrypted;
        private System.Windows.Forms.Button btn_Signed;
    }
}

