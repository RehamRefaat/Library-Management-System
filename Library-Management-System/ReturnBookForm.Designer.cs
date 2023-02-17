
namespace WindowsFormsApp1
{
    partial class ReturnBookForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReturnBookForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.stdnameTb = new ns1.BunifuMaterialTextbox();
            this.label9 = new System.Windows.Forms.Label();
            this.BorroweDate = new ns1.BunifuDatepicker();
            this.label8 = new System.Windows.Forms.Label();
            this.Bookcb = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.StdCb = new System.Windows.Forms.ComboBox();
            this.PhoneTb = new ns1.BunifuMaterialTextbox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.stddpmntTb = new ns1.BunifuMaterialTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ReturnDate = new ns1.BunifuDatepicker();
            this.label10 = new System.Windows.Forms.Label();
            this.BorroweBookDGV = new Guna.UI.WinForms.GunaDataGridView();
            this.ReturnNumTb = new ns1.BunifuMaterialTextbox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.ReturnedBookDGV = new Guna.UI.WinForms.GunaDataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BorroweBookDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReturnedBookDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1375, 80);
            this.panel1.TabIndex = 21;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApp1.Properties.Resources.cross;
            this.pictureBox2.Location = new System.Drawing.Point(1322, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(53, 43);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(573, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 34);
            this.label2.TabIndex = 2;
            this.label2.Text = "RETURN BOOKS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(461, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(435, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "LIBRARY MANAGEMENT SYSTEM";
            // 
            // stdnameTb
            // 
            this.stdnameTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.stdnameTb.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stdnameTb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.stdnameTb.HintForeColor = System.Drawing.Color.Empty;
            this.stdnameTb.HintText = "";
            this.stdnameTb.isPassword = false;
            this.stdnameTb.LineFocusedColor = System.Drawing.Color.DarkSlateBlue;
            this.stdnameTb.LineIdleColor = System.Drawing.Color.Gray;
            this.stdnameTb.LineMouseHoverColor = System.Drawing.Color.DarkSlateBlue;
            this.stdnameTb.LineThickness = 3;
            this.stdnameTb.Location = new System.Drawing.Point(194, 216);
            this.stdnameTb.Margin = new System.Windows.Forms.Padding(5);
            this.stdnameTb.Name = "stdnameTb";
            this.stdnameTb.Size = new System.Drawing.Size(171, 34);
            this.stdnameTb.TabIndex = 81;
            this.stdnameTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label9.Location = new System.Drawing.Point(11, 216);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 30);
            this.label9.TabIndex = 80;
            this.label9.Text = " NAME";
            // 
            // BorroweDate
            // 
            this.BorroweDate.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.BorroweDate.BorderRadius = 0;
            this.BorroweDate.ForeColor = System.Drawing.Color.White;
            this.BorroweDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.BorroweDate.FormatCustom = null;
            this.BorroweDate.Location = new System.Drawing.Point(173, 456);
            this.BorroweDate.Margin = new System.Windows.Forms.Padding(5);
            this.BorroweDate.Name = "BorroweDate";
            this.BorroweDate.Size = new System.Drawing.Size(228, 42);
            this.BorroweDate.TabIndex = 79;
            this.BorroweDate.Value = new System.DateTime(2021, 12, 27, 0, 0, 0, 0);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label8.Location = new System.Drawing.Point(11, 456);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 30);
            this.label8.TabIndex = 78;
            this.label8.Text = "BORROWE";
            // 
            // Bookcb
            // 
            this.Bookcb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bookcb.FormattingEnabled = true;
            this.Bookcb.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.Bookcb.Location = new System.Drawing.Point(173, 397);
            this.Bookcb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Bookcb.Name = "Bookcb";
            this.Bookcb.Size = new System.Drawing.Size(228, 31);
            this.Bookcb.TabIndex = 77;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label6.Location = new System.Drawing.Point(11, 396);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 30);
            this.label6.TabIndex = 76;
            this.label6.Text = "BOOK";
            // 
            // StdCb
            // 
            this.StdCb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StdCb.FormattingEnabled = true;
            this.StdCb.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.StdCb.Location = new System.Drawing.Point(194, 160);
            this.StdCb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StdCb.Name = "StdCb";
            this.StdCb.Size = new System.Drawing.Size(171, 31);
            this.StdCb.TabIndex = 75;
            // 
            // PhoneTb
            // 
            this.PhoneTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PhoneTb.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneTb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PhoneTb.HintForeColor = System.Drawing.Color.Empty;
            this.PhoneTb.HintText = "";
            this.PhoneTb.isPassword = false;
            this.PhoneTb.LineFocusedColor = System.Drawing.Color.DarkSlateBlue;
            this.PhoneTb.LineIdleColor = System.Drawing.Color.Gray;
            this.PhoneTb.LineMouseHoverColor = System.Drawing.Color.DarkSlateBlue;
            this.PhoneTb.LineThickness = 3;
            this.PhoneTb.Location = new System.Drawing.Point(194, 328);
            this.PhoneTb.Margin = new System.Windows.Forms.Padding(5);
            this.PhoneTb.Name = "PhoneTb";
            this.PhoneTb.Size = new System.Drawing.Size(171, 34);
            this.PhoneTb.TabIndex = 74;
            this.PhoneTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label7.Location = new System.Drawing.Point(11, 332);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 30);
            this.label7.TabIndex = 73;
            this.label7.Text = "PHONE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label5.Location = new System.Drawing.Point(12, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 30);
            this.label5.TabIndex = 72;
            this.label5.Text = "DEPARTMENT";
            // 
            // stddpmntTb
            // 
            this.stddpmntTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.stddpmntTb.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stddpmntTb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.stddpmntTb.HintForeColor = System.Drawing.Color.Empty;
            this.stddpmntTb.HintText = "";
            this.stddpmntTb.isPassword = false;
            this.stddpmntTb.LineFocusedColor = System.Drawing.Color.DarkSlateBlue;
            this.stddpmntTb.LineIdleColor = System.Drawing.Color.Gray;
            this.stddpmntTb.LineMouseHoverColor = System.Drawing.Color.DarkSlateBlue;
            this.stddpmntTb.LineThickness = 3;
            this.stddpmntTb.Location = new System.Drawing.Point(194, 273);
            this.stddpmntTb.Margin = new System.Windows.Forms.Padding(5);
            this.stddpmntTb.Name = "stddpmntTb";
            this.stddpmntTb.Size = new System.Drawing.Size(171, 34);
            this.stddpmntTb.TabIndex = 71;
            this.stddpmntTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label4.Location = new System.Drawing.Point(11, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 30);
            this.label4.TabIndex = 70;
            this.label4.Text = "Student ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label3.Location = new System.Drawing.Point(11, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 30);
            this.label3.TabIndex = 69;
            this.label3.Text = "Process Num";
            // 
            // ReturnDate
            // 
            this.ReturnDate.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ReturnDate.BorderRadius = 0;
            this.ReturnDate.ForeColor = System.Drawing.Color.White;
            this.ReturnDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ReturnDate.FormatCustom = null;
            this.ReturnDate.Location = new System.Drawing.Point(173, 510);
            this.ReturnDate.Margin = new System.Windows.Forms.Padding(5);
            this.ReturnDate.Name = "ReturnDate";
            this.ReturnDate.Size = new System.Drawing.Size(228, 42);
            this.ReturnDate.TabIndex = 83;
            this.ReturnDate.Value = new System.DateTime(2021, 12, 9, 11, 39, 55, 839);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label10.Location = new System.Drawing.Point(15, 510);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 30);
            this.label10.TabIndex = 82;
            this.label10.Text = "RETURN";
            // 
            // BorroweBookDGV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.BorroweBookDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.BorroweBookDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BorroweBookDGV.BackgroundColor = System.Drawing.Color.White;
            this.BorroweBookDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BorroweBookDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.BorroweBookDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BorroweBookDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.BorroweBookDGV.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BorroweBookDGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.BorroweBookDGV.EnableHeadersVisualStyles = false;
            this.BorroweBookDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.BorroweBookDGV.Location = new System.Drawing.Point(418, 134);
            this.BorroweBookDGV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BorroweBookDGV.Name = "BorroweBookDGV";
            this.BorroweBookDGV.ReadOnly = true;
            this.BorroweBookDGV.RowHeadersVisible = false;
            this.BorroweBookDGV.RowHeadersWidth = 51;
            this.BorroweBookDGV.RowTemplate.Height = 24;
            this.BorroweBookDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BorroweBookDGV.Size = new System.Drawing.Size(945, 228);
            this.BorroweBookDGV.TabIndex = 84;
            this.BorroweBookDGV.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.BorroweBookDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.BorroweBookDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.BorroweBookDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.BorroweBookDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.BorroweBookDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.BorroweBookDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.BorroweBookDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.BorroweBookDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.BorroweBookDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.BorroweBookDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BorroweBookDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.BorroweBookDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.BorroweBookDGV.ThemeStyle.HeaderStyle.Height = 30;
            this.BorroweBookDGV.ThemeStyle.ReadOnly = true;
            this.BorroweBookDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.BorroweBookDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.BorroweBookDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BorroweBookDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.BorroweBookDGV.ThemeStyle.RowsStyle.Height = 24;
            this.BorroweBookDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.BorroweBookDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.BorroweBookDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BorroweBookDGV_CellContentClick);
            this.BorroweBookDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BorroweBookDGV_CellContentClick);
            // 
            // ReturnNumTb
            // 
            this.ReturnNumTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ReturnNumTb.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnNumTb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ReturnNumTb.HintForeColor = System.Drawing.Color.Empty;
            this.ReturnNumTb.HintText = "";
            this.ReturnNumTb.isPassword = false;
            this.ReturnNumTb.LineFocusedColor = System.Drawing.Color.DarkSlateBlue;
            this.ReturnNumTb.LineIdleColor = System.Drawing.Color.Gray;
            this.ReturnNumTb.LineMouseHoverColor = System.Drawing.Color.DarkSlateBlue;
            this.ReturnNumTb.LineThickness = 3;
            this.ReturnNumTb.Location = new System.Drawing.Point(194, 101);
            this.ReturnNumTb.Margin = new System.Windows.Forms.Padding(5);
            this.ReturnNumTb.Name = "ReturnNumTb";
            this.ReturnNumTb.Size = new System.Drawing.Size(171, 34);
            this.ReturnNumTb.TabIndex = 68;
            this.ReturnNumTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ReturnNumTb.OnValueChanged += new System.EventHandler(this.ReturnNumTb_OnValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label11.Location = new System.Drawing.Point(812, 101);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(198, 28);
            this.label11.TabIndex = 85;
            this.label11.Text = "Books Borrowed";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label12.Location = new System.Drawing.Point(812, 383);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(191, 28);
            this.label12.TabIndex = 86;
            this.label12.Text = "Books Returned";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // ReturnedBookDGV
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.ReturnedBookDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.ReturnedBookDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ReturnedBookDGV.BackgroundColor = System.Drawing.Color.White;
            this.ReturnedBookDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ReturnedBookDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ReturnedBookDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ReturnedBookDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.ReturnedBookDGV.ColumnHeadersHeight = 30;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ReturnedBookDGV.DefaultCellStyle = dataGridViewCellStyle6;
            this.ReturnedBookDGV.EnableHeadersVisualStyles = false;
            this.ReturnedBookDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ReturnedBookDGV.Location = new System.Drawing.Point(418, 413);
            this.ReturnedBookDGV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ReturnedBookDGV.Name = "ReturnedBookDGV";
            this.ReturnedBookDGV.ReadOnly = true;
            this.ReturnedBookDGV.RowHeadersVisible = false;
            this.ReturnedBookDGV.RowHeadersWidth = 51;
            this.ReturnedBookDGV.RowTemplate.Height = 24;
            this.ReturnedBookDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ReturnedBookDGV.Size = new System.Drawing.Size(945, 243);
            this.ReturnedBookDGV.TabIndex = 87;
            this.ReturnedBookDGV.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.ReturnedBookDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.ReturnedBookDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.ReturnedBookDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.ReturnedBookDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.ReturnedBookDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.ReturnedBookDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.ReturnedBookDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ReturnedBookDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ReturnedBookDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ReturnedBookDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnedBookDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.ReturnedBookDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.ReturnedBookDGV.ThemeStyle.HeaderStyle.Height = 30;
            this.ReturnedBookDGV.ThemeStyle.ReadOnly = true;
            this.ReturnedBookDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.ReturnedBookDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ReturnedBookDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnedBookDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ReturnedBookDGV.ThemeStyle.RowsStyle.Height = 24;
            this.ReturnedBookDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ReturnedBookDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ReturnedBookDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ReturnedBookDGV_CellContentClick);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(799, 660);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(192, 57);
            this.button2.TabIndex = 89;
            this.button2.Text = "PRINT";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(141, 660);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(134, 57);
            this.button4.TabIndex = 91;
            this.button4.Text = "Home";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.FromReturned_BooksToMainForm);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(96, 586);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(240, 53);
            this.button1.TabIndex = 88;
            this.button1.Text = "Return Book";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Return_Book);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 733);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1375, 27);
            this.panel2.TabIndex = 6;
            // 
            // ReturnBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1375, 760);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ReturnedBookDGV);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.BorroweBookDGV);
            this.Controls.Add(this.ReturnDate);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.stdnameTb);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.BorroweDate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Bookcb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.StdCb);
            this.Controls.Add(this.PhoneTb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.stddpmntTb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ReturnNumTb);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ReturnBookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReturnBookForm";
            this.Load += new System.EventHandler(this.ReturnBookForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BorroweBookDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReturnedBookDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private ns1.BunifuMaterialTextbox stdnameTb;
        private System.Windows.Forms.Label label9;
        private ns1.BunifuDatepicker BorroweDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox Bookcb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox StdCb;
        private ns1.BunifuMaterialTextbox PhoneTb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private ns1.BunifuMaterialTextbox stddpmntTb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private ns1.BunifuDatepicker ReturnDate;
        private System.Windows.Forms.Label label10;
        private Guna.UI.WinForms.GunaDataGridView BorroweBookDGV;
        private ns1.BunifuMaterialTextbox ReturnNumTb;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private Guna.UI.WinForms.GunaDataGridView ReturnedBookDGV;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Panel panel2;
    }
}