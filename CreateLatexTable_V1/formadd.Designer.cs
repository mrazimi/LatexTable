namespace CreateLatexTable_V1
{
    partial class formadd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formadd));
            this.combo_end = new System.Windows.Forms.ComboBox();
            this.combo_begin = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_endminate = new System.Windows.Forms.TextBox();
            this.txt_beginminate = new System.Windows.Forms.TextBox();
            this.combo_days = new System.Windows.Forms.ComboBox();
            this.lbl_res_add = new System.Windows.Forms.Label();
            this.txt_day = new System.Windows.Forms.TextBox();
            this.lbl_day = new System.Windows.Forms.Label();
            this.btn_addvaluetotable = new System.Windows.Forms.Button();
            this.txt_endtime = new System.Windows.Forms.TextBox();
            this.lbl_endtime = new System.Windows.Forms.Label();
            this.txt_begintime = new System.Windows.Forms.TextBox();
            this.lbl_begintime = new System.Windows.Forms.Label();
            this.txt_title = new System.Windows.Forms.TextBox();
            this.lbl_title = new System.Windows.Forms.Label();
            this.lbl_filltable = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // combo_end
            // 
            this.combo_end.BackColor = System.Drawing.SystemColors.Menu;
            this.combo_end.FormattingEnabled = true;
            this.combo_end.Location = new System.Drawing.Point(86, 226);
            this.combo_end.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.combo_end.Name = "combo_end";
            this.combo_end.Size = new System.Drawing.Size(53, 36);
            this.combo_end.TabIndex = 6;
            this.combo_end.SelectedIndexChanged += new System.EventHandler(this.combo_end_SelectedIndexChanged);
            // 
            // combo_begin
            // 
            this.combo_begin.BackColor = System.Drawing.SystemColors.Menu;
            this.combo_begin.FormattingEnabled = true;
            this.combo_begin.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18"});
            this.combo_begin.Location = new System.Drawing.Point(86, 180);
            this.combo_begin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.combo_begin.Name = "combo_begin";
            this.combo_begin.Size = new System.Drawing.Size(53, 36);
            this.combo_begin.TabIndex = 5;
            this.combo_begin.SelectedIndexChanged += new System.EventHandler(this.combo_begin_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(203, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 28);
            this.label2.TabIndex = 160;
            this.label2.Text = ":";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(203, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 28);
            this.label1.TabIndex = 159;
            this.label1.Text = ":";
            // 
            // txt_endminate
            // 
            this.txt_endminate.BackColor = System.Drawing.SystemColors.Menu;
            this.txt_endminate.Enabled = false;
            this.txt_endminate.Location = new System.Drawing.Point(218, 228);
            this.txt_endminate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_endminate.Name = "txt_endminate";
            this.txt_endminate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_endminate.Size = new System.Drawing.Size(35, 36);
            this.txt_endminate.TabIndex = 158;
            this.txt_endminate.Text = "00";
            this.txt_endminate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_beginminate
            // 
            this.txt_beginminate.BackColor = System.Drawing.SystemColors.Menu;
            this.txt_beginminate.Enabled = false;
            this.txt_beginminate.Location = new System.Drawing.Point(218, 181);
            this.txt_beginminate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_beginminate.Name = "txt_beginminate";
            this.txt_beginminate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_beginminate.Size = new System.Drawing.Size(35, 36);
            this.txt_beginminate.TabIndex = 157;
            this.txt_beginminate.Text = "00";
            this.txt_beginminate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // combo_days
            // 
            this.combo_days.AccessibleRole = System.Windows.Forms.AccessibleRole.ComboBox;
            this.combo_days.BackColor = System.Drawing.SystemColors.Menu;
            this.combo_days.FormattingEnabled = true;
            this.combo_days.Items.AddRange(new object[] {
            "انتخاب کنید",
            "شنبه",
            "یکشنبه",
            "دوشنبه",
            "سه شنبه",
            "چهارشنبه"});
            this.combo_days.Location = new System.Drawing.Point(169, 134);
            this.combo_days.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.combo_days.Name = "combo_days";
            this.combo_days.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.combo_days.Size = new System.Drawing.Size(118, 36);
            this.combo_days.TabIndex = 1;
            this.combo_days.SelectedIndexChanged += new System.EventHandler(this.combo_days_SelectedIndexChanged);
            // 
            // lbl_res_add
            // 
            this.lbl_res_add.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_res_add.AutoSize = true;
            this.lbl_res_add.Location = new System.Drawing.Point(69, 359);
            this.lbl_res_add.Name = "lbl_res_add";
            this.lbl_res_add.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_res_add.Size = new System.Drawing.Size(0, 28);
            this.lbl_res_add.TabIndex = 156;
            this.lbl_res_add.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txt_day
            // 
            this.txt_day.BackColor = System.Drawing.SystemColors.Menu;
            this.txt_day.Enabled = false;
            this.txt_day.ForeColor = System.Drawing.SystemColors.Menu;
            this.txt_day.Location = new System.Drawing.Point(269, 134);
            this.txt_day.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_day.Name = "txt_day";
            this.txt_day.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_day.Size = new System.Drawing.Size(18, 36);
            this.txt_day.TabIndex = 155;
            // 
            // lbl_day
            // 
            this.lbl_day.AutoSize = true;
            this.lbl_day.BackColor = System.Drawing.Color.Transparent;
            this.lbl_day.ForeColor = System.Drawing.Color.Black;
            this.lbl_day.Location = new System.Drawing.Point(304, 136);
            this.lbl_day.Name = "lbl_day";
            this.lbl_day.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_day.Size = new System.Drawing.Size(31, 28);
            this.lbl_day.TabIndex = 154;
            this.lbl_day.Text = "روز";
            this.lbl_day.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_addvaluetotable
            // 
            this.btn_addvaluetotable.AccessibleRole = System.Windows.Forms.AccessibleRole.Animation;
            this.btn_addvaluetotable.BackColor = System.Drawing.Color.White;
            this.btn_addvaluetotable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_addvaluetotable.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btn_addvaluetotable.Font = new System.Drawing.Font("IRANSans", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addvaluetotable.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btn_addvaluetotable.Location = new System.Drawing.Point(130, 291);
            this.btn_addvaluetotable.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_addvaluetotable.Name = "btn_addvaluetotable";
            this.btn_addvaluetotable.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_addvaluetotable.Size = new System.Drawing.Size(90, 38);
            this.btn_addvaluetotable.TabIndex = 4;
            this.btn_addvaluetotable.Text = "افزودن";
            this.btn_addvaluetotable.UseVisualStyleBackColor = false;
            this.btn_addvaluetotable.Click += new System.EventHandler(this.btn_addvaluetotable_Click);
            // 
            // txt_endtime
            // 
            this.txt_endtime.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            this.txt_endtime.BackColor = System.Drawing.SystemColors.Menu;
            this.txt_endtime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_endtime.Location = new System.Drawing.Point(166, 228);
            this.txt_endtime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_endtime.Name = "txt_endtime";
            this.txt_endtime.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_endtime.Size = new System.Drawing.Size(35, 36);
            this.txt_endtime.TabIndex = 3;
            this.txt_endtime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_endtime.TextChanged += new System.EventHandler(this.txt_endtime_TextChanged);
            // 
            // lbl_endtime
            // 
            this.lbl_endtime.AutoSize = true;
            this.lbl_endtime.BackColor = System.Drawing.Color.Transparent;
            this.lbl_endtime.ForeColor = System.Drawing.Color.Black;
            this.lbl_endtime.Location = new System.Drawing.Point(262, 231);
            this.lbl_endtime.Name = "lbl_endtime";
            this.lbl_endtime.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_endtime.Size = new System.Drawing.Size(83, 28);
            this.lbl_endtime.TabIndex = 153;
            this.lbl_endtime.Text = "زمان پایان";
            this.lbl_endtime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_begintime
            // 
            this.txt_begintime.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            this.txt_begintime.BackColor = System.Drawing.SystemColors.Menu;
            this.txt_begintime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_begintime.Location = new System.Drawing.Point(166, 181);
            this.txt_begintime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_begintime.Name = "txt_begintime";
            this.txt_begintime.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_begintime.Size = new System.Drawing.Size(35, 36);
            this.txt_begintime.TabIndex = 2;
            this.txt_begintime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_begintime.TextChanged += new System.EventHandler(this.txt_begintime_TextChanged);
            // 
            // lbl_begintime
            // 
            this.lbl_begintime.AutoSize = true;
            this.lbl_begintime.BackColor = System.Drawing.Color.Transparent;
            this.lbl_begintime.ForeColor = System.Drawing.Color.Black;
            this.lbl_begintime.Location = new System.Drawing.Point(259, 185);
            this.lbl_begintime.Name = "lbl_begintime";
            this.lbl_begintime.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_begintime.Size = new System.Drawing.Size(86, 28);
            this.lbl_begintime.TabIndex = 150;
            this.lbl_begintime.Text = "زمان شروع";
            this.lbl_begintime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_title
            // 
            this.txt_title.BackColor = System.Drawing.SystemColors.Menu;
            this.txt_title.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_title.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_title.Location = new System.Drawing.Point(13, 81);
            this.txt_title.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_title.Name = "txt_title";
            this.txt_title.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_title.Size = new System.Drawing.Size(274, 36);
            this.txt_title.TabIndex = 0;
            this.txt_title.TextChanged += new System.EventHandler(this.txt_title_TextChanged);
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.BackColor = System.Drawing.Color.Transparent;
            this.lbl_title.ForeColor = System.Drawing.Color.Black;
            this.lbl_title.Location = new System.Drawing.Point(295, 82);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_title.Size = new System.Drawing.Size(49, 28);
            this.lbl_title.TabIndex = 148;
            this.lbl_title.Text = "عنوان";
            this.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_filltable
            // 
            this.lbl_filltable.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.lbl_filltable.AutoSize = true;
            this.lbl_filltable.BackColor = System.Drawing.Color.Transparent;
            this.lbl_filltable.Font = new System.Drawing.Font("IRANSans", 11.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_filltable.ForeColor = System.Drawing.Color.Black;
            this.lbl_filltable.Location = new System.Drawing.Point(227, 21);
            this.lbl_filltable.Name = "lbl_filltable";
            this.lbl_filltable.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_filltable.Size = new System.Drawing.Size(121, 33);
            this.lbl_filltable.TabIndex = 145;
            this.lbl_filltable.Text = "پر کردن جدول";
            this.lbl_filltable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label21
            // 
            this.label21.BackColor = System.Drawing.Color.Black;
            this.label21.ForeColor = System.Drawing.Color.Transparent;
            this.label21.Location = new System.Drawing.Point(203, 60);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(140, 2);
            this.label21.TabIndex = 170;
            this.label21.Text = "label21";
            // 
            // formadd
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(354, 353);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.combo_end);
            this.Controls.Add(this.combo_begin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_endminate);
            this.Controls.Add(this.txt_beginminate);
            this.Controls.Add(this.combo_days);
            this.Controls.Add(this.lbl_res_add);
            this.Controls.Add(this.txt_day);
            this.Controls.Add(this.lbl_day);
            this.Controls.Add(this.btn_addvaluetotable);
            this.Controls.Add(this.txt_endtime);
            this.Controls.Add(this.lbl_endtime);
            this.Controls.Add(this.txt_begintime);
            this.Controls.Add(this.lbl_begintime);
            this.Controls.Add(this.txt_title);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.lbl_filltable);
            this.Font = new System.Drawing.Font("IRANSans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "formadd";
            this.Text = "Add";
            this.Load += new System.EventHandler(this.formadd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox combo_end;
        private System.Windows.Forms.ComboBox combo_begin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_endminate;
        private System.Windows.Forms.TextBox txt_beginminate;
        private System.Windows.Forms.ComboBox combo_days;
        private System.Windows.Forms.Label lbl_res_add;
        private System.Windows.Forms.TextBox txt_day;
        private System.Windows.Forms.Label lbl_day;
        private System.Windows.Forms.Button btn_addvaluetotable;
        private System.Windows.Forms.TextBox txt_endtime;
        private System.Windows.Forms.Label lbl_endtime;
        private System.Windows.Forms.TextBox txt_begintime;
        private System.Windows.Forms.Label lbl_begintime;
        private System.Windows.Forms.TextBox txt_title;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lbl_filltable;
        private System.Windows.Forms.Label label21;
    }
}