﻿namespace Holiday_App
{
    partial class MainSelectionPage
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
            this.startCal = new System.Windows.Forms.MonthCalendar();
            this.endCal = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbPassangers = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFN0 = new System.Windows.Forms.TextBox();
            this.txtLN0 = new System.Windows.Forms.TextBox();
            this.txtFN1 = new System.Windows.Forms.TextBox();
            this.txtLN1 = new System.Windows.Forms.TextBox();
            this.txtFN2 = new System.Windows.Forms.TextBox();
            this.txtLN2 = new System.Windows.Forms.TextBox();
            this.txtFN3 = new System.Windows.Forms.TextBox();
            this.txtLN3 = new System.Windows.Forms.TextBox();
            this.txtFN4 = new System.Windows.Forms.TextBox();
            this.txtLN4 = new System.Windows.Forms.TextBox();
            this.txtFN5 = new System.Windows.Forms.TextBox();
            this.txtLN5 = new System.Windows.Forms.TextBox();
            this.txtFN6 = new System.Windows.Forms.TextBox();
            this.txtLN6 = new System.Windows.Forms.TextBox();
            this.txtFN7 = new System.Windows.Forms.TextBox();
            this.txtLN7 = new System.Windows.Forms.TextBox();
            this.cmbAge0 = new System.Windows.Forms.ComboBox();
            this.cmbAge1 = new System.Windows.Forms.ComboBox();
            this.cmbAge2 = new System.Windows.Forms.ComboBox();
            this.cmbAge3 = new System.Windows.Forms.ComboBox();
            this.cmbAge4 = new System.Windows.Forms.ComboBox();
            this.cmbAge5 = new System.Windows.Forms.ComboBox();
            this.cmbAge6 = new System.Windows.Forms.ComboBox();
            this.cmbAge7 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbOutAirport = new System.Windows.Forms.ComboBox();
            this.cmbDestPorts = new System.Windows.Forms.ComboBox();
            this.lblOutboundAirport = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnExtendedForecast = new System.Windows.Forms.Button();
            this.lblNumOfDays = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnGetPrices = new System.Windows.Forms.Button();
            this.cmbHolTYpe = new System.Windows.Forms.ComboBox();
            this.currentDate = new System.Windows.Forms.MonthCalendar();
            this.tmrISCompleted = new System.Windows.Forms.Timer(this.components);
            this.btnAdmin = new System.Windows.Forms.Button();
            this.chkFC = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // startCal
            // 
            this.startCal.Location = new System.Drawing.Point(76, 54);
            this.startCal.Name = "startCal";
            this.startCal.TabIndex = 1;
            this.startCal.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.startCal_DateChanged);
            this.startCal.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.startCal_DateSelected);
            // 
            // endCal
            // 
            this.endCal.Location = new System.Drawing.Point(79, 234);
            this.endCal.Name = "endCal";
            this.endCal.TabIndex = 1;
            this.endCal.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.endCal_DateChanged);
            this.endCal.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.endCal_DateSelected);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Start Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "End Date";
            // 
            // cmbPassangers
            // 
            this.cmbPassangers.FormattingEnabled = true;
            this.cmbPassangers.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.cmbPassangers.Location = new System.Drawing.Point(350, 124);
            this.cmbPassangers.Name = "cmbPassangers";
            this.cmbPassangers.Size = new System.Drawing.Size(121, 21);
            this.cmbPassangers.TabIndex = 3;
            this.cmbPassangers.Text = "1";
            this.cmbPassangers.SelectedIndexChanged += new System.EventHandler(this.cmbPassangers_SelectedIndexChanged);
            this.cmbPassangers.TextChanged += new System.EventHandler(this.cmbPassangers_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(357, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Number of Passangers";
            // 
            // txtFN0
            // 
            this.txtFN0.Location = new System.Drawing.Point(477, 124);
            this.txtFN0.Name = "txtFN0";
            this.txtFN0.Size = new System.Drawing.Size(100, 20);
            this.txtFN0.TabIndex = 4;
            // 
            // txtLN0
            // 
            this.txtLN0.Location = new System.Drawing.Point(592, 124);
            this.txtLN0.Name = "txtLN0";
            this.txtLN0.Size = new System.Drawing.Size(100, 20);
            this.txtLN0.TabIndex = 4;
            // 
            // txtFN1
            // 
            this.txtFN1.Enabled = false;
            this.txtFN1.Location = new System.Drawing.Point(477, 150);
            this.txtFN1.Name = "txtFN1";
            this.txtFN1.Size = new System.Drawing.Size(100, 20);
            this.txtFN1.TabIndex = 4;
            // 
            // txtLN1
            // 
            this.txtLN1.Enabled = false;
            this.txtLN1.Location = new System.Drawing.Point(592, 150);
            this.txtLN1.Name = "txtLN1";
            this.txtLN1.Size = new System.Drawing.Size(100, 20);
            this.txtLN1.TabIndex = 4;
            // 
            // txtFN2
            // 
            this.txtFN2.Enabled = false;
            this.txtFN2.Location = new System.Drawing.Point(477, 176);
            this.txtFN2.Name = "txtFN2";
            this.txtFN2.Size = new System.Drawing.Size(100, 20);
            this.txtFN2.TabIndex = 4;
            this.txtFN2.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // txtLN2
            // 
            this.txtLN2.Enabled = false;
            this.txtLN2.Location = new System.Drawing.Point(592, 176);
            this.txtLN2.Name = "txtLN2";
            this.txtLN2.Size = new System.Drawing.Size(100, 20);
            this.txtLN2.TabIndex = 4;
            // 
            // txtFN3
            // 
            this.txtFN3.Enabled = false;
            this.txtFN3.Location = new System.Drawing.Point(477, 202);
            this.txtFN3.Name = "txtFN3";
            this.txtFN3.Size = new System.Drawing.Size(100, 20);
            this.txtFN3.TabIndex = 4;
            // 
            // txtLN3
            // 
            this.txtLN3.Enabled = false;
            this.txtLN3.Location = new System.Drawing.Point(592, 202);
            this.txtLN3.Name = "txtLN3";
            this.txtLN3.Size = new System.Drawing.Size(100, 20);
            this.txtLN3.TabIndex = 4;
            // 
            // txtFN4
            // 
            this.txtFN4.Enabled = false;
            this.txtFN4.Location = new System.Drawing.Point(477, 227);
            this.txtFN4.Name = "txtFN4";
            this.txtFN4.Size = new System.Drawing.Size(100, 20);
            this.txtFN4.TabIndex = 4;
            // 
            // txtLN4
            // 
            this.txtLN4.Enabled = false;
            this.txtLN4.Location = new System.Drawing.Point(592, 227);
            this.txtLN4.Name = "txtLN4";
            this.txtLN4.Size = new System.Drawing.Size(100, 20);
            this.txtLN4.TabIndex = 4;
            // 
            // txtFN5
            // 
            this.txtFN5.Enabled = false;
            this.txtFN5.Location = new System.Drawing.Point(477, 253);
            this.txtFN5.Name = "txtFN5";
            this.txtFN5.Size = new System.Drawing.Size(100, 20);
            this.txtFN5.TabIndex = 4;
            // 
            // txtLN5
            // 
            this.txtLN5.Enabled = false;
            this.txtLN5.Location = new System.Drawing.Point(592, 253);
            this.txtLN5.Name = "txtLN5";
            this.txtLN5.Size = new System.Drawing.Size(100, 20);
            this.txtLN5.TabIndex = 4;
            // 
            // txtFN6
            // 
            this.txtFN6.Enabled = false;
            this.txtFN6.Location = new System.Drawing.Point(477, 279);
            this.txtFN6.Name = "txtFN6";
            this.txtFN6.Size = new System.Drawing.Size(100, 20);
            this.txtFN6.TabIndex = 4;
            // 
            // txtLN6
            // 
            this.txtLN6.Enabled = false;
            this.txtLN6.Location = new System.Drawing.Point(592, 279);
            this.txtLN6.Name = "txtLN6";
            this.txtLN6.Size = new System.Drawing.Size(100, 20);
            this.txtLN6.TabIndex = 4;
            // 
            // txtFN7
            // 
            this.txtFN7.Enabled = false;
            this.txtFN7.Location = new System.Drawing.Point(477, 305);
            this.txtFN7.Name = "txtFN7";
            this.txtFN7.Size = new System.Drawing.Size(100, 20);
            this.txtFN7.TabIndex = 4;
            // 
            // txtLN7
            // 
            this.txtLN7.Enabled = false;
            this.txtLN7.Location = new System.Drawing.Point(592, 305);
            this.txtLN7.Name = "txtLN7";
            this.txtLN7.Size = new System.Drawing.Size(100, 20);
            this.txtLN7.TabIndex = 4;
            // 
            // cmbAge0
            // 
            this.cmbAge0.FormattingEnabled = true;
            this.cmbAge0.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63",
            "64",
            "65",
            "66",
            "67",
            "68",
            "69",
            "70",
            "71",
            "72",
            "73",
            "74",
            "75",
            "76",
            "77",
            "78",
            "79",
            "80"});
            this.cmbAge0.Location = new System.Drawing.Point(699, 124);
            this.cmbAge0.Name = "cmbAge0";
            this.cmbAge0.Size = new System.Drawing.Size(48, 21);
            this.cmbAge0.TabIndex = 5;
            // 
            // cmbAge1
            // 
            this.cmbAge1.Enabled = false;
            this.cmbAge1.FormattingEnabled = true;
            this.cmbAge1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63",
            "64",
            "65",
            "66",
            "67",
            "68",
            "69",
            "70",
            "71",
            "72",
            "73",
            "74",
            "75",
            "76",
            "77",
            "78",
            "79",
            "80"});
            this.cmbAge1.Location = new System.Drawing.Point(699, 149);
            this.cmbAge1.Name = "cmbAge1";
            this.cmbAge1.Size = new System.Drawing.Size(48, 21);
            this.cmbAge1.TabIndex = 5;
            // 
            // cmbAge2
            // 
            this.cmbAge2.Enabled = false;
            this.cmbAge2.FormattingEnabled = true;
            this.cmbAge2.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63",
            "64",
            "65",
            "66",
            "67",
            "68",
            "69",
            "70",
            "71",
            "72",
            "73",
            "74",
            "75",
            "76",
            "77",
            "78",
            "79",
            "80"});
            this.cmbAge2.Location = new System.Drawing.Point(699, 176);
            this.cmbAge2.Name = "cmbAge2";
            this.cmbAge2.Size = new System.Drawing.Size(48, 21);
            this.cmbAge2.TabIndex = 5;
            // 
            // cmbAge3
            // 
            this.cmbAge3.Enabled = false;
            this.cmbAge3.FormattingEnabled = true;
            this.cmbAge3.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63",
            "64",
            "65",
            "66",
            "67",
            "68",
            "69",
            "70",
            "71",
            "72",
            "73",
            "74",
            "75",
            "76",
            "77",
            "78",
            "79",
            "80"});
            this.cmbAge3.Location = new System.Drawing.Point(698, 203);
            this.cmbAge3.Name = "cmbAge3";
            this.cmbAge3.Size = new System.Drawing.Size(48, 21);
            this.cmbAge3.TabIndex = 5;
            // 
            // cmbAge4
            // 
            this.cmbAge4.Enabled = false;
            this.cmbAge4.FormattingEnabled = true;
            this.cmbAge4.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63",
            "64",
            "65",
            "66",
            "67",
            "68",
            "69",
            "70",
            "71",
            "72",
            "73",
            "74",
            "75",
            "76",
            "77",
            "78",
            "79",
            "80"});
            this.cmbAge4.Location = new System.Drawing.Point(698, 226);
            this.cmbAge4.Name = "cmbAge4";
            this.cmbAge4.Size = new System.Drawing.Size(48, 21);
            this.cmbAge4.TabIndex = 5;
            // 
            // cmbAge5
            // 
            this.cmbAge5.Enabled = false;
            this.cmbAge5.FormattingEnabled = true;
            this.cmbAge5.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63",
            "64",
            "65",
            "66",
            "67",
            "68",
            "69",
            "70",
            "71",
            "72",
            "73",
            "74",
            "75",
            "76",
            "77",
            "78",
            "79",
            "80"});
            this.cmbAge5.Location = new System.Drawing.Point(698, 252);
            this.cmbAge5.Name = "cmbAge5";
            this.cmbAge5.Size = new System.Drawing.Size(48, 21);
            this.cmbAge5.TabIndex = 5;
            // 
            // cmbAge6
            // 
            this.cmbAge6.Enabled = false;
            this.cmbAge6.FormattingEnabled = true;
            this.cmbAge6.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63",
            "64",
            "65",
            "66",
            "67",
            "68",
            "69",
            "70",
            "71",
            "72",
            "73",
            "74",
            "75",
            "76",
            "77",
            "78",
            "79",
            "80"});
            this.cmbAge6.Location = new System.Drawing.Point(698, 278);
            this.cmbAge6.Name = "cmbAge6";
            this.cmbAge6.Size = new System.Drawing.Size(48, 21);
            this.cmbAge6.TabIndex = 5;
            // 
            // cmbAge7
            // 
            this.cmbAge7.Enabled = false;
            this.cmbAge7.FormattingEnabled = true;
            this.cmbAge7.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63",
            "64",
            "65",
            "66",
            "67",
            "68",
            "69",
            "70",
            "71",
            "72",
            "73",
            "74",
            "75",
            "76",
            "77",
            "78",
            "79",
            "80"});
            this.cmbAge7.Location = new System.Drawing.Point(698, 304);
            this.cmbAge7.Name = "cmbAge7";
            this.cmbAge7.Size = new System.Drawing.Size(48, 21);
            this.cmbAge7.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(474, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "First Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(589, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Last Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(705, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Age";
            // 
            // cmbOutAirport
            // 
            this.cmbOutAirport.FormattingEnabled = true;
            this.cmbOutAirport.Location = new System.Drawing.Point(185, 423);
            this.cmbOutAirport.Name = "cmbOutAirport";
            this.cmbOutAirport.Size = new System.Drawing.Size(121, 21);
            this.cmbOutAirport.TabIndex = 6;
            this.cmbOutAirport.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cmbDestPorts
            // 
            this.cmbDestPorts.FormattingEnabled = true;
            this.cmbDestPorts.Location = new System.Drawing.Point(185, 475);
            this.cmbDestPorts.Name = "cmbDestPorts";
            this.cmbDestPorts.Size = new System.Drawing.Size(121, 21);
            this.cmbDestPorts.TabIndex = 7;
            this.cmbDestPorts.SelectedIndexChanged += new System.EventHandler(this.cmbDestPorts_SelectedIndexChanged);
            // 
            // lblOutboundAirport
            // 
            this.lblOutboundAirport.AutoSize = true;
            this.lblOutboundAirport.Location = new System.Drawing.Point(182, 407);
            this.lblOutboundAirport.Name = "lblOutboundAirport";
            this.lblOutboundAirport.Size = new System.Drawing.Size(87, 13);
            this.lblOutboundAirport.TabIndex = 8;
            this.lblOutboundAirport.Text = "Outbound Airport";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(182, 459);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Destinations";
            // 
            // btnExtendedForecast
            // 
            this.btnExtendedForecast.Location = new System.Drawing.Point(78, 475);
            this.btnExtendedForecast.Name = "btnExtendedForecast";
            this.btnExtendedForecast.Size = new System.Drawing.Size(98, 48);
            this.btnExtendedForecast.TabIndex = 10;
            this.btnExtendedForecast.Text = "Get Extended Weather Forecasts";
            this.btnExtendedForecast.UseVisualStyleBackColor = true;
            this.btnExtendedForecast.Click += new System.EventHandler(this.btnWeatherForecast);
            // 
            // lblNumOfDays
            // 
            this.lblNumOfDays.AutoSize = true;
            this.lblNumOfDays.Location = new System.Drawing.Point(313, 423);
            this.lblNumOfDays.Name = "lblNumOfDays";
            this.lblNumOfDays.Size = new System.Drawing.Size(95, 13);
            this.lblNumOfDays.TabIndex = 11;
            this.lblNumOfDays.Text = "Number of Days: 0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(101, 419);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // btnGetPrices
            // 
            this.btnGetPrices.Location = new System.Drawing.Point(632, 408);
            this.btnGetPrices.Name = "btnGetPrices";
            this.btnGetPrices.Size = new System.Drawing.Size(114, 76);
            this.btnGetPrices.TabIndex = 13;
            this.btnGetPrices.Text = "Get Prices";
            this.btnGetPrices.UseVisualStyleBackColor = true;
            this.btnGetPrices.Click += new System.EventHandler(this.btnGetPrices_Click);
            // 
            // cmbHolTYpe
            // 
            this.cmbHolTYpe.FormattingEnabled = true;
            this.cmbHolTYpe.Items.AddRange(new object[] {
            "Just Flights",
            "Relax",
            "Cultural",
            "Adventure"});
            this.cmbHolTYpe.Location = new System.Drawing.Point(350, 203);
            this.cmbHolTYpe.Name = "cmbHolTYpe";
            this.cmbHolTYpe.Size = new System.Drawing.Size(121, 21);
            this.cmbHolTYpe.TabIndex = 14;
            this.cmbHolTYpe.Text = "Select from Type...";
            this.cmbHolTYpe.SelectedIndexChanged += new System.EventHandler(this.cmbHolTYpe_SelectedIndexChanged);
            // 
            // currentDate
            // 
            this.currentDate.Location = new System.Drawing.Point(79, 54);
            this.currentDate.Name = "currentDate";
            this.currentDate.TabIndex = 1;
            this.currentDate.Visible = false;
            this.currentDate.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.startCal_DateChanged);
            this.currentDate.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.startCal_DateSelected);
            // 
            // tmrISCompleted
            // 
            this.tmrISCompleted.Tick += new System.EventHandler(this.tmrIsCompleted_Tick);
            // 
            // btnAdmin
            // 
            this.btnAdmin.Location = new System.Drawing.Point(798, 488);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(75, 23);
            this.btnAdmin.TabIndex = 15;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // chkFC
            // 
            this.chkFC.AutoSize = true;
            this.chkFC.Location = new System.Drawing.Point(319, 378);
            this.chkFC.Name = "chkFC";
            this.chkFC.Size = new System.Drawing.Size(73, 17);
            this.chkFC.TabIndex = 16;
            this.chkFC.Text = "First Class";
            this.chkFC.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(350, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Type of Holiday";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(798, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 39);
            this.btnClose.TabIndex = 18;
            this.btnClose.Text = "Exit";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnExit_click);
            // 
            // MainSelectionPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 524);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.chkFC);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.cmbHolTYpe);
            this.Controls.Add(this.btnGetPrices);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblNumOfDays);
            this.Controls.Add(this.btnExtendedForecast);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblOutboundAirport);
            this.Controls.Add(this.cmbDestPorts);
            this.Controls.Add(this.cmbOutAirport);
            this.Controls.Add(this.cmbAge7);
            this.Controls.Add(this.cmbAge6);
            this.Controls.Add(this.cmbAge5);
            this.Controls.Add(this.cmbAge4);
            this.Controls.Add(this.cmbAge3);
            this.Controls.Add(this.cmbAge2);
            this.Controls.Add(this.cmbAge1);
            this.Controls.Add(this.cmbAge0);
            this.Controls.Add(this.txtLN7);
            this.Controls.Add(this.txtFN7);
            this.Controls.Add(this.txtLN6);
            this.Controls.Add(this.txtFN6);
            this.Controls.Add(this.txtLN5);
            this.Controls.Add(this.txtFN5);
            this.Controls.Add(this.txtLN4);
            this.Controls.Add(this.txtFN4);
            this.Controls.Add(this.txtLN3);
            this.Controls.Add(this.txtFN3);
            this.Controls.Add(this.txtLN2);
            this.Controls.Add(this.txtFN2);
            this.Controls.Add(this.txtLN1);
            this.Controls.Add(this.txtFN1);
            this.Controls.Add(this.txtLN0);
            this.Controls.Add(this.txtFN0);
            this.Controls.Add(this.cmbPassangers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.endCal);
            this.Controls.Add(this.currentDate);
            this.Controls.Add(this.startCal);
            this.Name = "MainSelectionPage";
            this.Text = "Main Selection Page";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar startCal;
        private System.Windows.Forms.MonthCalendar endCal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbPassangers;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFN0;
        private System.Windows.Forms.TextBox txtLN0;
        private System.Windows.Forms.TextBox txtFN1;
        private System.Windows.Forms.TextBox txtLN1;
        private System.Windows.Forms.TextBox txtFN2;
        private System.Windows.Forms.TextBox txtLN2;
        private System.Windows.Forms.TextBox txtFN3;
        private System.Windows.Forms.TextBox txtLN3;
        private System.Windows.Forms.TextBox txtFN4;
        private System.Windows.Forms.TextBox txtLN4;
        private System.Windows.Forms.TextBox txtFN5;
        private System.Windows.Forms.TextBox txtLN5;
        private System.Windows.Forms.TextBox txtFN6;
        private System.Windows.Forms.TextBox txtLN6;
        private System.Windows.Forms.TextBox txtFN7;
        private System.Windows.Forms.TextBox txtLN7;
        private System.Windows.Forms.ComboBox cmbAge0;
        private System.Windows.Forms.ComboBox cmbAge1;
        private System.Windows.Forms.ComboBox cmbAge2;
        private System.Windows.Forms.ComboBox cmbAge3;
        private System.Windows.Forms.ComboBox cmbAge4;
        private System.Windows.Forms.ComboBox cmbAge5;
        private System.Windows.Forms.ComboBox cmbAge6;
        private System.Windows.Forms.ComboBox cmbAge7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbOutAirport;
        private System.Windows.Forms.ComboBox cmbDestPorts;
        private System.Windows.Forms.Label lblOutboundAirport;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnExtendedForecast;
        private System.Windows.Forms.Label lblNumOfDays;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnGetPrices;
        private System.Windows.Forms.ComboBox cmbHolTYpe;
        private System.Windows.Forms.MonthCalendar currentDate;
        private System.Windows.Forms.Timer tmrISCompleted;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.CheckBox chkFC;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnClose;
    }
}

