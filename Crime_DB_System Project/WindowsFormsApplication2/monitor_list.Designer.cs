namespace WindowsFormsApplication2
{
    partial class monitor_list
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.c_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.c_isend = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.c_content = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.c_do = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.c_si = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.c_id,
            this.c_isend,
            this.c_content,
            this.c_do,
            this.c_si});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(22, 202);
            this.listView1.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1330, 752);
            this.listView1.TabIndex = 9;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // c_id
            // 
            this.c_id.Text = "범죄자 번호";
            this.c_id.Width = 78;
            // 
            // c_isend
            // 
            this.c_isend.Text = "범죄자 이름";
            this.c_isend.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.c_isend.Width = 83;
            // 
            // c_content
            // 
            this.c_content.Text = "범죄자 연락처";
            this.c_content.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.c_content.Width = 103;
            // 
            // c_do
            // 
            this.c_do.Text = "범죄자 주소";
            this.c_do.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.c_do.Width = 195;
            // 
            // c_si
            // 
            this.c_si.Text = "범죄자 생일";
            this.c_si.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.c_si.Width = 114;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("굴림", 14F);
            this.button1.Location = new System.Drawing.Point(1151, 24);
            this.button1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(201, 66);
            this.button1.TabIndex = 10;
            this.button1.Text = "뒤로가기";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(363, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 24);
            this.label2.TabIndex = 12;
            this.label2.Text = "label2";
            // 
            // monitor_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1374, 980);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "monitor_list";
            this.Text = "monitor_list";
            this.Load += new System.EventHandler(this.monitor_list_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader c_id;
        private System.Windows.Forms.ColumnHeader c_isend;
        private System.Windows.Forms.ColumnHeader c_content;
        private System.Windows.Forms.ColumnHeader c_do;
        private System.Windows.Forms.ColumnHeader c_si;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}