using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginScreen.Classes
{
    class PHTextBox : System.Windows.Forms.TextBox
    {
        System.Drawing.Color DefaultColor;
        public string PlaceHolderText { get; set; }
        public PHTextBox(string placeholdertext)
        {
            // get default color of text
            DefaultColor = this.ForeColor;
            // Add event handler for when the control gets focus
            this.GotFocus += (object sender, EventArgs e) =>
            {
                this.Text = String.Empty;
                this.ForeColor = DefaultColor;
            };

            // add event handling when focus is lost
            this.LostFocus += (Object sender, EventArgs e) => {
                if (String.IsNullOrEmpty(this.Text) || this.Text == PlaceHolderText)
                {
                    this.ForeColor = System.Drawing.Color.Gray;
                    this.Text = PlaceHolderText;
                }
                else
                {
                    this.ForeColor = DefaultColor;
                }
            };



            if (!string.IsNullOrEmpty(placeholdertext))
            {
                // change style   
                this.ForeColor = System.Drawing.Color.Gray;
                // Add text
                PlaceHolderText = placeholdertext;
                this.Text = placeholdertext;
            }



        }
           /* this.txtUserName = new PHTextBox("User Name");
            this.txtEmail = new PHTextBox("E-mail");
            this.txtFirstName = new PHTextBox("First Name");
            this.txtLastName = new PHTextBox("Last Name");
            this.txtpass = new PHTextBox("Password");
            this.txtpass_confirm = new PHTextBox("Confirm Password");*/


    }

}
