namespace Holiday_App
{
    partial class Quote
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.lblResults = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblBasePrice = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.cbOption1 = new System.Windows.Forms.CheckBox();
            this.cbOption2 = new System.Windows.Forms.CheckBox();
            this.cbOption3 = new System.Windows.Forms.CheckBox();
            this.cbOption4 = new System.Windows.Forms.CheckBox();
            this.lblHolType = new System.Windows.Forms.Label();
            this.btnStaffView = new System.Windows.Forms.Button();
            this.cbHostel = new System.Windows.Forms.CheckBox();
            this.cbLEH = new System.Windows.Forms.CheckBox();
            this.cbMRH = new System.Windows.Forms.CheckBox();
            this.CBHEH = new System.Windows.Forms.CheckBox();
            this.cbHotelReq = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of Passangers:";
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.Location = new System.Drawing.Point(136, 9);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(13, 13);
            this.lblResults.TabIndex = 1;
            this.lblResults.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Price:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Extra";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(415, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Flight";
            // 
            // lblBasePrice
            // 
            this.lblBasePrice.AutoSize = true;
            this.lblBasePrice.Location = new System.Drawing.Point(475, 51);
            this.lblBasePrice.Name = "lblBasePrice";
            this.lblBasePrice.Size = new System.Drawing.Size(13, 13);
            this.lblBasePrice.TabIndex = 5;
            this.lblBasePrice.Text = "0";
            this.lblBasePrice.Click += new System.EventHandler(this.label5_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Equipment";
            // 
            // cbOption1
            // 
            this.cbOption1.AutoSize = true;
            this.cbOption1.Location = new System.Drawing.Point(21, 172);
            this.cbOption1.Name = "cbOption1";
            this.cbOption1.Size = new System.Drawing.Size(80, 17);
            this.cbOption1.TabIndex = 8;
            this.cbOption1.Text = "checkBox1";
            this.cbOption1.UseVisualStyleBackColor = true;
            // 
            // cbOption2
            // 
            this.cbOption2.AutoSize = true;
            this.cbOption2.Location = new System.Drawing.Point(21, 195);
            this.cbOption2.Name = "cbOption2";
            this.cbOption2.Size = new System.Drawing.Size(80, 17);
            this.cbOption2.TabIndex = 8;
            this.cbOption2.Text = "checkBox1";
            this.cbOption2.UseVisualStyleBackColor = true;
            // 
            // cbOption3
            // 
            this.cbOption3.AutoSize = true;
            this.cbOption3.Location = new System.Drawing.Point(21, 218);
            this.cbOption3.Name = "cbOption3";
            this.cbOption3.Size = new System.Drawing.Size(80, 17);
            this.cbOption3.TabIndex = 8;
            this.cbOption3.Text = "checkBox1";
            this.cbOption3.UseVisualStyleBackColor = true;
            // 
            // cbOption4
            // 
            this.cbOption4.AutoSize = true;
            this.cbOption4.Location = new System.Drawing.Point(21, 241);
            this.cbOption4.Name = "cbOption4";
            this.cbOption4.Size = new System.Drawing.Size(80, 17);
            this.cbOption4.TabIndex = 8;
            this.cbOption4.Text = "checkBox1";
            this.cbOption4.UseVisualStyleBackColor = true;
            // 
            // lblHolType
            // 
            this.lblHolType.AutoSize = true;
            this.lblHolType.Location = new System.Drawing.Point(18, 144);
            this.lblHolType.Name = "lblHolType";
            this.lblHolType.Size = new System.Drawing.Size(35, 13);
            this.lblHolType.TabIndex = 9;
            this.lblHolType.Text = "label7";
            // 
            // btnStaffView
            // 
            this.btnStaffView.Location = new System.Drawing.Point(182, 330);
            this.btnStaffView.Name = "btnStaffView";
            this.btnStaffView.Size = new System.Drawing.Size(75, 23);
            this.btnStaffView.TabIndex = 10;
            this.btnStaffView.Text = "Staff View";
            this.btnStaffView.UseVisualStyleBackColor = true;
            this.btnStaffView.Click += new System.EventHandler(this.btnStaffView_Click);
            // 
            // cbHostel
            // 
            this.cbHostel.AutoSize = true;
            this.cbHostel.Enabled = false;
            this.cbHostel.Location = new System.Drawing.Point(478, 90);
            this.cbHostel.Name = "cbHostel";
            this.cbHostel.Size = new System.Drawing.Size(56, 17);
            this.cbHostel.TabIndex = 11;
            this.cbHostel.Text = "Hostel";
            this.cbHostel.UseVisualStyleBackColor = true;
            this.cbHostel.CheckedChanged += new System.EventHandler(this.cbHostel_CheckedChanged);
            // 
            // cbLEH
            // 
            this.cbLEH.AutoSize = true;
            this.cbLEH.Enabled = false;
            this.cbLEH.Location = new System.Drawing.Point(478, 113);
            this.cbLEH.Name = "cbLEH";
            this.cbLEH.Size = new System.Drawing.Size(88, 17);
            this.cbLEH.TabIndex = 11;
            this.cbLEH.Text = "Budget Hotel";
            this.cbLEH.UseVisualStyleBackColor = true;
            this.cbLEH.CheckedChanged += new System.EventHandler(this.cbLEH_CheckedChanged);
            // 
            // cbMRH
            // 
            this.cbMRH.AutoSize = true;
            this.cbMRH.Enabled = false;
            this.cbMRH.Location = new System.Drawing.Point(478, 136);
            this.cbMRH.Name = "cbMRH";
            this.cbMRH.Size = new System.Drawing.Size(106, 17);
            this.cbMRH.TabIndex = 11;
            this.cbMRH.Text = "Mid Range Hotel";
            this.cbMRH.UseVisualStyleBackColor = true;
            this.cbMRH.CheckedChanged += new System.EventHandler(this.cbMRH_CheckedChanged);
            // 
            // CBHEH
            // 
            this.CBHEH.AutoSize = true;
            this.CBHEH.Enabled = false;
            this.CBHEH.Location = new System.Drawing.Point(478, 159);
            this.CBHEH.Name = "CBHEH";
            this.CBHEH.Size = new System.Drawing.Size(85, 17);
            this.CBHEH.TabIndex = 11;
            this.CBHEH.Text = "Luxury Hotel";
            this.CBHEH.UseVisualStyleBackColor = true;
            this.CBHEH.CheckedChanged += new System.EventHandler(this.CBHEH_CheckedChanged);
            // 
            // cbHotelReq
            // 
            this.cbHotelReq.AutoSize = true;
            this.cbHotelReq.Location = new System.Drawing.Point(478, 67);
            this.cbHotelReq.Name = "cbHotelReq";
            this.cbHotelReq.Size = new System.Drawing.Size(97, 17);
            this.cbHotelReq.TabIndex = 12;
            this.cbHotelReq.Text = "Hotel Required";
            this.cbHotelReq.UseVisualStyleBackColor = true;
            this.cbHotelReq.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(459, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "£";
            // 
            // Quote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 407);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbHotelReq);
            this.Controls.Add(this.CBHEH);
            this.Controls.Add(this.cbMRH);
            this.Controls.Add(this.cbLEH);
            this.Controls.Add(this.cbHostel);
            this.Controls.Add(this.btnStaffView);
            this.Controls.Add(this.lblHolType);
            this.Controls.Add(this.cbOption4);
            this.Controls.Add(this.cbOption3);
            this.Controls.Add(this.cbOption2);
            this.Controls.Add(this.cbOption1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblBasePrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.label1);
            this.Name = "Quote";
            this.Text = "Quote";
            this.Load += new System.EventHandler(this.Quote_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblBasePrice;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox cbOption1;
        private System.Windows.Forms.CheckBox cbOption2;
        private System.Windows.Forms.CheckBox cbOption3;
        private System.Windows.Forms.CheckBox cbOption4;
        private System.Windows.Forms.Label lblHolType;
        private System.Windows.Forms.Button btnStaffView;
        private System.Windows.Forms.CheckBox cbHostel;
        private System.Windows.Forms.CheckBox cbLEH;
        private System.Windows.Forms.CheckBox cbMRH;
        private System.Windows.Forms.CheckBox CBHEH;
        private System.Windows.Forms.CheckBox cbHotelReq;
        private System.Windows.Forms.Label label5;
    }
}