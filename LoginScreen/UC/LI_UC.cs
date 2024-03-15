using LoginScreen.Classes;
using MySql.Data.MySqlClient;
using NuGet.Frameworks;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;

namespace LoginScreen.UC
{
    public partial class LI_UC : UserControl
    {
     
        public LI_UC()
        {
            InitializeComponent();
            Connection(label5);                                                                 // Start Connection with tha database 
            txtpass.PasswordChar = '*';
        }


         

        /// Initialize the variables ///
        static MySqlConnection conn = null;
        int valid = 0;




        /// CONNECTION FUNTION ///
        public static void Connection(Label label6)
        {

            string connStr = "server =127.0.0.1; user = root; database = test; password =";
            try
            {
                conn = new MySqlConnection(connStr);                                             // Opening The Connection using string => "connStr"
                conn.Open();                                            

                label6.Text = "Connected";                  
                label6.BackColor = Color.Green; 
               
                //MessageBox.Show("SUCCESSFUL");
            }
            catch (Exception ex)
            {
                label6.Text = "Disconnected";                                                    //Catching Errors
                label6.BackColor = Color.Red;

                MessageBox.Show(ex.Message,"Describe your issue through an e-mail and we will contact you!");
            }
            finally
            {
                conn.Close();
            }
        }



        /// LOGIN VALIDATION FUNCTION ///
        
        void LoginValidation()
        {
            string Uname = txtUserName.Text;
            string Upass = txtpass.Text;

            try
            {
                valid = 0;
                Valid_Transfer(Uname);
                conn.Open();                                                                     
                                                                                                 // Search in our database => for user's name 
                MySqlCommand mySqlCommand = new MySqlCommand("select * from test", conn);        // Verify in our database => using READER 
                MySqlDataReader Reader = mySqlCommand.ExecuteReader();                           // Granting  or denying   => ACCES
                while (Reader.Read())                                                           
                {
                    if (Uname == Reader.GetString("username") && Upass == Reader.GetString("password"))
                    {
                        MessageBox.Show("Authorized User");
                        valid = 1;
                        conn.Close();
                        Valid_Transfer(Uname);
                       
                        return;                                                                  // After granting acces => User is transfered to Main Application
                                                                                                 // If acces is denied User gets a message that the password/username is incorrect 
                                                                                                 // using a "Valid" variable that trigers the transfer into FORM 2
                                                                                                 
                    }
                }
                if (valid == 0)
                {                                                                                            
                    MessageBox.Show("Invalid User");                                             // Invalid User Error

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);                                                     //Catching Errors
            }
            finally
            {
                conn.Close();
            }
        }


        /// TRANSFER FUNCTION ///
        private void Valid_Transfer(string Uname)
        {
            var panel3 = this.Parent as Panel;                                                   //Converting "panel3" as a parent so we can transfer Data from ControlUser => Form
            var Form1 = panel3.TopLevelControl as Form;                                          //Sending "Valid" => "textBox1" in Form1
           ((TextBox)Form1.Controls.Find("textBox1", true)[0]).Text = valid.ToString();          //We use Valid to determine if User has acces to Main Application or not

            ((TextBox)Form1.Controls.Find("textBox2", true)[0]).Text = Uname;                    // !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!! //

        }


        /// ADD USERCONTROL LABEL ///
        private void label4_Click_1(object sender, EventArgs e)
        {
            RA_UC UC = new RA_UC();
            ADD_UC.showControl(UC, panel3);
        }

        /// CLEAR TEXT FUNCTION ///
        private void label2_Click(object sender, EventArgs e)
        {
            txtUserName.Clear();
            txtpass.Clear();
            txtUserName.Focus();
            txtpass.PasswordChar = '*';
        }

        /// LOGIN BUTTON ///
        private void button1_Click(object sender, EventArgs e)
        {
            LoginValidation();
        }

        /// EXIT BUTTON ///
        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// ENTER IS NOT ALOWED ///
        private void txtUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
            }
        }

        /// ENTER IS NOT ALOWED ///
        private void txtpass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            /*Label MyLabel = new Label();
            MyLabel.Visible = String.IsNullOrEmpty(txtUserName.Text = "Userame");*/

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtUserName.Text = "ddarian09";
            txtpass.Text = "nagyesuper";

        }

       

        private void eye_icon_MouseHover(object sender, EventArgs e)
        {
          /*  if (txtpass.PasswordChar == '*')
            {
                txtpass.PasswordChar = '\0';
            }
            else
            {
                txtpass.PasswordChar = '*';
            }*/
        }

        private void eye_icon_Click(object sender, EventArgs e)
        {
            if (txtpass.PasswordChar == '*')
            {
                txtpass.PasswordChar = '\0';
            }
            else
            {
                txtpass.PasswordChar = '*';
            }
        }
    }


}

