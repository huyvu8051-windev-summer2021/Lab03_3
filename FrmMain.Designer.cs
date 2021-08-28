
namespace Lab03_3
{
    partial class FrmMain
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTongCong = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tdpMinDeliveryDate = new System.Windows.Forms.DateTimePicker();
            this.tdpMaxDeliveryDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpViewByMonth = new System.Windows.Forms.DateTimePicker();
            this.dtpViewByDay = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoViewByDay = new System.Windows.Forms.RadioButton();
            this.rdoViewByMonth = new System.Windows.Forms.RadioButton();
            this.rdoViewFromDate = new System.Windows.Forms.RadioButton();
            this.btnPrint = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtTongCong);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 700);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1249, 45);
            this.panel1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1054, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tổng Cộng: ";
            // 
            // txtTongCong
            // 
            this.txtTongCong.Location = new System.Drawing.Point(1146, 6);
            this.txtTongCong.Name = "txtTongCong";
            this.txtTongCong.Size = new System.Drawing.Size(100, 22);
            this.txtTongCong.TabIndex = 0;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.Location = new System.Drawing.Point(0, 237);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1249, 463);
            this.reportViewer1.TabIndex = 2;
            // 
            // tdpMinDeliveryDate
            // 
            this.tdpMinDeliveryDate.CustomFormat = "dd/MM/yyyy";
            this.tdpMinDeliveryDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tdpMinDeliveryDate.Location = new System.Drawing.Point(426, 151);
            this.tdpMinDeliveryDate.Name = "tdpMinDeliveryDate";
            this.tdpMinDeliveryDate.Size = new System.Drawing.Size(200, 22);
            this.tdpMinDeliveryDate.TabIndex = 1;
            this.tdpMinDeliveryDate.ValueChanged += new System.EventHandler(this.DateTimePickerValueChange);
            // 
            // tdpMaxDeliveryDate
            // 
            this.tdpMaxDeliveryDate.CustomFormat = "dd/MM/yyyy";
            this.tdpMaxDeliveryDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tdpMaxDeliveryDate.Location = new System.Drawing.Point(688, 151);
            this.tdpMaxDeliveryDate.Name = "tdpMaxDeliveryDate";
            this.tdpMaxDeliveryDate.Size = new System.Drawing.Size(200, 22);
            this.tdpMaxDeliveryDate.TabIndex = 2;
            this.tdpMaxDeliveryDate.ValueChanged += new System.EventHandler(this.DateTimePickerValueChange);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(650, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "~";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Thời gian giao hàng";
            // 
            // dtpViewByMonth
            // 
            this.dtpViewByMonth.CustomFormat = "MM/yyyy";
            this.dtpViewByMonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpViewByMonth.Location = new System.Drawing.Point(426, 96);
            this.dtpViewByMonth.Name = "dtpViewByMonth";
            this.dtpViewByMonth.Size = new System.Drawing.Size(200, 22);
            this.dtpViewByMonth.TabIndex = 6;
            // 
            // dtpViewByDay
            // 
            this.dtpViewByDay.CustomFormat = "dd/MM/yyyy";
            this.dtpViewByDay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpViewByDay.Location = new System.Drawing.Point(426, 39);
            this.dtpViewByDay.Name = "dtpViewByDay";
            this.dtpViewByDay.Size = new System.Drawing.Size(200, 22);
            this.dtpViewByDay.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPrint);
            this.groupBox1.Controls.Add(this.rdoViewFromDate);
            this.groupBox1.Controls.Add(this.rdoViewByMonth);
            this.groupBox1.Controls.Add(this.rdoViewByDay);
            this.groupBox1.Controls.Add(this.dtpViewByDay);
            this.groupBox1.Controls.Add(this.dtpViewByMonth);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tdpMaxDeliveryDate);
            this.groupBox1.Controls.Add(this.tdpMinDeliveryDate);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1249, 237);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin đơn hàng";
            // 
            // rdoViewByDay
            // 
            this.rdoViewByDay.AutoSize = true;
            this.rdoViewByDay.Checked = true;
            this.rdoViewByDay.Location = new System.Drawing.Point(248, 43);
            this.rdoViewByDay.Name = "rdoViewByDay";
            this.rdoViewByDay.Size = new System.Drawing.Size(124, 21);
            this.rdoViewByDay.TabIndex = 8;
            this.rdoViewByDay.TabStop = true;
            this.rdoViewByDay.Text = "Xem theo ngày";
            this.rdoViewByDay.UseVisualStyleBackColor = true;
            this.rdoViewByDay.CheckedChanged += new System.EventHandler(this.rdoViewByDate_CheckedChanged);
            // 
            // rdoViewByMonth
            // 
            this.rdoViewByMonth.AutoSize = true;
            this.rdoViewByMonth.Location = new System.Drawing.Point(248, 95);
            this.rdoViewByMonth.Name = "rdoViewByMonth";
            this.rdoViewByMonth.Size = new System.Drawing.Size(129, 21);
            this.rdoViewByMonth.TabIndex = 9;
            this.rdoViewByMonth.TabStop = true;
            this.rdoViewByMonth.Text = "Xem theo tháng";
            this.rdoViewByMonth.UseVisualStyleBackColor = true;
            this.rdoViewByMonth.CheckedChanged += new System.EventHandler(this.rdoViewByMonth_CheckedChanged);
            // 
            // rdoViewFromDate
            // 
            this.rdoViewFromDate.AutoSize = true;
            this.rdoViewFromDate.Location = new System.Drawing.Point(248, 150);
            this.rdoViewFromDate.Name = "rdoViewFromDate";
            this.rdoViewFromDate.Size = new System.Drawing.Size(108, 21);
            this.rdoViewFromDate.TabIndex = 10;
            this.rdoViewFromDate.TabStop = true;
            this.rdoViewFromDate.Text = "Xem từ ngày";
            this.rdoViewFromDate.UseVisualStyleBackColor = true;
            this.rdoViewFromDate.CheckedChanged += new System.EventHandler(this.rdoViewFromDate_CheckedChanged);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(688, 191);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(200, 23);
            this.btnPrint.TabIndex = 11;
            this.btnPrint.Text = "In/Xem";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1249, 745);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTongCong;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.RadioButton rdoViewFromDate;
        private System.Windows.Forms.RadioButton rdoViewByMonth;
        private System.Windows.Forms.RadioButton rdoViewByDay;
        private System.Windows.Forms.DateTimePicker dtpViewByDay;
        private System.Windows.Forms.DateTimePicker dtpViewByMonth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker tdpMaxDeliveryDate;
        private System.Windows.Forms.DateTimePicker tdpMinDeliveryDate;
    }
}