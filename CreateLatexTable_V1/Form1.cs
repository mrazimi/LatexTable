using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using System.IO.Compression;
using System.Globalization;

namespace CreateLatexTable_V1
{
    public partial class Form1 : Form
    {

        //FUNCTIONS
        public void turnOffotherField(TextBox st1, TextBox st2)
        {
            if (st1.Text != "")
            {
                st2.Enabled = false;
                st2.ReadOnly = true;
                st1.BackColor = Color.White;
            }
            else
            {
                st2.Enabled = true;
                st2.ReadOnly = false;
                st1.BackColor = Color.WhiteSmoke;
            }

        }

        public void turnOffotherField2(TextBox st1, TextBox st2, TextBox st3)
        {
            if (st1.Text != "")
            {
                st2.Enabled = false;
                st2.ReadOnly = true;
                st3.Enabled = false;
                st3.ReadOnly = true;
                st1.BackColor = Color.White;
            }
            else
            {
                st2.Enabled = true;
                st2.ReadOnly = false;
                st3.Enabled = true;
                st3.ReadOnly = false;
                st1.BackColor = Color.WhiteSmoke;
            }
        }

        public void changeColorBlue(Label lb) => lb.ForeColor = Color.Blue;

        public void whereLabel(string a, string b)
        {
            string res = a + b;

            if (nameof(lbl_89).Substring(nameof(lbl_89).IndexOf("_") + 1) == res)
                changeColorBlue(lbl_89);
            else if (nameof(lbl_910).Substring(nameof(lbl_910).IndexOf("_") + 1) == res)
                changeColorBlue(lbl_910);
            else if (nameof(lbl_810).Substring(nameof(lbl_810).IndexOf("_") + 1) == res)
                changeColorBlue(lbl_810);
            else if (nameof(lbl_1011).Substring(nameof(lbl_1011).IndexOf("_") + 1) == res)
                changeColorBlue(lbl_1011);
            else if (nameof(lbl_1112).Substring(nameof(lbl_1112).IndexOf("_") + 1) == res)
                changeColorBlue(lbl_1112);
            else if (nameof(lbl_1012).Substring(nameof(lbl_1012).IndexOf("_") + 1) == res)
                changeColorBlue(lbl_1012);
            else if (nameof(lbl_1314).Substring(nameof(lbl_1314).IndexOf("_") + 1) == res)
                changeColorBlue(lbl_1314);
            else if (nameof(lbl_1415).Substring(nameof(lbl_1415).IndexOf("_") + 1) == res)
                changeColorBlue(lbl_1415);
            else if (nameof(lbl_1315).Substring(nameof(lbl_1315).IndexOf("_") + 1) == res)
                changeColorBlue(lbl_1315);
            else if (nameof(lbl_1516).Substring(nameof(lbl_1516).IndexOf("_") + 1) == res)
                changeColorBlue(lbl_1516);
            else if (nameof(lbl_1617).Substring(nameof(lbl_1617).IndexOf("_") + 1) == res)
                changeColorBlue(lbl_1617);
            else if (nameof(lbl_1517).Substring(nameof(lbl_1517).IndexOf("_") + 1) == res)
                changeColorBlue(lbl_1517);
            else if (nameof(lbl_1718).Substring(nameof(lbl_1718).IndexOf("_") + 1) == res)
                changeColorBlue(lbl_1718);
            else if (nameof(lbl_1819).Substring(nameof(lbl_1819).IndexOf("_") + 1) == res)
                changeColorBlue(lbl_1819);
            else if (nameof(lbl_1719).Substring(nameof(lbl_1719).IndexOf("_") + 1) == res)
                changeColorBlue(lbl_1719);
        }

        public void changeColorBrown(Label lb) => lb.ForeColor = Color.Black;

        public void whereday(string combo)
        {

            if (combo == "شنبه")
                changeColorBlue(lbl_saterday);
            else
                changeColorBrown(lbl_saterday);
            if (combo == "یک شنبه")
                changeColorBlue(lbl_sundy);
            else
                changeColorBrown(lbl_sundy);
            if (combo == "دوشنبه")
                changeColorBlue(lbl_mondy);
            else
                changeColorBrown(lbl_mondy);
            if (combo == "سه شنبه")
                changeColorBlue(lbl_thursday);
            else
                changeColorBrown(lbl_thursday);
            if (combo == "چهارشنبه")
                changeColorBlue(lbl_wendsday);
            else
                changeColorBrown(lbl_wendsday);
        }

        public void defaultColorLabel()
        {
            changeColorBrown(lbl_89); changeColorBrown(lbl_1011); changeColorBrown(lbl_1314);
            changeColorBrown(lbl_910); changeColorBrown(lbl_1112); changeColorBrown(lbl_1415);
            changeColorBrown(lbl_810); changeColorBrown(lbl_1012); changeColorBrown(lbl_1315);
            changeColorBrown(lbl_1516); changeColorBrown(lbl_1617); changeColorBrown(lbl_1517);
            changeColorBrown(lbl_1718); changeColorBrown(lbl_1819); changeColorBrown(lbl_1719);
        }

        public void enableScrollBar15(TextBox tx)
        {
            if (tx.Text.Length > 15)
                tx.ScrollBars = ScrollBars.Both;
            else
                tx.ScrollBars = ScrollBars.None;
        }
        public void enableScrollBar7(TextBox tx)
        {
            if (tx.Text.Length > 7)
                tx.ScrollBars = ScrollBars.Both;
            else
                tx.ScrollBars = ScrollBars.None;
        }



        public TextBox strTotxt(string st)
        {
            if (nameof(txt_810shanbe) == st)
                return txt_810shanbe;
            else if (nameof(txt_89shanbe) == st)
                return txt_89shanbe;
            else if (nameof(txt_910shanbe) == st)
                return txt_910shanbe;
            else if (nameof(txt_1011shanbe) == st)
                return txt_1011shanbe;
            else if (nameof(txt_1112shanbe) == st)
                return txt_1112shanbe;
            else if (nameof(txt_1012shanbe) == st)
                return txt_1012shanbe;
            else if (nameof(txt_1314shanbe) == st)
                return txt_1314shanbe;
            else if (nameof(txt_1415shanbe) == st)
                return txt_1415shanbe;
            else if (nameof(txt_1315shanbe) == st)
                return txt_1315shanbe;
            else if (nameof(txt_1516shanbe) == st)
                return txt_1516shanbe;
            else if (nameof(txt_1617shanbe) == st)
                return txt_1617shanbe;
            else if (nameof(txt_1517shanbe) == st)
                return txt_1517shanbe;
            else if (nameof(txt_1718shanbe) == st)
                return txt_1718shanbe;
            else if (nameof(txt_1819shanbe) == st)
                return txt_1819shanbe;
            else if (nameof(txt_1719shanbe) == st)
                return txt_1719shanbe;

            if (nameof(txt_810yekshanbe) == st)
                return txt_810yekshanbe;
            else if (nameof(txt_89yekshanbe) == st)
                return txt_89yekshanbe;
            else if (nameof(txt_910yekshanbe) == st)
                return txt_910yekshanbe;
            else if (nameof(txt_1011yekshanbe) == st)
                return txt_1011yekshanbe;
            else if (nameof(txt_1112yekshanbe) == st)
                return txt_1112yekshanbe;
            else if (nameof(txt_1012yekshanbe) == st)
                return txt_1012yekshanbe;
            else if (nameof(txt_1314yekshanbe) == st)
                return txt_1314yekshanbe;
            else if (nameof(txt_1415yekshanbe) == st)
                return txt_1415yekshanbe;
            else if (nameof(txt_1315yekshanbe) == st)
                return txt_1315yekshanbe;
            else if (nameof(txt_1516yekshanbe) == st)
                return txt_1516yekshanbe;
            else if (nameof(txt_1617yekshanbe) == st)
                return txt_1617yekshanbe;
            else if (nameof(txt_1517yekshanbe) == st)
                return txt_1517yekshanbe;
            else if (nameof(txt_1718yekshanbe) == st)
                return txt_1718yekshanbe;
            else if (nameof(txt_1819yekshanbe) == st)
                return txt_1819yekshanbe;
            else if (nameof(txt_1719yekshanbe) == st)
                return txt_1719yekshanbe;

            if (nameof(txt_810dokshanbe) == st)
                return txt_810dokshanbe;
            else if (nameof(txt_89dokshanbe) == st)
                return txt_89dokshanbe;
            else if (nameof(txt_910dokshanbe) == st)
                return txt_910dokshanbe;
            else if (nameof(txt_1011dokshanbe) == st)
                return txt_1011dokshanbe;
            else if (nameof(txt_1112dokshanbe) == st)
                return txt_1112dokshanbe;
            else if (nameof(txt_1012dokshanbe) == st)
                return txt_1012dokshanbe;
            else if (nameof(txt_1314dokshanbe) == st)
                return txt_1314dokshanbe;
            else if (nameof(txt_1415dokshanbe) == st)
                return txt_1415dokshanbe;
            else if (nameof(txt_1315dokshanbe) == st)
                return txt_1315dokshanbe;
            else if (nameof(txt_1516dokshanbe) == st)
                return txt_1516dokshanbe;
            else if (nameof(txt_1617dokshanbe) == st)
                return txt_1617dokshanbe;
            else if (nameof(txt_1517dokshanbe) == st)
                return txt_1517dokshanbe;
            else if (nameof(txt_1718dokshanbe) == st)
                return txt_1718dokshanbe;
            else if (nameof(txt_1819dokshanbe) == st)
                return txt_1819dokshanbe;
            else if (nameof(txt_1719dokshanbe) == st)
                return txt_1719dokshanbe;

            if (nameof(txt_810sekshanbe) == st)
                return txt_810sekshanbe;
            else if (nameof(txt_89sekshanbe) == st)
                return txt_89sekshanbe;
            else if (nameof(txt_910sekshanbe) == st)
                return txt_910sekshanbe;
            else if (nameof(txt_1011sekshanbe) == st)
                return txt_1011sekshanbe;
            else if (nameof(txt_1112sekshanbe) == st)
                return txt_1112sekshanbe;
            else if (nameof(txt_1012sekshanbe) == st)
                return txt_1012sekshanbe;
            else if (nameof(txt_1314sekshanbe) == st)
                return txt_1314sekshanbe;
            else if (nameof(txt_1415sekshanbe) == st)
                return txt_1415sekshanbe;
            else if (nameof(txt_1315sekshanbe) == st)
                return txt_1315sekshanbe;
            else if (nameof(txt_1516sekshanbe) == st)
                return txt_1516sekshanbe;
            else if (nameof(txt_1617sekshanbe) == st)
                return txt_1617sekshanbe;
            else if (nameof(txt_1517sekshanbe) == st)
                return txt_1517sekshanbe;
            else if (nameof(txt_1718sekshanbe) == st)
                return txt_1718sekshanbe;
            else if (nameof(txt_1819sekshanbe) == st)
                return txt_1819sekshanbe;
            else if (nameof(txt_1719sekshanbe) == st)
                return txt_1719sekshanbe;

            if (nameof(txt_810charkshanbe) == st)
                return txt_810charkshanbe;
            else if (nameof(txt_89charkshanbe) == st)
                return txt_89charkshanbe;
            else if (nameof(txt_910charkshanbe) == st)
                return txt_910charkshanbe;
            else if (nameof(txt_1011charkshanbe) == st)
                return txt_1011charkshanbe;
            else if (nameof(txt_1112charkshanbe) == st)
                return txt_1112charkshanbe;
            else if (nameof(txt_1012charkshanbe) == st)
                return txt_1012charkshanbe;
            else if (nameof(txt_1314charkshanbe) == st)
                return txt_1314charkshanbe;
            else if (nameof(txt_1415charkshanbe) == st)
                return txt_1415charkshanbe;
            else if (nameof(txt_1315charkshanbe) == st)
                return txt_1315charkshanbe;
            else if (nameof(txt_1516charkshanbe) == st)
                return txt_1516charkshanbe;
            else if (nameof(txt_1617charkshanbe) == st)
                return txt_1617charkshanbe;
            else if (nameof(txt_1517charkshanbe) == st)
                return txt_1517charkshanbe;
            else if (nameof(txt_1718charkshanbe) == st)
                return txt_1718charkshanbe;
            else if (nameof(txt_1819charkshanbe) == st)
                return txt_1819charkshanbe;
            else if (nameof(txt_1719charkshanbe) == st)
                return txt_1719charkshanbe;

            return txt_test;
        }

        public void fillAutoTable(string st, string title, string begin_time, string end_time)
        {
            string beginFirst = "_8_10_13_15_17";
            string beginSecend = "_9_11_14_16_18";

            string endFirst = "_10_12_15_17_19";
            string endSecend = "_9_11_14_16_18";

            int begin = Convert.ToInt32(begin_time);
            int end = Convert.ToInt32(end_time);
            //-------------------------
            if (beginFirst.Contains("_" + begin.ToString()) && endFirst.Contains("_" + end.ToString()))
            {
                for (int i = begin; i < end; i += 2)
                {
                    if (i == 12)
                        i = 13;
                    strTotxt("txt_" + i.ToString() + (i + 2).ToString() + st).Text = title;
                }
            }
            //-------------------------
            else if (beginFirst.Contains("_" + begin.ToString()) && endSecend.Contains("_" + end.ToString()))
            {
                if (end - begin >= 2)
                {
                    for (int i = begin; i < end - 2; i += 2)
                    {
                        if (i == 12)
                            i = 13;
                        strTotxt("txt_" + (i).ToString() + (i + 2).ToString() + st).Text = title;
                    }
                    strTotxt("txt_" + (end - 1).ToString() + (end).ToString() + st).Text = title;
                }
                else
                {
                    strTotxt("txt_" + (end - 1).ToString() + (end).ToString() + st).Text = title;
                }

            }
            //-------------------------
            else if (beginSecend.Contains("_" + begin.ToString()) && endFirst.Contains("_" + end.ToString()))
            {
                strTotxt("txt_" + begin.ToString() + (begin + 1).ToString() + st).Text = title;
                begin++;
                if (end - begin >= 2)
                {
                    for (int i = begin; i < end; i += 2)
                    {
                        if (i == 12)
                            i = 13;
                        strTotxt("txt_" + i.ToString() + (i + 2).ToString() + st).Text = title;
                    }
                }
            }
            //-------------------------
            else if (beginSecend.Contains("_" + begin.ToString()) && endSecend.Contains("_" + end.ToString()))
            {
                strTotxt("txt_" + begin.ToString() + (begin + 1).ToString() + st).Text = title;
                begin++;

                for (int i = begin; i <= end - 2; i += 2)
                {
                    if (i == 12)
                        i = 13;
                    strTotxt("txt_" + i.ToString() + (i + 2).ToString() + st).Text = title;
                }
                strTotxt("txt_" + (end - 1).ToString() + (end).ToString() + st).Text = title;
            }
        }

        public void add(string title, string day, string begin_time, string end_time)
        {

            switch (day)
            {
                case "شنبه":
                    fillAutoTable("shanbe", title, begin_time, end_time);
                    break;
                case "یکشنبه":
                    fillAutoTable("yekshanbe", title, begin_time, end_time);
                    break;
                case "دوشنبه":
                    fillAutoTable("dokshanbe", title, begin_time, end_time);
                    break;
                case "سه شنبه":
                    fillAutoTable("sekshanbe", title, begin_time, end_time);
                    break;
                case "چهارشنبه":
                    fillAutoTable("charkshanbe", title, begin_time, end_time);
                    break;
            }

            title = "";
            end_time = "";
            begin_time = "";

        }

        public void clear_btn(string input) => btn_cleartable.Enabled = Convert.ToBoolean(input.Length);


        //Start WindowsForm Code
        public Form1()
        {
            Thread t = new Thread(new ThreadStart(start_form));
            t.Start();
            Thread.Sleep((int)System.TimeSpan.FromSeconds(5.1).TotalMilliseconds);


            InitializeComponent();

            t.Abort();
        }

        public void start_form()
        {
            Application.Run(new formsplash());
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }


        public void setTextFont(TextBox tx, string mode = "mode1")
        {

            switch (mode)
            {
                case "mode1":
                    if (tx.Text.Length > 15)
                        tx.Font = new Font(tx.Font.FontFamily, 8);
                    if (tx.Text.Length > 25)
                        tx.Font = new Font(tx.Font.FontFamily, 7);
                    if (tx.Text.Length > 30)
                        tx.Font = new Font(tx.Font.FontFamily, 6);
                    if (tx.Text.Length < 15)
                        tx.Font = new Font(tx.Font.FontFamily, 10);

                    break;
                case "min":
                    if (tx.Text.Length > 10)
                        tx.Font = new Font(tx.Font.FontFamily, 7);
                    if (tx.Text.Length > 25)
                        tx.Font = new Font(tx.Font.FontFamily, 6);
                    if (tx.Text.Length < 10)
                        tx.Font = new Font(tx.Font.FontFamily, 9);

                    break;
            }

        }

        //---------------------------------------------------------------------
        // shanbe
        //---------------------------------------------------------------------
        private void txt_810shanbe_TextChanged(object sender, EventArgs e)
        {
            turnOffotherField2(txt_810shanbe, txt_89shanbe, txt_910shanbe);

            setTextFont(txt_810shanbe);
        }
        private void txt_1012shanbe_TextChanged(object sender, EventArgs e)
        {
            turnOffotherField2(txt_1012shanbe, txt_1011shanbe, txt_1112shanbe);

            setTextFont(txt_1012shanbe);
        }
        private void txt_1315shanbe_TextChanged(object sender, EventArgs e)
        {
            turnOffotherField2(txt_1315shanbe, txt_1314shanbe, txt_1415shanbe);

            setTextFont(txt_1315shanbe);
        }
        private void txt_1517shanbe_TextChanged(object sender, EventArgs e)
        {
            turnOffotherField2(txt_1517shanbe, txt_1516shanbe, txt_1617shanbe);

            setTextFont(txt_1517shanbe);

        }
        private void txt_1719shanbe_TextChanged(object sender, EventArgs e)
        {
            turnOffotherField2(txt_1719shanbe, txt_1718shanbe, txt_1819shanbe);

            setTextFont(txt_1719shanbe);

        }
        //---------======----------
        private void txt_89shanbe_TextChanged(object sender, EventArgs e)
        {
            turnOffotherField(txt_89shanbe, txt_810shanbe);

            setTextFont(txt_89shanbe, "min");
        }
        private void txt_910shanbe_TextChanged(object sender, EventArgs e)
        {
            turnOffotherField(txt_910shanbe, txt_810shanbe);

            setTextFont(txt_910shanbe, "min");
        }
        private void txt_1011shanbe_TextChanged(object sender, EventArgs e)
        {
            turnOffotherField(txt_1011shanbe, txt_1012shanbe);

            setTextFont(txt_1011shanbe, "min");
        }
        private void txt_1112shanbe_TextChanged(object sender, EventArgs e)
        {
            turnOffotherField(txt_1112shanbe, txt_1012shanbe);

            setTextFont(txt_1112shanbe, "min");
        }
        private void txt_1314shanbe_TextChanged(object sender, EventArgs e)
        {
            turnOffotherField(txt_1314shanbe, txt_1315shanbe);

            setTextFont(txt_1314shanbe, "min");
        }
        private void txt_1415shanbe_TextChanged(object sender, EventArgs e)
        {
            turnOffotherField(txt_1415shanbe, txt_1315shanbe);

            setTextFont(txt_1415shanbe, "min");
        }
        private void txt_1516shanbe_TextChanged(object sender, EventArgs e)
        {
            turnOffotherField(txt_1516shanbe, txt_1517shanbe);

            setTextFont(txt_1516shanbe, "min");
        }
        private void txt_1617shanbe_TextChanged(object sender, EventArgs e)
        {
            turnOffotherField(txt_1617shanbe, txt_1517shanbe);

            setTextFont(txt_1617shanbe, "min");
        }
        private void txt_1718shanbe_TextChanged(object sender, EventArgs e)
        {
            turnOffotherField(txt_1718shanbe, txt_1719shanbe);

            setTextFont(txt_1718shanbe, "min");
        }
        private void txt_1819shanbe_TextChanged(object sender, EventArgs e)
        {
            turnOffotherField(txt_1819shanbe, txt_1719shanbe);

            setTextFont(txt_1819shanbe, "min");
        }
        //----------------------------------------------------------------------------
        // yek shanbe
        //----------------------------------------------------------------------------
        private void txt_810yekshanbe_TextChanged(object sender, EventArgs e)
        {
            turnOffotherField2(txt_810yekshanbe, txt_89yekshanbe, txt_910yekshanbe);

            setTextFont(txt_810yekshanbe);
        }
        private void txt_1012yekshanbe_TextChanged(object sender, EventArgs e)
        {
            turnOffotherField2(txt_1012yekshanbe, txt_1011yekshanbe, txt_1112yekshanbe);

            setTextFont(txt_1012yekshanbe);
        }
        private void txt_1315yekshanbe_TextChanged(object sender, EventArgs e)
        {
            turnOffotherField2(txt_1315yekshanbe, txt_1314yekshanbe, txt_1415yekshanbe);

            setTextFont(txt_1315yekshanbe);
        }
        private void txt_1517yekshanbe_TextChanged(object sender, EventArgs e)
        {
            turnOffotherField2(txt_1517yekshanbe, txt_1516yekshanbe, txt_1617yekshanbe);

            setTextFont(txt_1517yekshanbe);
        }
        private void txt_1719yekshanbe_TextChanged(object sender, EventArgs e)
        {
            turnOffotherField2(txt_1719yekshanbe, txt_1718yekshanbe, txt_1819yekshanbe);

            setTextFont(txt_1719yekshanbe);
        }
        //-----------==============-------------
        private void txt_89yekshanbe_TextChanged(object sender, EventArgs e)
        {
            turnOffotherField(txt_89yekshanbe, txt_810yekshanbe);

            setTextFont(txt_89yekshanbe, "min");
        }
        private void txt_910yekshanbe_TextChanged(object sender, EventArgs e)
        {
            turnOffotherField(txt_910yekshanbe, txt_810yekshanbe);

            setTextFont(txt_910yekshanbe, "min");
        }
        private void txt_1011yekshanbe_TextChanged(object sender, EventArgs e)
        {
            turnOffotherField(txt_1011yekshanbe, txt_1012yekshanbe);

            setTextFont(txt_1011yekshanbe, "min");
        }
        private void txt_1112yekshanbe_TextChanged(object sender, EventArgs e)
        {
            turnOffotherField(txt_1112yekshanbe, txt_1012yekshanbe);

            setTextFont(txt_1112yekshanbe, "min");
        }
        private void txt_1314yekshanbe_TextChanged(object sender, EventArgs e)
        {
            turnOffotherField(txt_1314yekshanbe, txt_1315yekshanbe);

            setTextFont(txt_1314yekshanbe, "min");
        }
        private void txt_1415yekshanbe_TextChanged(object sender, EventArgs e)
        {
            turnOffotherField(txt_1415yekshanbe, txt_1315yekshanbe);

            setTextFont(txt_1415yekshanbe, "min");
        }
        private void txt_1516yekshanbe_TextChanged(object sender, EventArgs e)
        {
            turnOffotherField(txt_1516yekshanbe, txt_1517yekshanbe);

            setTextFont(txt_1516yekshanbe, "min");
        }
        private void txt_1617yekshanbe_TextChanged(object sender, EventArgs e)
        {
            turnOffotherField(txt_1617yekshanbe, txt_1517yekshanbe);

            setTextFont(txt_1617yekshanbe, "min");
        }
        private void txt_1718yekshanbe_TextChanged(object sender, EventArgs e)
        {
            turnOffotherField(txt_1718yekshanbe, txt_1719yekshanbe);

            setTextFont(txt_1718yekshanbe, "min");
        }
        private void txt_1819yekshanbe_TextChanged(object sender, EventArgs e)
        {
            turnOffotherField(txt_1819yekshanbe, txt_1719yekshanbe);

            setTextFont(txt_1819yekshanbe, "min");
        }


        // -------------------------------------------------------------------------------
        // do shanbe
        //--------------------------------------------------------------------------------
        private void txt_810dokshanbe_TextChanged(object sender, EventArgs e)
        {
            turnOffotherField2(txt_810dokshanbe, txt_89dokshanbe, txt_910dokshanbe);

            setTextFont(txt_810dokshanbe);
        }
        private void txt_1012dokshanbe_TextChanged(object sender, EventArgs e)
        {
            turnOffotherField2(txt_1012dokshanbe, txt_1011dokshanbe, txt_1112dokshanbe);

            setTextFont(txt_1012dokshanbe);
        }
        private void txt_1315dokshanbe_TextChanged(object sender, EventArgs e)
        {
            turnOffotherField2(txt_1315dokshanbe, txt_1314dokshanbe, txt_1415dokshanbe);

            setTextFont(txt_1315dokshanbe);
        }
        private void txt_1517dokshanbe_TextChanged(object sender, EventArgs e)
        {
            turnOffotherField2(txt_1517dokshanbe, txt_1516dokshanbe, txt_1617dokshanbe);

            setTextFont(txt_1517dokshanbe);
        }
        private void txt_1719dokshanbe_TextChanged(object sender, EventArgs e)
        {
            turnOffotherField2(txt_1719dokshanbe, txt_1718dokshanbe, txt_1819dokshanbe);

            setTextFont(txt_1719dokshanbe);
        }
        //-------==========-------------
        private void txt_89dokshanbe_TextChanged(object sender, EventArgs e)
        {
            turnOffotherField(txt_89dokshanbe, txt_810dokshanbe);

            setTextFont(txt_89dokshanbe, "min");
        }
        private void txt_910dokshanbe_TextChanged(object sender, EventArgs e)
        {
            turnOffotherField(txt_910dokshanbe, txt_810dokshanbe);

            setTextFont(txt_910dokshanbe, "min");
        }
        private void txt_1011dokshanbe_TextChanged(object sender, EventArgs e)
        {
            turnOffotherField(txt_1011dokshanbe, txt_1012dokshanbe);

            setTextFont(txt_1011dokshanbe, "min");
        }
        private void txt_1112dokshanbe_TextChanged(object sender, EventArgs e)
        {
            turnOffotherField(txt_1112dokshanbe, txt_1012dokshanbe);

            setTextFont(txt_1112dokshanbe, "min");
        }
        private void txt_1314dokshanbe_TextChanged(object sender, EventArgs e)
        {
            turnOffotherField(txt_1314dokshanbe, txt_1315dokshanbe);

            setTextFont(txt_1314dokshanbe, "min");
        }
        private void txt_1415dokshanbe_TextChanged(object sender, EventArgs e)
        {
            turnOffotherField(txt_1415dokshanbe, txt_1315dokshanbe);

            setTextFont(txt_1415dokshanbe, "min");
        }
        private void txt_1516dokshanbe_TextChanged(object sender, EventArgs e)
        {
            turnOffotherField(txt_1516dokshanbe, txt_1517dokshanbe);

            setTextFont(txt_1516dokshanbe, "min");
        }
        private void txt_1617dokshanbe_TextChanged(object sender, EventArgs e)
        {
            turnOffotherField(txt_1617dokshanbe, txt_1517dokshanbe);

            setTextFont(txt_1617dokshanbe, "min");

        }
        private void txt_1718dokshanbe_TextChanged(object sender, EventArgs e)
        {
            turnOffotherField(txt_1718dokshanbe, txt_1719dokshanbe);

            setTextFont(txt_1718dokshanbe, "min");
        }
        private void txt_1819dokshanbe_TextChanged(object sender, EventArgs e)
        {
            turnOffotherField(txt_1819dokshanbe, txt_1719dokshanbe);

            setTextFont(txt_1819dokshanbe, "min");
        }
        //----------------------------------------------------------------------------
        // se shanbe
        //----------------------------------------------------------------------------
        private void txt_810sekshanbe_TextChanged(object sender, EventArgs e)
        {
            turnOffotherField2(txt_810sekshanbe, txt_89sekshanbe, txt_910sekshanbe);

            setTextFont(txt_810sekshanbe);
        }
        private void txt_1012sekshanbe_TextChanged(object sender, EventArgs e)
        {
            turnOffotherField2(txt_1012sekshanbe, txt_1011sekshanbe, txt_1112sekshanbe);

            setTextFont(txt_1012sekshanbe);
        }
        private void txt_1315sekshanbe_TextChanged(object sender, EventArgs e)
        {
            turnOffotherField2(txt_1315sekshanbe, txt_1314sekshanbe, txt_1415sekshanbe);

            setTextFont(txt_1315sekshanbe);
        }
        private void txt_1517sekshanbe_TextChanged(object sender, EventArgs e)
        {
            turnOffotherField2(txt_1517sekshanbe, txt_1516sekshanbe, txt_1617sekshanbe);

            setTextFont(txt_1517sekshanbe);
        }
        private void txt_1719sekshanbe_TextChanged(object sender, EventArgs e)
        {
            turnOffotherField2(txt_1719sekshanbe, txt_1718sekshanbe, txt_1819sekshanbe);

            setTextFont(txt_1719sekshanbe);
        }
        //-----------==============-------------
        private void txt_89sekshanbe_TextChanged(object sender, EventArgs e)
        {
            turnOffotherField(txt_89sekshanbe, txt_810sekshanbe);

            setTextFont(txt_89sekshanbe, "min");
        }
        private void txt_910sekshanbe_TextChanged(object sender, EventArgs e)
        {
            turnOffotherField(txt_910sekshanbe, txt_810sekshanbe);

            setTextFont(txt_910sekshanbe, "min");
        }
        private void txt_1011sekshanbe_TextChanged(object sender, EventArgs e)
        {
            turnOffotherField(txt_1011sekshanbe, txt_1012sekshanbe);

            setTextFont(txt_1011sekshanbe, "min");
        }
        private void txt_1112sekshanbe_TextChanged(object sender, EventArgs e)
        {
            turnOffotherField(txt_1112sekshanbe, txt_1012sekshanbe);

            setTextFont(txt_1112sekshanbe, "min");
        }
        private void txt_1314sekshanbe_TextChanged(object sender, EventArgs e)
        {
            turnOffotherField(txt_1314sekshanbe, txt_1315sekshanbe);

            setTextFont(txt_1314sekshanbe, "min");
        }
        private void txt_1415sekshanbe_TextChanged(object sender, EventArgs e)
        {
            turnOffotherField(txt_1415sekshanbe, txt_1315sekshanbe);

            setTextFont(txt_1415sekshanbe, "min");
        }
        private void txt_1516sekshanbe_TextChanged(object sender, EventArgs e)
        {
            turnOffotherField(txt_1516sekshanbe, txt_1517sekshanbe);

            setTextFont(txt_1516sekshanbe, "min");
        }
        private void txt_1617sekshanbe_TextChanged(object sender, EventArgs e)
        {
            turnOffotherField(txt_1617sekshanbe, txt_1517sekshanbe);

            setTextFont(txt_1617sekshanbe, "min");
        }
        private void txt_1718sekshanbe_TextChanged(object sender, EventArgs e)
        {
            turnOffotherField(txt_1718sekshanbe, txt_1719sekshanbe);

            setTextFont(txt_1718sekshanbe, "min");
        }
        private void txt_1819sekshanbe_TextChanged(object sender, EventArgs e)
        {
            turnOffotherField(txt_1819charkshanbe, txt_1719charkshanbe);

            setTextFont(txt_1819sekshanbe, "min");
        }
        //----------------------------------------------------------------------------
        // char shanbe
        //----------------------------------------------------------------------------
        private void txt_810charkshanbe_TextChanged(object sender, EventArgs e)
        {
            turnOffotherField2(txt_810charkshanbe, txt_89charkshanbe, txt_910charkshanbe);



            setTextFont(txt_810charkshanbe);
        }
        private void txt_1012charkshanbe_TextChanged(object sender, EventArgs e)
        {

            turnOffotherField2(txt_1012charkshanbe, txt_1011charkshanbe, txt_1112charkshanbe);

            setTextFont(txt_1012charkshanbe);
        }
        private void txt_1315charkshanbe_TextChanged(object sender, EventArgs e)
        {
            turnOffotherField2(txt_1315charkshanbe, txt_1314charkshanbe, txt_1415charkshanbe);

            setTextFont(txt_1315charkshanbe);
        }
        private void txt_1517charkshanbe_TextChanged(object sender, EventArgs e)
        {
            turnOffotherField2(txt_1517charkshanbe, txt_1516charkshanbe, txt_1617charkshanbe);

            setTextFont(txt_1517charkshanbe);
        }
        private void txt_1719charkshanbe_TextChanged(object sender, EventArgs e)
        {
            turnOffotherField2(txt_1719charkshanbe, txt_1718charkshanbe, txt_1819charkshanbe);

            setTextFont(txt_1719charkshanbe);
        }
        //--------------=============------------------
        private void txt_89charkshanbe_TextChanged(object sender, EventArgs e)
        {
            turnOffotherField(txt_89charkshanbe, txt_810charkshanbe);

            setTextFont(txt_89charkshanbe, "min");
        }
        private void txt_910charkshanbe_TextChanged(object sender, EventArgs e)
        {
            turnOffotherField(txt_910charkshanbe, txt_810charkshanbe);

            setTextFont(txt_910charkshanbe, "min");
        }
        private void txt_1011charkshanbe_TextChanged(object sender, EventArgs e)
        {
            turnOffotherField(txt_1011charkshanbe, txt_1012charkshanbe);

            setTextFont(txt_1011charkshanbe, "min");
        }
        private void txt_1112charkshanbe_TextChanged(object sender, EventArgs e)
        {
            turnOffotherField(txt_1112charkshanbe, txt_1012charkshanbe);

            setTextFont(txt_1112charkshanbe, "min");
        }
        private void txt_1314charkshanbe_TextChanged(object sender, EventArgs e)
        {
            turnOffotherField(txt_1314charkshanbe, txt_1315charkshanbe);

            setTextFont(txt_1314charkshanbe, "min");
        }
        private void txt_1415charkshanbe_TextChanged(object sender, EventArgs e)
        {
            turnOffotherField(txt_1415charkshanbe, txt_1315charkshanbe);

            setTextFont(txt_1415charkshanbe, "min");
        }
        private void txt_1516charkshanbe_TextChanged(object sender, EventArgs e)
        {
            turnOffotherField(txt_1516charkshanbe, txt_1517charkshanbe);

            setTextFont(txt_1516charkshanbe, "min");
        }
        private void txt_1617charkshanbe_TextChanged(object sender, EventArgs e)
        {
            turnOffotherField(txt_1617charkshanbe, txt_1517charkshanbe);

            setTextFont(txt_1617charkshanbe, "min");
        }
        private void txt_1718charkshanbe_TextChanged(object sender, EventArgs e)
        {
            turnOffotherField(txt_1718charkshanbe, txt_1719charkshanbe);

            setTextFont(txt_1718charkshanbe, "min");
        }
        private void txt_1819charkshanbe_TextChanged(object sender, EventArgs e)
        {
            turnOffotherField(txt_1819charkshanbe, txt_1719charkshanbe);

            setTextFont(txt_1819charkshanbe, "min");
        }


        // ----------------- ============================= ------------------------------------




        private void lbl_sundy_Click(object sender, EventArgs e)
        {

        }

        private void btn_cleartable_Click(object sender, EventArgs e)
        {
            txt_teacherfname.Text = "";
            txt_teacherlname.Text = "";
            txt_address.Text = "";
            //-------------------------------shanbe
            txt_810shanbe.Text = "";
            txt_89shanbe.Text = "";
            txt_910shanbe.Text = "";
            txt_1012shanbe.Text = "";
            txt_1011shanbe.Text = "";
            txt_1112shanbe.Text = "";
            txt_1315shanbe.Text = "";
            txt_1314shanbe.Text = "";
            txt_1415shanbe.Text = "";
            txt_1517shanbe.Text = "";
            txt_1516shanbe.Text = "";
            txt_1617shanbe.Text = "";
            txt_1719shanbe.Text = "";
            txt_1718shanbe.Text = "";
            txt_1819shanbe.Text = "";
            //-------------------------------yekshanbe
            txt_810yekshanbe.Text = "";
            txt_89yekshanbe.Text = "";
            txt_910yekshanbe.Text = "";
            txt_1012yekshanbe.Text = "";
            txt_1011yekshanbe.Text = "";
            txt_1112yekshanbe.Text = "";
            txt_1315yekshanbe.Text = "";
            txt_1314yekshanbe.Text = "";
            txt_1415yekshanbe.Text = "";
            txt_1517yekshanbe.Text = "";
            txt_1516yekshanbe.Text = "";
            txt_1617yekshanbe.Text = "";
            txt_1719yekshanbe.Text = "";
            txt_1718yekshanbe.Text = "";
            txt_1819yekshanbe.Text = "";
            //-------------------------------dokshanbe
            txt_810dokshanbe.Text = "";
            txt_89dokshanbe.Text = "";
            txt_910dokshanbe.Text = "";
            txt_1012dokshanbe.Text = "";
            txt_1011dokshanbe.Text = "";
            txt_1112dokshanbe.Text = "";
            txt_1315dokshanbe.Text = "";
            txt_1314dokshanbe.Text = "";
            txt_1415dokshanbe.Text = "";
            txt_1517dokshanbe.Text = "";
            txt_1516dokshanbe.Text = "";
            txt_1617dokshanbe.Text = "";
            txt_1719dokshanbe.Text = "";
            txt_1718dokshanbe.Text = "";
            txt_1819dokshanbe.Text = "";
            //-------------------------------sekshanbe
            txt_810sekshanbe.Text = "";
            txt_89sekshanbe.Text = "";
            txt_910sekshanbe.Text = "";
            txt_1012sekshanbe.Text = "";
            txt_1011sekshanbe.Text = "";
            txt_1112sekshanbe.Text = "";
            txt_1315sekshanbe.Text = "";
            txt_1314sekshanbe.Text = "";
            txt_1415sekshanbe.Text = "";
            txt_1517sekshanbe.Text = "";
            txt_1516sekshanbe.Text = "";
            txt_1617sekshanbe.Text = "";
            txt_1719sekshanbe.Text = "";
            txt_1718sekshanbe.Text = "";
            txt_1819sekshanbe.Text = "";
            //-------------------------------charkshanbe
            txt_810charkshanbe.Text = "";
            txt_89charkshanbe.Text = "";
            txt_910charkshanbe.Text = "";
            txt_1012charkshanbe.Text = "";
            txt_1011charkshanbe.Text = "";
            txt_1112charkshanbe.Text = "";
            txt_1315charkshanbe.Text = "";
            txt_1314charkshanbe.Text = "";
            txt_1415charkshanbe.Text = "";
            txt_1517charkshanbe.Text = "";
            txt_1516charkshanbe.Text = "";
            txt_1617charkshanbe.Text = "";
            txt_1719charkshanbe.Text = "";
            txt_1718charkshanbe.Text = "";
            txt_1819charkshanbe.Text = "";
        }


        public bool have89()
        {
            if (txt_89shanbe.Text != "" ||
                txt_89yekshanbe.Text != "" ||
                txt_89dokshanbe.Text != "" ||
                txt_89sekshanbe.Text != "" ||
                txt_89charkshanbe.Text != "")
                return true;
            return false;
        }

        public bool have910()
        {
            bool res = true;
            if (txt_910shanbe.Text != "" ||
                txt_910yekshanbe.Text != "" ||
                txt_910dokshanbe.Text != "" ||
                txt_910sekshanbe.Text != "" ||
                txt_910charkshanbe.Text != "")
            {
                return res;
            }
            return false;
        }
        public bool have1011()
        {
            bool res = true;
            if (txt_1011shanbe.Text != "" ||
                txt_1011yekshanbe.Text != "" ||
                txt_1011dokshanbe.Text != "" ||
                txt_1011sekshanbe.Text != "" ||
                txt_1011charkshanbe.Text != "")
            {
                return res;
            }
            return false;
        }
        public bool have1112()
        {
            bool res = true;
            if (txt_1112shanbe.Text != "" ||
                txt_1112yekshanbe.Text != "" ||
                txt_1112dokshanbe.Text != "" ||
                txt_1112sekshanbe.Text != "" ||
                txt_1112charkshanbe.Text != "")
            {
                return res;
            }
            return false;
        }
        public bool have1314()
        {
            bool res = true;
            if (txt_1314shanbe.Text != "" ||
                txt_1314yekshanbe.Text != "" ||
                txt_1314dokshanbe.Text != "" ||
                txt_1314sekshanbe.Text != "" ||
                txt_1314charkshanbe.Text != "")
            {
                return res;
            }
            return false;
        }
        public bool have1415()
        {
            bool res = true;
            if (txt_1415shanbe.Text != "" ||
                txt_1415yekshanbe.Text != "" ||
                txt_1415dokshanbe.Text != "" ||
                txt_1415sekshanbe.Text != "" ||
                txt_1415charkshanbe.Text != "")
            {
                return res;
            }
            return false;
        }
        public bool have1516()
        {
            bool res = true;
            if (txt_1516shanbe.Text != "" ||
                txt_1516yekshanbe.Text != "" ||
                txt_1516dokshanbe.Text != "" ||
                txt_1516sekshanbe.Text != "" ||
                txt_1516charkshanbe.Text != "")
            {
                return res;
            }
            return false;
        }
        public bool have1617()
        {
            bool res = true;
            if (txt_1617shanbe.Text != "" ||
                txt_1617yekshanbe.Text != "" ||
                txt_1617dokshanbe.Text != "" ||
                txt_1617sekshanbe.Text != "" ||
                txt_1617charkshanbe.Text != "")
            {
                return res;
            }
            return false;
        }
        public bool have1718()
        {
            bool res = true;
            if (txt_1718shanbe.Text != "" ||
                txt_1718yekshanbe.Text != "" ||
                txt_1718dokshanbe.Text != "" ||
                txt_1718sekshanbe.Text != "" ||
                txt_1718charkshanbe.Text != "")
            {
                return res;
            }
            return false;
        }
        public bool have1819()
        {
            bool res = true;
            if (txt_1819shanbe.Text != "" ||
                txt_1819yekshanbe.Text != "" ||
                txt_1819dokshanbe.Text != "" ||
                txt_1819sekshanbe.Text != "" ||
                txt_1819charkshanbe.Text != "")
            {
                return res;
            }
            return false;
        }


        public string multicol(int num, string margin, string text)
        {
            return "\\multicolumn{" + num.ToString() + "}{" + margin + "}{" + text + "}";
        }

        public string field(TextBox both, string min1, string min2, bool b1, bool b2, string mode = "default")
        {
            string result;
            string bothText = both.Text.Replace("\u200C", " ");
            min1.Replace("\u200C", " ");
            min2.Replace("\u200C", " ");

            if (mode == "default")
            {
                if (bothText != "" && (b1 || b2))
                    if (both.ScrollBars == ScrollBars.Horizontal)
                        result = multicol(2, "C{3.5cm}|", "\\thead{" + "تدریس" + "\\\\" + "(" + bothText + ")}");
                    else
                        result = multicol(2, "C{3.5cm}|", bothText);

                else if (bothText != "")
                    if (both.ScrollBars == ScrollBars.Horizontal)
                        result = "\\thead{" + "تدریس" + "\\\\" + "(" + bothText + ")}";
                    else
                        result = $"{bothText}";

                else if (min1 != "" || min2 != "")
                    result = $"{min1} & {min2}";

                else if ((b1 || b2))
                    result = multicol(2, "C{3.5cm}|", " ");

                else
                    result = " ";

                return result;
            }
            else
            {
                if (bothText != "" && (b1 || b2))
                    if (both.ScrollBars == ScrollBars.Horizontal)
                        result = multicol(2, "C{3.5cm}'", "\\thead{" + "تدریس" + "\\\\" + "(" + bothText + ")}");
                    else
                        result = multicol(2, "C{3.5cm}'", bothText);

                else if (bothText != "")
                    if (both.ScrollBars == ScrollBars.Horizontal)
                        result = "\\thead{" + "تدریس" + "\\\\" + "(" + bothText + ")}";
                    else
                        result = $"{bothText}";

                else if (min1 != "" || min2 != "")
                    result = $"{min1} & {min2}";

                else if ((b1 || b2))
                    result = multicol(2, "C{3.5cm}'", " ");

                else
                    result = " ";

                return result;
            }
        }

        public string field2(TextBox tx1, TextBox tx2, string min1, string min2, string min3, string min4, bool b1, bool b2, bool b3, bool b4)
        {

            string result = "";

            string tx1Text = tx1.Text.Replace("\u200C", " ");
            string tx2Text = tx2.Text.Replace("\u200C", " ");
            min1.Replace("\u200C", " ");
            min2.Replace("\u200C", " ");
            min3.Replace("\u200C", " ");
            min4.Replace("\u200C", " ");


            string state = "0";

            if (tx1Text != "" && tx1Text == tx2Text)
                state = "1";
            else if (tx1Text != "" && tx1Text == min3)
                state = "2";
            else if (min2 != "" && min2 == min3)
                state = "3";
            else if (min2 != "" && min2 == tx2Text)
                state = "4";


            switch (state)
            {
                case "0":
                    // 8-10 , 8-9 , 9-10
                    result = field(tx1, min1, min2, b1, b2) + " & ";

                    // 10-12 , 11-12 , 10-11
                    result += field(tx2, min3, min4, b3, b4);

                    return result;




                case "1":
                    if ((b1 || b2) && (b3 || b4))
                    {
                        if (tx2.ScrollBars == ScrollBars.Horizontal)
                            result = multicol(4, "C{7cm}|", "\\thead{" + "تدریس" + "\\\\" + "(" + tx2Text + ")}");
                        else
                            result = multicol(4, "C{7cm}|", tx2Text);
                    }
                    else if ((b1 || b2) || (b3 || b4))
                    {
                        if (tx2.ScrollBars == ScrollBars.Horizontal)
                            result = multicol(3, "C{7cm}|", "\\thead{" + "تدریس" + "\\\\" + "(" + tx2Text + ")}");
                        else
                            result = multicol(3, "C{7cm}|", tx2Text);
                    }
                    else
                    {
                        if (tx2.ScrollBars == ScrollBars.Horizontal)
                            result = multicol(2, "C{7cm}|", "\\thead{" + "تدریس" + "\\\\" + "(" + tx2Text + ")}");
                        else
                            result = multicol(2, "C{7cm}|", tx2Text);
                    }
                    return result;

                case "2":
                    if ((b1 || b2))
                        result = multicol(3, "C{5.25cm}|", tx1Text) + " & " + min4;
                    else
                        result = multicol(2, "C{5.25cm}|", tx1Text) + " & " + min4;
                    return result;

                case "3":

                    result = min1 + " & " + multicol(2, "C{3.5cm}|", min2) + " & " + min4;
                    return result;

                case "4":

                    if ((b3 || b4))
                        result = min1 + " & " + multicol(3, "C{5.25cm}|", tx2Text);
                    else
                        result = min1 + " & " + multicol(2, "C{5.25cm}|", tx2Text);
                    return result;
            }



            return result;
        }


        public string field3(TextBox tx1, TextBox tx2, TextBox tx3, string min1, string min2, string min3, string min4, string min5, string min6, bool b1, bool b2, bool b3, bool b4, bool b5, bool b6)
        {
            string result = "";
            string tx1Text = tx1.Text.Replace("\u200C", " ");
            string tx2Text = tx2.Text.Replace("\u200C", " ");
            string tx3Text = tx3.Text.Replace("\u200C", " ");
            min1.Replace("\u200C", " ");
            min2.Replace("\u200C", " ");
            min3.Replace("\u200C", " ");
            min4.Replace("\u200C", " ");
            min5.Replace("\u200C", " ");
            min6.Replace("\u200C", " ");

            string state = "0";

            if (tx1Text != "" && tx1Text == tx2Text && tx1Text == tx3Text)
                state = "1";
            else if (tx1Text != "" && tx1Text == tx2Text && tx1Text == min5)
                state = "2";
            else if (tx1Text != "" && tx1Text == tx2Text)
                state = "3";
            else if (tx1Text != "" && tx1Text == min3)
                state = "4";

            else if (min2 != "" && min2 == tx2Text && min2 == tx3Text)
                state = "5";
            else if (min2 != "" && min2 == tx2Text && min2 == min5)
                state = "6";
            else if (min2 != "" && min2 == tx2Text)
                state = "7";
            else if (min2 != "" && min2 == min3)
                state = "8";

            else if (tx2Text != "" && tx2Text == tx3Text)
                state = "9";
            else if (tx2Text != "" && tx2Text == min5)
                state = "10";

            else if (min4 != "" && min4 == tx3Text)
                state = "12";
            else if (min4 != "" && min4 == min5)
                state = "11";



            switch (state)
            {
                case "0":

                    // 13-15 , 13-14 , 14-15
                    result = field(tx1, min1, min2, b1, b2) + " & ";

                    // 15-17 , 15-16 , 16-17
                    result += field(tx2, min3, min4, b3, b4) + " & ";

                    // 17-19 , 17-18 , 18-19
                    result += field(tx3, min5, min6, b5, b6, "lastTexbox");

                    return result;

                case "1":
                    if ((b1 || b2) && (b3 || b4) && (b5 || b6))
                    {
                        if (tx2.ScrollBars == ScrollBars.Horizontal)
                            result = multicol(6, "C{10.5cm}'", "\\thead{" + "تدریس" + "\\\\" + "(" + tx2Text + ")}");
                        else
                            result = multicol(6, "C{10.5cm}'", tx2Text);
                    }
                    else if (((b1 || b2) && (b3 || b4)) || ((b1 || b2) && (b5 || b6)) || ((b5 || b6) && (b3 || b4)))
                    {
                        if (tx2.ScrollBars == ScrollBars.Horizontal)
                            result = multicol(5, "C{10.5cm}'", "\\thead{" + "تدریس" + "\\\\" + "(" + tx2Text + ")}");
                        else
                            result = multicol(5, "C{10.5cm}'", tx2Text);
                    }
                    else if ((b1 || b2) || (b3 || b4) || (b5 || b6))
                    {
                        if (tx2.ScrollBars == ScrollBars.Horizontal)
                            result = multicol(4, "C{10.5cm}'", "\\thead{" + "تدریس" + "\\\\" + "(" + tx2Text + ")}");
                        else
                            result = multicol(4, "C{10.5cm}'", tx2Text);
                    }
                    else
                    {
                        if (tx2.ScrollBars == ScrollBars.Horizontal)
                            result = multicol(3, "C{10.5cm}'", "\\thead{" + "تدریس" + "\\\\" + "(" + tx2Text + ")}");
                        else
                            result = multicol(3, "C{10.5cm}'", tx2Text);
                    }
                    return result;


                case "2":
                    if ((b1 || b2) && (b3 || b4))
                        result = multicol(5, "C{8.75cm}|", tx1Text) + "&" + min6;
                    else if ((b1 || b2) || (b3 || b4))
                        result = multicol(4, "C{8.75cm}|", tx1Text) + "&" + min6;
                    else
                        result = multicol(3, "C{8.75cm}|", tx1Text) + "&" + min6;

                    return result;


                case "3":
                    if ((b1 || b2) && (b3 || b4))
                        result = multicol(4, "C{7cm}|", tx1Text) + "&" + field(tx3, min5, min6, b5, b6, "lastTexbox");

                    else if ((b1 || b2) || (b3 || b4))
                        result = multicol(3, "C{7cm}|", tx1Text) + "&" + field(tx3, min5, min6, b5, b6, "lastTexbox");

                    else
                        result = multicol(2, "C{7cm}|", tx1Text) + "&" + field(tx3, min5, min6, b5, b6, "lastTexbox");

                    return result;


                case "4":
                    if ((b1 || b2))
                        result = multicol(3, "C{5.25cm}|", tx1Text) + "&" + min4 + " & " + field(tx3, min5, min6, b5, b6, "lastTexbox");

                    else
                        result = multicol(2, "C{5.25cm}|", tx1Text) + "&" + min4 + " & " + field(tx3, min5, min6, b5, b6, "lastTexbox");
                    return result;

                case "5":
                    if ((b5 || b6) && (b3 || b4))
                        result = min1 + " & " + multicol(5, "C{8.75cm}'", tx2Text);
                    else if ((b5 || b6) || (b3 || b4))
                        result = min1 + " & " + multicol(4, "C{8.75cm}'", tx2Text);
                    else
                        result = min1 + " & " + multicol(3, "C{8.75cm}'", tx2Text);

                    return result;

                case "6":


                    if ((b3 || b4))
                        result = min1 + " & " + multicol(4, "C{7cm}|", tx2Text) + "&" + min6;
                    else
                        result = min1 + " & " + multicol(3, "C{7cm}|", tx2Text) + "&" + min6;
                    return result;


                case "7":
                    if ((b3 || b4))
                        result = min1 + " & " + multicol(3, "C{5.25cm}|", tx2Text) + "&" + field(tx3, min5, min6, b5, b6, "lastTexbox");
                    else
                        result = min1 + " & " + multicol(2, "C{5.25cm}|", tx2Text) + "&" + field(tx3, min5, min6, b5, b6, "lastTexbox");

                    return result;


                case "8":

                    result = min1 + " & " + multicol(2, "C{3.5cm}|", min2) + "&" + min4 + " & " + field(tx3, min5, min6, b5, b6, "lastTexbox");
                    return result;



                case "9":
                    if ((b3 || b4) && (b5 || b6))
                    {
                        if (tx2.ScrollBars == ScrollBars.Horizontal)
                            result = field(tx1, min1, min2, b1, b2) + " & " + multicol(4, "C{7cm}'", "\\thead{" + "تدریس" + "\\\\" + "(" + tx2Text + ")}");
                        else
                            result = field(tx1, min1, min2, b1, b2) + " & " + multicol(4, "C{7cm}'", tx2Text);
                    }

                    else if ((b3 || b4) && (b5 || b6))
                    {
                        if (tx2.ScrollBars == ScrollBars.Horizontal)
                            result = field(tx1, min1, min2, b1, b2) + " & " + multicol(3, "C{7cm}'", "\\thead{" + "تدریس" + "\\\\" + "(" + tx2Text + ")}");
                        else
                            result = field(tx1, min1, min2, b1, b2) + " & " + multicol(3, "C{7cm}'", tx2Text);
                    }

                    else
                    {
                        if (tx2.ScrollBars == ScrollBars.Horizontal)
                            result = field(tx1, min1, min2, b1, b2) + " & " + multicol(2, "C{7cm}'", "\\thead{" + "تدریس" + "\\\\" + "(" + tx2Text + ")}");
                        else
                            result = field(tx1, min1, min2, b1, b2) + " & " + multicol(2, "C{7cm}'", tx2Text);
                    }
                    return result;


                case "10":

                    if ((b3 || b4))
                        result = field(tx1, min1, min2, b1, b2) + " & " + multicol(3, "C{5.25cm}|", tx2Text) + "&" + min6;

                    else
                        result = field(tx1, min1, min2, b1, b2) + " & " + multicol(2, "C{5.25cm}|", tx2Text) + "&" + min6;
                    return result;



                case "11":

                    result = field(tx1, min1, min2, b1, b2) + " & " + min3 + " & " + multicol(2, "C{3.5cm}|", min4) + "&" + min6;
                    return result;


                case "12":

                    if ((b5 || b6))
                        result = field(tx1, min1, min2, b1, b2) + " & " + min3 + " & " + multicol(3, "C{5.25cm}'", min4);
                    else
                        result = field(tx1, min1, min2, b1, b2) + " & " + min3 + " & " + multicol(2, "C{5.25cm}'", min4);

                    return result;

            }



            return result;
        }



        public string createTabular(bool b1, bool b2)
        {
            if (b1 || b2)
                return ">{\\arraybackslash}P{1.75cm}|P{1.75cm}";

            else
                return ">{\\arraybackslash}P{3.5cm}";

        }



        private void btn_createtable_Click(object sender, EventArgs e)
        {


            if (txt_address.Text == "")
            {
                string desktopfolder = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Desktop);

                txt_address.Text = desktopfolder;
                MessageBox.Show("لطفا ابتدا مکانی را برای ذخیره کردن انخاب کنید\n" + "به صورت پیشفرض مسیر\n" + txt_address.Text + "\nدر نظر گرفته شد");
                btn_address.Focus();
                this.Text = "Create Latex Table | " + desktopfolder;
            }
            else
            {
                try
                {

                    string path = txt_address.Text + "\\Latex";
                    //System.IO.Directory.CreateDirectory(path);

                    if (System.IO.Directory.Exists(path))
                    {
                        Random rnd = new Random();
                        int card = rnd.Next(100);
                        path = txt_address.Text + "\\Latex" + card.ToString();
                    }

                    System.IO.Directory.CreateDirectory(path);

                    string InstallDir = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Windows);
                    InstallDir += "\\LatexTableProgram";

                    string[] files = System.IO.Directory.GetFiles(InstallDir);
                    foreach (string s in files)
                    {
                        if (s.Contains("BNAZANIN.TTF"))
                            System.IO.File.Copy(s, System.IO.Path.Combine(path, "font.ttf"), true);
                        if (s.Contains("BNAZANB.TTF"))
                            System.IO.File.Copy(s, System.IO.Path.Combine(path, "fontB.ttf"), true);
                    }


                    StreamWriter file = new StreamWriter(path + "\\main.tex");

                    file.WriteLine("\\documentclass[12pt,a4paper]{article}");
                    file.WriteLine("\\usepackage{mathrsfs,amsmath,amssymb,amsthm}");
                    file.WriteLine("\\usepackage[table]{xcolor}");
                    file.WriteLine("\\usepackage{multicol}");
                    file.WriteLine("\\usepackage[paperwidth=28cm,paperheight=22cm,top=2cm,right=2cm,bottom=0.1mm,left=2cm]{geometry}");
                    file.WriteLine("\\usepackage{boldline}");
                    file.WriteLine("\\usepackage{tikz}");
                    file.WriteLine("\\usetikzlibrary{calc}");
                    file.WriteLine("\\usepackage{eso-pic}");

                    file.WriteLine("\\usepackage{array}");

                    file.WriteLine("\\usepackage{makecell}");
                    file.WriteLine("\\renewcommand\\theadalign{bc}");
                    file.WriteLine("\\renewcommand\\theadfont{\\bfseries}");
                    file.WriteLine("\\renewcommand\\theadgape{\\Gape[4pt]}");
                    file.WriteLine("\\renewcommand\\cellgape{\\Gape[4pt]}");

                    file.WriteLine("\\newcolumntype{C}[1]{>{\\centering\\arraybackslash}p{#1}}");
                    file.WriteLine("\\newcolumntype{P}[1]{%");
                    file.WriteLine(">{\\vbox to 4ex\\bgroup\\vfill\\centering\\arraybackslash}%");
                    file.WriteLine("m{#1}%");
                    file.WriteLine("<{\\vskip-\\baselineskip\\vfill\\egroup}}");
                    file.WriteLine("\\newcolumntype{\'}{!{\\vrule width 2pt}}");

                    file.WriteLine("\\usepackage{xepersian}");
                    file.WriteLine("\\settextfont[Scale=1]{font.ttf}");
                    file.WriteLine("\\defpersianfont\\nbf[Scale=1]{fontB.ttf}");

                    //----Def
                    //file.WriteLine("\\makeatletter");
                    //file.WriteLine("\\def\\thickhline{%");
                    //file.WriteLine("\\noalign{\\ifnum0=`}\\fi\\hrule\\@height\\thickarrayrulewidth\\futurelet");
                    //file.WriteLine("\\reserved@a\\@xthickhline}");
                    //file.WriteLine("\\def\\@xthickhline{\\ifx\\reserved@a\\thickhline");
                    //file.WriteLine("\\vskip\\doublerulesep");
                    //file.WriteLine("\\vskip-\\thickarrayrulewidth");
                    //file.WriteLine("\\fi");
                    //file.WriteLine("\\ifnum0=`{\\fi}}");
                    //file.WriteLine("\\makeatother");
                    //file.WriteLine("\\newlength{\\thickarrayrulewidth}");
                    //file.WriteLine("\\setlength{\\thickarrayrulewidth}{6\\arrayrulewidth}");

                    file.WriteLine("\\begin{document}");

                    //%------ Set Border
                    file.WriteLine("\\AddToShipoutPictureBG{%");
                    file.WriteLine("\\begin{tikzpicture}[overlay,remember picture]");
                    file.WriteLine("\\draw[line width=3pt]");
                    file.WriteLine("($ (current page.north west) + (0.5cm,-0.5cm) $)");
                    file.WriteLine("rectangle");
                    file.WriteLine("($ (current page.south east) + (-0.5cm,0.5cm) $);");
                    file.WriteLine("\\draw[line width=1.5pt]");
                    file.WriteLine("($ (current page.north west) + (0.8cm,-0.8cm) $)");
                    file.WriteLine("rectangle");
                    file.WriteLine("($ (current page.south east) + (-0.8cm,0.8cm) $);");
                    file.WriteLine("\\end{tikzpicture}}");




                    file.WriteLine("\\begin{center}");

                    PersianCalendar p = new PersianCalendar();
                    DateTime dt = DateTime.Now;
                    int y = p.GetYear(dt);

                    file.WriteLine("\\huge{برنامه هفتگی اعضای هیأت علمی در نیمسال " + txt_nimsal.Text + " " + (y + 1).ToString() + "-" + y.ToString() + "}");

                    file.WriteLine("\\end{center}");

                    file.WriteLine("\\vspace{0.5cm}");
                    file.WriteLine("\\begin{flushright}");

                    if (txt_teacherfname.Text == "" && txt_teacherlname.Text == "")
                    {
                        txt_teacherfname.Text = ".............";
                        txt_teacherlname.Text = ".............";
                    }

                    if (txt_field.Text == "" && txt_field2.Text == "")

                        txt_field.Text = ".........................";

                    file.WriteLine("\\hspace{2.7cm}\\Large{نام و نام خانوادگی: " + txt_teacherfname.Text + " " + txt_teacherlname.Text + "}\\hspace{4cm}\\Large{رشته و گرایش: " + txt_field.Text + " - " + txt_field2.Text + "}");
                    file.WriteLine("\\end{flushright}");

                    file.WriteLine("%---------------------------- Start Table Code");

                    file.WriteLine("\\begin{table}[!ht]");
                    file.WriteLine("\\footnotesize");

                    file.WriteLine("\\renewcommand{\\arraystretch}{3}");
                    // DEFINE SIZE COLUMNS
                    string[] tabular = {createTabular(have89(), have910()),
                                createTabular(have1011(), have1112()),
                                createTabular(have1314(), have1415()),
                                createTabular(have1516(), have1617()),
                                createTabular(have1718(), have1819())};

                    string res = $"\'c|{tabular[0]}|{tabular[1]}|c|{tabular[2]}|{tabular[3]}|{tabular[4]}\'";

                    file.WriteLine("\\begin{center}");
                    file.WriteLine("\\begin{tabular}{" + res + "}");

                    //file.WriteLine("\\noalign{‎\\hrule ‎height 2pt‎}‎"); //-------------------------------------------------------->
                    file.WriteLine("\\hlineB{5}");

                    // CREATE TITLE (HOURS) FOR ROWS
                    file.WriteLine("\\cellcolor{gray!15!white}{ایام هفته}&");
                    //8 - 10
                    if (have89() || have910())
                    {
                        file.WriteLine("\\cellcolor{gray!15!white}{\\nbf{9-8}}&");
                        file.WriteLine("\\cellcolor{gray!15!white}{\\nbf{10-9}}&");
                    }
                    else
                        file.WriteLine("\\cellcolor{gray!15!white}{\\nbf{10-8}}&");
                    //10 - 12
                    if (have1011() || have1112())
                    {
                        file.WriteLine("\\cellcolor{gray!15!white}{\\nbf{11-10}}&");
                        file.WriteLine("\\cellcolor{gray!15!white}{\\nbf{12-11}}&");
                    }
                    else
                        file.WriteLine("\\cellcolor{gray!15!white}{\\nbf{12-10}}&");

                    file.WriteLine("\\cellcolor{gray!15!white}{}&");

                    //13 - 15
                    if (have1314() || have1415())
                    {
                        file.WriteLine("\\cellcolor{gray!15!white}{\\nbf{14-13}}&");
                        file.WriteLine("\\cellcolor{gray!15!white}{\\nbf{15-14}}&");
                    }
                    else
                        file.WriteLine("\\cellcolor{gray!15!white}{\\nbf{15-13}}&");
                    //15 - 17
                    if (have1516() || have1617())
                    {
                        file.WriteLine("\\cellcolor{gray!15!white}{\\nbf{16-15}}&");
                        file.WriteLine("\\cellcolor{gray!15!white}{\\nbf{17-16}}&");
                    }
                    else
                        file.WriteLine("\\cellcolor{gray!15!white}{\\nbf{17-15}}&");
                    //17 -19
                    if (have1718() || have1819())
                    {
                        file.WriteLine("\\cellcolor{gray!15!white}{\\nbf{18-17}}&");
                        file.WriteLine("\\cellcolor{gray!15!white}{\\nbf{19-18}}&");
                    }
                    else
                        file.WriteLine("\\cellcolor{gray!15!white}{\\nbf{19-17}}\\\\");

                    file.WriteLine("\\hline");


                    //FILL TABLE
                    //-------------------------------------------------------------------
                    file.WriteLine("\\cellcolor{gray!15!white}{\\nbf{شنبه}}&");

                    string last0 = field2(txt_810shanbe, txt_1012shanbe,
                                          txt_89shanbe.Text, txt_910shanbe.Text,
                                          txt_1011shanbe.Text, txt_1112shanbe.Text,
                                          have89(), have910(),
                                          have1011(), have1112());

                    // lunch time | |
                    string op2 = "\\cellcolor{gray!15!white}";

                    string next0 = field3(txt_1315shanbe, txt_1517shanbe, txt_1719shanbe,
                                          txt_1314shanbe.Text, txt_1415shanbe.Text,
                                          txt_1516shanbe.Text, txt_1617shanbe.Text,
                                          txt_1718shanbe.Text, txt_1819shanbe.Text,
                                          have1314(), have1415(),
                                          have1516(), have1617(),
                                          have1718(), have1819());
                    // نوشتن نتایج
                    file.WriteLine($"{last0}&{op2}&{next0}\\\\");
                    file.WriteLine("\\hline");

                    //----------------------------------------------------------------------------------------------------------------------
                    file.WriteLine("\\cellcolor{gray!15!white}{\\nbf{یکشنبه}}&");

                    string last1 = field2(txt_810yekshanbe, txt_1012yekshanbe,
                                          txt_89yekshanbe.Text, txt_910yekshanbe.Text,
                                          txt_1011yekshanbe.Text, txt_1112yekshanbe.Text,
                                          have89(), have910(),
                                          have1011(), have1112());

                    // lunch time | |
                    string os2 = "\\cellcolor{gray!15!white}";

                    string next1 = field3(txt_1315yekshanbe, txt_1517yekshanbe, txt_1719yekshanbe,
                                          txt_1314yekshanbe.Text, txt_1415yekshanbe.Text,
                                          txt_1516yekshanbe.Text, txt_1617yekshanbe.Text,
                                          txt_1718yekshanbe.Text, txt_1819yekshanbe.Text,
                                          have1314(), have1415(),
                                          have1516(), have1617(),
                                          have1718(), have1819());

                    // نوشتن نتایج
                    file.WriteLine($"{last1}&{os2}&{next1}\\\\");
                    file.WriteLine("\\hline");

                    //------------------------------------------------------------------------------------------------------------------------
                    file.WriteLine("\\cellcolor{gray!15!white}{\\nbf{دوشنبه}}&");

                    string last2 = field2(txt_810dokshanbe, txt_1012dokshanbe,
                                          txt_89dokshanbe.Text, txt_910dokshanbe.Text,
                                          txt_1011dokshanbe.Text, txt_1112dokshanbe.Text,
                                          have89(), have910(),
                                          have1011(), have1112());

                    // lunch time | |
                    string od2 = "\\cellcolor{gray!15!white}";

                    string next2 = field3(txt_1315dokshanbe, txt_1517dokshanbe, txt_1719dokshanbe,
                                          txt_1314dokshanbe.Text, txt_1415dokshanbe.Text,
                                          txt_1516dokshanbe.Text, txt_1617dokshanbe.Text,
                                          txt_1718dokshanbe.Text, txt_1819dokshanbe.Text,
                                          have1314(), have1415(),
                                          have1516(), have1617(),
                                          have1718(), have1819());

                    // نوشتن نتایج
                    file.WriteLine($"{last2}&{od2}&{next2}\\\\");
                    file.WriteLine("\\hline");

                    //--------------------------------------------------------------------------------------------------------------------------
                    file.WriteLine("\\cellcolor{gray!15!white}{\\nbf{سه شنبه}}&");

                    string last3 = field2(txt_810sekshanbe, txt_1012sekshanbe,
                                          txt_89sekshanbe.Text, txt_910sekshanbe.Text,
                                          txt_1011sekshanbe.Text, txt_1112sekshanbe.Text,
                                          have89(), have910(),
                                          have1011(), have1112());

                    // lunch time | |
                    string oy2 = "\\cellcolor{gray!15!white}";

                    string next3 = field3(txt_1315sekshanbe, txt_1517sekshanbe, txt_1719sekshanbe,
                                          txt_1314sekshanbe.Text, txt_1415sekshanbe.Text,
                                          txt_1516sekshanbe.Text, txt_1617sekshanbe.Text,
                                          txt_1718sekshanbe.Text, txt_1819sekshanbe.Text,
                                          have1314(), have1415(),
                                          have1516(), have1617(),
                                          have1718(), have1819());


                    // نوشتن نتایج
                    file.WriteLine($"{last3}&{oy2}&{next3}\\\\");
                    file.WriteLine("\\hline");

                    //-------------------------------------------------------------------------------------------------------------------------
                    file.WriteLine("\\cellcolor{gray!15!white}{\\nbf{چهارشنبه}}&");


                    string last4 = field2(txt_810charkshanbe, txt_1012charkshanbe,
                                          txt_89charkshanbe.Text, txt_910charkshanbe.Text,
                                          txt_1011charkshanbe.Text, txt_1112charkshanbe.Text,
                                          have89(), have910(),
                                          have1011(), have1112());

                    // lunch time | |
                    string oq2 = "\\cellcolor{gray!15!white}";
                    // چهارشنبه 13 تا 15

                    string next4 = field3(txt_1315charkshanbe, txt_1517charkshanbe, txt_1719charkshanbe,
                                          txt_1314charkshanbe.Text, txt_1415charkshanbe.Text,
                                          txt_1516charkshanbe.Text, txt_1617charkshanbe.Text,
                                          txt_1718charkshanbe.Text, txt_1819charkshanbe.Text,
                                          have1314(), have1415(),
                                          have1516(), have1617(),
                                          have1718(), have1819());

                    // نوشتن نتایج
                    file.WriteLine($"{last4} & {oq2} & {next4}\\\\");

                    //file.WriteLine("\\noalign{‎\\hrule ‎height 2pt‎}‎"); //--------------------------------------------------------------------------->
                    file.WriteLine("\\hlineB{5}");

                    file.WriteLine("\\end{tabular}");
                    file.WriteLine("\\end{center}");
                    file.WriteLine("\\end{table}");
                    file.WriteLine("%---------------------------- end table code");


                    file.WriteLine("\\vspace{0.0001mm}");
                    file.WriteLine("\\begin{flushright}");
                    file.WriteLine("\\hspace{1.5cm}\\Large{امضاء عضو هیأت علمی}\\hspace{1.5cm}\\Large{امضاء مدیر گروه}\\hspace{1.5cm}\\Large{امضاء رئیس دانشگده}\\hspace{1.5cm}\\Large{امضاء معاون آموزشی پژوهشی}");
                    file.WriteLine("\\end{flushright}");


                    file.Write("\\end{document}");
                    file.Close();



                    // -------------------------------------------------------------------------------------
                    // -------------------------------------------------------------------------------------
                    // -------------------------------------------------------------------------------------

                    StreamWriter file2 = new StreamWriter(path + "\\mainWithoutFooter.tex");

                    file2.WriteLine("\\documentclass[12pt,a4paper]{article}");
                    file2.WriteLine("\\usepackage{mathrsfs,amsmath,amssymb,amsthm}");
                    file2.WriteLine("\\usepackage[table]{xcolor}");
                    file2.WriteLine("\\usepackage{multicol}");
                    file2.WriteLine("\\usepackage[paperwidth=28cm,paperheight=22cm,top=2cm,right=2cm,bottom=0.1mm,left=2cm]{geometry}");
                    file2.WriteLine("\\usepackage{boldline}");
                    file2.WriteLine("\\usepackage{tikz}");
                    file2.WriteLine("\\usetikzlibrary{calc}");
                    file2.WriteLine("\\usepackage{eso-pic}");

                    file2.WriteLine("\\usepackage{array}");

                    file2.WriteLine("\\usepackage{makecell}");
                    file2.WriteLine("\\renewcommand\\theadalign{bc}");
                    file2.WriteLine("\\renewcommand\\theadfont{\\bfseries}");
                    file2.WriteLine("\\renewcommand\\theadgape{\\Gape[4pt]}");
                    file2.WriteLine("\\renewcommand\\cellgape{\\Gape[4pt]}");

                    file2.WriteLine("\\newcolumntype{C}[1]{>{\\centering\\arraybackslash}p{#1}}");
                    file2.WriteLine("\\newcolumntype{P}[1]{%");
                    file2.WriteLine(">{\\vbox to 4ex\\bgroup\\vfill\\centering\\arraybackslash}%");
                    file2.WriteLine("m{#1}%");
                    file2.WriteLine("<{\\vskip-\\baselineskip\\vfill\\egroup}}");
                    file2.WriteLine("\\newcolumntype{\'}{!{\\vrule width 2pt}}");



                    file2.WriteLine("\\usepackage{xepersian}");
                    file2.WriteLine("\\settextfont[Scale=1]{font.ttf}");
                    file2.WriteLine("\\defpersianfont\\nbf[Scale=1]{fontB.ttf}");

                    //----Def
                    //file2.WriteLine("\\makeatletter");
                    //file2.WriteLine("\\def\\thickhline{%");
                    //file2.WriteLine("\\noalign{\\ifnum0=`}\\fi\\hrule\\@height\\thickarrayrulewidth\\futurelet");
                    //file2.WriteLine("\\reserved@a\\@xthickhline}");
                    //file2.WriteLine("\\def\\@xthickhline{\\ifx\\reserved@a\\thickhline");
                    //file2.WriteLine("\\vskip\\doublerulesep");
                    //file2.WriteLine("\\vskip-\\thickarrayrulewidth");
                    //file2.WriteLine("\\fi");
                    //file2.WriteLine("\\ifnum0=`{\\fi}}");
                    //file2.WriteLine("\\makeatother");
                    //file2.WriteLine("\\newlength{\\thickarrayrulewidth}");
                    //file2.WriteLine("\\setlength{\\thickarrayrulewidth}{6\\arrayrulewidth}");

                    file2.WriteLine("\\begin{document}");

                    //%------ Set Border
                    file2.WriteLine("\\AddToShipoutPictureBG{%");
                    file2.WriteLine("\\begin{tikzpicture}[overlay,remember picture]");
                    file2.WriteLine("\\draw[line width=3pt]");
                    file2.WriteLine("($ (current page.north west) + (0.5cm,-0.5cm) $)");
                    file2.WriteLine("rectangle");
                    file2.WriteLine("($ (current page.south east) + (-0.5cm,0.5cm) $);");
                    file2.WriteLine("\\draw[line width=1.5pt]");
                    file2.WriteLine("($ (current page.north west) + (0.8cm,-0.8cm) $)");
                    file2.WriteLine("rectangle");
                    file2.WriteLine("($ (current page.south east) + (-0.8cm,0.8cm) $);");
                    file2.WriteLine("\\end{tikzpicture}}");




                    file2.WriteLine("\\begin{center}");

                    file2.WriteLine("\\huge{برنامه هفتگی اعضای هیأت علمی در نیمسال " + txt_nimsal.Text + " " + (y + 1).ToString() + "-" + (y).ToString() + "}");
                    file2.WriteLine("\\end{center}");

                    file2.WriteLine("\\vspace{0.5cm}");
                    file2.WriteLine("\\begin{flushright}");
                    file2.WriteLine("\\hspace{2.7cm}\\Large{نام و نام خانوادگی: " + txt_teacherfname.Text + " " + txt_teacherlname.Text + "}\\hspace{4cm}\\Large{رشته و گرایش: " + txt_field.Text + " - " + txt_field2.Text + "}");
                    file2.WriteLine("\\end{flushright}");

                    file2.WriteLine("%---------------------------- Start Table Code");

                    file2.WriteLine("\\begin{table}[!ht]");
                    file2.WriteLine("\\footnotesize");

                    file2.WriteLine("\\renewcommand{\\arraystretch}{3}");
                    // DEFINE SIZE COLUMNS

                    file2.WriteLine("\\begin{center}");
                    file2.WriteLine("\\begin{tabular}{" + res + "}");

                    //file2.WriteLine("\\noalign{‎\\hrule ‎height 2pt‎}‎"); //-------------------------------------------------------->
                    file2.WriteLine("\\hlineB{5}");

                    // CREATE TITLE (HOURS) FOR ROWS
                    file2.WriteLine("\\cellcolor{gray!15!white}{ایام هفته}&");
                    //8 - 10
                    if (have89() || have910())
                    {
                        file2.WriteLine("\\cellcolor{gray!15!white}{\\nbf{9-8}}&");
                        file2.WriteLine("\\cellcolor{gray!15!white}{\\nbf{10-9}}&");
                    }
                    else
                        file2.WriteLine("\\cellcolor{gray!15!white}{\\nbf{10-8}}&");
                    //10 - 12
                    if (have1011() || have1112())
                    {
                        file2.WriteLine("\\cellcolor{gray!15!white}{\\nbf{11-10}}&");
                        file2.WriteLine("\\cellcolor{gray!15!white}{\\nbf{12-11}}&");
                    }
                    else
                        file2.WriteLine("\\cellcolor{gray!15!white}{\\nbf{12-10}}&");

                    file2.WriteLine("\\cellcolor{gray!15!white}{}&");

                    //13 - 15
                    if (have1314() || have1415())
                    {
                        file2.WriteLine("\\cellcolor{gray!15!white}{\\nbf{14-13}}&");
                        file2.WriteLine("\\cellcolor{gray!15!white}{\\nbf{15-14}}&");
                    }
                    else
                        file2.WriteLine("\\cellcolor{gray!15!white}{\\nbf{15-13}}&");
                    //15 - 17
                    if (have1516() || have1617())
                    {
                        file2.WriteLine("\\cellcolor{gray!15!white}{\\nbf{16-15}}&");
                        file2.WriteLine("\\cellcolor{gray!15!white}{\\nbf{17-16}}&");
                    }
                    else
                        file2.WriteLine("\\cellcolor{gray!15!white}{\\nbf{17-15}}&");
                    //17 -19
                    if (have1718() || have1819())
                    {
                        file2.WriteLine("\\cellcolor{gray!15!white}{\\nbf{18-17}}&");
                        file2.WriteLine("\\cellcolor{gray!15!white}{\\nbf{19-18}}&");
                    }
                    else
                        file2.WriteLine("\\cellcolor{gray!15!white}{\\nbf{19-17}}\\\\");

                    file2.WriteLine("\\hline");


                    //FILL TABLE
                    //-------------------------------------------------------------------
                    file2.WriteLine("\\cellcolor{gray!15!white}{\\nbf{شنبه}}&");

                    file2.WriteLine($"{last0}&{op2}&{next0}\\\\");
                    file2.WriteLine("\\hline");

                    //----------------------------------------------------------------------------------------------------------------------
                    file2.WriteLine("\\cellcolor{gray!15!white}{\\nbf{یکشنبه}}&");

                    file2.WriteLine($"{last1}&{os2}&{next1}\\\\");
                    file2.WriteLine("\\hline");

                    //------------------------------------------------------------------------------------------------------------------------
                    file2.WriteLine("\\cellcolor{gray!15!white}{\\nbf{دوشنبه}}&");

                    file2.WriteLine($"{last2}&{od2}&{next2}\\\\");
                    file2.WriteLine("\\hline");

                    //--------------------------------------------------------------------------------------------------------------------------
                    file2.WriteLine("\\cellcolor{gray!15!white}{\\nbf{سه شنبه}}&");

                    file2.WriteLine($"{last3}&{oy2}&{next3}\\\\");
                    file2.WriteLine("\\hline");

                    //-------------------------------------------------------------------------------------------------------------------------
                    file2.WriteLine("\\cellcolor{gray!15!white}{\\nbf{چهارشنبه}}&");

                    file2.WriteLine($"{last4} & {oq2} & {next4}\\\\");
                    file2.WriteLine("\\hlineB{5}");

                    file2.WriteLine("\\end{tabular}");
                    file2.WriteLine("\\end{center}");
                    file2.WriteLine("\\end{table}");
                    file2.WriteLine("%---------------------------- end table code");

                    file2.Write("\\end{document}");
                    file2.Close();


                    try
                    {
                        ToZip(path);
                    }
                    catch (Exception)
                    {
                        //MessageBox.Show("ffsd", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Console.WriteLine("Source path does not exist!");
                    }



                    formcode fcode = new formcode(this, path);
                    fcode.Show();


                }
                catch (Exception)
                {
                    MessageBox.Show("خطایی رخ داده. لطفا مجددا تلاش کتید و در صورت تکرار برنامه را دوباره راه اندازی کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btn_address.Focus();
                }


            }
        }

        public void ToZip(string dir)
        {
            string parent = Path.GetDirectoryName(dir);
            string name = Path.GetFileName(dir);
            string fileName = Path.Combine(parent, name + ".zip");
            ZipFile.CreateFromDirectory(dir, fileName, CompressionLevel.Fastest, true);
        }
        public string get_path()
        {
            return txt_address.Text;
        }



        private void ButtomMouseMove(object sender, MouseEventArgs e)
        {
            ((Button)sender).ForeColor = Color.White;
            ((Button)sender).BackColor = Color.RoyalBlue;
            ((Button)sender).FlatAppearance.BorderColor = Color.White;
        }

        private void ButtomMouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).ForeColor = Color.RoyalBlue;
            ((Button)sender).BackColor = Color.White;
            ((Button)sender).FlatAppearance.BorderColor = Color.RoyalBlue;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult x = MessageBox.Show("آیا مطمئن هستید که خارج می‌شوید؟", "خروج", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (x == DialogResult.Yes)
                Application.Exit();
        }


        private void lbl_1617_Click(object sender, EventArgs e)
        {

        }

        private void btn_address_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            string fn = folderBrowserDialog1.SelectedPath;
            txt_address.Text = fn;
            this.Text = "Create Latex Table | " + fn;
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formadd fadd = new formadd(this);
            fadd.Show(this);
        }

        private void پاککردنToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_cleartable_Click(null, null);
        }

        private void addresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_address_Click(null, null);
        }

        private void doneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_createtable_Click(null, null);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1_Click(null, null);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        //----------------------------------------------------------------------------------------------
        //----------------------------------------------------------------------------------------------

        public DataTable ReadExcel(string fileName, string fileExt)
        {
            string conn = string.Empty;
            DataTable dtexcel = new DataTable();
            if (fileExt.CompareTo(".xls") == 0)
                conn = @"provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + fileName + ";Extended Properties='Excel 8.0;HRD=Yes;IMEX=1';";
            else
                conn = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + fileName + ";Extended Properties='Excel 12.0;HDR=NO';";
            using (OleDbConnection con = new OleDbConnection(conn))
            {
                try
                {
                    OleDbDataAdapter oleAdpt = new OleDbDataAdapter("select * from [برنامه هفتگی$]", con);
                    oleAdpt.Fill(dtexcel);
                }
                catch { }
            }
            return dtexcel;
        }


        private void btn_fillTableByCourse_Click(object sender, EventArgs e)
        {
            string filePath = string.Empty;
            string fileExt = string.Empty;
            //OpenFileDialog file = new OpenFileDialog();
            if (true/*file.ShowDialog() == System.Windows.Forms.DialogResult.OK*/)
            {
                //filePath = file.FileName;
                //filePath = @"C:\992-v7Last.xlsx";



                string InstallDir = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Windows);
                InstallDir += "\\LatexTableProgram";

                string[] files = System.IO.Directory.GetFiles(InstallDir, "*.xlsx");

                filePath = files[0];

                fileExt = Path.GetExtension(filePath);
                if (fileExt.CompareTo(".xls") == 0 || fileExt.CompareTo(".xlsx") == 0)
                {
                    try
                    {
                        DataTable dtExcel = new DataTable();
                        dtExcel = ReadExcel(filePath, fileExt);
                        //----------------------------------------------------------PreProccess
                        string st = "شنبه";
                        for (int i = 2; i < dtExcel.Rows.Count - 1; i++)
                        {
                            if (dtExcel.Rows[i][0].ToString() == "یکشنبه")
                            {
                                st = "یکشنبه";
                            }
                            else if (dtExcel.Rows[i][0].ToString() == "دوشنبه")
                            {
                                st = "دوشنبه";
                            }
                            else if (dtExcel.Rows[i][0].ToString() == "سه شنبه")
                            {
                                st = "سه شنبه";
                            }
                            else if (dtExcel.Rows[i][0].ToString() == "چهارشنبه")
                            {
                                st = "چهارشنبه";
                            }
                            dtExcel.Rows[i][0] = st;
                        }


                        Regex r = new Regex(@"^(.{2})(.+)\((.*)\)");
                        List<string> arr = new List<string>();

                        for (int i = 2; i < dtExcel.Rows.Count; i++)
                            for (int j = 1; j < dtExcel.Columns.Count; j++)
                            {
                                Match m = r.Match(dtExcel.Rows[i][j].ToString());
                                if (m.Groups[3].ToString() == txt_teacherlname.Text)
                                    arr.Add(dtExcel.Rows[i][0] + "_" + dtExcel.Rows[1][j] + "_" + m.Groups[2]);
                            }

                        if (arr.Count == 0)
                        {
                            MessageBox.Show("نام شما یافت نشد، لطفا دوباره امتحان کنید",
                                            "خطا",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Asterisk);
                        }

                        for (int i = 0; i < arr.Count; i++)
                        {
                            setCourse(arr[i].ToString().Split('_')[0],
                                      arr[i].ToString().Split('_')[1],
                                      arr[i].ToString().Split('_')[2]);

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                    }
                }
                else
                {
                    MessageBox.Show("Please choose .xls or .xlsx file only.",
                                    "Warning",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }


        }

        public void setFeture(TextBox tx, string course)
        {
            tx.Text = course.Replace("\u200C", " ");
            //tx.Enabled = false;
            tx.ScrollBars = ScrollBars.Horizontal;
        }

        public void setCourse(string day, string clock, string course)
        {
            switch (day)
            {
                case "شنبه":
                    if (clock == "۸-۱۰")
                        setFeture(txt_810shanbe, course);
                    else if (clock == "۱۰-۱۲")
                        setFeture(txt_1012shanbe, course);
                    else if (clock == "۱۳-۱۵")
                        setFeture(txt_1315shanbe, course);
                    else if (clock == "۱۵-۱۷")
                        setFeture(txt_1517shanbe, course);
                    else if (clock == "۱۷-۱۹")
                        setFeture(txt_1719shanbe, course);
                    break;
                case "یکشنبه":
                    if (clock == "۸-۱۰")
                        setFeture(txt_810yekshanbe, course);
                    else if (clock == "۱۰-۱۲")
                        setFeture(txt_1012yekshanbe, course);
                    else if (clock == "۱۳-۱۵")
                        setFeture(txt_1315yekshanbe, course);
                    else if (clock == "۱۵-۱۷")
                        setFeture(txt_1517yekshanbe, course);
                    else if (clock == "۱۷-۱۹")
                        setFeture(txt_1719yekshanbe, course);
                    break;
                case "دوشنبه":
                    if (clock == "۸-۱۰")
                        setFeture(txt_810dokshanbe, course);
                    else if (clock == "۱۰-۱۲")
                        setFeture(txt_1012dokshanbe, course);
                    else if (clock == "۱۳-۱۵")
                        setFeture(txt_1315dokshanbe, course);

                    else if (clock == "۱۵-۱۷")
                        setFeture(txt_1517dokshanbe, course);
                    else if (clock == "۱۷-۱۹")
                        setFeture(txt_1719dokshanbe, course);
                    break;
                case "سه شنبه":
                    if (clock == "۸-۱۰")
                        setFeture(txt_810sekshanbe, course);
                    else if (clock == "۱۰-۱۲")
                        setFeture(txt_1012sekshanbe, course);
                    else if (clock == "۱۳-۱۵")
                        setFeture(txt_1315sekshanbe, course);

                    else if (clock == "۱۵-۱۷")
                        setFeture(txt_1517sekshanbe, course);
                    else if (clock == "۱۷-۱۹")
                        setFeture(txt_1719sekshanbe, course);
                    break;
                case "چهارشنبه":
                    if (clock == "۸-۱۰")
                        setFeture(txt_810charkshanbe, course);
                    else if (clock == "۱۰-۱۲")
                        setFeture(txt_1012charkshanbe, course);
                    else if (clock == "۱۳-۱۵")
                        setFeture(txt_1315charkshanbe, course);

                    else if (clock == "۱۵-۱۷")
                        setFeture(txt_1517charkshanbe, course);
                    else if (clock == "۱۷-۱۹")
                        setFeture(txt_1719charkshanbe, course);
                    break;
                default:
                    break;
            }
        }

        private void txt_teacherfname_TextChanged(object sender, EventArgs e)
        {




        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void radio_first_CheckedChanged(object sender, EventArgs e)
        {
            txt_nimsal.Text = radio_first.Text;
        }

        private void radio_sec_CheckedChanged(object sender, EventArgs e)
        {
            txt_nimsal.Text = radio_sec.Text;
        }

        private void اکسلToolStripMenuItem_Click(object sender, EventArgs e)
        {

            string filePath = string.Empty;
            string fileExt = string.Empty;
            OpenFileDialog file = new OpenFileDialog();
            if (file.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                filePath = file.FileName;
                fileExt = nameof(filePath);
            }

            string InstallDir = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Windows);
            InstallDir += "\\LatexTableProgram";

            try
            {
                string[] oldfile = System.IO.Directory.GetFiles(InstallDir, "*.xlsx");
                if (oldfile.Length > 0)
                    System.IO.File.Delete(oldfile[0]);

                string fileNameWithoutExt = Path.GetFileNameWithoutExtension(filePath);
                System.IO.File.Copy(filePath, System.IO.Path.Combine(InstallDir, fileNameWithoutExt + ".xlsx"), true);
            }
            catch (Exception)
            {
                MessageBox.Show("لطفا برنامه را ببندید و با حالت ادمین وارد شوید",
                    "خطای دسترسی",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            

            //txt_1012shanbe.Text = filePath;


        }
    }
}
