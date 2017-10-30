namespace WindowsFormsApplication2
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.dc_time2 = new System.Windows.Forms.DateTimePicker();
            this.dc_time1 = new System.Windows.Forms.DateTimePicker();
            this.rd_captain = new System.Windows.Forms.CheckBox();
            this.rcrl_type = new System.Windows.Forms.CheckBox();
            this.rd_name = new System.Windows.Forms.CheckBox();
            this.rc_time = new System.Windows.Forms.CheckBox();
            this.rc_dosigudong = new System.Windows.Forms.CheckBox();
            this.rc_content = new System.Windows.Forms.CheckBox();
            this.rc_isend = new System.Windows.Forms.CheckBox();
            this.rc_id = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cd_captain = new System.Windows.Forms.ComboBox();
            this.cd_name = new System.Windows.Forms.ComboBox();
            this.cc_isend = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.td_captain = new System.Windows.Forms.TextBox();
            this.tcrl_type = new System.Windows.Forms.TextBox();
            this.td_name = new System.Windows.Forms.TextBox();
            this.tc_dong = new System.Windows.Forms.TextBox();
            this.tc_gu = new System.Windows.Forms.TextBox();
            this.tc_si = new System.Windows.Forms.TextBox();
            this.tc_do = new System.Windows.Forms.TextBox();
            this.tc_content = new System.Windows.Forms.TextBox();
            this.tc_id = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.c_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.c_isend = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.c_content = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.c_do = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.c_si = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.c_gu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.c_dong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.c_time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.c_dept = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.crl_type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.d_captain = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button2 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.day_comboBox = new System.Windows.Forms.ComboBox();
            this.crimelist_checkBox = new System.Windows.Forms.CheckBox();
            this.age_checkBox = new System.Windows.Forms.CheckBox();
            this.time_checkBox = new System.Windows.Forms.CheckBox();
            this.month_comboBox = new System.Windows.Forms.ComboBox();
            this.year_comboBox = new System.Windows.Forms.ComboBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1039, 766);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.dc_time2);
            this.tabPage1.Controls.Add(this.dc_time1);
            this.tabPage1.Controls.Add(this.rd_captain);
            this.tabPage1.Controls.Add(this.rcrl_type);
            this.tabPage1.Controls.Add(this.rd_name);
            this.tabPage1.Controls.Add(this.rc_time);
            this.tabPage1.Controls.Add(this.rc_dosigudong);
            this.tabPage1.Controls.Add(this.rc_content);
            this.tabPage1.Controls.Add(this.rc_isend);
            this.tabPage1.Controls.Add(this.rc_id);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.cd_captain);
            this.tabPage1.Controls.Add(this.cd_name);
            this.tabPage1.Controls.Add(this.cc_isend);
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.button5);
            this.tabPage1.Controls.Add(this.td_captain);
            this.tabPage1.Controls.Add(this.tcrl_type);
            this.tabPage1.Controls.Add(this.td_name);
            this.tabPage1.Controls.Add(this.tc_dong);
            this.tabPage1.Controls.Add(this.tc_gu);
            this.tabPage1.Controls.Add(this.tc_si);
            this.tabPage1.Controls.Add(this.tc_do);
            this.tabPage1.Controls.Add(this.tc_content);
            this.tabPage1.Controls.Add(this.tc_id);
            this.tabPage1.Controls.Add(this.listView1);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(1031, 740);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "사건";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(756, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 12);
            this.label6.TabIndex = 43;
            this.label6.Text = "~";
            // 
            // dc_time2
            // 
            this.dc_time2.Location = new System.Drawing.Point(778, 20);
            this.dc_time2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dc_time2.Name = "dc_time2";
            this.dc_time2.Size = new System.Drawing.Size(175, 21);
            this.dc_time2.TabIndex = 42;
            // 
            // dc_time1
            // 
            this.dc_time1.Location = new System.Drawing.Point(575, 20);
            this.dc_time1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dc_time1.Name = "dc_time1";
            this.dc_time1.Size = new System.Drawing.Size(175, 21);
            this.dc_time1.TabIndex = 42;
            // 
            // rd_captain
            // 
            this.rd_captain.AutoSize = true;
            this.rd_captain.Location = new System.Drawing.Point(493, 121);
            this.rd_captain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rd_captain.Name = "rd_captain";
            this.rd_captain.Size = new System.Drawing.Size(60, 16);
            this.rd_captain.TabIndex = 41;
            this.rd_captain.Text = "담당자";
            this.rd_captain.UseVisualStyleBackColor = true;
            this.rd_captain.CheckedChanged += new System.EventHandler(this.rd_captain_CheckedChanged);
            // 
            // rcrl_type
            // 
            this.rcrl_type.AutoSize = true;
            this.rcrl_type.Location = new System.Drawing.Point(492, 89);
            this.rcrl_type.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rcrl_type.Name = "rcrl_type";
            this.rcrl_type.Size = new System.Drawing.Size(72, 16);
            this.rcrl_type.TabIndex = 41;
            this.rcrl_type.Text = "범죄종류";
            this.rcrl_type.UseVisualStyleBackColor = true;
            this.rcrl_type.CheckedChanged += new System.EventHandler(this.rcrl_type_CheckedChanged);
            // 
            // rd_name
            // 
            this.rd_name.AutoSize = true;
            this.rd_name.Location = new System.Drawing.Point(493, 58);
            this.rd_name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rd_name.Name = "rd_name";
            this.rd_name.Size = new System.Drawing.Size(48, 16);
            this.rd_name.TabIndex = 41;
            this.rd_name.Text = "부서";
            this.rd_name.UseVisualStyleBackColor = true;
            this.rd_name.CheckedChanged += new System.EventHandler(this.rd_name_CheckedChanged);
            // 
            // rc_time
            // 
            this.rc_time.AutoSize = true;
            this.rc_time.Location = new System.Drawing.Point(492, 23);
            this.rc_time.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rc_time.Name = "rc_time";
            this.rc_time.Size = new System.Drawing.Size(72, 16);
            this.rc_time.TabIndex = 41;
            this.rc_time.Text = "발생날짜";
            this.rc_time.UseVisualStyleBackColor = true;
            this.rc_time.CheckedChanged += new System.EventHandler(this.rc_time_CheckedChanged);
            // 
            // rc_dosigudong
            // 
            this.rc_dosigudong.AutoSize = true;
            this.rc_dosigudong.Location = new System.Drawing.Point(74, 121);
            this.rc_dosigudong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rc_dosigudong.Name = "rc_dosigudong";
            this.rc_dosigudong.Size = new System.Drawing.Size(48, 16);
            this.rc_dosigudong.TabIndex = 41;
            this.rc_dosigudong.Text = "장소";
            this.rc_dosigudong.UseVisualStyleBackColor = true;
            this.rc_dosigudong.CheckedChanged += new System.EventHandler(this.rc_dosigudong_CheckedChanged);
            // 
            // rc_content
            // 
            this.rc_content.AutoSize = true;
            this.rc_content.Location = new System.Drawing.Point(74, 89);
            this.rc_content.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rc_content.Name = "rc_content";
            this.rc_content.Size = new System.Drawing.Size(72, 16);
            this.rc_content.TabIndex = 41;
            this.rc_content.Text = "사건내용";
            this.rc_content.UseVisualStyleBackColor = true;
            this.rc_content.CheckedChanged += new System.EventHandler(this.rc_content_CheckedChanged);
            // 
            // rc_isend
            // 
            this.rc_isend.AutoSize = true;
            this.rc_isend.Location = new System.Drawing.Point(74, 57);
            this.rc_isend.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rc_isend.Name = "rc_isend";
            this.rc_isend.Size = new System.Drawing.Size(76, 16);
            this.rc_isend.TabIndex = 41;
            this.rc_isend.Text = "해결 여부";
            this.rc_isend.UseVisualStyleBackColor = true;
            this.rc_isend.CheckedChanged += new System.EventHandler(this.rc_isend_CheckedChanged);
            // 
            // rc_id
            // 
            this.rc_id.AutoSize = true;
            this.rc_id.Location = new System.Drawing.Point(74, 23);
            this.rc_id.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rc_id.Name = "rc_id";
            this.rc_id.Size = new System.Drawing.Size(63, 16);
            this.rc_id.TabIndex = 41;
            this.rc_id.Text = "사건 ID";
            this.rc_id.UseVisualStyleBackColor = true;
            this.rc_id.CheckedChanged += new System.EventHandler(this.rc_id_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 10F);
            this.label4.Location = new System.Drawing.Point(430, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 14);
            this.label4.TabIndex = 40;
            this.label4.Text = "동";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 10F);
            this.label3.Location = new System.Drawing.Point(361, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 14);
            this.label3.TabIndex = 39;
            this.label3.Text = "구";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 10F);
            this.label2.Location = new System.Drawing.Point(291, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 14);
            this.label2.TabIndex = 38;
            this.label2.Text = "시";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 10F);
            this.label5.Location = new System.Drawing.Point(219, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 14);
            this.label5.TabIndex = 37;
            this.label5.Text = "도";
            // 
            // cd_captain
            // 
            this.cd_captain.FormattingEnabled = true;
            this.cd_captain.Items.AddRange(new object[] {
            "ID",
            "이름"});
            this.cd_captain.Location = new System.Drawing.Point(575, 118);
            this.cd_captain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cd_captain.Name = "cd_captain";
            this.cd_captain.Size = new System.Drawing.Size(63, 20);
            this.cd_captain.TabIndex = 36;
            // 
            // cd_name
            // 
            this.cd_name.FormattingEnabled = true;
            this.cd_name.Items.AddRange(new object[] {
            "ID",
            "이름"});
            this.cd_name.Location = new System.Drawing.Point(575, 56);
            this.cd_name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cd_name.Name = "cd_name";
            this.cd_name.Size = new System.Drawing.Size(63, 20);
            this.cd_name.TabIndex = 36;
            // 
            // cc_isend
            // 
            this.cc_isend.FormattingEnabled = true;
            this.cc_isend.Items.AddRange(new object[] {
            "해결(Y)",
            "미해결(N)"});
            this.cc_isend.Location = new System.Drawing.Point(160, 55);
            this.cc_isend.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cc_isend.Name = "cc_isend";
            this.cc_isend.Size = new System.Drawing.Size(106, 20);
            this.cc_isend.TabIndex = 35;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(829, 111);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(66, 20);
            this.button4.TabIndex = 34;
            this.button4.Text = "전체보기";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(829, 73);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(66, 20);
            this.button5.TabIndex = 25;
            this.button5.Text = "검색";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // td_captain
            // 
            this.td_captain.Location = new System.Drawing.Point(642, 118);
            this.td_captain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.td_captain.Name = "td_captain";
            this.td_captain.Size = new System.Drawing.Size(127, 21);
            this.td_captain.TabIndex = 23;
            // 
            // tcrl_type
            // 
            this.tcrl_type.Location = new System.Drawing.Point(575, 86);
            this.tcrl_type.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tcrl_type.Name = "tcrl_type";
            this.tcrl_type.Size = new System.Drawing.Size(194, 21);
            this.tcrl_type.TabIndex = 22;
            // 
            // td_name
            // 
            this.td_name.Location = new System.Drawing.Point(642, 55);
            this.td_name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.td_name.Name = "td_name";
            this.td_name.Size = new System.Drawing.Size(127, 21);
            this.td_name.TabIndex = 21;
            // 
            // tc_dong
            // 
            this.tc_dong.Location = new System.Drawing.Point(388, 118);
            this.tc_dong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tc_dong.Name = "tc_dong";
            this.tc_dong.Size = new System.Drawing.Size(41, 21);
            this.tc_dong.TabIndex = 19;
            // 
            // tc_gu
            // 
            this.tc_gu.Location = new System.Drawing.Point(319, 118);
            this.tc_gu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tc_gu.Name = "tc_gu";
            this.tc_gu.Size = new System.Drawing.Size(41, 21);
            this.tc_gu.TabIndex = 18;
            // 
            // tc_si
            // 
            this.tc_si.Location = new System.Drawing.Point(249, 118);
            this.tc_si.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tc_si.Name = "tc_si";
            this.tc_si.Size = new System.Drawing.Size(41, 21);
            this.tc_si.TabIndex = 17;
            // 
            // tc_do
            // 
            this.tc_do.Location = new System.Drawing.Point(160, 118);
            this.tc_do.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tc_do.Name = "tc_do";
            this.tc_do.Size = new System.Drawing.Size(57, 21);
            this.tc_do.TabIndex = 16;
            // 
            // tc_content
            // 
            this.tc_content.Location = new System.Drawing.Point(160, 86);
            this.tc_content.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tc_content.Name = "tc_content";
            this.tc_content.Size = new System.Drawing.Size(203, 21);
            this.tc_content.TabIndex = 15;
            // 
            // tc_id
            // 
            this.tc_id.Location = new System.Drawing.Point(160, 22);
            this.tc_id.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tc_id.Name = "tc_id";
            this.tc_id.Size = new System.Drawing.Size(203, 21);
            this.tc_id.TabIndex = 14;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.c_id,
            this.c_isend,
            this.c_content,
            this.c_do,
            this.c_si,
            this.c_gu,
            this.c_dong,
            this.c_time,
            this.c_dept,
            this.crl_type,
            this.d_captain});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(5, 158);
            this.listView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1013, 311);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // c_id
            // 
            this.c_id.Text = "사건 ID";
            this.c_id.Width = 70;
            // 
            // c_isend
            // 
            this.c_isend.Text = "해결여부";
            this.c_isend.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.c_isend.Width = 75;
            // 
            // c_content
            // 
            this.c_content.Text = "사건 내용";
            this.c_content.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.c_content.Width = 140;
            // 
            // c_do
            // 
            this.c_do.Text = "도";
            this.c_do.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.c_do.Width = 74;
            // 
            // c_si
            // 
            this.c_si.Text = "시";
            this.c_si.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.c_si.Width = 50;
            // 
            // c_gu
            // 
            this.c_gu.Text = "구";
            this.c_gu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.c_gu.Width = 50;
            // 
            // c_dong
            // 
            this.c_dong.Text = "동";
            this.c_dong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.c_dong.Width = 50;
            // 
            // c_time
            // 
            this.c_time.Text = "발생 날짜";
            this.c_time.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.c_time.Width = 185;
            // 
            // c_dept
            // 
            this.c_dept.Text = "부서";
            this.c_dept.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.c_dept.Width = 110;
            // 
            // crl_type
            // 
            this.crl_type.Text = "범죄 종류";
            this.crl_type.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.crl_type.Width = 110;
            // 
            // d_captain
            // 
            this.d_captain.Text = "담당자";
            this.d_captain.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.d_captain.Width = 65;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(899, 472);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 29);
            this.button2.TabIndex = 7;
            this.button2.Text = "상세 보기";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listView2);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Controls.Add(this.comboBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(1031, 740);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "범죄 종류";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader12,
            this.columnHeader13});
            this.listView2.FullRowSelect = true;
            this.listView2.GridLines = true;
            this.listView2.Location = new System.Drawing.Point(69, 66);
            this.listView2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(903, 414);
            this.listView2.TabIndex = 11;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 40;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "범죄 이름";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "      설명";
            this.columnHeader3.Width = 590;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "징역(개월)";
            this.columnHeader12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader12.Width = 90;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "벌금(원)";
            this.columnHeader13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader13.Width = 80;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(795, 28);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 20);
            this.button1.TabIndex = 10;
            this.button1.Text = "전체보기";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(721, 29);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(59, 20);
            this.button3.TabIndex = 10;
            this.button3.Text = "검색";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(400, 28);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(310, 21);
            this.textBox2.TabIndex = 9;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "ID",
            "범죄 이름",
            "설명",
            "징역",
            "벌금"});
            this.comboBox2.Location = new System.Drawing.Point(249, 28);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(113, 20);
            this.comboBox2.TabIndex = 7;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.pictureBox1);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.comboBox3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Size = new System.Drawing.Size(1031, 740);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "지도 검색";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication2.Properties.Resources.area_all2;
            this.pictureBox1.Location = new System.Drawing.Point(453, 26);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(363, 464);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 18F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(8, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 24);
            this.label1.TabIndex = 19;
            this.label1.Text = "지역 선택";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(137, 60);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 20);
            this.comboBox3.TabIndex = 17;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label9);
            this.tabPage4.Controls.Add(this.label8);
            this.tabPage4.Controls.Add(this.label7);
            this.tabPage4.Controls.Add(this.day_comboBox);
            this.tabPage4.Controls.Add(this.crimelist_checkBox);
            this.tabPage4.Controls.Add(this.age_checkBox);
            this.tabPage4.Controls.Add(this.time_checkBox);
            this.tabPage4.Controls.Add(this.month_comboBox);
            this.tabPage4.Controls.Add(this.year_comboBox);
            this.tabPage4.Controls.Add(this.chart1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage4.Size = new System.Drawing.Size(1031, 740);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "통계";
            this.tabPage4.UseVisualStyleBackColor = true;
            this.tabPage4.Click += new System.EventHandler(this.tabPage4_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 222);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 12);
            this.label9.TabIndex = 9;
            this.label9.Text = "요일";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 198);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 12);
            this.label8.TabIndex = 8;
            this.label8.Text = "월";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 12);
            this.label7.TabIndex = 7;
            this.label7.Text = "년";
            // 
            // day_comboBox
            // 
            this.day_comboBox.FormattingEnabled = true;
            this.day_comboBox.Location = new System.Drawing.Point(62, 215);
            this.day_comboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.day_comboBox.Name = "day_comboBox";
            this.day_comboBox.Size = new System.Drawing.Size(79, 20);
            this.day_comboBox.TabIndex = 6;
            this.day_comboBox.SelectedIndexChanged += new System.EventHandler(this.day_comboBox_SelectedIndexChanged);
            // 
            // crimelist_checkBox
            // 
            this.crimelist_checkBox.AutoSize = true;
            this.crimelist_checkBox.Location = new System.Drawing.Point(20, 78);
            this.crimelist_checkBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.crimelist_checkBox.Name = "crimelist_checkBox";
            this.crimelist_checkBox.Size = new System.Drawing.Size(72, 16);
            this.crimelist_checkBox.TabIndex = 5;
            this.crimelist_checkBox.Text = "범죄종류";
            this.crimelist_checkBox.UseVisualStyleBackColor = true;
            this.crimelist_checkBox.CheckStateChanged += new System.EventHandler(this.crimelist_checkBox_CheckStateChanged);
            // 
            // age_checkBox
            // 
            this.age_checkBox.AutoSize = true;
            this.age_checkBox.Location = new System.Drawing.Point(20, 108);
            this.age_checkBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.age_checkBox.Name = "age_checkBox";
            this.age_checkBox.Size = new System.Drawing.Size(48, 16);
            this.age_checkBox.TabIndex = 4;
            this.age_checkBox.Text = "연령";
            this.age_checkBox.UseVisualStyleBackColor = true;
            this.age_checkBox.CheckStateChanged += new System.EventHandler(this.age_checkBox_CheckStateChanged);
            // 
            // time_checkBox
            // 
            this.time_checkBox.AutoSize = true;
            this.time_checkBox.Location = new System.Drawing.Point(20, 137);
            this.time_checkBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.time_checkBox.Name = "time_checkBox";
            this.time_checkBox.Size = new System.Drawing.Size(48, 16);
            this.time_checkBox.TabIndex = 3;
            this.time_checkBox.Text = "기간";
            this.time_checkBox.UseVisualStyleBackColor = true;
            this.time_checkBox.CheckStateChanged += new System.EventHandler(this.time_checkBox_CheckStateChanged);
            // 
            // month_comboBox
            // 
            this.month_comboBox.FormattingEnabled = true;
            this.month_comboBox.Location = new System.Drawing.Point(62, 191);
            this.month_comboBox.Name = "month_comboBox";
            this.month_comboBox.Size = new System.Drawing.Size(79, 20);
            this.month_comboBox.TabIndex = 2;
            this.month_comboBox.SelectedIndexChanged += new System.EventHandler(this.month_SelectedIndexChanged);
            // 
            // year_comboBox
            // 
            this.year_comboBox.FormattingEnabled = true;
            this.year_comboBox.Location = new System.Drawing.Point(62, 166);
            this.year_comboBox.Name = "year_comboBox";
            this.year_comboBox.Size = new System.Drawing.Size(79, 20);
            this.year_comboBox.TabIndex = 1;
            this.year_comboBox.SelectedIndexChanged += new System.EventHandler(this.year_comboBox_SelectedIndexChanged);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(108, 51);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(927, 454);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 527);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader c_id;
        private System.Windows.Forms.ColumnHeader c_isend;
        private System.Windows.Forms.ColumnHeader c_content;
        private System.Windows.Forms.ColumnHeader c_do;
        private System.Windows.Forms.ColumnHeader c_si;
        private System.Windows.Forms.ColumnHeader c_gu;
        private System.Windows.Forms.ColumnHeader c_dong;
        private System.Windows.Forms.ColumnHeader c_time;
        private System.Windows.Forms.ColumnHeader c_dept;
        private System.Windows.Forms.ColumnHeader crl_type;
        private System.Windows.Forms.ColumnHeader d_captain;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox month_comboBox;
        private System.Windows.Forms.ComboBox year_comboBox;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cd_name;
        private System.Windows.Forms.ComboBox cc_isend;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox td_captain;
        private System.Windows.Forms.TextBox tcrl_type;
        private System.Windows.Forms.TextBox td_name;
        private System.Windows.Forms.TextBox tc_dong;
        private System.Windows.Forms.TextBox tc_gu;
        private System.Windows.Forms.TextBox tc_si;
        private System.Windows.Forms.TextBox tc_do;
        private System.Windows.Forms.TextBox tc_content;
        private System.Windows.Forms.TextBox tc_id;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox rc_id;
        private System.Windows.Forms.CheckBox rc_isend;
        private System.Windows.Forms.CheckBox rd_captain;
        private System.Windows.Forms.CheckBox rcrl_type;
        private System.Windows.Forms.CheckBox rd_name;
        private System.Windows.Forms.CheckBox rc_time;
        private System.Windows.Forms.CheckBox rc_dosigudong;
        private System.Windows.Forms.CheckBox rc_content;
        private System.Windows.Forms.ComboBox cd_captain;
        private System.Windows.Forms.DateTimePicker dc_time1;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dc_time2;
        private System.Windows.Forms.CheckBox crimelist_checkBox;
        private System.Windows.Forms.CheckBox age_checkBox;
        private System.Windows.Forms.CheckBox time_checkBox;
        private System.Windows.Forms.ComboBox day_comboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}