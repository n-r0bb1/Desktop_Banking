namespace LoginScreen
{
    partial class Form2
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.balanceBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.moneyBox = new System.Windows.Forms.TextBox();
            this.userFindBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.transferButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.Refresh_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.senderColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receiverCoumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fundsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.declineButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.acceptButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.verify_label = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.title_bar = new System.Windows.Forms.Panel();
            this.minimize_button = new System.Windows.Forms.Button();
            this.mepassBox = new System.Windows.Forms.TextBox();
            this.exit_button = new System.Windows.Forms.Button();
            this.mesendBox = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.metransferBox = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.meemailBox = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menu_panel = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.name_picbox = new System.Windows.Forms.PictureBox();
            this.profile_panel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_exchange = new System.Windows.Forms.Button();
            this.versionLabel = new System.Windows.Forms.Label();
            this.settingsLabel = new System.Windows.Forms.Label();
            this.button_transactions = new System.Windows.Forms.Button();
            this.button_services = new System.Windows.Forms.Button();
            this.button_stats = new System.Windows.Forms.Button();
            this.button_home = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.title_bar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.menu_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.name_picbox)).BeginInit();
            this.profile_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(210, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1130, 720);
            this.panel2.TabIndex = 100;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // balanceBox
            // 
            this.balanceBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.balanceBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.balanceBox.Font = new System.Drawing.Font("Bahnschrift", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balanceBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.balanceBox.Location = new System.Drawing.Point(370, 220);
            this.balanceBox.Multiline = true;
            this.balanceBox.Name = "balanceBox";
            this.balanceBox.ReadOnly = true;
            this.balanceBox.Size = new System.Drawing.Size(220, 60);
            this.balanceBox.TabIndex = 149;
            this.balanceBox.Text = "99999 RON";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.label4.Location = new System.Drawing.Point(250, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 25);
            this.label4.TabIndex = 144;
            this.label4.Text = "Balance:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.label7.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.label7.Location = new System.Drawing.Point(250, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 19);
            this.label7.TabIndex = 155;
            this.label7.Text = "Welcome back @";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(240, 60);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(447, 240);
            this.pictureBox3.TabIndex = 147;
            this.pictureBox3.TabStop = false;
            // 
            // moneyBox
            // 
            this.moneyBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.moneyBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.moneyBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moneyBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.moneyBox.Location = new System.Drawing.Point(341, 389);
            this.moneyBox.Multiline = true;
            this.moneyBox.Name = "moneyBox";
            this.moneyBox.Size = new System.Drawing.Size(240, 24);
            this.moneyBox.TabIndex = 148;
            this.moneyBox.TextChanged += new System.EventHandler(this.moneyBox_TextChanged);
            // 
            // userFindBox
            // 
            this.userFindBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.userFindBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userFindBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userFindBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.userFindBox.Location = new System.Drawing.Point(353, 332);
            this.userFindBox.Multiline = true;
            this.userFindBox.Name = "userFindBox";
            this.userFindBox.Size = new System.Drawing.Size(240, 24);
            this.userFindBox.TabIndex = 147;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(286, 485);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 30);
            this.button2.TabIndex = 150;
            this.button2.Text = "Default";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.panel3.Location = new System.Drawing.Point(271, 358);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(310, 1);
            this.panel3.TabIndex = 145;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.label1.Location = new System.Drawing.Point(267, 331);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 18);
            this.label1.TabIndex = 141;
            this.label1.Text = "Username";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // transferButton
            // 
            this.transferButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(204)))), ((int)(((byte)(214)))));
            this.transferButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.transferButton.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transferButton.ForeColor = System.Drawing.Color.White;
            this.transferButton.Location = new System.Drawing.Point(286, 451);
            this.transferButton.Name = "transferButton";
            this.transferButton.Size = new System.Drawing.Size(150, 30);
            this.transferButton.TabIndex = 142;
            this.transferButton.Text = "Send";
            this.transferButton.UseVisualStyleBackColor = false;
            this.transferButton.Click += new System.EventHandler(this.transferButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.panel1.Location = new System.Drawing.Point(271, 416);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(310, 1);
            this.panel1.TabIndex = 146;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.label2.Location = new System.Drawing.Point(268, 390);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 18);
            this.label2.TabIndex = 143;
            this.label2.Text = "Money";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.pictureBox4.Location = new System.Drawing.Point(238, 308);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(447, 230);
            this.pictureBox4.TabIndex = 153;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // Refresh_button
            // 
            this.Refresh_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.Refresh_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Refresh_button.ForeColor = System.Drawing.Color.White;
            this.Refresh_button.Location = new System.Drawing.Point(899, 496);
            this.Refresh_button.Name = "Refresh_button";
            this.Refresh_button.Size = new System.Drawing.Size(200, 30);
            this.Refresh_button.TabIndex = 152;
            this.Refresh_button.Text = "Show Pending Transactions";
            this.Refresh_button.UseVisualStyleBackColor = false;
            this.Refresh_button.Click += new System.EventHandler(this.Refresh_button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.label3.Location = new System.Drawing.Point(146, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 16);
            this.label3.TabIndex = 137;
            this.label3.Text = "Exit";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.senderColumn,
            this.receiverCoumn,
            this.fundsColumn,
            this.declineButton,
            this.acceptButton});
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.dataGridView1.Location = new System.Drawing.Point(759, 99);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.Size = new System.Drawing.Size(521, 380);
            this.dataGridView1.TabIndex = 151;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // id
            // 
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // senderColumn
            // 
            this.senderColumn.HeaderText = "Sender";
            this.senderColumn.Name = "senderColumn";
            this.senderColumn.ReadOnly = true;
            this.senderColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // receiverCoumn
            // 
            this.receiverCoumn.HeaderText = "Receiver";
            this.receiverCoumn.Name = "receiverCoumn";
            this.receiverCoumn.ReadOnly = true;
            this.receiverCoumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // fundsColumn
            // 
            this.fundsColumn.HeaderText = "Funds";
            this.fundsColumn.Name = "fundsColumn";
            this.fundsColumn.ReadOnly = true;
            this.fundsColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // declineButton
            // 
            this.declineButton.HeaderText = "Decline";
            this.declineButton.Name = "declineButton";
            this.declineButton.ReadOnly = true;
            // 
            // acceptButton
            // 
            this.acceptButton.HeaderText = "Accept";
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.ReadOnly = true;
            // 
            // verify_label
            // 
            this.verify_label.AutoSize = true;
            this.verify_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.verify_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verify_label.Location = new System.Drawing.Point(288, 425);
            this.verify_label.Name = "verify_label";
            this.verify_label.Size = new System.Drawing.Size(0, 16);
            this.verify_label.TabIndex = 116;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.pictureBox5.Location = new System.Drawing.Point(726, 60);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(569, 478);
            this.pictureBox5.TabIndex = 154;
            this.pictureBox5.TabStop = false;
            // 
            // title_bar
            // 
            this.title_bar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.title_bar.Controls.Add(this.minimize_button);
            this.title_bar.Controls.Add(this.mepassBox);
            this.title_bar.Controls.Add(this.exit_button);
            this.title_bar.Controls.Add(this.mesendBox);
            this.title_bar.Controls.Add(this.button3);
            this.title_bar.Controls.Add(this.metransferBox);
            this.title_bar.Controls.Add(this.pictureBox2);
            this.title_bar.Controls.Add(this.meemailBox);
            this.title_bar.Controls.Add(this.textBox5);
            this.title_bar.Controls.Add(this.textBox4);
            this.title_bar.Controls.Add(this.textBox3);
            this.title_bar.Controls.Add(this.textBox2);
            this.title_bar.Controls.Add(this.textBox1);
            this.title_bar.Location = new System.Drawing.Point(210, 0);
            this.title_bar.Name = "title_bar";
            this.title_bar.Size = new System.Drawing.Size(1131, 30);
            this.title_bar.TabIndex = 2;
            this.title_bar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.title_bar_MouseDown);
            // 
            // minimize_button
            // 
            this.minimize_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.minimize_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimize_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.minimize_button.Image = ((System.Drawing.Image)(resources.GetObject("minimize_button.Image")));
            this.minimize_button.Location = new System.Drawing.Point(1015, 0);
            this.minimize_button.Margin = new System.Windows.Forms.Padding(0);
            this.minimize_button.Name = "minimize_button";
            this.minimize_button.Size = new System.Drawing.Size(30, 25);
            this.minimize_button.TabIndex = 144;
            this.minimize_button.UseVisualStyleBackColor = false;
            this.minimize_button.Click += new System.EventHandler(this.minimize_button_Click);
            // 
            // mepassBox
            // 
            this.mepassBox.Location = new System.Drawing.Point(673, 11);
            this.mepassBox.Multiline = true;
            this.mepassBox.Name = "mepassBox";
            this.mepassBox.Size = new System.Drawing.Size(10, 13);
            this.mepassBox.TabIndex = 96;
            this.mepassBox.Visible = false;
            // 
            // exit_button
            // 
            this.exit_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.exit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.exit_button.Image = ((System.Drawing.Image)(resources.GetObject("exit_button.Image")));
            this.exit_button.Location = new System.Drawing.Point(1095, 0);
            this.exit_button.Margin = new System.Windows.Forms.Padding(0);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(30, 25);
            this.exit_button.TabIndex = 142;
            this.exit_button.UseVisualStyleBackColor = false;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // mesendBox
            // 
            this.mesendBox.Location = new System.Drawing.Point(705, 10);
            this.mesendBox.Multiline = true;
            this.mesendBox.Name = "mesendBox";
            this.mesendBox.Size = new System.Drawing.Size(10, 13);
            this.mesendBox.TabIndex = 95;
            this.mesendBox.Visible = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(1055, 0);
            this.button3.Margin = new System.Windows.Forms.Padding(0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(30, 25);
            this.button3.TabIndex = 143;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // metransferBox
            // 
            this.metransferBox.Location = new System.Drawing.Point(689, 11);
            this.metransferBox.Multiline = true;
            this.metransferBox.Name = "metransferBox";
            this.metransferBox.Size = new System.Drawing.Size(10, 13);
            this.metransferBox.TabIndex = 94;
            this.metransferBox.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.pictureBox2.Location = new System.Drawing.Point(985, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(147, 30);
            this.pictureBox2.TabIndex = 147;
            this.pictureBox2.TabStop = false;
            // 
            // meemailBox
            // 
            this.meemailBox.Location = new System.Drawing.Point(656, 10);
            this.meemailBox.Multiline = true;
            this.meemailBox.Name = "meemailBox";
            this.meemailBox.Size = new System.Drawing.Size(10, 13);
            this.meemailBox.TabIndex = 93;
            this.meemailBox.Visible = false;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(771, 11);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(10, 13);
            this.textBox5.TabIndex = 92;
            this.textBox5.Visible = false;
            // 
            // textBox4
            // 
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.textBox4.Location = new System.Drawing.Point(640, 10);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(10, 13);
            this.textBox4.TabIndex = 91;
            this.textBox4.Visible = false;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(756, 11);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(10, 13);
            this.textBox3.TabIndex = 90;
            this.textBox3.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(740, 10);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(10, 13);
            this.textBox2.TabIndex = 89;
            this.textBox2.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(722, 10);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(10, 13);
            this.textBox1.TabIndex = 88;
            this.textBox1.Visible = false;
            // 
            // menu_panel
            // 
            this.menu_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.menu_panel.Controls.Add(this.label8);
            this.menu_panel.Controls.Add(this.panel4);
            this.menu_panel.Controls.Add(this.label6);
            this.menu_panel.Controls.Add(this.name_picbox);
            this.menu_panel.Controls.Add(this.profile_panel);
            this.menu_panel.Controls.Add(this.button_exchange);
            this.menu_panel.Controls.Add(this.versionLabel);
            this.menu_panel.Controls.Add(this.settingsLabel);
            this.menu_panel.Controls.Add(this.button_transactions);
            this.menu_panel.Controls.Add(this.button_services);
            this.menu_panel.Controls.Add(this.button_stats);
            this.menu_panel.Controls.Add(this.button_home);
            this.menu_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menu_panel.Location = new System.Drawing.Point(0, 0);
            this.menu_panel.Name = "menu_panel";
            this.menu_panel.Size = new System.Drawing.Size(210, 750);
            this.menu_panel.TabIndex = 101;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(66, 725);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 16);
            this.label8.TabIndex = 148;
            this.label8.Text = "Log Out";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(20, 224);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(170, 1);
            this.panel4.TabIndex = 147;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(10, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 16);
            this.label6.TabIndex = 146;
            this.label6.Text = "Astrea Banking";
            // 
            // name_picbox
            // 
            this.name_picbox.Location = new System.Drawing.Point(0, 1);
            this.name_picbox.Name = "name_picbox";
            this.name_picbox.Size = new System.Drawing.Size(210, 30);
            this.name_picbox.TabIndex = 139;
            this.name_picbox.TabStop = false;
            this.name_picbox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.name_picbox_MouseDown);
            // 
            // profile_panel
            // 
            this.profile_panel.BackColor = System.Drawing.Color.Transparent;
            this.profile_panel.Controls.Add(this.label3);
            this.profile_panel.Controls.Add(this.label5);
            this.profile_panel.Controls.Add(this.pictureBox1);
            this.profile_panel.Location = new System.Drawing.Point(10, 50);
            this.profile_panel.Name = "profile_panel";
            this.profile_panel.Size = new System.Drawing.Size(190, 168);
            this.profile_panel.TabIndex = 139;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(44, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 19);
            this.label5.TabIndex = 145;
            this.label5.Text = "@ddarian09";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(38, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 110);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button_exchange
            // 
            this.button_exchange.FlatAppearance.BorderSize = 0;
            this.button_exchange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_exchange.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.button_exchange.ForeColor = System.Drawing.Color.White;
            this.button_exchange.Location = new System.Drawing.Point(0, 451);
            this.button_exchange.Name = "button_exchange";
            this.button_exchange.Size = new System.Drawing.Size(210, 40);
            this.button_exchange.TabIndex = 121;
            this.button_exchange.Text = "Currency";
            this.button_exchange.UseVisualStyleBackColor = true;
            this.button_exchange.Click += new System.EventHandler(this.button_exchange_Click);
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.versionLabel.ForeColor = System.Drawing.Color.White;
            this.versionLabel.Location = new System.Drawing.Point(116, 695);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(75, 16);
            this.versionLabel.TabIndex = 8;
            this.versionLabel.Text = "version 1.20";
            // 
            // settingsLabel
            // 
            this.settingsLabel.AutoSize = true;
            this.settingsLabel.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsLabel.ForeColor = System.Drawing.Color.White;
            this.settingsLabel.Location = new System.Drawing.Point(12, 695);
            this.settingsLabel.Name = "settingsLabel";
            this.settingsLabel.Size = new System.Drawing.Size(54, 16);
            this.settingsLabel.TabIndex = 0;
            this.settingsLabel.Text = "Settings";
            this.settingsLabel.Click += new System.EventHandler(this.settingsLabel_Click);
            // 
            // button_transactions
            // 
            this.button_transactions.FlatAppearance.BorderSize = 0;
            this.button_transactions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_transactions.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.button_transactions.ForeColor = System.Drawing.Color.White;
            this.button_transactions.Location = new System.Drawing.Point(0, 286);
            this.button_transactions.Name = "button_transactions";
            this.button_transactions.Size = new System.Drawing.Size(210, 40);
            this.button_transactions.TabIndex = 7;
            this.button_transactions.Text = "Dashboard";
            this.button_transactions.UseVisualStyleBackColor = true;
            this.button_transactions.Click += new System.EventHandler(this.button_transactions_Click);
            // 
            // button_services
            // 
            this.button_services.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.button_services.FlatAppearance.BorderSize = 0;
            this.button_services.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_services.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_services.ForeColor = System.Drawing.Color.White;
            this.button_services.Location = new System.Drawing.Point(0, 506);
            this.button_services.Name = "button_services";
            this.button_services.Size = new System.Drawing.Size(210, 40);
            this.button_services.TabIndex = 6;
            this.button_services.Text = "Services";
            this.button_services.UseVisualStyleBackColor = false;
            this.button_services.Click += new System.EventHandler(this.button_services_Click);
            // 
            // button_stats
            // 
            this.button_stats.FlatAppearance.BorderSize = 0;
            this.button_stats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_stats.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.button_stats.ForeColor = System.Drawing.Color.White;
            this.button_stats.Location = new System.Drawing.Point(0, 396);
            this.button_stats.Name = "button_stats";
            this.button_stats.Size = new System.Drawing.Size(210, 40);
            this.button_stats.TabIndex = 5;
            this.button_stats.Text = "Statistics";
            this.button_stats.UseVisualStyleBackColor = true;
            this.button_stats.Click += new System.EventHandler(this.button_stats_Click);
            // 
            // button_home
            // 
            this.button_home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.button_home.FlatAppearance.BorderSize = 0;
            this.button_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_home.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.button_home.ForeColor = System.Drawing.Color.White;
            this.button_home.Location = new System.Drawing.Point(0, 341);
            this.button_home.Name = "button_home";
            this.button_home.Size = new System.Drawing.Size(210, 40);
            this.button_home.TabIndex = 4;
            this.button_home.Text = "Transactions";
            this.button_home.UseVisualStyleBackColor = false;
            this.button_home.Click += new System.EventHandler(this.button_home_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.label9.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.label9.Location = new System.Drawing.Point(484, 454);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 19);
            this.label9.TabIndex = 156;
            this.label9.Text = "Clear Fields";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.label10.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.label10.Location = new System.Drawing.Point(755, 73);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(163, 19);
            this.label10.TabIndex = 157;
            this.label10.Text = "Pending Transactions";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1341, 750);
            this.Controls.Add(this.balanceBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.moneyBox);
            this.Controls.Add(this.userFindBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.verify_label);
            this.Controls.Add(this.transferButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Refresh_button);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.menu_panel);
            this.Controls.Add(this.title_bar);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Astraea Banking";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.title_bar.ResumeLayout(false);
            this.title_bar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.menu_panel.ResumeLayout(false);
            this.menu_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.name_picbox)).EndInit();
            this.profile_panel.ResumeLayout(false);
            this.profile_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel menu_panel;
        private System.Windows.Forms.Label versionLabel;
        private System.Windows.Forms.Label settingsLabel;
        private System.Windows.Forms.Button button_transactions;
        private System.Windows.Forms.Button button_services;
        private System.Windows.Forms.Button button_stats;
        private System.Windows.Forms.Button button_home;
        private System.Windows.Forms.Panel title_bar;
        private System.Windows.Forms.TextBox mepassBox;
        private System.Windows.Forms.TextBox mesendBox;
        private System.Windows.Forms.TextBox metransferBox;
        private System.Windows.Forms.TextBox meemailBox;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label verify_label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_exchange;
        private System.Windows.Forms.Button Refresh_button;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn senderColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn receiverCoumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fundsColumn;
        private System.Windows.Forms.DataGridViewButtonColumn declineButton;
        private System.Windows.Forms.DataGridViewButtonColumn acceptButton;
        private System.Windows.Forms.TextBox userFindBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox balanceBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox moneyBox;
        private System.Windows.Forms.Button transferButton;
        private System.Windows.Forms.Button minimize_button;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.Panel profile_panel;
        private System.Windows.Forms.PictureBox name_picbox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}