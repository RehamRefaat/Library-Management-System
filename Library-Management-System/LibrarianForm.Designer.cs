
namespace WindowsFormsApp1
{
    partial class LibrarianForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LibrarianDGV = new Guna.UI.WinForms.GunaDataGridView();
            this.Home = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.LibPhone = new ns1.BunifuMaterialTextbox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LibPassword = new ns1.BunifuMaterialTextbox();
            this.LibName = new ns1.BunifuMaterialTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LibId = new ns1.BunifuMaterialTextbox();
            this.mylibrarydbDataSet = new WindowsFormsApp1.MylibrarydbDataSet();
            this.librarianTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.librarianTblTableAdapter = new WindowsFormsApp1.MylibrarydbDataSetTableAdapters.LibrarianTblTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LibrarianDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mylibrarydbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.librarianTblBindingSource)).BeginInit();
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
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(774, 83);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApp1.Properties.Resources.cross;
            this.pictureBox2.Location = new System.Drawing.Point(731, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(43, 43);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.Exit);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(319, 40);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 33);
            this.label2.TabIndex = 2;
            this.label2.Text = "LIBRARIANS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(195, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(413, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "LIBRARY MANAGEMENT SYSTEM";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 502);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(774, 24);
            this.panel2.TabIndex = 18;
            // 
            // LibrarianDGV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.LibrarianDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.LibrarianDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.LibrarianDGV.BackgroundColor = System.Drawing.Color.White;
            this.LibrarianDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LibrarianDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.LibrarianDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.LibrarianDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.LibrarianDGV.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.LibrarianDGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.LibrarianDGV.EnableHeadersVisualStyles = false;
            this.LibrarianDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.LibrarianDGV.Location = new System.Drawing.Point(305, 96);
            this.LibrarianDGV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LibrarianDGV.Name = "LibrarianDGV";
            this.LibrarianDGV.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.LibrarianDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.LibrarianDGV.RowHeadersVisible = false;
            this.LibrarianDGV.RowHeadersWidth = 51;
            this.LibrarianDGV.RowTemplate.Height = 24;
            this.LibrarianDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.LibrarianDGV.Size = new System.Drawing.Size(460, 392);
            this.LibrarianDGV.TabIndex = 19;
            this.LibrarianDGV.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.LibrarianDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.LibrarianDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.LibrarianDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.LibrarianDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.LibrarianDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.LibrarianDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.LibrarianDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.LibrarianDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.LibrarianDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.LibrarianDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LibrarianDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.LibrarianDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.LibrarianDGV.ThemeStyle.HeaderStyle.Height = 30;
            this.LibrarianDGV.ThemeStyle.ReadOnly = true;
            this.LibrarianDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.LibrarianDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.LibrarianDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LibrarianDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.LibrarianDGV.ThemeStyle.RowsStyle.Height = 24;
            this.LibrarianDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.LibrarianDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.LibrarianDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.LibrarianDGV_CellContentClick);
            // 
            // Home
            // 
            this.Home.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.Home.FlatAppearance.BorderSize = 0;
            this.Home.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Home.ForeColor = System.Drawing.Color.White;
            this.Home.Location = new System.Drawing.Point(109, 396);
            this.Home.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(88, 34);
            this.Home.TabIndex = 47;
            this.Home.Text = "Home";
            this.Home.UseVisualStyleBackColor = false;
            this.Home.Click += new System.EventHandler(this.FromLibrarianToMainForm);
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.Delete.FlatAppearance.BorderSize = 0;
            this.Delete.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.ForeColor = System.Drawing.Color.White;
            this.Delete.Location = new System.Drawing.Point(109, 358);
            this.Delete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(87, 34);
            this.Delete.TabIndex = 46;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.DeleteLibrarian);
            // 
            // Edit
            // 
            this.Edit.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.Edit.FlatAppearance.BorderSize = 0;
            this.Edit.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edit.ForeColor = System.Drawing.Color.White;
            this.Edit.Location = new System.Drawing.Point(200, 358);
            this.Edit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(87, 34);
            this.Edit.TabIndex = 45;
            this.Edit.Text = "Edit";
            this.Edit.UseVisualStyleBackColor = false;
            this.Edit.Click += new System.EventHandler(this.EditLibrarian);
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.Add.FlatAppearance.BorderSize = 0;
            this.Add.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.ForeColor = System.Drawing.Color.White;
            this.Add.Location = new System.Drawing.Point(16, 358);
            this.Add.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(88, 34);
            this.Add.TabIndex = 44;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.AddLibrarian);
            // 
            // LibPhone
            // 
            this.LibPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LibPhone.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LibPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LibPhone.HintForeColor = System.Drawing.Color.Empty;
            this.LibPhone.HintText = "";
            this.LibPhone.isPassword = false;
            this.LibPhone.LineFocusedColor = System.Drawing.Color.DarkSlateBlue;
            this.LibPhone.LineIdleColor = System.Drawing.Color.Gray;
            this.LibPhone.LineMouseHoverColor = System.Drawing.Color.DarkSlateBlue;
            this.LibPhone.LineThickness = 3;
            this.LibPhone.Location = new System.Drawing.Point(156, 261);
            this.LibPhone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LibPhone.Name = "LibPhone";
            this.LibPhone.Size = new System.Drawing.Size(140, 28);
            this.LibPhone.TabIndex = 43;
            this.LibPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label7.Location = new System.Drawing.Point(29, 270);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 22);
            this.label7.TabIndex = 42;
            this.label7.Text = "PHONE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label5.Location = new System.Drawing.Point(29, 227);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 22);
            this.label5.TabIndex = 41;
            this.label5.Text = "PASSWORD";
            // 
            // LibPassword
            // 
            this.LibPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LibPassword.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LibPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LibPassword.HintForeColor = System.Drawing.Color.Empty;
            this.LibPassword.HintText = "";
            this.LibPassword.isPassword = false;
            this.LibPassword.LineFocusedColor = System.Drawing.Color.DarkSlateBlue;
            this.LibPassword.LineIdleColor = System.Drawing.Color.Gray;
            this.LibPassword.LineMouseHoverColor = System.Drawing.Color.DarkSlateBlue;
            this.LibPassword.LineThickness = 3;
            this.LibPassword.Location = new System.Drawing.Point(155, 219);
            this.LibPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LibPassword.Name = "LibPassword";
            this.LibPassword.Size = new System.Drawing.Size(140, 28);
            this.LibPassword.TabIndex = 40;
            this.LibPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // LibName
            // 
            this.LibName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LibName.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LibName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LibName.HintForeColor = System.Drawing.Color.Empty;
            this.LibName.HintText = "";
            this.LibName.isPassword = false;
            this.LibName.LineFocusedColor = System.Drawing.Color.DarkSlateBlue;
            this.LibName.LineIdleColor = System.Drawing.Color.Gray;
            this.LibName.LineMouseHoverColor = System.Drawing.Color.DarkSlateBlue;
            this.LibName.LineThickness = 3;
            this.LibName.Location = new System.Drawing.Point(155, 179);
            this.LibName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LibName.Name = "LibName";
            this.LibName.Size = new System.Drawing.Size(140, 28);
            this.LibName.TabIndex = 39;
            this.LibName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label4.Location = new System.Drawing.Point(29, 187);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 22);
            this.label4.TabIndex = 38;
            this.label4.Text = "NAME";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label3.Location = new System.Drawing.Point(29, 151);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 22);
            this.label3.TabIndex = 37;
            this.label3.Text = "ID";
            // 
            // LibId
            // 
            this.LibId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LibId.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LibId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LibId.HintForeColor = System.Drawing.Color.Empty;
            this.LibId.HintText = "";
            this.LibId.isPassword = false;
            this.LibId.LineFocusedColor = System.Drawing.Color.DarkSlateBlue;
            this.LibId.LineIdleColor = System.Drawing.Color.Gray;
            this.LibId.LineMouseHoverColor = System.Drawing.Color.DarkSlateBlue;
            this.LibId.LineThickness = 3;
            this.LibId.Location = new System.Drawing.Point(155, 143);
            this.LibId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LibId.Name = "LibId";
            this.LibId.Size = new System.Drawing.Size(140, 28);
            this.LibId.TabIndex = 36;
            this.LibId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // mylibrarydbDataSet
            // 
            this.mylibrarydbDataSet.DataSetName = "MylibrarydbDataSet";
            this.mylibrarydbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // librarianTblBindingSource
            // 
            this.librarianTblBindingSource.DataMember = "LibrarianTbl";
            this.librarianTblBindingSource.DataSource = this.mylibrarydbDataSet;
            // 
            // librarianTblTableAdapter
            // 
            this.librarianTblTableAdapter.ClearBeforeFill = true;
            // 
            // LibrarianForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(774, 526);
            this.Controls.Add(this.Home);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.LibPhone);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LibPassword);
            this.Controls.Add(this.LibName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LibId);
            this.Controls.Add(this.LibrarianDGV);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.LightGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "LibrarianForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LibrarianForm";
            this.Load += new System.EventHandler(this.LibrarianForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LibrarianDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mylibrarydbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.librarianTblBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI.WinForms.GunaDataGridView LibrarianDGV;
        private System.Windows.Forms.Button Home;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Button Add;
        private ns1.BunifuMaterialTextbox LibPhone;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private ns1.BunifuMaterialTextbox LibPassword;
        private ns1.BunifuMaterialTextbox LibName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private ns1.BunifuMaterialTextbox LibId;
        private MylibrarydbDataSet mylibrarydbDataSet;
        private System.Windows.Forms.BindingSource librarianTblBindingSource;
        private MylibrarydbDataSetTableAdapters.LibrarianTblTableAdapter librarianTblTableAdapter;
    }
}