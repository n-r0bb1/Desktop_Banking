using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Protobuf.WellKnownTypes;
using System.Xml.Linq;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities.Collections;
using static System.Net.Mime.MediaTypeNames;
using Application = System.Windows.Forms.Application;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Runtime.Remoting.Messaging;
using System.Drawing.Text;
using LoginScreen.UC;
using System.Runtime.InteropServices;

namespace LoginScreen
{
    public partial class Form2 : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void title_bar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        private void name_picbox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        //////////////////////////////////////////////////
        
        public static Form2 instance;
        public Form2()
        {
            InitializeComponent();
            

            Connection();                                                                          // Starting Connection
  
            instance = this;                                                                        // Initializing Instance as a TextBox from => Form1                                                              

            dataGridView1.ReadOnly = true;                                                         // Setting DataGridView
            dataGridView1.Columns["id"].Visible  = false;

            transferButton.Enabled = false;                                                        // Setting Transfer Button => Color 
            transferButton.BackColor = Color.FromArgb(193, 204, 214);

          

        }

        public string ID
        {
            get { return textBox4.Text; }
        }


       

        // FORM 2 FUNCTION //
        private void Form2_Load(object sender, EventArgs e)
        {   
            //textBox4.Text =  Form1.instance.UnameBox.Text;  ////////////////DEOMMET THIS LINE & CHANGE PROGRAM CS TO FORM1                                     // TextBox4 = Form1 Instance =>
            showBalance();

            UC_HOME uc = new UC_HOME();
            uc.ID = ID;

            dataGridView1.DefaultCellStyle.BackColor = Color.FromArgb(250, 250, 251);
            label5.Text = "@"+textBox4.Text;

            label7.Text = "Welcome back @" + textBox4.Text;
        }


        static MySqlConnection conn = null;


        // CONNECTION FUNCTION //
        public static void Connection()
        {
            string connStr = "server =127.0.0.1; user = root; database = test; password =";
            try
            {
                conn = new MySqlConnection(connStr);
                conn.Open();                                                                       // Opening the Connection using server information string => "connStr"
                //MessageBox.Show("SUCCESSFUL");    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);                                                       // In case of an error, we catch it in try catch
            }
            finally
            {
                conn.Close();                                                                      // Finally continues the procces without breaking  
            }
        }



        // SHOWING BALANCE FUNCTION //
        public void showBalance()
        {
            string Uname = textBox4.Text;                                                          // Initializing Variables
            string Umoney = moneyBox.Text;
            string Utransfer;


            try
            {
                MySqlCommand mySqlCommand = new MySqlCommand("select * from test where username = '" + Uname + "'", conn);
                conn.Open();
                MySqlDataReader Reader = mySqlCommand.ExecuteReader();
                if (Reader.Read())
                {
                                                                                                   // Extracting the amount of money as TRANSFER from ( Uname == UserName ) 
                    Utransfer = Reader["transfer"].ToString();
                    balanceBox.Text = Utransfer + " RON";                                          // Ading Currency symbol RON 

                }
                Reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
            finally
            {
                conn.Close();
            }
        }



        // MONEY TRANSFER FUNCTION //
        private void transferButton_Click(object sender, EventArgs e)
        {
            string Uname = userFindBox.Text;    
            string Uemail;
            string Upass;
            string Umoney = moneyBox.Text;                                                         // Initializing "U" - Type variables 
            string Utransfer;
            string Usend;

            bool userFound = false;                                                                // Initializing Boolean variables 
            bool verifyFunds = true;

            string meEmail;
            string mePass;                                                          
            string meTransfer;                                                                     // Initializing "me" - Type variables    
            string meSend;
            string meUname = textBox4.Text;

            int want_to_send_value = 0;


            if (VerifyFunds() == 0)                                                                // Verify if User has enough funds for a succesfull transfer  
            {
                verifyFunds = false;
            }
            else
            {
                verifyFunds = true;
            }

            try
            {
                MySqlCommand mySqlCommand = new MySqlCommand("select * from test where username = '" + Uname + "'", conn);
                conn.Open();
                MySqlDataReader Reader = mySqlCommand.ExecuteReader();                             // Searching for User => Receiver

                if ((Reader.HasRows == true) && (meUname != Uname))                                // If receiver if diffrent from User's own USERNAME Traansfer is possible
                {
                    userFound = true;
                    
                    if (verifyFunds == false)                                                      // Otherwise is not possible
                    {
                        verify_label.Text = "Inssufficient Funds!";
                        verify_label.ForeColor = Color.Red;                                        // Color changeing to highlight event
                    }
                 
                    else
                    {
                        
                        if (Reader.Read())
                        {
                           Uemail          = Reader["email"].ToString();
                           Upass           = Reader["password"].ToString();                       // Extracting USER'S details (RECEIVER)
                           Utransfer       = Reader["transfer"].ToString();
                           Usend           = Reader["send"].ToString();


                           textBox1.Text   = Uemail;
                           textBox2.Text   = Upass;
                                                                                                   // Calculating User's new funds    
                           Umoney          = (int.Parse(Umoney) + int.Parse(Utransfer)).ToString();      
                           textBox3.Text   = Umoney;

                           balanceBox.Text = (int.Parse(balanceBox.Text.Split()[0]) - int.Parse(moneyBox.Text)).ToString() + " RON";
                           textBox5.Text   = Usend;


                        }
                    }
                    Reader.Close();
                }
                else
                {
                    userFound = false;                                                             // NOP() => if Receiver's Name == User's Name
                }  

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
            finally
            {
                conn.Close();
            }

            // USER INTERFACE //     // FRONT END //


            if (userFound == true)
            {
                if (verifyFunds == false)
                {
                    verify_label.Text = "Inssufficient Funds!";
                    verify_label.ForeColor = Color.Red;
                }
                else
                {

                    // INTRODUCTION IN FUNDS - TABLE FUNCTION //
                    try
                    {                                                                              // Introduction in Funds of Sender, Receiver & Sum for Accept/Decline
                        conn.Open();
                        string insert = "INSERT INTO `funds`(`sender`, `receiver`, `sum`) VALUES(@sender,@receiver,@sum)";
                        MySqlCommand mySqlCommand3 = new MySqlCommand(insert, conn);
                        mySqlCommand3.Parameters.AddWithValue("@sender", textBox4.Text);           // Pending transactions => Likewise BT PAY
                        mySqlCommand3.Parameters.AddWithValue("@receiver", userFindBox.Text);
                        mySqlCommand3.Parameters.AddWithValue("@sum", moneyBox.Text);
                        mySqlCommand3.ExecuteNonQuery();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());

                    }
                    finally
                    {
                        conn.Close();
                    }




                    try
                    {
                        MySqlCommand mySqlCommand = new MySqlCommand("select * from test where username = '" + meUname + "'", conn);
                        conn.Open();
                        MySqlDataReader Reader1 = mySqlCommand.ExecuteReader();


                        if (Reader1.Read())
                        {
                            meEmail = Reader1["email"].ToString();
                            mePass = Reader1["password"].ToString();                               // Extracting meUser (myself) details from TEST table
                            meTransfer = Reader1["transfer"].ToString();
                            meSend = Reader1["send"].ToString();


                            meemailBox.Text = meEmail;
                            mepassBox.Text = mePass;
                            metransferBox.Text = balanceBox.Text.Split()[0];                       // Splitting Sum from Currency ex: "125 RON"
                            mesendBox.Text = meSend;


                        }
                        Reader1.Close();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());

                    }
                    finally
                    {
                        conn.Close();
                    }

                    try
                    {

                        conn.Open();
                        MySqlCommand cmd1 = new MySqlCommand("Update test set username = @username, email = @email, password = @password, transfer = @transfer, send = @send where username = @username", conn);
                        cmd1.Parameters.AddWithValue("@username", meUname);
                        cmd1.Parameters.AddWithValue("@email", meemailBox.Text);
                        cmd1.Parameters.AddWithValue("@password", mepassBox.Text);                 // Update User Interface and Test table 
                        cmd1.Parameters.AddWithValue("@transfer", metransferBox.Text);
                        cmd1.Parameters.AddWithValue("@send", mesendBox.Text);
                        cmd1.ExecuteNonQuery();

                        verify_label.Text = "Money Sent";                                          // "Money Sent" => Label showing that transaction was succesfull
                        verify_label.ForeColor = Color.Green;                                      // Green Color Label 
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                    finally
                    {
                        conn.Close();
                    }

                    /// FUNDS DATA BASE /// at step 1


                }
            }
            else
            {
                verify_label.Text = "This User does not exists!";
                verify_label.ForeColor = Color.Red;
            }

        }

       




        // VERIFY FUNDS FUNCTION //
        private int VerifyFunds()
        {
            string vfTransfer;
            string vfUname = textBox4.Text;
            try
            {
                MySqlCommand mySqlFundsCommand = new MySqlCommand("select * from test where username = '" + vfUname + "'", conn);
                conn.Open();
                MySqlDataReader Reader2 = mySqlFundsCommand.ExecuteReader();


                if (Reader2.Read())
                {
                    vfTransfer = Reader2["transfer"].ToString();                                   // Verify if User (myself) has enough funds to send
                    if (int.Parse(vfTransfer) - int.Parse(moneyBox.Text) < 0)
                        return 0;                                                                  // If NOT return 0;
                }
                
                Reader2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
            finally
            {
                conn.Close();
               
            }
            return 1;                                                                              // If YES return 1;
        }



        // EXIT FUNCTION //
        private void label3_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // DEFAULT DATA FUNCTION //
        private void button2_Click(object sender, EventArgs e)
        {
            userFindBox.Text = "robi";
            moneyBox.Text = "100";
        }

        int minValue, v;



        // TRANSFER ACCEPT/DECLINE //       // BACK END //
        
       


        // REFRESH PENDING TRANSACTIONS FUNCTION //
        private void RefreshButton()
        {       
            string meReceiver = textBox4.Text;                                                     // Initializing Variables
            string transferData;    
            int fundsId;

            try
            {
                conn.Open();
                MySqlCommand mySqlCommand = new MySqlCommand("select * from funds where receiver = '" + meReceiver + "'", conn);
                MySqlDataReader Reader = mySqlCommand.ExecuteReader();                             

                dataGridView1.Rows.Clear();                                                        // Clearing DataGridView
                dataGridView1.Refresh();                                                           // Refresh DataGridView

                while (Reader.Read())                                                              // Extracting data from FUNDS TABLE => DataGridView
                {
                    dataGridView1.Rows.Add(Reader["id"], Reader["sender"], Reader["receiver"], Reader["sum"], "Decline", "Accept");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
            finally
            {
                conn.Close();
            }
        }



        // ACCEPT/DECLINE TRANSACTIONS FUNCTION //
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if(e.ColumnIndex == 4 && e.RowIndex >-1)
            {
                if (dataGridView1 != null)
                {
                    string reUname = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                    string reEmail;
                    string rePass;
                    string reTransfer;
                    string reSend;
                    string reFunds = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                    string reSendSum;

                    int fundsId = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
                
                
                

                // PULLING DETAILS OF SENDER //
                try
                {

                    MySqlCommand mySqlCommand = new MySqlCommand("select * from test where username = '" + reUname + "'", conn);
                    conn.Open();
                    MySqlDataReader Reader1 = mySqlCommand.ExecuteReader();


                    if (Reader1.Read())
                    {
                        reEmail = Reader1["email"].ToString();
                        rePass = Reader1["password"].ToString();                                   // Extracting Sender Information 
                        reTransfer = Reader1["transfer"].ToString();
                        reSend = Reader1["send"].ToString();


                        meemailBox.Text = reEmail;
                        mepassBox.Text = rePass;
                        metransferBox.Text = reTransfer;
                        mesendBox.Text = reSend;
                        reSendSum = (Convert.ToInt32(reFunds) + Convert.ToInt32(metransferBox.Text)).ToString();                  
                        metransferBox.Text = reSendSum;
                    }
                    Reader1.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());

                }
                finally
                {
                    conn.Close();
                }



                // DECLINE PENDING TRANSACTION //
                try
                {


                    conn.Open();
                    MySqlCommand cmd1 = new MySqlCommand("Update test set username = @username, email = @email, password = @password, transfer = @transfer, send = @send where username = @username", conn);
                    cmd1.Parameters.AddWithValue("@username", reUname);
                    cmd1.Parameters.AddWithValue("@email", meemailBox.Text);
                    cmd1.Parameters.AddWithValue("@password", mepassBox.Text);
                    cmd1.Parameters.AddWithValue("@transfer", metransferBox.Text);                 // Return funds to original Sender 
                    cmd1.Parameters.AddWithValue("@send", mesendBox.Text);
                    cmd1.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    conn.Close();
                }
                //RefreshButton();
                //showBalance();



                // DELETE ROWS TRY-CATCH //
                try
                {
                    MySqlCommand fundsCommand = new MySqlCommand("select * from funds where id = '" + fundsId + "'", conn);
                    conn.Open();
                    MySqlDataReader Reader = fundsCommand.ExecuteReader();
                    if (Reader.HasRows == true)
                    {
                        Reader.Close();                                                               
                        fundsCommand = new MySqlCommand("Delete from funds where id = '" + fundsId + "'", conn);                 
                                                                                
                                                                                                   // Delete Row ID from FUNDS TABLE after Decline/Accept 
                    }
                    Reader.Close();
                    fundsCommand.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());

                }
                finally
                {
                    conn.Close();
                }
                RefreshButton();




                }

            }
            else if(e.ColumnIndex == 5 && e.RowIndex >-1)
            {

                string meSendSum     = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                string meSendUser    = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                string meEmail       = meemailBox.Text;
                string mePass        = mepassBox.Text;
                string meTransfer;
                string meSend        = mesendBox.Text;
                string meUname       = textBox4.Text;

                string dataReceiver  = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString(); 
                string dataSender    = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString(); 
                string dataSum       = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString(); 

                int fundsId          = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;


                try
                {
                    
                    MySqlCommand mySqlCommand = new MySqlCommand("select * from test where username = '" + meUname + "'", conn);
                    conn.Open();
                    MySqlDataReader Reader1 = mySqlCommand.ExecuteReader();


                    if (Reader1.Read())
                    {
                        meEmail = Reader1["email"].ToString();
                        mePass = Reader1["password"].ToString();
                        meTransfer = Reader1["transfer"].ToString();
                        meSend = Reader1["send"].ToString();


                        meemailBox.Text = meEmail;
                        mepassBox.Text = mePass;
                        metransferBox.Text = balanceBox.Text.Split()[0];
                        mesendBox.Text = meSend;
                        meSendSum = (Convert.ToInt32(meSendSum) + Convert.ToInt32(metransferBox.Text)).ToString();                  //////////////////////////////////////////// AM RAMAS AICI TREBUIE PUSE DATELE IN TABELELE COREWSPUNZATOARE
                        metransferBox.Text = meSendSum;
                    }
                    Reader1.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());

                }
                finally
                {
                    conn.Close();
                }

                ///////////////////////////////////////////////////////////
                /////////////// ADAUGAREB DATE IN DATA TABLE ///////////////
                ///////////////////////////////////////////////////////////


                try
                {
                    conn.Open();
                    string insert = "INSERT INTO `data`(`sender`, `receiver`, `sum`) VALUES(@sender,@receiver,@sum)";
                    MySqlCommand mySqlCommand3 = new MySqlCommand(insert, conn);
                    mySqlCommand3.Parameters.AddWithValue("@sender", dataSender);
                    mySqlCommand3.Parameters.AddWithValue("@receiver", dataReceiver);
                    mySqlCommand3.Parameters.AddWithValue("@sum", dataSum);
                    mySqlCommand3.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());

                }
                finally
                {
                    conn.Close();
                }




                //////////////////////Stergere date din funds dupa accept/decline ///////////

                //senderBox.Text = meSendSum;
                try
                {
                    MySqlCommand fundsCommand = new MySqlCommand("select * from funds where id = '" + fundsId + "'", conn);
                    conn.Open();
                    MySqlDataReader Reader = fundsCommand.ExecuteReader();
                    if(Reader.HasRows == true)
                    {
                        Reader.Close();
                        fundsCommand = new MySqlCommand("Delete from funds where id = '" + fundsId + "'", conn);
                       
                    }
                    Reader.Close();
                    fundsCommand.ExecuteNonQuery();
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());

                }
                finally
                {
                    conn.Close();
                }




                string Uname     = textBox4.Text;
                string Uemail    = meemailBox.Text;
                string Utransfer = metransferBox.Text;
                string Upass     = mepassBox.Text;
                string Usend     = mesendBox.Text;

                // UPDATED LA DATELE DIN TABELUL TEST - Transfer DUPA ACCEPT/DECLINE //

                try
                {


                    conn.Open();
                    MySqlCommand cmd1 = new MySqlCommand("Update test set username = @username, email = @email, password = @password, transfer = @transfer, send = @send where username = @username", conn);
                    cmd1.Parameters.AddWithValue("@username", Uname);
                    cmd1.Parameters.AddWithValue("@email", Uemail);
                    cmd1.Parameters.AddWithValue("@password", Upass);
                    cmd1.Parameters.AddWithValue("@transfer", Utransfer);
                    cmd1.Parameters.AddWithValue("@send", Usend);
                    cmd1.ExecuteNonQuery();
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    conn.Close();
                }
                RefreshButton();
                showBalance();
            }
        }


        // LOG OUT FUNCTION //
        private void button1_Click(object sender, EventArgs e)
        {

                this.Hide();
                var Form1 = new Form1();
                Form1.Closed += (s, args) => this.Close();
                Form1.Show();

        }


        

        

        private void Refresh_button_Click(object sender, EventArgs e)
        {
            RefreshButton();
        }



        // MINIMUM AMOUNT VERIFY FUNCTION //
        private void moneyBox_TextChanged(object sender, EventArgs e)
        {

            if (moneyBox.Text != "")
            {
                if (int.TryParse(moneyBox.Text, out minValue))
                { 
                        if (minValue < 5)
                        {
                            verify_label.Text = "The minimum amount is 5.00 RON";
                            verify_label.ForeColor = Color.Red;
                            transferButton.Enabled = false;
                            transferButton.BackColor = Color.FromArgb(193, 204, 214);
                        }
                     else
                        {
                            transferButton.BackColor = Color.FromArgb(0, 117, 214);
                            transferButton.Enabled = true;
                            verify_label.Text = "";
                        }
                }
                else
                {
                    minValue = 0;
                    moneyBox.Text = "";
                }
                
             }
             else
            {
                transferButton.Enabled=false;
                verify_label.Text = "";
                transferButton.BackColor = Color.FromArgb(193, 204, 214);
                minValue = 0;
            }
        }

        // ADD USER CONTROL FUNCTION //

        private void addUserControl(UserControl userControl)
        {
            panel2.Visible = true;
            panel2.BringToFront();

            userControl.Dock = DockStyle.Fill;

            panel2.Controls.Clear();                                                               // ADD USER CONTROL FUNCTION
            panel2.Controls.Add(userControl);

            userControl.BringToFront();
        }



        // UC_HOME SELECTED //
        private void button_home_Click(object sender, EventArgs e)
        {

            button_home.BackColor = Color.FromArgb(0, 140, 255);                                   // Selected Button Color
                                      
            button_services.BackColor = Color.FromArgb(0, 117, 214);                               // Not Selected Button Color
            button_stats.BackColor = Color.FromArgb(0, 117, 214);
            button_exchange.BackColor = Color.FromArgb(0, 117, 214);
            button_transactions.BackColor = Color.FromArgb(0, 117, 214);


            UC_HOME uc = new UC_HOME();
            addUserControl(uc);
        }

        // UC_SERVICES SELECTED //
        private void button_services_Click(object sender, EventArgs e)
        {
            button_services.BackColor = Color.FromArgb(0, 140, 255);                               // Selected Button Color

            button_stats.BackColor = Color.FromArgb(0, 117, 214);                                  // Not Selected Button Color
            button_home.BackColor = Color.FromArgb(0, 117, 214);
            button_transactions.BackColor = Color.FromArgb(0, 117, 214);
            button_exchange.BackColor = Color.FromArgb(0, 117, 214);


            UC_SERVICES uc = new UC_SERVICES();
            addUserControl(uc);
        }

        // UC_STATISTICS SELECTED //
        private void button_stats_Click(object sender, EventArgs e)
        {
            button_stats.BackColor  = Color.FromArgb(0, 140, 255);                                  // Selected Button Color

            button_services.BackColor = Color.FromArgb(0, 117, 214);                                // Not Selected Button Color
            button_home.BackColor = Color.FromArgb(0, 117, 214);
            button_transactions.BackColor = Color.FromArgb(0, 117, 214);
            button_exchange.BackColor = Color.FromArgb(0, 117, 214);

            UC_STATISTICS uc = new UC_STATISTICS();
            addUserControl(uc);
        }

        // UC_CURRENCY SELECTED //
        private void button_exchange_Click(object sender, EventArgs e)
        {
              button_exchange.BackColor = Color.FromArgb(0, 140, 255);                                  // Selected Button Color

              button_stats.BackColor = Color.FromArgb(0, 117, 214); ;
              button_services.BackColor = Color.FromArgb(0, 117, 214);                                // Not Selected Button Color
              button_home.BackColor = Color.FromArgb(0, 117, 214);
              button_transactions.BackColor = Color.FromArgb(0, 117, 214);

            UC_CURRENCY uc = new UC_CURRENCY();
            addUserControl(uc);
        }
        //Minimize button
        private void minimize_button_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Exit button
        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void settingsLabel_Click(object sender, EventArgs e)
        {

            UC_SETTINGS uc = new UC_SETTINGS();
            addUserControl(uc);
        }

        private void label8_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Form1 = new Form1();
            Form1.Closed += (s, args) => this.Close();
            Form1.Show();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            userFindBox.Clear();
            moneyBox.Clear();
        }



        // Form2 TRANSACTION PANEL SELECTED
        private void button_transactions_Click(object sender, EventArgs e)
        {

            button_transactions.BackColor = Color.FromArgb(0, 140, 255);                            // Selected Button Color

            button_stats.BackColor = Color.FromArgb(0, 117, 214);                                   // Not Selected Button Color
            button_home.BackColor = Color.FromArgb(0, 117, 214);
            button_services.BackColor = Color.FromArgb(0, 117, 214);
            button_exchange.BackColor = Color.FromArgb(0, 117, 214);

            panel2.Visible = false;
            panel2.SendToBack();

        }

       
           

        ///////////////////////// ultimul proiect /////////////////////////////
        //////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////

    }
}
