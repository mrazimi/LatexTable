namespace CreateLatexTable_V1
{
    partial class formcode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formcode));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radio_yes = new System.Windows.Forms.RadioButton();
            this.radio_no = new System.Windows.Forms.RadioButton();
            this.btn_compile = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lbl_done = new System.Windows.Forms.Label();
            this.lbl_done2 = new System.Windows.Forms.Label();
            this.pictureBox_wait = new System.Windows.Forms.PictureBox();
            this.pictureBox_sucs = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_wait)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_sucs)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(889, 398);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(623, 424);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "آیا نرم افزار لاتک در سیستم نصب است؟";
            // 
            // radio_yes
            // 
            this.radio_yes.AutoSize = true;
            this.radio_yes.Checked = true;
            this.radio_yes.Location = new System.Drawing.Point(566, 422);
            this.radio_yes.Name = "radio_yes";
            this.radio_yes.Size = new System.Drawing.Size(51, 32);
            this.radio_yes.TabIndex = 2;
            this.radio_yes.TabStop = true;
            this.radio_yes.Text = "بله";
            this.radio_yes.UseVisualStyleBackColor = true;
            this.radio_yes.CheckedChanged += new System.EventHandler(this.radio_yes_CheckedChanged);
            // 
            // radio_no
            // 
            this.radio_no.AutoSize = true;
            this.radio_no.Location = new System.Drawing.Point(488, 422);
            this.radio_no.Name = "radio_no";
            this.radio_no.Size = new System.Drawing.Size(56, 32);
            this.radio_no.TabIndex = 3;
            this.radio_no.Text = "خیر";
            this.radio_no.UseVisualStyleBackColor = true;
            this.radio_no.CheckedChanged += new System.EventHandler(this.radio_no_CheckedChanged);
            // 
            // btn_compile
            // 
            this.btn_compile.BackColor = System.Drawing.Color.White;
            this.btn_compile.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btn_compile.Location = new System.Drawing.Point(380, 521);
            this.btn_compile.Name = "btn_compile";
            this.btn_compile.Size = new System.Drawing.Size(129, 42);
            this.btn_compile.TabIndex = 4;
            this.btn_compile.Text = "کامپایل";
            this.btn_compile.UseVisualStyleBackColor = false;
            this.btn_compile.Click += new System.EventHandler(this.btn_compile_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 466);
            this.progressBar1.Maximum = 40;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(889, 36);
            this.progressBar1.TabIndex = 5;
            // 
            // lbl_done
            // 
            this.lbl_done.AutoSize = true;
            this.lbl_done.Location = new System.Drawing.Point(49, 431);
            this.lbl_done.Name = "lbl_done";
            this.lbl_done.Size = new System.Drawing.Size(68, 28);
            this.lbl_done.TabIndex = 6;
            this.lbl_done.Text = "Wait ...";
            this.lbl_done.Visible = false;
            // 
            // lbl_done2
            // 
            this.lbl_done2.AutoSize = true;
            this.lbl_done2.Location = new System.Drawing.Point(49, 425);
            this.lbl_done2.Name = "lbl_done2";
            this.lbl_done2.Size = new System.Drawing.Size(54, 28);
            this.lbl_done2.TabIndex = 10;
            this.lbl_done2.Text = "Done";
            this.lbl_done2.Visible = false;
            // 
            // pictureBox_wait
            // 
            this.pictureBox_wait.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_wait.Image")));
            this.pictureBox_wait.Location = new System.Drawing.Point(13, 426);
            this.pictureBox_wait.Name = "pictureBox_wait";
            this.pictureBox_wait.Size = new System.Drawing.Size(36, 28);
            this.pictureBox_wait.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_wait.TabIndex = 11;
            this.pictureBox_wait.TabStop = false;
            this.pictureBox_wait.Visible = false;
            // 
            // pictureBox_sucs
            // 
            this.pictureBox_sucs.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_sucs.Image")));
            this.pictureBox_sucs.Location = new System.Drawing.Point(18, 422);
            this.pictureBox_sucs.Name = "pictureBox_sucs";
            this.pictureBox_sucs.Size = new System.Drawing.Size(30, 32);
            this.pictureBox_sucs.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_sucs.TabIndex = 12;
            this.pictureBox_sucs.TabStop = false;
            this.pictureBox_sucs.Visible = false;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // formcode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 575);
            this.Controls.Add(this.pictureBox_sucs);
            this.Controls.Add(this.pictureBox_wait);
            this.Controls.Add(this.lbl_done2);
            this.Controls.Add(this.lbl_done);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btn_compile);
            this.Controls.Add(this.radio_no);
            this.Controls.Add(this.radio_yes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Font = new System.Drawing.Font("IRANSans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.MaximizeBox = false;
            this.Name = "formcode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.formcode_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_wait)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_sucs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radio_yes;
        private System.Windows.Forms.RadioButton radio_no;
        private System.Windows.Forms.Button btn_compile;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lbl_done;
        private System.Windows.Forms.Label lbl_done2;
        private System.Windows.Forms.PictureBox pictureBox_wait;
        private System.Windows.Forms.PictureBox pictureBox_sucs;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}