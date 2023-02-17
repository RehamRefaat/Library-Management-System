
namespace WindowsFormsApp1
{
    partial class Borrowed_Books
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.PhoneTb = new ns1.BunifuMaterialTextbox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.stddpmntTb = new ns1.BunifuMaterialTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BorroweNumTb = new ns1.BunifuMaterialTextbox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.StdCb = new System.Windows.Forms.ComboBox();
            this.Bookcb = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.BorroweDate = new ns1.BunifuDatepicker();
            this.label9 = new System.Windows.Forms.Label();
            this.stdnameTb = new ns1.BunifuMaterialTextbox();
            this.BorroweBookDGV = new Guna.UI.WinForms.GunaDataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BorroweBookDGV)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(1276, 82);
            this.panel1.TabIndex = 20;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApp1.Properties.Resources.cross;
            this.pictureBox2.Location = new System.Drawing.Point(1222, 2);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(51, 47);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.Exit);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(485, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(258, 34);
            this.label2.TabIndex = 2;
            this.label2.Text = "BORROWE BOOKS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(401, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(435, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "LIBRARY MANAGEMENT SYSTEM";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(112, 569);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(140, 52);
            this.button4.TabIndex = 59;
            this.button4.Text = "Home";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.FromBorrowedBooksToMainForm);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(745, 567);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(189, 56);
            this.button3.TabIndex = 58;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Borrowe_Cancele);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(84, 503);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(242, 54);
            this.button1.TabIndex = 56;
            this.button1.Text = "Borrowe Book";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Borrowe_Book);
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
            this.PhoneTb.Location = new System.Drawing.Point(188, 315);
            this.PhoneTb.Margin = new System.Windows.Forms.Padding(5);
            this.PhoneTb.Name = "PhoneTb";
            this.PhoneTb.Size = new System.Drawing.Size(171, 34);
            this.PhoneTb.TabIndex = 55;
            this.PhoneTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label7.Location = new System.Drawing.Point(14, 319);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 30);
            this.label7.TabIndex = 54;
            this.label7.Text = "PHONE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label5.Location = new System.Drawing.Point(14, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 30);
            this.label5.TabIndex = 53;
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
            this.stddpmntTb.Location = new System.Drawing.Point(188, 266);
            this.stddpmntTb.Margin = new System.Windows.Forms.Padding(5);
            this.stddpmntTb.Name = "stddpmntTb";
            this.stddpmntTb.Size = new System.Drawing.Size(171, 34);
            this.stddpmntTb.TabIndex = 52;
            this.stddpmntTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label4.Location = new System.Drawing.Point(14, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 30);
            this.label4.TabIndex = 50;
            this.label4.Text = "Student ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label3.Location = new System.Drawing.Point(14, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 30);
            this.label3.TabIndex = 49;
            this.label3.Text = "Process Num";
            // 
            // BorroweNumTb
            // 
            this.BorroweNumTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.BorroweNumTb.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BorroweNumTb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BorroweNumTb.HintForeColor = System.Drawing.Color.Empty;
            this.BorroweNumTb.HintText = "";
            this.BorroweNumTb.isPassword = false;
            this.BorroweNumTb.LineFocusedColor = System.Drawing.Color.DarkSlateBlue;
            this.BorroweNumTb.LineIdleColor = System.Drawing.Color.Gray;
            this.BorroweNumTb.LineMouseHoverColor = System.Drawing.Color.DarkSlateBlue;
            this.BorroweNumTb.LineThickness = 3;
            this.BorroweNumTb.Location = new System.Drawing.Point(188, 131);
            this.BorroweNumTb.Margin = new System.Windows.Forms.Padding(5);
            this.BorroweNumTb.Name = "BorroweNumTb";
            this.BorroweNumTb.Size = new System.Drawing.Size(171, 34);
            this.BorroweNumTb.TabIndex = 48;
            this.BorroweNumTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BorroweNumTb.OnValueChanged += new System.EventHandler(this.BorroweNumTb_OnValueChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 629);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1276, 18);
            this.panel2.TabIndex = 60;
            // 
            // StdCb
            // 
            this.StdCb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StdCb.FormattingEnabled = true;
            this.StdCb.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.StdCb.Location = new System.Drawing.Point(188, 184);
            this.StdCb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StdCb.Name = "StdCb";
            this.StdCb.Size = new System.Drawing.Size(171, 31);
            this.StdCb.TabIndex = 61;
            this.StdCb.SelectionChangeCommitted += new System.EventHandler(this.StdCd_SelectionChangeCommitted);
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
            this.Bookcb.Location = new System.Drawing.Point(187, 370);
            this.Bookcb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Bookcb.Name = "Bookcb";
            this.Bookcb.Size = new System.Drawing.Size(171, 31);
            this.Bookcb.TabIndex = 63;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label6.Location = new System.Drawing.Point(14, 369);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 30);
            this.label6.TabIndex = 62;
            this.label6.Text = "BOOK";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label8.Location = new System.Drawing.Point(14, 418);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 30);
            this.label8.TabIndex = 64;
            this.label8.Text = "DATE";
            // 
            // BorroweDate
            // 
            this.BorroweDate.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.BorroweDate.BorderRadius = 0;
            this.BorroweDate.ForeColor = System.Drawing.Color.White;
            this.BorroweDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.BorroweDate.FormatCustom = null;
            this.BorroweDate.Location = new System.Drawing.Point(152, 418);
            this.BorroweDate.Margin = new System.Windows.Forms.Padding(5);
            this.BorroweDate.Name = "BorroweDate";
            this.BorroweDate.Size = new System.Drawing.Size(207, 42);
            this.BorroweDate.TabIndex = 65;
            this.BorroweDate.Value = new System.DateTime(2021, 12, 9, 11, 39, 55, 839);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label9.Location = new System.Drawing.Point(14, 226);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 30);
            this.label9.TabIndex = 66;
            this.label9.Text = "NAME";
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
            this.stdnameTb.Location = new System.Drawing.Point(188, 222);
            this.stdnameTb.Margin = new System.Windows.Forms.Padding(5);
            this.stdnameTb.Name = "stdnameTb";
            this.stdnameTb.Size = new System.Drawing.Size(171, 34);
            this.stdnameTb.TabIndex = 67;
            this.stdnameTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.BorroweBookDGV.Location = new System.Drawing.Point(367, 93);
            this.BorroweBookDGV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BorroweBookDGV.Name = "BorroweBookDGV";
            this.BorroweBookDGV.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BorroweBookDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.BorroweBookDGV.RowHeadersVisible = false;
            this.BorroweBookDGV.RowHeadersWidth = 51;
            this.BorroweBookDGV.RowTemplate.Height = 24;
            this.BorroweBookDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BorroweBookDGV.Size = new System.Drawing.Size(897, 471);
            this.BorroweBookDGV.TabIndex = 68;
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
            // Borrowed_Books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1276, 647);
            this.Controls.Add(this.BorroweBookDGV);
            this.Controls.Add(this.stdnameTb);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.BorroweDate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Bookcb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.StdCb);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PhoneTb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.stddpmntTb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BorroweNumTb);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Borrowed_Books";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Borrowed_Books";
            this.Load += new System.EventHandler(this.Borrowed_Books_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BorroweBookDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private ns1.BunifuMaterialTextbox PhoneTb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private ns1.BunifuMaterialTextbox stddpmntTb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private ns1.BunifuMaterialTextbox BorroweNumTb;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox StdCb;
        private System.Windows.Forms.ComboBox Bookcb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private ns1.BunifuDatepicker BorroweDate;
        private System.Windows.Forms.Label label9;
        private ns1.BunifuMaterialTextbox stdnameTb;
        private Guna.UI.WinForms.GunaDataGridView BorroweBookDGV;
    }
}