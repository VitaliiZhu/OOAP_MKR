namespace OOAP_MKR
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
            this.btnCheckBaggage = new System.Windows.Forms.Button();
            this.listBoxPassengers = new System.Windows.Forms.ListBox();
            this.txtTicketNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCheckBaggage
            // 
            this.btnCheckBaggage.Location = new System.Drawing.Point(79, 283);
            this.btnCheckBaggage.Name = "btnCheckBaggage";
            this.btnCheckBaggage.Size = new System.Drawing.Size(161, 65);
            this.btnCheckBaggage.TabIndex = 0;
            this.btnCheckBaggage.Text = "Перевірити багаж";
            this.btnCheckBaggage.UseVisualStyleBackColor = true;
            this.btnCheckBaggage.Click += new System.EventHandler(this.btnCheckBaggage_Click);
            // 
            // listBoxPassengers
            // 
            this.listBoxPassengers.FormattingEnabled = true;
            this.listBoxPassengers.ItemHeight = 16;
            this.listBoxPassengers.Location = new System.Drawing.Point(317, 12);
            this.listBoxPassengers.Name = "listBoxPassengers";
            this.listBoxPassengers.Size = new System.Drawing.Size(332, 340);
            this.listBoxPassengers.TabIndex = 1;
            // 
            // txtTicketNumber
            // 
            this.txtTicketNumber.Location = new System.Drawing.Point(12, 255);
            this.txtTicketNumber.Name = "txtTicketNumber";
            this.txtTicketNumber.Size = new System.Drawing.Size(299, 22);
            this.txtTicketNumber.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Введіть номер квитка,\r\n за яким потрібно шукати багаж";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 360);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTicketNumber);
            this.Controls.Add(this.listBoxPassengers);
            this.Controls.Add(this.btnCheckBaggage);
            this.MinimumSize = new System.Drawing.Size(671, 407);
            this.Name = "Form1";
            this.Text = "Перевірка багажу";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCheckBaggage;
        private System.Windows.Forms.ListBox listBoxPassengers;
        private System.Windows.Forms.TextBox txtTicketNumber;
        private System.Windows.Forms.Label label1;
    }
}

