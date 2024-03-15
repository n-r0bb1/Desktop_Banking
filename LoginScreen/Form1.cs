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
using System.Security.Cryptography.X509Certificates;
using System.Drawing.Text;
using LoginScreen.UC;
using System.Runtime.Remoting.Messaging;
using LoginScreen.Classes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;

namespace LoginScreen
{
    public partial class Form1 : Form
    {

        public static Form1 instance;
        public TextBox UnameBox;
        private void Form1_Load(object sender, EventArgs e)
        {
            LI_UC uc = new LI_UC();
            ADD_UC.showControl(uc, panel1);

            instance = this;
            UnameBox = textBox2;
        } 

        public Form1()
        {
            InitializeComponent();

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "1")
            {
              
               
                this.Hide();  
                var Form2 = new Form2();
                Form2.Closed += (s, args) => this.Close();
                Form2.Show(); 

            }
        }

    }
}
