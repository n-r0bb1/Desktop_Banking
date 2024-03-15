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
    public partial class UC_SETTINGS : UserControl
    {
        public UC_SETTINGS()
        {
            InitializeComponent();
        }

        private void UC_SETTINGS_Load(object sender, EventArgs e)
        {
            PictureBox picture = new PictureBox
            {
                Name = "pictureBox",
                //Size = new Size(200, 100),
                //Location = new Point(804, 277),
                Image = Image.FromFile(Application.StartupPath + @"\Pictures\logo_inc_2_15.png"),
                SizeMode = PictureBoxSizeMode.AutoSize
            };
            pictureBox1.Controls.Add(picture);
        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "By using our product, you agree to our Terms of Service." + '\n' +
                "The Astraea Banking Team is a set of related Internet Banking system and other applications for transfering funds " +
                "owned and operated by ABT, Inc. (“Astraea Bank”, “we” or “us”), " +
                "a Romanian corporation. AB welcomes you to the Network, the largest community of humans interconnected in the world, and " +
                "invites you to participate in the community by sharing funds with your peers and colleagues. Like all communities, we ask " +
                "that you participate in a manner that respects your fellow community members. To that end, we provide you with these terms of service" +
                "to advise you of the legal obligations you assume when you engage with the ABT community or otherwise access " +
                "or use the public Network or any services provided on the public Network (collectively, “Services”). These terms govern the " +
                "use of the public Network (the “Public Network Terms”).To the extent you are accessing or using our other products on " +
                "behalf of a Company or Team, including without limitation by registering for an account on behalf of a Company or Team, your use " +
                "of those product is governed by their relevant Terms and Conditions." + '\n' + "We are working non-stop to develop high end technology for our customers." +
                "Thank you for using our product!";


            pictureBox1.Controls.Clear();
            PictureBox picture = new PictureBox
            {
                Name = "pictureBox",
                //Size = new Size(200, 100),
                //Location = new Point(804, 277),
                Image = Image.FromFile(Application.StartupPath + @"\Pictures\logo_inc_2_15.png"),
                SizeMode = PictureBoxSizeMode.AutoSize
            };
            pictureBox1.Controls.Add(picture);
        }

        private void materialLabel2_Click(object sender, EventArgs e)
        {


            richTextBox1.Text = "Welcome to Astrea Banking Team! " + '\n'+
                "We're a team of three colleagues who are passionate about technology and finance. " + 
                "We created this app with the goal of innovating banking experience for people of all ages and backgrounds.Our team has a " + '\n' +
                "diverse set of skills and experiences that we bring to the table. " + '\n' + '\n' +
                    //Robi
                    "Nagy Robert, \"the designer\" is a software engineer " +
                 "with 1 year of experience in developing cutting-edge software applications and designed highly complex printed circuit boards." + '\n'+ '\n' +
             //Sandu
                    "Gitlan Sandu, \"the doctor\" is the mathematician that solved our hardest math problems- Mortgage and Deposit Calculators," +
                " and changing banking industry by creating innovative financial solutions. " + '\n'+ '\n' +
                    //Darian
                    "Domocos Darian, \"the creator\", bringing " +
                "a unique perspective with his expertise in marketing and customer experience alongside with his backend and frontend skills." + '\n' + '\n' +

                "Together, we've combined our skills and knowledge to create a banking app that we believe will revolutionize the way people manage their money. " +
                "Our app is designed with simplicity and convenience in mind, allowing users to easily access and control their finances from anywhere, at any time." +
                "We understand that trust is a crucial element in the banking industry, and we take the security and privacy of our users' information very seriously. " +
                "That's why we've implemented top-of-the-line security measures to ensure that our app is safe and secure.We're proud of what we've accomplished so " +
                "far, but we know that there's always room for improvement. \r\nWe're constantly working to enhance our app and add new features to make it even more " +
                "useful and user-friendly.Thank you for choosing our banking app. We're excited to have you join us on this journey as we continue to innovate " +
                "and improve the world of banking."+'\n';

          







            pictureBox1.Controls.Clear();
            PictureBox picture = new PictureBox
            {
                Name = "pictureBox",
                //Size = new Size(200, 100),
                //Location = new Point(804, 277),
                Image = Image.FromFile(Application.StartupPath + @"\Pictures\IMG_6411_5_15.jpg"),
                SizeMode = PictureBoxSizeMode.AutoSize
            };
            pictureBox1.Controls.Add(picture);
            
        }

        private void materialLabel3_Click(object sender, EventArgs e)
        {
            /*var sb = new StringBuilder();
        sb.Append(@"{\rtf1\ansi");
        sb.Append(@"Welcome to our banking app! ");
        sb.Append(@" \line ");
        sb.Append(@"We're a team of three colleagues who are passionate about technology and finance.");
        sb.Append(@" \line ");
        sb.Append(@"We created this app with the goal of innovating banking experience for people of all ages and backgrounds.Our team has a ");
        sb.Append(@" \line ");
        sb.Append(@" diverse set of skills and experiences that we bring to the table. ");
        sb.Append(@" \line ");
        sb.Append(@" \line ");
        sb.Append(@" \line ");
        sb.Append(@" \line ");
        sb.Append(@" \line ");
        sb.Append(@" \line ");

            sb.Append(@"}");

         richTextBox1.Rtf = sb.ToString();*/

            richTextBox1.Text = "We're always here to help you with any questions or concerns you may have about our banking app. " +
               "Whether you need technical assistance, have a suggestion for a new feature, or simply want to provide feedback, " +
               "we'd love to hear from you.There are several ways to get in touch with us:" + '\n' + '\n' +
               "Email: You can send us an email at astreabanking-support@gmail.com and we'll get back to you as soon as possible." + '\n' + '\n' +
               "Phone: If you prefer to speak to someone directly, you can call us at: 0771314814. Our customer service representatives are available 24/7." + '\n' + '\n' +
               "Live chat: Live chat is at the moment unavailable, but we are working towards creating a stable live comunication with our customers as we speak." + '\n' + '\n' +
               "Social media: You can also reach out to us on our social media channels. Follow us on Facebook and Instagram at @sandugitlan & @robby_nagy_22 & @ddarian09  and send us a direct message, or tag us in your posts." + '\n' + '\n' +
               "We're committed to providing the best possible service to our users, and we appreciate your feedback and suggestions. " +
               "So don't hesitate to contact us if you need anything. We're always here to help!";



            pictureBox1.Controls.Clear();




            PictureBox picture = new PictureBox
            {
                Name = "pictureBox",
                //Size = new Size(200, 100),
                //Location = new Point(804, 277),
                Image = Image.FromFile(Application.StartupPath + @"\Pictures\logo_inc_2_15.png"),
                SizeMode = PictureBoxSizeMode.AutoSize
            };
            pictureBox1.Controls.Add(picture);

        }

        private void materialLabel4_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "Stack Overflow - For Debbuging complex problems" + '\n' + '\n'
              + "YouTube - Inspiration for design and ideas" + '\n' + '\n'
              + "GeeksforGeeks - Syntax errors" + '\n' + '\n'
              + "Microsoft's official documentation for C# and .NET Documentations - Syntax and Databasses" + '\n' + '\n'
              + "Integrated Development Environment (IDE) - We used Visual Studio because is a popular IDE for C# development, "
              + "but there are also other options like JetBrains Rider and Visual Studio Code." + '\n' + '\n'
              + ".NET Framework or .NET Core - C# is part of the .NET family of languages, also Libraries and packages";




            pictureBox1.Controls.Clear();
            PictureBox picture = new PictureBox
            {
                Name = "pictureBox",
                //Size = new Size(200, 100),
                //Location = new Point(804, 277),
                Image = Image.FromFile(Application.StartupPath + @"\Pictures\logo_inc_2_15.png"),
                SizeMode = PictureBoxSizeMode.AutoSize
            };
            pictureBox1.Controls.Add(picture);

        }

        private void materialLabel7_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/");
        }
    }
}
