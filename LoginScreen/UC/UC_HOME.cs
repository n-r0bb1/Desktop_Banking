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
using System.Globalization;

namespace LoginScreen.UC
{
    public partial class UC_HOME : UserControl
    {
        // EVENT PLANNER => TABLE
        DataTable table;

        public UC_HOME()
        {
            InitializeComponent();
            // if(balance!=null)
            //   text();
            Connection();

    }


        public string uname;
        static string user;
        public string ID
        {
            set { user = value; }

            //set { textBox1.Text = value; }
          
        }
     
        public void text()
        {
            textBox1.Text = user.ToString();
        }

        public void UC_HOME_Load(object sender, EventArgs e)
        {
            text();

            // EVENT PLANNER //
            table = new DataTable();
            table.Columns.Add("Event", typeof(String));
            dataGridView1.DataSource = table;
            dataGridView1.Columns[0].Width = 272;
            table.Rows.Add("Emergency Meeting 1 June");
            table.Rows.Add("Do HomeWork 20 May ");
            table.Rows.Add("Talk to Business Partners");
            table.Rows.Add("Make Money ALL THE TIME");
            table.Rows.Add("Event 10 May - 12:00");
            table.Rows.Add("Create Desktop App");
            table.Rows.Add("End Of HighSchool Party 1 June");

            showTransfers();

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


        // SHOW OLD TRANSFERS FUNCTION //

        private void showTransfers()
        {

            string meReceiver = textBox1.Text;

            try
            {
                conn.Open();

                dataGridView2.Rows.Clear();
                dataGridView2.Refresh();

                MySqlCommand mySqlCommand = new MySqlCommand("select * from data where 1", conn);
                MySqlDataReader Reader = mySqlCommand.ExecuteReader();
                while (Reader.Read())
                {
                    if ((string)Reader["sender"] == meReceiver || (string)Reader["receiver"] == meReceiver)
                        dataGridView2.Rows.Add(Reader["sender"], Reader["receiver"], Reader["sum"]);
                 
                }

                foreach(DataGridViewRow r in dataGridView2.Rows)
                {
                    if ((string)r.Cells[0].Value == meReceiver)
                        r.DefaultCellStyle.ForeColor = Color.Red;
                    if ((string)r.Cells[1].Value == meReceiver)
                        r.DefaultCellStyle.ForeColor = Color.Green;
                    
                }
                dataGridView2.DefaultCellStyle.Font = new Font(dataGridView2.DefaultCellStyle.Font, FontStyle.Bold);


                /* 
                 * 
                 *  int fav1 = 0, fav2 = 0, fav3 = 0;
                 *  string f1, f2, f3;
                 * 
                 * for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
                 {
                     string value = dataGridView2.Rows[i].Cells[2].Value.ToString();
                     for (int j = i + 1; j < dataGridView2.Rows.Count; j++)
                     {
                         string verify = dataGridView2.Rows[j].Cells[2].Value.ToString();
                         if (value == verify)
                         {
                             //fav1++;
                             //f1 = value; 
                         }

                     }

                 }*/


                //label_fav1.Text = f1;



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

        private void dataButton_Click(object sender, EventArgs e)
        {
            showTransfers();
        }

        private void addEventBut_Click(object sender, EventArgs e)
        {
            if (titleBox.Text != "")
            {
                table.Rows.Add(titleBox.Text);
                titleBox.Clear();
            }
        }

        private void removeEventBut_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            table.Rows[index].Delete();
        }
    }
}
