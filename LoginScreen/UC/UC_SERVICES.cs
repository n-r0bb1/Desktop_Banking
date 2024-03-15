using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginScreen.UC
{
    public partial class UC_SERVICES : UserControl
    {
        public UC_SERVICES()
        {
            InitializeComponent();
            price_box.BackColor = Color.White;

            ///-------------------///
            ///   Values Set-Up   ///
            ///-------------------///


            //deposit_box.Text = deposit.ToString();
            //price_box.Text = price.ToString();

            term_box.Text = term.ToString();
            ir_box.Text = interest.ToString();
            term_box.SelectedIndex = term;
            nr = deposit / price * 100;
            deposit_box.Hint = "Deposit " + '(' + nr.ToString() + '%' + ')';
        }

        int term = 24, mp_int = 0;
        double price = 0, deposit = 0, interest = 3, monthlypayment = 0, v, d, p, nr = 0;
        bool deposit_verify = false;

        int count, count1, count2;
        private void UC_SERVICES_Load(object sender, EventArgs e)
        {
            int poz = 1; 
            Random rnd = new Random();
            count = rnd.Next(3);
            count1 = rnd.Next(3);
            count2 = rnd.Next(3);
           
            com_3.Image = Image.FromFile(Application.StartupPath + @"\Reclame\Reclame1\" + count + ".png");
            com_2.Image = Image.FromFile(Application.StartupPath + @"\Reclame\Reclame2\" + count1 + ".png");
            com_1.Image = Image.FromFile(Application.StartupPath + @"\Reclame\Reclame3\" + count2 + ".png");
            


            deposit_box.Hint = "Deposit (0%)";
            ini_deposit_txtbox.Hint = "Initial Deposit Value (RON)";
            final_deposit_txtbox1.Hint = "Deposit Value Capitalised (RON)";
            intere_rate_txtbox.Hint = "Interest Rate (%)";
            interest_time_cbox.Hint = "Deposit Time";

            intere_rate_txtbox.Text = rates[interest_time_cbox.SelectedIndex].ToString() + " %";
        }

        double deposit_1, fin_deposit;
        double day_rate, rate, aux_rate;
        double[] rates = { 6.50, 7, 7.25, 8.50 };
        int[] time = { 3, 6, 12, 36 };

        private void interest_time_cbox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            intere_rate_txtbox.Text = rates[interest_time_cbox.SelectedIndex].ToString() + " %";
        }



        private void deposit_button_Click(object sender, EventArgs e)
        {
            try
            {
                deposit = Convert.ToInt32(ini_deposit_txtbox.Text);

                fin_deposit = (((day_rate / 100) * deposit) * 30) * time[interest_time_cbox.SelectedIndex];
                final_deposit_txtbox1.Text = (deposit + ((deposit * (time[interest_time_cbox.SelectedIndex] * 30) * rates[interest_time_cbox.SelectedIndex]) / (360 * 100))).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Initial Depoist has to be greater than 0 ");
            }
        }

        /////////////////////////COMERCIALS FUNCTION///////////////////////////////
        string[] links = { "https://www.bancatransilvania.ro/","https://www.trading212.com/" ,"https://www.coinbase.com/" , "https://www.xtb.com/int", "https://finance.yahoo.com/", "https://www.zoopla.co.uk/", "https://www.plus500.com/en-RO/", "https://www.revolut.com/", "https://www.etoro.com/" };
        private void com_1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(links[count]);
        }
        
        private void com_2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(links[count1 + 3]);
        }
        
        private void com_3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(links[count2 + 6]);
        }

        ////////////////////////////////////////////////////////

        public void deposit_Hint_percentage(double price, double deposit)
        {
            if (price == 0 || deposit_box.Text == "" || price_box.Text == "")
            {
                deposit_box.Hint = "Deposit (0%)";
                deposit_verify = true;
            }
            else
            {
                nr = deposit / price * 100;
                deposit_box.Hint = "Deposit " + '(' + nr.ToString("0.#") + '%' + ')';
            }

        }

        string link = "https://www.revolut.com/";
        private void button1_Click(object sender, EventArgs e)
        {
            
            System.Diagnostics.Process.Start(link);
        }

        private void term_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            term = term_box.SelectedIndex + 1;
            MortgageCalculator();
        }


        ///-------------------///
        ///  Price Box Set-Up ///
        ///-------------------///

        private void price_box_TextChanged(object sender, EventArgs e)
        {
            if (price_box.Text.Length != 0)
            {
                deposit_Hint_percentage(price, deposit);
                if (double.TryParse(price_box.Text, out p))
                {
                    //p = Double.Parse(price_box.Text);
                    if (p <= 0)
                    {
                        price = 0;
                        //price_box.Text = "0";
                        //MortgageCalculator();

                    }
                    else
                    {

                        price = Double.Parse(price_box.Text);
                        MortgageCalculator();

                    }
                }
                else
                {
                    price = 0;
                    price_box.Text = "";
                }
            }

        }


        private void price_box_Leave(object sender, EventArgs e)
        {
            deposit_Hint_percentage(price, deposit);
            if (price_box.Text.Length == 0)
            {
                price = 0;
                //deposit_Hint_percentage(price, deposit);
                //price_box.Text = "0";                               /// When leaving the (price_box) without ENTERING any value , it automatically ENTERS  0 , as a default value
                MortgageCalculator();
            }
        }

        ///-------------------///
        /// Deposit Box Set-Up ///
        ///-------------------///

        private void deposit_box_TextChanged(object sender, EventArgs e)
        {
            deposit_Hint_percentage(price, deposit);
            if (deposit_box.Text.Length != 0)
            {
                if (double.TryParse(deposit_box.Text, out d))
                {
                    // d = Double.Parse(deposit_box.Text);
                    if (d <= 0)
                    {
                        deposit = 0;
                        //deposit_box.Text = "0";
                        //MortgageCalculator();
                    }
                    else
                    {
                        //deposit_Hint_percentage(price, deposit);
                        deposit = Double.Parse(deposit_box.Text);
                        MortgageCalculator();
                    }
                }
                else
                {
                    deposit = 0;
                    deposit_box.Text = "";
                }
            }

        }


        private void deposit_box_Leave(object sender, EventArgs e)
        {
            deposit_Hint_percentage(price, deposit);
            if (deposit_box.Text.Length == 0)
            {
                deposit = 0;
                //deposit_Hint_percentage(price, deposit);
                //deposit_box.Text = "0";                               /// When leaving the (deposit_box) without ENTERING any value , it automatically ENTERS  0 , as a default value
                MortgageCalculator();
            }

        }


        ///-------------------///
        ///Interest Box Set-Up///
        ///-------------------///
        private void ir_box_TextChanged(object sender, EventArgs e)
        {


            if (ir_box.Text.Length != 0)
            {
                if (double.TryParse(ir_box.Text, out v))
                {
                    // v = Double.Parse(ir_box.Text);
                    if (v <= 0)
                    {
                        interest = 1;
                        interest = interest * 0.01;
                        //ir_box.Text = "0,01";
                        //MortgageCalculator();
                    }
                    else
                    {

                        interest = Double.Parse(ir_box.Text);
                        interest = interest * 0.01;

                        MortgageCalculator();
                    }
                }
                else
                {
                    interest = 0;
                    ir_box.Text = "";
                }
            }
        }

        private void ir_box_Leave(object sender, EventArgs e)
        {
            if (ir_box.Text.Length == 0 || ir_box.Text == "0")
            {
                interest = 1;
                interest = interest * 0.01;                     /// When leaving the (ir_box) without ENTERING any value , it automatically ENTERS  0.01 , as a default value
                ir_box.Text = "0,01";
                MortgageCalculator();
            }
        }



        public void MortgageCalculator()
        {

            //price = Int32.Parse(price_box.Text);
            //deposit = Int32.Parse(deposit_box.Text);
            //term = term_box.SelectedIndex+1;
            //interest = Double.Parse(ir_box.Text);

            try
            {
                monthlypayment = (price - deposit) * ((interest / 12) * Math.Pow(1 + (interest / 12), (int)(term * 12))) / (Math.Pow((1 + (interest / 12)), (int)(term * 12)) - 1);
                mp_int = (int)(monthlypayment);
                deposit_Hint_percentage(price, deposit);
                calc_box.Text = "$" + mp_int.ToString() + " per month";

                //MessageBox.Show(ex.Message.ToString(),"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (mp_int < 0)
                    result_label.Text = String.Format("0");
                else
                    result_label.Text = String.Format(calc_box.Text);
            }
            catch (Exception ex1)
            {
                MessageBox.Show(ex1.Message.ToString(), "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

    }
}
