namespace AnuraLearners
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paymentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stPaymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ndPaymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rdPaymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewPaymentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.examsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trialsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerToolStripMenuItem,
            this.paymentsToolStripMenuItem,
            this.examsToolStripMenuItem,
            this.trialsToolStripMenuItem,
            this.reportsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(904, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newCustomerToolStripMenuItem,
            this.searchCustomerToolStripMenuItem});
            this.customerToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.customerToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(170)))), ((int)(((byte)(230)))));
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(90, 25);
            this.customerToolStripMenuItem.Text = "Customer";
            // 
            // newCustomerToolStripMenuItem
            // 
            this.newCustomerToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(170)))), ((int)(((byte)(230)))));
            this.newCustomerToolStripMenuItem.Name = "newCustomerToolStripMenuItem";
            this.newCustomerToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.newCustomerToolStripMenuItem.Text = "New Customer";
            this.newCustomerToolStripMenuItem.Click += new System.EventHandler(this.newCustomerToolStripMenuItem_Click);
            // 
            // searchCustomerToolStripMenuItem
            // 
            this.searchCustomerToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(170)))), ((int)(((byte)(230)))));
            this.searchCustomerToolStripMenuItem.Name = "searchCustomerToolStripMenuItem";
            this.searchCustomerToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.searchCustomerToolStripMenuItem.Text = "Search Customer";
            this.searchCustomerToolStripMenuItem.Click += new System.EventHandler(this.searchCustomerToolStripMenuItem_Click);
            // 
            // paymentsToolStripMenuItem
            // 
            this.paymentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stPaymentToolStripMenuItem,
            this.ndPaymentToolStripMenuItem,
            this.rdPaymentToolStripMenuItem,
            this.viewPaymentsToolStripMenuItem});
            this.paymentsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.paymentsToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(170)))), ((int)(((byte)(230)))));
            this.paymentsToolStripMenuItem.Name = "paymentsToolStripMenuItem";
            this.paymentsToolStripMenuItem.Size = new System.Drawing.Size(90, 25);
            this.paymentsToolStripMenuItem.Text = "Payments";
            // 
            // stPaymentToolStripMenuItem
            // 
            this.stPaymentToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(170)))), ((int)(((byte)(230)))));
            this.stPaymentToolStripMenuItem.Name = "stPaymentToolStripMenuItem";
            this.stPaymentToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.stPaymentToolStripMenuItem.Text = "1st Payment";
            this.stPaymentToolStripMenuItem.Click += new System.EventHandler(this.stPaymentToolStripMenuItem_Click);
            // 
            // ndPaymentToolStripMenuItem
            // 
            this.ndPaymentToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(170)))), ((int)(((byte)(230)))));
            this.ndPaymentToolStripMenuItem.Name = "ndPaymentToolStripMenuItem";
            this.ndPaymentToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.ndPaymentToolStripMenuItem.Text = "2nd Payment";
            this.ndPaymentToolStripMenuItem.Click += new System.EventHandler(this.ndPaymentToolStripMenuItem_Click);
            // 
            // rdPaymentToolStripMenuItem
            // 
            this.rdPaymentToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(170)))), ((int)(((byte)(230)))));
            this.rdPaymentToolStripMenuItem.Name = "rdPaymentToolStripMenuItem";
            this.rdPaymentToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.rdPaymentToolStripMenuItem.Text = "3rd Payment";
            this.rdPaymentToolStripMenuItem.Click += new System.EventHandler(this.rdPaymentToolStripMenuItem_Click);
            // 
            // viewPaymentsToolStripMenuItem
            // 
            this.viewPaymentsToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(170)))), ((int)(((byte)(230)))));
            this.viewPaymentsToolStripMenuItem.Name = "viewPaymentsToolStripMenuItem";
            this.viewPaymentsToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.viewPaymentsToolStripMenuItem.Text = "View Payments";
            this.viewPaymentsToolStripMenuItem.Click += new System.EventHandler(this.viewPaymentsToolStripMenuItem_Click);
            // 
            // examsToolStripMenuItem
            // 
            this.examsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.examsToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(170)))), ((int)(((byte)(230)))));
            this.examsToolStripMenuItem.Name = "examsToolStripMenuItem";
            this.examsToolStripMenuItem.Size = new System.Drawing.Size(66, 25);
            this.examsToolStripMenuItem.Text = "Exams";
            this.examsToolStripMenuItem.Click += new System.EventHandler(this.examsToolStripMenuItem_Click);
            // 
            // trialsToolStripMenuItem
            // 
            this.trialsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.trialsToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(170)))), ((int)(((byte)(230)))));
            this.trialsToolStripMenuItem.Name = "trialsToolStripMenuItem";
            this.trialsToolStripMenuItem.Size = new System.Drawing.Size(59, 25);
            this.trialsToolStripMenuItem.Text = "Trials";
            this.trialsToolStripMenuItem.Click += new System.EventHandler(this.trialsToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewReportsToolStripMenuItem});
            this.reportsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.reportsToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(170)))), ((int)(((byte)(230)))));
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(76, 25);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // viewReportsToolStripMenuItem
            // 
            this.viewReportsToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(170)))), ((int)(((byte)(230)))));
            this.viewReportsToolStripMenuItem.Name = "viewReportsToolStripMenuItem";
            this.viewReportsToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
            this.viewReportsToolStripMenuItem.Text = "View Reports";
            this.viewReportsToolStripMenuItem.Click += new System.EventHandler(this.viewReportsToolStripMenuItem_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(904, 555);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paymentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stPaymentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ndPaymentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rdPaymentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewPaymentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem examsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trialsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewReportsToolStripMenuItem;
    }
}