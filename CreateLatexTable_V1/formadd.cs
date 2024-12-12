using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreateLatexTable_V1
{
    public partial class formadd : Form
    {
        Form1 main;
        public formadd(Form1 frm)
        {
            main = frm;
            InitializeComponent();
        }

        public void changeColorBrown(Label tx)
        {
            tx.ForeColor = Color.Black;
        }

        public void combo_(string s)
        {
            combo_end.Items.Clear();
            var i = 8;
            try
            {
                i = Convert.ToInt32(s);
            }
            catch (Exception)
            {
                throw;
            }
            
            while (i < 19)
            {
                if (i != 12)
                    combo_end.Items.Add(i + 1);
              
                i++;
            }
        }

        public void limiteForTime(TextBox tx)
        {
            int len_tx = tx.Text.Length;
            //string allowedchar = "0123456789";
            System.Text.RegularExpressions.Regex regex = null;
            regex = new System.Text.RegularExpressions.Regex("^([0-9])*$");

            if (!regex.IsMatch(tx.Text))
            {
                tx.Text = tx.Text.Substring(0, len_tx - 1);
                MessageBox.Show("در این فیلد فقط مجاز به وارد کردن عدد هستید",
                                "",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
            }
            else if (len_tx >= 3)
            {
                tx.Text = tx.Text.Substring(0, len_tx - 1);
                MessageBox.Show("ساعت شروع باید یک عدد یک رقمی یا دو رقمی باشد\nلطفا در مقدار ورودی دقت کنید",
                                "", 
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
            }
            else if (len_tx > 0)
            {
                int r = Int32.Parse(tx.Text);
                if (r > 24)
                {
                    tx.Text = "";
                }
            }
        }


        private void txt_title_TextChanged(object sender, EventArgs e)
        {
            if(txt_title.Text.Length > 30)
            {
                txt_title.Font = new Font(txt_title.Font.FontFamily, 8);

            }
        }

        private void combo_days_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_day.Text = combo_days.Text;
            main.whereday(combo_days.Text);
        }

        private void txt_begintime_TextChanged(object sender, EventArgs e)
        {

            limiteForTime(txt_begintime);
            int x = combo_begin.Items.IndexOf(txt_begintime.Text);
            //combo_begin.SelectedIndex = x;
            main.defaultColorLabel();
        }

        private void combo_begin_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_begintime.Text = combo_begin.Text;
            combo_(combo_begin.Text);
            main.defaultColorLabel();

        }

        private void formadd_Load(object sender, EventArgs e)
        {
            combo_days.SelectedIndex = 0;
        }

        private void txt_endtime_TextChanged(object sender, EventArgs e)
        {
            limiteForTime(txt_endtime);
            main.defaultColorLabel();
            main.whereLabel(txt_begintime.Text, txt_endtime.Text);
        }

        private void combo_end_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_endtime.Text = combo_end.Text;
            main.defaultColorLabel();
            main.whereLabel(txt_begintime.Text, txt_endtime.Text);
        }

        private void btn_addvaluetotable_Click(object sender, EventArgs e)
        {
            main.add(txt_title.Text , combo_days.Text , txt_begintime.Text , txt_endtime.Text);
            txt_title.Text = "";
            txt_begintime.Text = "";
            txt_endtime.Text = "";
            main.defaultColorLabel();
            
        }
    }
}


