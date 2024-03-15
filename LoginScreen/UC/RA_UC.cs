using LoginScreen.Classes;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities.Collections;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Application = System.Windows.Forms.Application;

namespace LoginScreen.UC
{
    public partial class RA_UC : UserControl
    {
        public RA_UC()
        {
            InitializeComponent();                                                               // Start Connection with tha database 
            Connection();
            label1.Visible = false;

        }

        private void RA_UC_Load(object sender, EventArgs e)
        {
            //NOP()
            monthBox.SelectedIndex = 0;
            yearBox.SelectedIndex = 0;
            dayBox.SelectedIndex = 0;


        }

        static MySqlConnection conn = null;
        public static void Connection()
        {
            string connStr = "server =127.0.0.1; user = root; database = test; password =";
            try
            {
                conn = new MySqlConnection(connStr);
                conn.Open();                                                                     // Opening The Connection using string => "connStr"
                //MessageBox.Show("SUCCESSFUL");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            RegisterValidation();

        }

        void RegisterValidation()
        {
            int contor_fields = 0;
            int RYear = Convert.ToInt16(yearBox.SelectedItem);
            int RMonth = monthBox.SelectedIndex + 1;
            int RDay = Convert.ToInt16(dayBox.SelectedItem);

            bool valid = false;
            bool age = true;

            string UEmail = txtEmail.Text;                     // Register Validation Function Initiation variables => TextBox
            string Uname = txtUserName.Text;
            string Upass = txtpass.Text;
            string UpassConfirm = txtpass_confirm.Text;
            string reEmail;
            string reUname;

            var Year = DateTime.Now.Year;
            var Month = DateTime.Now.Month;
            var Day = DateTime.Now.Day;



            if (Uname == "")
            {
                label12.Visible = true;
                //txtUserName.ForeColor = Color.Red;
                label12.Text = "This field is requierd!";
            }
            else
            {
                contor_fields++;
                label12.Visible = false;
            }

            if (UEmail == "")
            {
                label13.Visible = true;
                //txtEmail.ForeColor = Color.Red;
                label13.Text = "This field is requierd!";
            }
            else
            {
                contor_fields++;
                label13.Visible = false;
            }

            if (Upass == "")
            {
                label16.Visible = true;
                //txtpass.ForeColor = Color.Red;
                label16.Text = "This field is requierd!";
            }
            else
            {
                contor_fields++;
                label16.Visible = false;
            }

            if (UpassConfirm == "")
            {
                label17.Visible = true;
                //txtpass_confirm.ForeColor = Color.Red;
                label17.Text = "This field is requierd!";
            }
            else
            {
                contor_fields++;
                label17.Visible = false;
            }
            if (Year - RYear > 18)
            {
                contor_fields++;
            }
            else if ((Year - RYear == 18))
            {
                if (RMonth < Month)
                {
                    contor_fields++;
                }
                else if (RMonth == Month)
                {
                    if (RDay <= Day)
                    {
                        contor_fields++;
                    }
                    else
                    {
                        age = false;
                    }
                }
                else
                {
                    age = false;
                }
            }
            else
            {
                age = false;
            }

            if (age == false)
            {
                //MessageBox.Show(Uname + " Must be over 18 years old in order to register");                                             // DESIGN
                label15.Visible = true;
                label15.Text = "You must be over 18 years old in order to register!";
            }
            else
            {
                label15.Visible = false;

                if (contor_fields == 5)
                {
                    try
                    {

                        MySqlCommand mySqlCommand = new MySqlCommand("select * from test where username = '" + Uname + "'", conn);          // Verifying if "Uname" == USER NAME => already exists in DATABASE
                                                                                                                                            // Verifying if "UEmail" == Email => already exists in DATABASE
                        MySqlCommand mySqlCommand1 = new MySqlCommand("select * from test where email = '" + UEmail + "'", conn);           // If they BOTH don't exist than we verify if PASSWORD matches the criterias 
                        conn.Open();                                                                                                        // PASSWORD >= 6 characters
                        MySqlDataReader Reader = mySqlCommand.ExecuteReader();                                                              // PASSWORD == CONFIERMATION
                                                                                                                                            // Register Completed

                        /*if (Reader.Read())
                        {
                            reUname = Reader["username"].ToString();
                            textBox2.Text = reUname;
                        }
                        Reader.Close();*/
                        //Reader1.Close();



                        // VERIFY USERNAME //

                        if (Reader.HasRows == true)
                        {
                            //MessageBox.Show("This UserName Already exists. Enter another one!");
                            label12.Visible = true;
                            label12.Text = "This username already exists!";
                        }
                         else
                        {
                            label12.Visible = false;
                            contor_fields++;
                        }
                        Reader.Close();


                        // VERIFY EMAIL //

                        MySqlDataReader Reader1 = mySqlCommand1.ExecuteReader();
                        if (Reader1.HasRows == true)
                        {
                            //MessageBox.Show("This Email Already exists. Enter another one!");
                            label13.Visible = true;
                            label13.Text = "This email already exists!";
                        }
                        else
                        {
                            label13.Visible = false;
                            contor_fields++;
                        }
                        if(contor_fields == 7)
                        {
                            if (Upass == UpassConfirm)
                            {

                                if (Upass.Length >= 6)
                                {

                                    Reader1.Close();
                                    string insert = "INSERT INTO `test`(`username`, `password`,`email`, `transfer`, `send`) VALUES(@username,@password,@email,@transfer,@send)";                           // Inserting values into DATABASE
                                    mySqlCommand = new MySqlCommand(insert, conn);
                                    mySqlCommand.Parameters.AddWithValue("@username", Uname);
                                    mySqlCommand.Parameters.AddWithValue("@password", Upass);
                                    mySqlCommand.Parameters.AddWithValue("@email", UEmail);
                                    mySqlCommand.Parameters.AddWithValue("@transfer", "0");
                                    mySqlCommand.Parameters.AddWithValue("@send", "0");

                                    mySqlCommand.ExecuteNonQuery();
                                    MessageBox.Show("Registration Completed");
                                    valid = true;

                                }
                                else
                                {
                                    MessageBox.Show("Password is too short");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Passwords don't match!");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        conn.Close();                                                                   // NO REGISTRATION if User already EXISTS                                
                    }

                    if (valid)
                    {
                        LI_UC uc = new LI_UC();                                                          // Validity verification => If Valid == 1 => Main App Starts 
                        ADD_UC.showControl(uc, panel1);                                                  // Else User Gets an Error
                    }

                }
            }
        }


        /// TRASNFER FUNCTION ///
        private void label4_Click_1(object sender, EventArgs e)
        {
            LI_UC uc = new LI_UC();
            ADD_UC.showControl(uc, panel1);
        }

        /// EXIT BUTTON ///
        private void label3_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            Application.Exit();
        }

        /// CLEAR TEXT FUNCTION ///
        private void label2_Click(object sender, EventArgs e)
        {
            txtUserName.Clear();
            txtpass.Clear();
            txtUserName.Focus();
            txtEmail.Clear();
            txtpass_confirm.Clear();
            
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

        /// ENTER IS NOT ALOWED ///
        private void txtpass_confirm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtEmail.Text = "dariandomocos59@gmail.com";     
            txtpass.Text = "nagyesuper";
            txtpass_confirm.Text = "nagyesuper";
            txtUserName.Text = "ddarian09";
        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {
                label1.Visible = true;

            if (txtpass.Text.Length < 6)
            {
               
                label1.Text = "Weak";
                label1.BackColor = Color.Red;
                label1.ForeColor = Color.White;
            }
            else if(txtpass.Text.Length >= 6 && txtpass.Text.Length <=8)
            {
                label1.Text = "Medium";
                label1.BackColor = Color.Orange;
                label1.ForeColor = Color.White;
            }
            else if(txtpass.Text.Length >= 9)
            {
                label1.Text = "Strong";
                label1.BackColor = Color.Green;
                label1.ForeColor = Color.White;
            }
        }

        private void monthBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //monthBox.DropDownStyle = ComboBoxStyle.DropDownList;

        }

    
    }

}

