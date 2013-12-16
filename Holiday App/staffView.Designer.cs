namespace Holiday_App
{
    partial class staffView
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.lblFlights = new System.Windows.Forms.Label();
            this.lblHotels = new System.Windows.Forms.Label();
            this.lblExtras = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblProfit = new System.Windows.Forms.Label();
            this.btnInvoice = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Price:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Flights:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hotels:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Extras";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Location = new System.Drawing.Point(109, 32);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(13, 13);
            this.lblTotalPrice.TabIndex = 4;
            this.lblTotalPrice.Text = "0";
            // 
            // lblFlights
            // 
            this.lblFlights.AutoSize = true;
            this.lblFlights.Location = new System.Drawing.Point(109, 53);
            this.lblFlights.Name = "lblFlights";
            this.lblFlights.Size = new System.Drawing.Size(13, 13);
            this.lblFlights.TabIndex = 5;
            this.lblFlights.Text = "0";
            // 
            // lblHotels
            // 
            this.lblHotels.AutoSize = true;
            this.lblHotels.Location = new System.Drawing.Point(109, 75);
            this.lblHotels.Name = "lblHotels";
            this.lblHotels.Size = new System.Drawing.Size(13, 13);
            this.lblHotels.TabIndex = 6;
            this.lblHotels.Text = "0";
            // 
            // lblExtras
            // 
            this.lblExtras.AutoSize = true;
            this.lblExtras.Location = new System.Drawing.Point(109, 97);
            this.lblExtras.Name = "lblExtras";
            this.lblExtras.Size = new System.Drawing.Size(13, 13);
            this.lblExtras.TabIndex = 7;
            this.lblExtras.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(36, 122);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Profit:";
            // 
            // lblProfit
            // 
            this.lblProfit.AutoSize = true;
            this.lblProfit.Location = new System.Drawing.Point(109, 122);
            this.lblProfit.Name = "lblProfit";
            this.lblProfit.Size = new System.Drawing.Size(13, 13);
            this.lblProfit.TabIndex = 9;
            this.lblProfit.Text = "0";
            // 
            // btnInvoice
            // 
            this.btnInvoice.Location = new System.Drawing.Point(39, 172);
            this.btnInvoice.Name = "btnInvoice";
            this.btnInvoice.Size = new System.Drawing.Size(83, 35);
            this.btnInvoice.TabIndex = 10;
            this.btnInvoice.Text = "Create Invoice";
            this.btnInvoice.UseVisualStyleBackColor = true;
            // 
            // staffView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(200, 236);
            this.Controls.Add(this.btnInvoice);
            this.Controls.Add(this.lblProfit);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblExtras);
            this.Controls.Add(this.lblHotels);
            this.Controls.Add(this.lblFlights);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "staffView";
            this.Text = "staffView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label lblFlights;
        private System.Windows.Forms.Label lblHotels;
        private System.Windows.Forms.Label lblExtras;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblProfit;
        private System.Windows.Forms.Button btnInvoice;
    }
}