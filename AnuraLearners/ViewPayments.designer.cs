namespace AnuraLearners
{
    partial class ViewPayments
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
            this.lblNewCustomerHead = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCustomerId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.grpb_second_payment = new System.Windows.Forms.GroupBox();
            this.txtThirdPayment = new System.Windows.Forms.TextBox();
            this.txtThirdPaymentDate = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtFirstPayment = new System.Windows.Forms.TextBox();
            this.txtFirstPayementDate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtSecondPayment = new System.Windows.Forms.TextBox();
            this.txtSecondPaymentDate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFullPayment = new System.Windows.Forms.TextBox();
            this.grpb_second_payment.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNewCustomerHead
            // 
            this.lblNewCustomerHead.AutoSize = true;
            this.lblNewCustomerHead.BackColor = System.Drawing.Color.Transparent;
            this.lblNewCustomerHead.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewCustomerHead.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(170)))), ((int)(((byte)(230)))));
            this.lblNewCustomerHead.Location = new System.Drawing.Point(28, 27);
            this.lblNewCustomerHead.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNewCustomerHead.Name = "lblNewCustomerHead";
            this.lblNewCustomerHead.Size = new System.Drawing.Size(180, 32);
            this.lblNewCustomerHead.TabIndex = 59;
            this.lblNewCustomerHead.Text = "View Payments";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(170)))), ((int)(((byte)(230)))));
            this.label3.Location = new System.Drawing.Point(52, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 21);
            this.label3.TabIndex = 62;
            this.label3.Text = "Customer Id";
            // 
            // txtCustomerId
            // 
            this.txtCustomerId.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtCustomerId.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtCustomerId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerId.Location = new System.Drawing.Point(216, 126);
            this.txtCustomerId.Name = "txtCustomerId";
            this.txtCustomerId.Size = new System.Drawing.Size(214, 26);
            this.txtCustomerId.TabIndex = 60;
            this.txtCustomerId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCustomerId_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(170)))), ((int)(((byte)(230)))));
            this.label2.Location = new System.Drawing.Point(53, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 21);
            this.label2.TabIndex = 63;
            this.label2.Text = "Customer Name";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtCustomerName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerName.Location = new System.Drawing.Point(217, 81);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(214, 26);
            this.txtCustomerName.TabIndex = 61;
            this.txtCustomerName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCustomerName_KeyDown);
            // 
            // grpb_second_payment
            // 
            this.grpb_second_payment.Controls.Add(this.txtThirdPayment);
            this.grpb_second_payment.Controls.Add(this.txtThirdPaymentDate);
            this.grpb_second_payment.Controls.Add(this.label8);
            this.grpb_second_payment.Controls.Add(this.label9);
            this.grpb_second_payment.Location = new System.Drawing.Point(246, 338);
            this.grpb_second_payment.Name = "grpb_second_payment";
            this.grpb_second_payment.Size = new System.Drawing.Size(307, 132);
            this.grpb_second_payment.TabIndex = 64;
            this.grpb_second_payment.TabStop = false;
            this.grpb_second_payment.Text = "Third Payment Details";
            // 
            // txtThirdPayment
            // 
            this.txtThirdPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThirdPayment.Location = new System.Drawing.Point(129, 28);
            this.txtThirdPayment.Name = "txtThirdPayment";
            this.txtThirdPayment.ReadOnly = true;
            this.txtThirdPayment.Size = new System.Drawing.Size(165, 26);
            this.txtThirdPayment.TabIndex = 19;
            // 
            // txtThirdPaymentDate
            // 
            this.txtThirdPaymentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThirdPaymentDate.Location = new System.Drawing.Point(129, 75);
            this.txtThirdPaymentDate.Name = "txtThirdPaymentDate";
            this.txtThirdPaymentDate.ReadOnly = true;
            this.txtThirdPaymentDate.Size = new System.Drawing.Size(165, 26);
            this.txtThirdPaymentDate.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(170)))), ((int)(((byte)(230)))));
            this.label8.Location = new System.Drawing.Point(11, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 21);
            this.label8.TabIndex = 9;
            this.label8.Text = "Payment Date";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(170)))), ((int)(((byte)(230)))));
            this.label9.Location = new System.Drawing.Point(11, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 21);
            this.label9.TabIndex = 10;
            this.label9.Text = "3rd Payment";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtFirstPayment);
            this.groupBox1.Controls.Add(this.txtFirstPayementDate);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(53, 191);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(307, 132);
            this.groupBox1.TabIndex = 65;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "First Payment Details";
            // 
            // txtFirstPayment
            // 
            this.txtFirstPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstPayment.Location = new System.Drawing.Point(129, 28);
            this.txtFirstPayment.Name = "txtFirstPayment";
            this.txtFirstPayment.ReadOnly = true;
            this.txtFirstPayment.Size = new System.Drawing.Size(165, 26);
            this.txtFirstPayment.TabIndex = 19;
            // 
            // txtFirstPayementDate
            // 
            this.txtFirstPayementDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstPayementDate.Location = new System.Drawing.Point(129, 75);
            this.txtFirstPayementDate.Name = "txtFirstPayementDate";
            this.txtFirstPayementDate.ReadOnly = true;
            this.txtFirstPayementDate.Size = new System.Drawing.Size(165, 26);
            this.txtFirstPayementDate.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(170)))), ((int)(((byte)(230)))));
            this.label1.Location = new System.Drawing.Point(11, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "Payment Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(170)))), ((int)(((byte)(230)))));
            this.label4.Location = new System.Drawing.Point(11, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 21);
            this.label4.TabIndex = 10;
            this.label4.Text = "1st Payment";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtSecondPayment);
            this.groupBox2.Controls.Add(this.txtSecondPaymentDate);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(414, 191);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(307, 132);
            this.groupBox2.TabIndex = 66;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Second Payment Details";
            // 
            // txtSecondPayment
            // 
            this.txtSecondPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSecondPayment.Location = new System.Drawing.Point(129, 28);
            this.txtSecondPayment.Name = "txtSecondPayment";
            this.txtSecondPayment.ReadOnly = true;
            this.txtSecondPayment.Size = new System.Drawing.Size(165, 26);
            this.txtSecondPayment.TabIndex = 19;
            // 
            // txtSecondPaymentDate
            // 
            this.txtSecondPaymentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSecondPaymentDate.Location = new System.Drawing.Point(129, 75);
            this.txtSecondPaymentDate.Name = "txtSecondPaymentDate";
            this.txtSecondPaymentDate.ReadOnly = true;
            this.txtSecondPaymentDate.Size = new System.Drawing.Size(165, 26);
            this.txtSecondPaymentDate.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(170)))), ((int)(((byte)(230)))));
            this.label5.Location = new System.Drawing.Point(11, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 21);
            this.label5.TabIndex = 9;
            this.label5.Text = "Payment Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(170)))), ((int)(((byte)(230)))));
            this.label6.Location = new System.Drawing.Point(11, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 21);
            this.label6.TabIndex = 10;
            this.label6.Text = "2nd Payment";
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(170)))), ((int)(((byte)(230)))));
            this.btnHome.BackgroundImage = global::AnuraLearners.Properties.Resources.home;
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Location = new System.Drawing.Point(682, 13);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(70, 65);
            this.btnHome.TabIndex = 67;
            this.btnHome.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(170)))), ((int)(((byte)(230)))));
            this.label7.Location = new System.Drawing.Point(445, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 21);
            this.label7.TabIndex = 69;
            this.label7.Text = "Full Payment";
            // 
            // txtFullPayment
            // 
            this.txtFullPayment.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtFullPayment.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtFullPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFullPayment.Location = new System.Drawing.Point(579, 125);
            this.txtFullPayment.Name = "txtFullPayment";
            this.txtFullPayment.ReadOnly = true;
            this.txtFullPayment.Size = new System.Drawing.Size(173, 26);
            this.txtFullPayment.TabIndex = 68;
            // 
            // ViewPayments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 471);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtFullPayment);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpb_second_payment);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCustomerId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.lblNewCustomerHead);
            this.Name = "ViewPayments";
            this.Text = "ViewPayments";
            this.Load += new System.EventHandler(this.ViewPayments_Load);
            this.grpb_second_payment.ResumeLayout(false);
            this.grpb_second_payment.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNewCustomerHead;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCustomerId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.GroupBox grpb_second_payment;
        private System.Windows.Forms.TextBox txtThirdPayment;
        private System.Windows.Forms.TextBox txtThirdPaymentDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtFirstPayment;
        private System.Windows.Forms.TextBox txtFirstPayementDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtSecondPayment;
        private System.Windows.Forms.TextBox txtSecondPaymentDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtFullPayment;
    }
}