namespace LoginScreen.UC
{
    partial class UC_STATISTICS
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
            this.budget = new CircularProgressBar.CircularProgressBar();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.title = new System.Windows.Forms.Label();
            this.chart = new LiveCharts.WinForms.CartesianChart();
            this.pieChart1 = new LiveCharts.WinForms.PieChart();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.budget_button = new System.Windows.Forms.Button();
            this.max_budget_txtbox = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.invoice_txtbox = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.spent_money_txtbox = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.month_cbbox = new MaterialSkin.Controls.MaterialComboBox();
            this.maxbdt_button = new System.Windows.Forms.Button();
            this.save_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // budget
            // 
            this.budget.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.budget.AnimationSpeed = 500;
            this.budget.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.budget.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.budget.ForeColor = System.Drawing.Color.Black;
            this.budget.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.budget.InnerMargin = 2;
            this.budget.InnerWidth = -1;
            this.budget.Location = new System.Drawing.Point(34, 99);
            this.budget.MarqueeAnimationSpeed = 2000;
            this.budget.Name = "budget";
            this.budget.OuterColor = System.Drawing.Color.Navy;
            this.budget.OuterMargin = -26;
            this.budget.OuterWidth = 26;
            this.budget.ProgressColor = System.Drawing.Color.RoyalBlue;
            this.budget.ProgressWidth = 25;
            this.budget.SecondaryFont = new System.Drawing.Font("Bernard MT Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.budget.Size = new System.Drawing.Size(170, 170);
            this.budget.StartAngle = 270;
            this.budget.SubscriptColor = System.Drawing.Color.Transparent;
            this.budget.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.budget.SubscriptText = ".23";
            this.budget.SuperscriptColor = System.Drawing.Color.Transparent;
            this.budget.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.budget.SuperscriptText = "°C";
            this.budget.TabIndex = 153;
            this.budget.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.budget.Value = 68;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.pictureBox3.Location = new System.Drawing.Point(20, 60);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(539, 270);
            this.pictureBox3.TabIndex = 154;
            this.pictureBox3.TabStop = false;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.title.Location = new System.Drawing.Point(40, 10);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(119, 29);
            this.title.TabIndex = 155;
            this.title.Text = "Statistics ";
            // 
            // chart
            // 
            this.chart.BackColor = System.Drawing.Color.Transparent;
            this.chart.ForeColor = System.Drawing.Color.Transparent;
            this.chart.Location = new System.Drawing.Point(20, 430);
            this.chart.Name = "chart";
            this.chart.Size = new System.Drawing.Size(1110, 260);
            this.chart.TabIndex = 156;
            this.chart.Text = "cartesianChart1";
            // 
            // pieChart1
            // 
            this.pieChart1.BackColor = System.Drawing.Color.Transparent;
            this.pieChart1.ForeColor = System.Drawing.Color.Transparent;
            this.pieChart1.Location = new System.Drawing.Point(590, 60);
            this.pieChart1.Name = "pieChart1";
            this.pieChart1.Size = new System.Drawing.Size(539, 270);
            this.pieChart1.TabIndex = 158;
            this.pieChart1.Text = "pieChart2";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.pictureBox1.Location = new System.Drawing.Point(590, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(539, 259);
            this.pictureBox1.TabIndex = 159;
            this.pictureBox1.TabStop = false;
            // 
            // budget_button
            // 
            this.budget_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.budget_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.budget_button.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.budget_button.ForeColor = System.Drawing.Color.White;
            this.budget_button.Location = new System.Drawing.Point(390, 260);
            this.budget_button.Margin = new System.Windows.Forms.Padding(0);
            this.budget_button.Name = "budget_button";
            this.budget_button.Size = new System.Drawing.Size(90, 30);
            this.budget_button.TabIndex = 160;
            this.budget_button.Text = "Calculate";
            this.budget_button.UseVisualStyleBackColor = false;
            this.budget_button.Click += new System.EventHandler(this.budget_button_Click);
            // 
            // max_budget_txtbox
            // 
            this.max_budget_txtbox.AllowPromptAsInput = true;
            this.max_budget_txtbox.AnimateReadOnly = false;
            this.max_budget_txtbox.AsciiOnly = false;
            this.max_budget_txtbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.max_budget_txtbox.BeepOnError = false;
            this.max_budget_txtbox.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.max_budget_txtbox.Depth = 0;
            this.max_budget_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.max_budget_txtbox.HidePromptOnLeave = false;
            this.max_budget_txtbox.HideSelection = true;
            this.max_budget_txtbox.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.max_budget_txtbox.LeadingIcon = null;
            this.max_budget_txtbox.Location = new System.Drawing.Point(290, 80);
            this.max_budget_txtbox.Mask = "";
            this.max_budget_txtbox.MaxLength = 32767;
            this.max_budget_txtbox.MouseState = MaterialSkin.MouseState.OUT;
            this.max_budget_txtbox.Name = "max_budget_txtbox";
            this.max_budget_txtbox.PasswordChar = '\0';
            this.max_budget_txtbox.PrefixSuffixText = null;
            this.max_budget_txtbox.PromptChar = '_';
            this.max_budget_txtbox.ReadOnly = false;
            this.max_budget_txtbox.RejectInputOnFirstFailure = false;
            this.max_budget_txtbox.ResetOnPrompt = true;
            this.max_budget_txtbox.ResetOnSpace = true;
            this.max_budget_txtbox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.max_budget_txtbox.SelectedText = "";
            this.max_budget_txtbox.SelectionLength = 0;
            this.max_budget_txtbox.SelectionStart = 0;
            this.max_budget_txtbox.ShortcutsEnabled = true;
            this.max_budget_txtbox.Size = new System.Drawing.Size(190, 48);
            this.max_budget_txtbox.SkipLiterals = true;
            this.max_budget_txtbox.TabIndex = 161;
            this.max_budget_txtbox.TabStop = false;
            this.max_budget_txtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.max_budget_txtbox.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.max_budget_txtbox.TrailingIcon = null;
            this.max_budget_txtbox.UseSystemPasswordChar = false;
            this.max_budget_txtbox.ValidatingType = null;
            // 
            // invoice_txtbox
            // 
            this.invoice_txtbox.AllowPromptAsInput = true;
            this.invoice_txtbox.AnimateReadOnly = false;
            this.invoice_txtbox.AsciiOnly = false;
            this.invoice_txtbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.invoice_txtbox.BeepOnError = false;
            this.invoice_txtbox.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.invoice_txtbox.Depth = 0;
            this.invoice_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.invoice_txtbox.HidePromptOnLeave = false;
            this.invoice_txtbox.HideSelection = true;
            this.invoice_txtbox.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.invoice_txtbox.LeadingIcon = null;
            this.invoice_txtbox.Location = new System.Drawing.Point(290, 200);
            this.invoice_txtbox.Mask = "";
            this.invoice_txtbox.MaxLength = 32767;
            this.invoice_txtbox.MouseState = MaterialSkin.MouseState.OUT;
            this.invoice_txtbox.Name = "invoice_txtbox";
            this.invoice_txtbox.PasswordChar = '\0';
            this.invoice_txtbox.PrefixSuffixText = null;
            this.invoice_txtbox.PromptChar = '_';
            this.invoice_txtbox.ReadOnly = false;
            this.invoice_txtbox.RejectInputOnFirstFailure = false;
            this.invoice_txtbox.ResetOnPrompt = true;
            this.invoice_txtbox.ResetOnSpace = true;
            this.invoice_txtbox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.invoice_txtbox.SelectedText = "";
            this.invoice_txtbox.SelectionLength = 0;
            this.invoice_txtbox.SelectionStart = 0;
            this.invoice_txtbox.ShortcutsEnabled = true;
            this.invoice_txtbox.Size = new System.Drawing.Size(190, 48);
            this.invoice_txtbox.SkipLiterals = true;
            this.invoice_txtbox.TabIndex = 162;
            this.invoice_txtbox.TabStop = false;
            this.invoice_txtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.invoice_txtbox.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.invoice_txtbox.TrailingIcon = null;
            this.invoice_txtbox.UseSystemPasswordChar = false;
            this.invoice_txtbox.ValidatingType = null;
            // 
            // spent_money_txtbox
            // 
            this.spent_money_txtbox.AllowPromptAsInput = true;
            this.spent_money_txtbox.AnimateReadOnly = false;
            this.spent_money_txtbox.AsciiOnly = false;
            this.spent_money_txtbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.spent_money_txtbox.BeepOnError = false;
            this.spent_money_txtbox.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.spent_money_txtbox.Depth = 0;
            this.spent_money_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.spent_money_txtbox.HidePromptOnLeave = false;
            this.spent_money_txtbox.HideSelection = true;
            this.spent_money_txtbox.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.spent_money_txtbox.LeadingIcon = null;
            this.spent_money_txtbox.Location = new System.Drawing.Point(290, 140);
            this.spent_money_txtbox.Mask = "";
            this.spent_money_txtbox.MaxLength = 32767;
            this.spent_money_txtbox.MouseState = MaterialSkin.MouseState.OUT;
            this.spent_money_txtbox.Name = "spent_money_txtbox";
            this.spent_money_txtbox.PasswordChar = '\0';
            this.spent_money_txtbox.PrefixSuffixText = null;
            this.spent_money_txtbox.PromptChar = '_';
            this.spent_money_txtbox.ReadOnly = false;
            this.spent_money_txtbox.RejectInputOnFirstFailure = false;
            this.spent_money_txtbox.ResetOnPrompt = true;
            this.spent_money_txtbox.ResetOnSpace = true;
            this.spent_money_txtbox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.spent_money_txtbox.SelectedText = "";
            this.spent_money_txtbox.SelectionLength = 0;
            this.spent_money_txtbox.SelectionStart = 0;
            this.spent_money_txtbox.ShortcutsEnabled = true;
            this.spent_money_txtbox.Size = new System.Drawing.Size(190, 48);
            this.spent_money_txtbox.SkipLiterals = true;
            this.spent_money_txtbox.TabIndex = 163;
            this.spent_money_txtbox.TabStop = false;
            this.spent_money_txtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.spent_money_txtbox.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.spent_money_txtbox.TrailingIcon = null;
            this.spent_money_txtbox.UseSystemPasswordChar = false;
            this.spent_money_txtbox.ValidatingType = null;
            // 
            // month_cbbox
            // 
            this.month_cbbox.AutoResize = false;
            this.month_cbbox.BackColor = System.Drawing.Color.Red;
            this.month_cbbox.Depth = 0;
            this.month_cbbox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.month_cbbox.DropDownHeight = 174;
            this.month_cbbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.month_cbbox.DropDownWidth = 121;
            this.month_cbbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.month_cbbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.month_cbbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(217)))));
            this.month_cbbox.FormattingEnabled = true;
            this.month_cbbox.IntegralHeight = false;
            this.month_cbbox.ItemHeight = 43;
            this.month_cbbox.Items.AddRange(new object[] {
            "May",
            "April",
            "March"});
            this.month_cbbox.Location = new System.Drawing.Point(20, 350);
            this.month_cbbox.MaxDropDownItems = 4;
            this.month_cbbox.MouseState = MaterialSkin.MouseState.OUT;
            this.month_cbbox.Name = "month_cbbox";
            this.month_cbbox.Size = new System.Drawing.Size(326, 49);
            this.month_cbbox.StartIndex = 0;
            this.month_cbbox.TabIndex = 164;
            this.month_cbbox.SelectedIndexChanged += new System.EventHandler(this.month_cbbox_SelectedIndexChanged);
            // 
            // maxbdt_button
            // 
            this.maxbdt_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.maxbdt_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maxbdt_button.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxbdt_button.ForeColor = System.Drawing.Color.White;
            this.maxbdt_button.Location = new System.Drawing.Point(290, 260);
            this.maxbdt_button.Margin = new System.Windows.Forms.Padding(0);
            this.maxbdt_button.Name = "maxbdt_button";
            this.maxbdt_button.Size = new System.Drawing.Size(90, 30);
            this.maxbdt_button.TabIndex = 165;
            this.maxbdt_button.Text = "Set Budget";
            this.maxbdt_button.UseVisualStyleBackColor = false;
            this.maxbdt_button.Click += new System.EventHandler(this.maxbdt_button_Click);
            // 
            // save_label
            // 
            this.save_label.AutoSize = true;
            this.save_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.save_label.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.save_label.Location = new System.Drawing.Point(30, 290);
            this.save_label.Name = "save_label";
            this.save_label.Size = new System.Drawing.Size(80, 29);
            this.save_label.TabIndex = 166;
            this.save_label.Text = "0 RON";
            // 
            // UC_STATISTICS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.save_label);
            this.Controls.Add(this.maxbdt_button);
            this.Controls.Add(this.month_cbbox);
            this.Controls.Add(this.spent_money_txtbox);
            this.Controls.Add(this.invoice_txtbox);
            this.Controls.Add(this.max_budget_txtbox);
            this.Controls.Add(this.budget_button);
            this.Controls.Add(this.pieChart1);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.title);
            this.Controls.Add(this.budget);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Name = "UC_STATISTICS";
            this.Size = new System.Drawing.Size(1150, 720);
            this.Load += new System.EventHandler(this.UC_STATISTICS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CircularProgressBar.CircularProgressBar budget;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label title;
        private LiveCharts.WinForms.CartesianChart chart;
        private LiveCharts.WinForms.PieChart pieChart1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button budget_button;
        private MaterialSkin.Controls.MaterialMaskedTextBox max_budget_txtbox;
        private MaterialSkin.Controls.MaterialMaskedTextBox invoice_txtbox;
        private MaterialSkin.Controls.MaterialMaskedTextBox spent_money_txtbox;
        private MaterialSkin.Controls.MaterialComboBox month_cbbox;
        private System.Windows.Forms.Button maxbdt_button;
        private System.Windows.Forms.Label save_label;
    }
}
