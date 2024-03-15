namespace LoginScreen.UC
{
    partial class UC_HOME
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_HOME));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataButton = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Sender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Receiver = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Funds = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label_fav1 = new System.Windows.Forms.Label();
            this.removeEventBut = new System.Windows.Forms.Button();
            this.addEventBut = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.titleBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(16, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.Visible = false;
            // 
            // dataButton
            // 
            this.dataButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.dataButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dataButton.ForeColor = System.Drawing.Color.White;
            this.dataButton.Location = new System.Drawing.Point(232, 582);
            this.dataButton.Name = "dataButton";
            this.dataButton.Size = new System.Drawing.Size(200, 28);
            this.dataButton.TabIndex = 143;
            this.dataButton.Text = "Show Transfers";
            this.dataButton.UseVisualStyleBackColor = false;
            this.dataButton.Click += new System.EventHandler(this.dataButton_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sender,
            this.Receiver,
            this.Funds});
            this.dataGridView2.GridColor = System.Drawing.Color.White;
            this.dataGridView2.Location = new System.Drawing.Point(58, 49);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidth = 50;
            this.dataGridView2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView2.Size = new System.Drawing.Size(551, 525);
            this.dataGridView2.TabIndex = 142;
            // 
            // Sender
            // 
            this.Sender.HeaderText = "Sender";
            this.Sender.Name = "Sender";
            this.Sender.ReadOnly = true;
            // 
            // Receiver
            // 
            this.Receiver.HeaderText = "Receiver";
            this.Receiver.Name = "Receiver";
            this.Receiver.ReadOnly = true;
            // 
            // Funds
            // 
            this.Funds.HeaderText = "Funds";
            this.Funds.Name = "Funds";
            this.Funds.ReadOnly = true;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "1. Pay mortgage",
            "2. Get money from Radu",
            "3. Transfer money in CA",
            "4. Receive weekly payments",
            "5. Send money to Robert",
            "6. Get contract from JP Morgan",
            "7. Get approved by BT",
            "8. Finish highschool",
            "9. Sell Dropshipping Course  ($10k)",
            "10. Crypto Scam",
            "11. NFT Project Launch",
            "12. Emergency Meeting in War Room",
            "13. Sell/Buy Stocks",
            "14. FaceTime Putin",
            "15. Buy 10 boxes Cuban Cigars",
            "16. Scam 10 years olds on CS:GO",
            "17. Become Milionair by 15 year old",
            "18. Wake up at 03:61AM ",
            "19. Run 101 miles (lite run)"});
            this.checkedListBox1.Location = new System.Drawing.Point(725, 71);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(265, 244);
            this.checkedListBox1.TabIndex = 145;
            // 
            // label_fav1
            // 
            this.label_fav1.AutoSize = true;
            this.label_fav1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_fav1.Location = new System.Drawing.Point(767, 49);
            this.label_fav1.Name = "label_fav1";
            this.label_fav1.Size = new System.Drawing.Size(154, 19);
            this.label_fav1.TabIndex = 146;
            this.label_fav1.Text = "Keep bussines in order";
            // 
            // removeEventBut
            // 
            this.removeEventBut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.removeEventBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeEventBut.ForeColor = System.Drawing.Color.White;
            this.removeEventBut.Location = new System.Drawing.Point(910, 649);
            this.removeEventBut.Name = "removeEventBut";
            this.removeEventBut.Size = new System.Drawing.Size(88, 27);
            this.removeEventBut.TabIndex = 151;
            this.removeEventBut.Text = "Remove Event";
            this.removeEventBut.UseVisualStyleBackColor = false;
            this.removeEventBut.Click += new System.EventHandler(this.removeEventBut_Click);
            // 
            // addEventBut
            // 
            this.addEventBut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.addEventBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addEventBut.ForeColor = System.Drawing.Color.White;
            this.addEventBut.Location = new System.Drawing.Point(725, 649);
            this.addEventBut.Name = "addEventBut";
            this.addEventBut.Size = new System.Drawing.Size(88, 27);
            this.addEventBut.TabIndex = 150;
            this.addEventBut.Text = "Add Event";
            this.addEventBut.UseVisualStyleBackColor = false;
            this.addEventBut.Click += new System.EventHandler(this.addEventBut_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(725, 365);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.Size = new System.Drawing.Size(273, 243);
            this.dataGridView1.TabIndex = 149;
            // 
            // titleBox
            // 
            this.titleBox.Location = new System.Drawing.Point(725, 613);
            this.titleBox.Multiline = true;
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(273, 30);
            this.titleBox.TabIndex = 148;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(767, 340);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 19);
            this.label1.TabIndex = 152;
            this.label1.Text = "Add events to your planner";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(58, 655);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 21);
            this.pictureBox1.TabIndex = 155;
            this.pictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox1, "Green Values = Received funds\r\nRed Values = Sent funds \r\n\r\n");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.label3.Location = new System.Drawing.Point(40, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 29);
            this.label3.TabIndex = 157;
            this.label3.Text = "Transactions";
            // 
            // UC_HOME
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_fav1);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.removeEventBut);
            this.Controls.Add(this.addEventBut);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.titleBox);
            this.Controls.Add(this.dataButton);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.textBox1);
            this.Name = "UC_HOME";
            this.Size = new System.Drawing.Size(1150, 720);
            this.Load += new System.EventHandler(this.UC_HOME_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button dataButton;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Receiver;
        private System.Windows.Forms.DataGridViewTextBoxColumn Funds;
        private System.Windows.Forms.Label label_fav1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button removeEventBut;
        private System.Windows.Forms.Button addEventBut;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox titleBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
    }
}
