using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Markup;
using HtmlAgilityPack;

namespace LoginScreen.UC
{
    public partial class UC_CURRENCY : UserControl
    {
        string s1 = "0";
        string[] s2 = new string[10000000];
        public static List<string> data = new List<string>();
        public static List<string> data1 = new List<string>();
        public static List<string> data2 = new List<string>();
        public static List<List<string>> currency = new List<List<string>>();


        public UC_CURRENCY()
        {
            InitializeComponent();
            cb_1.SelectedIndex = 10;
            cb_2.SelectedIndex = 28;
            cb_3.SelectedIndex = 11;
            cb_4.SelectedIndex = 12;

            txtbox_1.ForeColor = Color.Red;
            txtbox_2.ForeColor = Color.Red;
            txtbox_3.ForeColor = Color.Green;
            txtbox_4.ForeColor = Color.Red;



        }
        private void UC_CURRENCY_Load(object sender, EventArgs e)
        {


            update_label.Text = "Last updated " + DateTime.Today.ToString("MMM dd yyyy");
            rate_label.Hide();
            rate_label.Text = "Currency Rate is: ";
            ex_ini_cbbox.SelectedIndex = 10;
            ex_fin_cbbox.SelectedIndex = 23;
            ex_ini_amount_txtbox.Text = "1" + " " + ex_ini_cbbox.SelectedItem.ToString();

            var html = @"https://www.bnr.ro/curs_mobil.aspx";

            HtmlWeb web = new HtmlWeb();

            var htmlDoc = web.Load(html);

            var node = htmlDoc.DocumentNode.SelectNodes("//table");


            if (node != null)
            {
                foreach (var content in node)
                {

                    s1 = content.InnerText.ToString();
                }

                s2 = Regex.Split(s1, " ");

                for (int i = 1; i < 30; i++)
                {
                    if (i == 24)
                    {
                        data.Add("RON");
                        data1.Add("1.0000");
                        data2.Add("0.000000");
                    }
                    //RON  1.0000  0.000000

                    if (s2[i].Length > 17) s2[i] = s2[i].Remove(s2[i].Length - 2);
                    if (s2[i].Length == 16) s2[i] += '0';
                    Console.WriteLine(s2[i].Length + " ");
                    data.Add(s2[i].Substring(0, 3));
                    data1.Add(s2[i].Substring(3, 6));
                    data2.Add(s2[i].Substring(s2[i].Length - 8));
                }
                currency.Add(data);
                currency.Add(data1);
                currency.Add(data2);

            }
           
            ex_fin_amount_txtbox.Text = (1 * Convert.ToDouble(data1[10])).ToString() + " " + "RON";


            txtbox_1.Text = data2[cb_1.SelectedIndex].ToString() + " %";
            txtbox_2.Text = data2[cb_2.SelectedIndex].ToString() + " %";
            txtbox_3.Text = data2[cb_3.SelectedIndex].ToString() + " %";
            txtbox_4.Text = data2[cb_4.SelectedIndex].ToString() + " %";

            textbox1.Text = data1[cb_1.SelectedIndex].ToString() + " " + "RON";
            textbox2.Text = data1[cb_2.SelectedIndex].ToString() + " " + "RON";
            textbox3.Text = data1[cb_3.SelectedIndex].ToString() + " " + "RON";
            textbox4.Text = data1[cb_4.SelectedIndex].ToString() + " " + "RON";
            
            if (data2[cb_1.SelectedIndex][0].ToString() == "+" || data2[cb_1.SelectedIndex][0].ToString() == "0" || data2[cb_1.SelectedIndex][0].ToString() == " ")
            {
                txtbox_1.ForeColor = Color.Green;
            }
            else if (data2[cb_1.SelectedIndex][0].ToString() == "-")
            {

                txtbox_1.ForeColor = Color.Red;
            }

            if (data2[cb_2.SelectedIndex][0].ToString() == "+" || data2[cb_2.SelectedIndex][0].ToString() == "0" || data2[cb_2.SelectedIndex][0].ToString() == " ")
            {
                txtbox_2.ForeColor = Color.Green;
            }
            else if (data2[cb_2.SelectedIndex][0].ToString() == "-")
            {

                txtbox_2.ForeColor = Color.Red;
            }

            if (data2[cb_3.SelectedIndex][0].ToString() == "+" || data2[cb_3.SelectedIndex][0].ToString() == "0" || data2[cb_3.SelectedIndex][0].ToString() == " ")
            {
                txtbox_3.ForeColor = Color.Green;
            }
            else if (data2[cb_3.SelectedIndex][0].ToString() == "-")
            {

                txtbox_3.ForeColor = Color.Red;
            }

            if (data2[cb_4.SelectedIndex][0].ToString() == "+" || data2[cb_4.SelectedIndex][0].ToString() == "0" || data2[cb_4.SelectedIndex][0].ToString() == " ")
            {
                txtbox_4.ForeColor = Color.Green;
            }
            else if (data2[cb_4.SelectedIndex][0].ToString() == "-")
            {

                txtbox_4.ForeColor = Color.Red;
            }


        }


        double ini_amount, fin_amount, ex_rate;
        double ex_rate_ini, ex_rate_fin;

        private void switch_button_Click(object sender, EventArgs e)
        {
            int aux;
            ex_ini_amount_txtbox.Text = ex_fin_amount_txtbox.Text.ToString() + " " + ex_fin_cbbox.SelectedItem.ToString();
            ex_fin_amount_txtbox.Text = ex_ini_amount_txtbox.Text.ToString() + " " + ex_ini_cbbox.SelectedItem.ToString();
            aux = ex_fin_cbbox.SelectedIndex;
            ex_fin_cbbox.SelectedIndex = ex_ini_cbbox.SelectedIndex;
            ex_ini_cbbox.SelectedIndex = aux;
        }

        string aux;
        private void cb_1_SelectedIndexChanged(object sender, EventArgs e)
        {

            txtbox_1.Text = data2[cb_1.SelectedIndex].ToString() + " %";
            aux = data2[cb_1.SelectedIndex][0].ToString();

            if (aux == "-")
                txtbox_1.ForeColor = Color.Red;
            else
                if (aux == "+" || aux == "0" || aux == " ")
                txtbox_1.ForeColor = Color.Green;
            textbox1.Text = data1[cb_1.SelectedIndex].ToString() + " " + "RON";

        }

        private void cb_2_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtbox_2.Text = data2[cb_2.SelectedIndex].ToString() + " %";
            aux = data2[cb_2.SelectedIndex][0].ToString();

            if (aux == "-")
                txtbox_2.ForeColor = Color.Red;
            else
                if (aux == "+" || aux == "0" || aux == " ")
                txtbox_2.ForeColor = Color.Green;
            textbox2.Text = data1[cb_2.SelectedIndex].ToString() + " " + "RON";

        }

        private void cb_3_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtbox_3.Text = data2[cb_3.SelectedIndex].ToString() + " %";
            aux = data2[cb_3.SelectedIndex][0].ToString();

            if (aux == "-")
                txtbox_3.ForeColor = Color.Red;
            else
                if (aux == "+" || aux == "0" || aux == " ")
                txtbox_3.ForeColor = Color.Green;
            textbox3.Text = data1[cb_3.SelectedIndex].ToString() + " " + "RON";

        }

        private void cb_4_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtbox_4.Text = data2[cb_4.SelectedIndex].ToString() + " %";
            aux = data2[cb_4.SelectedIndex][0].ToString();

            if (aux == "-")
                txtbox_4.ForeColor = Color.Red;
            else
                if (aux == "+" || aux == "0" || aux == " ")
                txtbox_4.ForeColor = Color.Green;
            textbox4.Text = data1[cb_4.SelectedIndex].ToString() + " " + "RON";
        }

        private void ex_ini_amount_txtbox_Click(object sender, EventArgs e)
        {
            ex_ini_amount_txtbox.Text = " ";
        }

        private void ex_fin_cbbox_SelectedIndexChanged(object sender, EventArgs e)
        {

            ex_fin_amount_txtbox.Text = '1' + " " + ex_fin_cbbox.SelectedItem.ToString();


        }

        private void ex_ini_cbbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ex_ini_cbbox.SelectedIndex == 12 || ex_ini_cbbox.SelectedIndex == 14 || ex_ini_cbbox.SelectedIndex == 15)
            {
                ex_ini_amount_txtbox.Text = "100" + " " + ex_ini_cbbox.SelectedItem.ToString();
            }
            else
            {
                ex_ini_amount_txtbox.Text = '1' + " " + ex_ini_cbbox.SelectedItem.ToString();
            }

        }

        private void ex_button_Click(object sender, EventArgs e)
        {
            try {
                if (ex_fin_cbbox.SelectedIndex == 23)
                {
                    rate_label.Show();

                    ini_amount = Convert.ToDouble(ex_ini_amount_txtbox.Text.ToString().Split()[0]);
                    ex_rate = Convert.ToDouble(data1[ex_ini_cbbox.SelectedIndex]);

                    if (ex_ini_cbbox.SelectedIndex == 12 || ex_ini_cbbox.SelectedIndex == 14 || ex_ini_cbbox.SelectedIndex == 15)
                    {
                        ex_rate = ex_rate / 100;
                    }

                    rate_label.Text = "Currency Rate: 1 " + ex_ini_cbbox.SelectedItem.ToString() + " = " + ex_rate.ToString() + " " + ex_fin_cbbox.SelectedItem.ToString();



                    fin_amount = ini_amount * ex_rate;
                    fin_amount = ((double)((int)(fin_amount * 100.0))) / 100.0;
                    ex_fin_amount_txtbox.Text = fin_amount.ToString() + " " + ex_fin_cbbox.SelectedItem.ToString();
                    ex_ini_amount_txtbox.Text = ini_amount.ToString() + " " + ex_ini_cbbox.SelectedItem.ToString();
                }
                else
                {
                    rate_label.Show();

                    ini_amount = Convert.ToDouble(ex_ini_amount_txtbox.Text.ToString().Split()[0]);
                    ex_ini_amount_txtbox.Text = ini_amount.ToString() + " " + ex_ini_cbbox.SelectedItem.ToString();


                    ex_rate_ini = Convert.ToDouble(data1[ex_ini_cbbox.SelectedIndex]);
                    ex_rate_fin = Convert.ToDouble(data1[ex_fin_cbbox.SelectedIndex]);

                    ex_rate = ex_rate_ini / ex_rate_fin;

                    if (ex_ini_cbbox.SelectedIndex == 12 || ex_ini_cbbox.SelectedIndex == 14 || ex_ini_cbbox.SelectedIndex == 15)
                    {
                        ex_rate = ex_rate / 100;
                    }

                    fin_amount = ini_amount * ex_rate;
                    fin_amount = ((double)((int)(fin_amount * 100.0))) / 100.0;
                    rate_label.Text = "Currency Rate: 1 " + ex_ini_cbbox.SelectedItem.ToString() + " = " + (((double)((int)(ex_rate * 100000.0))) / 100000.0).ToString() + " " + ex_fin_cbbox.SelectedItem.ToString(); ;
                    //currency_textbox.AppendText(Environment.NewLine + ex_rate_ini.ToString() + Environment.NewLine + ex_rate_fin.ToString() + Environment.NewLine + fin_amount.ToString());

                    ex_fin_amount_txtbox.Text = fin_amount.ToString() + " " + ex_fin_cbbox.SelectedItem.ToString();
                }


            }catch (Exception ex)
            {                
                MessageBox.Show(ex.Message);                                                       // In case of an error, we catch it in try catch
            }
        }
    }
}

