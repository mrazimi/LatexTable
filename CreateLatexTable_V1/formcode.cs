using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreateLatexTable_V1
{
    public partial class formcode : Form
    {
        Form1 main;
        private string path;

        public formcode(Form1 frm , string pathf1)
        {
            main = frm;
            path = pathf1;
            InitializeComponent();
        }

        private void radio_yes_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radio_no_CheckedChanged(object sender, EventArgs e)
        {

        }


        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        public bool IsProcessOpen(string name)
        {
            foreach (Process clsProcess in Process.GetProcesses())
            {

                if (clsProcess.ProcessName.Contains(name))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }

            return false;
        }

       
        private void btn_compile_Click(object sender, EventArgs e)
        {
            if (radio_yes.Checked == true)
            {
                lbl_done.Visible = true;
                pictureBox_wait.Visible = true;

                progressBar1.Style = ProgressBarStyle.Marquee;
                progressBar1.ForeColor = Color.SkyBlue;

                btn_compile.Enabled = false;
                BackgroundWorker bgw = new BackgroundWorker();
                bgw.DoWork += backgroundWorker1_DoWork;
                bgw.RunWorkerCompleted += backgroundWorker1_RunWorkerCompleted;
                bgw.RunWorkerAsync("cmd.exe");

                

                

            }
            else
            {
                // btn_compile.Enabled = false;
              MessageBox.Show("قابلیت کامپایل بدون نرم افزار امکان پذیر نمی باشد",
                               "پیغام خطا",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Error);

            }


        }

        private void formcode_Load(object sender, EventArgs e)
        {
            //string path = main.get_path() + "/Latex";
            System.IO.Directory.CreateDirectory(path);

            path.Replace("/", "\\");
            StreamReader file = new StreamReader(path + "/main.tex");


            richTextBox1.Text = file.ReadToEnd();

            this.Text = path + "/main.tex";
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

            //string path = main.get_path() + "/Latex";
            System.IO.Directory.CreateDirectory(path);
            path.Replace("/", "\\");


            ProcessStartInfo ps = new ProcessStartInfo();
            ps.WorkingDirectory = path;
            ps.FileName = "cmd.exe";
            ps.WindowStyle = ProcessWindowStyle.Minimized;
            ps.Arguments = "/c xelatex -interaction=nonstopmode -synctex=-1 main.tex";
            Process proc = Process.Start(ps);
            
            proc.WaitForExit();


            if (proc.HasExited)
            {
                if (lbl_done.InvokeRequired)
                    lbl_done.Invoke(new MethodInvoker(delegate { lbl_done.Text = "Wait ... (1/4)"; }));
                else
                    lbl_done.Text = "Wait ... (1/4)";
                
                
                //progressBar1.Value = 10;
                var ps2 = new ProcessStartInfo();
                ps2.WorkingDirectory = path;
                ps2.FileName = "cmd.exe";
                ps2.WindowStyle = ProcessWindowStyle.Minimized;
                ps2.Arguments = "/c xelatex -interaction=nonstopmode -synctex=-1 main.tex";
                Process proc2 = Process.Start(ps2);

                proc2.WaitForExit();

                if (proc2.HasExited)
                {
                    if (lbl_done.InvokeRequired)
                        lbl_done.Invoke(new MethodInvoker(delegate { lbl_done.Text = "Wait ... (2/4)"; }));
                    else
                        lbl_done.Text = "Wait ... (2/4)";
                    //progressBar1.Value = 20;
                    var ps3 = new ProcessStartInfo();
                    ps3.WorkingDirectory = path;
                    ps3.FileName = "cmd.exe";
                    ps3.WindowStyle = ProcessWindowStyle.Minimized;
                    ps3.Arguments = "/c xelatex -interaction=nonstopmode -synctex=-1 mainWithoutFooter.tex";
                    Process proc3 = Process.Start(ps3);
                    proc3.WaitForExit();


                    if (proc3.HasExited)
                    {
                        if (lbl_done.InvokeRequired)
                            lbl_done.Invoke(new MethodInvoker(delegate { lbl_done.Text = "Wait ... (3/4)"; }));
                        else
                            lbl_done.Text = "Wait ... (3/4)";

                        // progressBar1.Value = 30;
                        var ps4 = new ProcessStartInfo();
                        ps4.WorkingDirectory = path;
                        ps4.FileName = "cmd.exe";
                        ps4.WindowStyle = ProcessWindowStyle.Minimized;
                        ps4.Arguments = "/c xelatex -interaction=nonstopmode -synctex=-1 mainWithoutFooter.tex";
                        Process proc4 = Process.Start(ps4);
                        proc4.WaitForExit();

                        if (proc4.HasExited)
                        {
                            if (lbl_done.InvokeRequired)
                                lbl_done.Invoke(new MethodInvoker(delegate { lbl_done2.Text = "Done (4/4)"; }));
                            else
                                lbl_done2.Text = "Done (4/4)";
                        }

                    }

                }

            }



        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            progressBar1.Style = ProgressBarStyle.Blocks;
            progressBar1.Maximum = 40;
            progressBar1.Value = 40;
            lbl_done.Visible = false;
            pictureBox_wait.Visible = false;
            lbl_done2.Visible = true;
            pictureBox_sucs.Visible = true;
            btn_compile.Enabled = true;

        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }
    }
}
