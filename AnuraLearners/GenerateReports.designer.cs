namespace AnuraLearners
{
    partial class GenerateReports
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
            this.dtmFrom = new System.Windows.Forms.DateTimePicker();
            this.lblFromDate = new System.Windows.Forms.Label();
            this.lblToDate = new System.Windows.Forms.Label();
            this.dtmTo = new System.Windows.Forms.DateTimePicker();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnTotalIncome = new System.Windows.Forms.Button();
            this.btnExamReport = new System.Windows.Forms.Button();
            this.btnTrialReport = new System.Windows.Forms.Button();
            this.btnPaymentDelay = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnPDF = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtmFrom
            // 
            this.dtmFrom.CalendarFont = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtmFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtmFrom.Location = new System.Drawing.Point(36, 102);
            this.dtmFrom.Margin = new System.Windows.Forms.Padding(2);
            this.dtmFrom.Name = "dtmFrom";
            this.dtmFrom.Size = new System.Drawing.Size(190, 20);
            this.dtmFrom.TabIndex = 2;
            // 
            // lblFromDate
            // 
            this.lblFromDate.AutoSize = true;
            this.lblFromDate.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFromDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(170)))), ((int)(((byte)(230)))));
            this.lblFromDate.Location = new System.Drawing.Point(32, 76);
            this.lblFromDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFromDate.Name = "lblFromDate";
            this.lblFromDate.Size = new System.Drawing.Size(99, 25);
            this.lblFromDate.TabIndex = 3;
            this.lblFromDate.Text = "From Date";
            // 
            // lblToDate
            // 
            this.lblToDate.AutoSize = true;
            this.lblToDate.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(170)))), ((int)(((byte)(230)))));
            this.lblToDate.Location = new System.Drawing.Point(298, 76);
            this.lblToDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblToDate.Name = "lblToDate";
            this.lblToDate.Size = new System.Drawing.Size(77, 25);
            this.lblToDate.TabIndex = 4;
            this.lblToDate.Text = "To Date";
            // 
            // dtmTo
            // 
            this.dtmTo.CalendarFont = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtmTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtmTo.Location = new System.Drawing.Point(302, 102);
            this.dtmTo.Margin = new System.Windows.Forms.Padding(2);
            this.dtmTo.Name = "dtmTo";
            this.dtmTo.Size = new System.Drawing.Size(190, 20);
            this.dtmTo.TabIndex = 5;
            // 
            // btnCustomer
            // 
            this.btnCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomer.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(170)))), ((int)(((byte)(230)))));
            this.btnCustomer.Location = new System.Drawing.Point(649, 69);
            this.btnCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(161, 42);
            this.btnCustomer.TabIndex = 6;
            this.btnCustomer.Text = "Customer Registration Report";
            this.btnCustomer.UseVisualStyleBackColor = true;
            this.btnCustomer.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnTotalIncome
            // 
            this.btnTotalIncome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTotalIncome.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTotalIncome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(170)))), ((int)(((byte)(230)))));
            this.btnTotalIncome.Location = new System.Drawing.Point(649, 136);
            this.btnTotalIncome.Margin = new System.Windows.Forms.Padding(2);
            this.btnTotalIncome.Name = "btnTotalIncome";
            this.btnTotalIncome.Size = new System.Drawing.Size(161, 42);
            this.btnTotalIncome.TabIndex = 7;
            this.btnTotalIncome.Text = "Total Income Report";
            this.btnTotalIncome.UseVisualStyleBackColor = true;
            this.btnTotalIncome.Click += new System.EventHandler(this.btnTotalIncome_Click);
            // 
            // btnExamReport
            // 
            this.btnExamReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExamReport.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExamReport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(170)))), ((int)(((byte)(230)))));
            this.btnExamReport.Location = new System.Drawing.Point(649, 203);
            this.btnExamReport.Margin = new System.Windows.Forms.Padding(2);
            this.btnExamReport.Name = "btnExamReport";
            this.btnExamReport.Size = new System.Drawing.Size(161, 42);
            this.btnExamReport.TabIndex = 8;
            this.btnExamReport.Text = "Exam Report";
            this.btnExamReport.UseVisualStyleBackColor = true;
            this.btnExamReport.Click += new System.EventHandler(this.btnExamReport_Click);
            // 
            // btnTrialReport
            // 
            this.btnTrialReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrialReport.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrialReport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(170)))), ((int)(((byte)(230)))));
            this.btnTrialReport.Location = new System.Drawing.Point(649, 270);
            this.btnTrialReport.Margin = new System.Windows.Forms.Padding(2);
            this.btnTrialReport.Name = "btnTrialReport";
            this.btnTrialReport.Size = new System.Drawing.Size(161, 42);
            this.btnTrialReport.TabIndex = 9;
            this.btnTrialReport.Text = "Trial Report";
            this.btnTrialReport.UseVisualStyleBackColor = true;
            this.btnTrialReport.Click += new System.EventHandler(this.btnTrialReport_Click);
            // 
            // btnPaymentDelay
            // 
            this.btnPaymentDelay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaymentDelay.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaymentDelay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(170)))), ((int)(((byte)(230)))));
            this.btnPaymentDelay.Location = new System.Drawing.Point(649, 330);
            this.btnPaymentDelay.Margin = new System.Windows.Forms.Padding(2);
            this.btnPaymentDelay.Name = "btnPaymentDelay";
            this.btnPaymentDelay.Size = new System.Drawing.Size(161, 42);
            this.btnPaymentDelay.TabIndex = 10;
            this.btnPaymentDelay.Text = "Payment Delay Report";
            this.btnPaymentDelay.UseVisualStyleBackColor = true;
            this.btnPaymentDelay.Click += new System.EventHandler(this.button5_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(31, 136);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(595, 176);
            this.dataGridView1.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(170)))), ((int)(((byte)(230)))));
            this.label4.Location = new System.Drawing.Point(30, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(207, 64);
            this.label4.TabIndex = 21;
            this.label4.Text = "Report Generator\r\n\r\n";
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(170)))), ((int)(((byte)(230)))));
            this.btnHome.BackgroundImage = global::AnuraLearners.Properties.Resources.home;
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Location = new System.Drawing.Point(752, 11);
            this.btnHome.Margin = new System.Windows.Forms.Padding(2);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(58, 49);
            this.btnHome.TabIndex = 22;
            this.btnHome.UseVisualStyleBackColor = false;
            // 
            // btnPDF
            // 
            this.btnPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPDF.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPDF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(170)))), ((int)(((byte)(230)))));
            this.btnPDF.Location = new System.Drawing.Point(465, 330);
            this.btnPDF.Margin = new System.Windows.Forms.Padding(2);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Size = new System.Drawing.Size(161, 42);
            this.btnPDF.TabIndex = 23;
            this.btnPDF.Text = "Export as PDF";
            this.btnPDF.UseVisualStyleBackColor = true;
            this.btnPDF.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // GenerateReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(816, 383);
            this.Controls.Add(this.btnPDF);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnPaymentDelay);
            this.Controls.Add(this.btnTrialReport);
            this.Controls.Add(this.btnExamReport);
            this.Controls.Add(this.btnTotalIncome);
            this.Controls.Add(this.btnCustomer);
            this.Controls.Add(this.dtmTo);
            this.Controls.Add(this.lblToDate);
            this.Controls.Add(this.lblFromDate);
            this.Controls.Add(this.dtmFrom);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GenerateReports";
            this.Text = "GenerateReports";
            this.Load += new System.EventHandler(this.GenerateReports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtmFrom;
        private System.Windows.Forms.Label lblFromDate;
        private System.Windows.Forms.Label lblToDate;
        private System.Windows.Forms.DateTimePicker dtmTo;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Button btnTotalIncome;
        private System.Windows.Forms.Button btnExamReport;
        private System.Windows.Forms.Button btnTrialReport;
        private System.Windows.Forms.Button btnPaymentDelay;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnPDF;
    }
}