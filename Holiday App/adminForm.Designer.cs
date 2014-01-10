namespace Holiday_App
{
    partial class adminForm
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
            this.listBoxAirAdd = new System.Windows.Forms.ListBox();
            this.txtBoxAirport = new System.Windows.Forms.TextBox();
            this.lslAirRemove = new System.Windows.Forms.ListBox();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.btnAddPort = new System.Windows.Forms.Button();
            this.btnRmPort = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxAirAdd
            // 
            this.listBoxAirAdd.FormattingEnabled = true;
            this.listBoxAirAdd.Location = new System.Drawing.Point(188, 33);
            this.listBoxAirAdd.Name = "listBoxAirAdd";
            this.listBoxAirAdd.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxAirAdd.Size = new System.Drawing.Size(120, 95);
            this.listBoxAirAdd.TabIndex = 1;
            // 
            // txtBoxAirport
            // 
            this.txtBoxAirport.Location = new System.Drawing.Point(32, 33);
            this.txtBoxAirport.Name = "txtBoxAirport";
            this.txtBoxAirport.Size = new System.Drawing.Size(100, 20);
            this.txtBoxAirport.TabIndex = 2;
            // 
            // lslAirRemove
            // 
            this.lslAirRemove.FormattingEnabled = true;
            this.lslAirRemove.Location = new System.Drawing.Point(188, 154);
            this.lslAirRemove.Name = "lslAirRemove";
            this.lslAirRemove.Size = new System.Drawing.Size(120, 95);
            this.lslAirRemove.TabIndex = 3;
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Location = new System.Drawing.Point(188, 14);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(130, 13);
            this.lblInstructions.TabIndex = 4;
            this.lblInstructions.Text = "Select Connected Airports";
            // 
            // btnAddPort
            // 
            this.btnAddPort.Location = new System.Drawing.Point(391, 69);
            this.btnAddPort.Name = "btnAddPort";
            this.btnAddPort.Size = new System.Drawing.Size(75, 23);
            this.btnAddPort.TabIndex = 5;
            this.btnAddPort.Text = "Add Airport";
            this.btnAddPort.UseVisualStyleBackColor = true;
            this.btnAddPort.Click += new System.EventHandler(this.btnAddPort_Click);
            // 
            // btnRmPort
            // 
            this.btnRmPort.Location = new System.Drawing.Point(391, 173);
            this.btnRmPort.Name = "btnRmPort";
            this.btnRmPort.Size = new System.Drawing.Size(75, 23);
            this.btnRmPort.TabIndex = 6;
            this.btnRmPort.Text = "Remove Airport";
            this.btnRmPort.UseVisualStyleBackColor = true;
            this.btnRmPort.Click += new System.EventHandler(this.btnRmPort_Click);
            // 
            // adminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 333);
            this.Controls.Add(this.btnRmPort);
            this.Controls.Add(this.btnAddPort);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.lslAirRemove);
            this.Controls.Add(this.txtBoxAirport);
            this.Controls.Add(this.listBoxAirAdd);
            this.Name = "adminForm";
            this.Text = "adminForm";
            this.Deactivate += new System.EventHandler(this.adminForm_Deactivate);
            this.Load += new System.EventHandler(this.adminForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxAirAdd;
        private System.Windows.Forms.TextBox txtBoxAirport;
        private System.Windows.Forms.ListBox lslAirRemove;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Button btnAddPort;
        private System.Windows.Forms.Button btnRmPort;
    }
}